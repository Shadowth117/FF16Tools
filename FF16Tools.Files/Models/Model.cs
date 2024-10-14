using CommunityToolkit.HighPerformance.Buffers;
using FF16Tools.Shared;
using Microsoft.Extensions.Logging;
using Syroot.BinaryData;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static FF16Tools.Model.Model;

namespace FF16Tools.Model
{
    /// <summary>
    /// FF16 'mdl' Model file
    /// Skeleton data is stored in .skl and Animation data is stored in .anmb Havok 2020 files respectively
    /// </summary>
    public class Model
    {
        private ILoggerFactory _loggerFactory;
        private ILogger _logger;

        /// <summary>
        /// Magic, 'MDL '
        /// </summary>
        public const uint MAGIC = 0x204C444D;
        public const uint HEADER_SIZE = 0xA8;

        public Model(ILoggerFactory loggerFactory = null)
        {
            _loggerFactory = loggerFactory;

            if (_loggerFactory is not null)
                _logger = _loggerFactory.CreateLogger(GetType().ToString());
        }
        public void FromStream(Stream stream)
        {
            var bs = new BinaryStream(stream, ByteConverter.Little);
            Debug.Assert(bs.Length - bs.Position >= HEADER_SIZE, "Not enough space for texture header");

            //Read main header
            if (bs.ReadUInt32() != MAGIC)
                throw new NotSupportedException();

            //Flags?
            var flag0 = bs.Read1Byte();
            var flag1 = bs.Read1Byte();
            var flag2 = bs.Read1Byte();
            var flag3 = bs.Read1Byte();

            var materialSection0Size = bs.ReadUInt32();
            var materialSection1Size = bs.ReadUInt32();

            var usht_10 = bs.ReadUInt16();
            var usht_12 = bs.ReadUInt16();
            var elementCount0 = bs.ReadUInt16();
            var elementCount1 = bs.Read1Byte();
            var bt_15 = bs.Read1Byte();
            var bt_16 = bs.Read1Byte();
            var bt_17 = bs.Read1Byte();

            // There are 4 of these that store references to compressed data. Other data might be reserves.
            // Info varies in definition depending on index. 
            // 0 - Vertex Data Offset
            // 1 - Face indices Offset
            // 2 - Vertex Data Size
            // 3 - Face indices Size
            // Data is written out such that vertices and face indices for a given LOD are packed together (e.g. LOD0 Vert, LOD0 Faces, LOD1 Vert, etc.)
            List<int[]> bufferInfoList = new List<int[]>();
            for(int i = 0; i < 4; i++)
            {
                int[] infoArr = new int[8];
                for(int j = 0; j < 8; j++)
                {
                    infoArr[j] = bs.ReadInt32();
                }
                bufferInfoList.Add(infoArr);
            }

            var unkChunk = new UnkInfo();
            unkChunk.offset0 = bs.ReadInt32();
            unkChunk.size0 = bs.ReadInt32();
            unkChunk.offset1 = bs.ReadInt32();
            unkChunk.size1 = bs.ReadInt32();

            //Vertex Data
            for(int i = 0; i < 8; i++)
            {
                //Check if the LOD level is valid
                if (bufferInfoList[0][i] != 0 && bufferInfoList[2][i] != 0)
                {
                    bs.Position = HEADER_SIZE + bufferInfoList[0][i];
                    using MemoryOwner<byte> chunkBuffer = MemoryOwner<byte>.Allocate(bufferInfoList[2][i]);
                    bs.Read(chunkBuffer.Span);
                    GDeflate.Decompress(chunkBuffer.Span, decompressedBuffer.Span.Slice(offset, (int)chunkInfo.DecompressedChunkSize));
                }    
            }

            //Face Data
            for (int i = 0; i < 8; i++)
            {
                if (bufferInfoList[1][i] != 0 && bufferInfoList[3][i] != 0)
                {
                    bs.Position = HEADER_SIZE + bufferInfoList[1][i];
                }
            }
        }

        /// <summary>
        /// Points to data at the end of the file. Could be debugging related.
        /// </summary>
        public struct UnkInfo()
        {
            public int offset0;
            public int size0;
            public int offset1;
            public int size1;
        }


    }
}
