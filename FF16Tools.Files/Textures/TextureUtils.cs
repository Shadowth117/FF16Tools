﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FF16Tools.Shared.Dds;

namespace FF16Tools.Files.Textures;

public class TextureUtils
{
    public static uint Align(uint x, uint alignment)
    {
        uint mask = ~(alignment - 1);
        return (x + (alignment - 1)) & mask;
    }

    public static DXGI_FORMAT TexPixelFormatToDxgiFormat(TexturePixelFormat format)
    {
        return format switch
        {
            TexturePixelFormat.R8_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R8_TYPELESS,
            TexturePixelFormat.R8_UNORM => DXGI_FORMAT.DXGI_FORMAT_R8_UNORM,
            TexturePixelFormat.A8_UNORM => DXGI_FORMAT.DXGI_FORMAT_A8_UNORM,
            TexturePixelFormat.R8_SNORM => DXGI_FORMAT.DXGI_FORMAT_R8_SNORM,
            TexturePixelFormat.R8_UINT => DXGI_FORMAT.DXGI_FORMAT_R8_UINT,
            TexturePixelFormat.R8_SINT => DXGI_FORMAT.DXGI_FORMAT_R8_SINT,
            TexturePixelFormat.R16_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R16_TYPELESS,
            TexturePixelFormat.R16_UNORM => DXGI_FORMAT.DXGI_FORMAT_R16_UNORM,
            TexturePixelFormat.R16_SNORM => DXGI_FORMAT.DXGI_FORMAT_R16_SNORM,
            TexturePixelFormat.R16_UINT => DXGI_FORMAT.DXGI_FORMAT_R16_UINT,
            TexturePixelFormat.R16_SINT => DXGI_FORMAT.DXGI_FORMAT_R16_SINT,
            TexturePixelFormat.R16_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT,
            TexturePixelFormat.D16_UNORM => DXGI_FORMAT.DXGI_FORMAT_D16_UNORM,
            TexturePixelFormat.R8G8_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R8G8_TYPELESS,
            TexturePixelFormat.R8G8_UNORM => DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM,
            TexturePixelFormat.R8G8_UINT => DXGI_FORMAT.DXGI_FORMAT_R8G8_UINT,
            TexturePixelFormat.R8G8_SNORM => DXGI_FORMAT.DXGI_FORMAT_R8G8_SNORM,
            TexturePixelFormat.R8G8_SINT => DXGI_FORMAT.DXGI_FORMAT_R8G8_SINT,
            TexturePixelFormat.R32_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32_TYPELESS,
            TexturePixelFormat.R32_UINT => DXGI_FORMAT.DXGI_FORMAT_R32_UINT,
            TexturePixelFormat.R32_SINT => DXGI_FORMAT.DXGI_FORMAT_R32_SINT,
            TexturePixelFormat.R32_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT,
            TexturePixelFormat.D32_FLOAT => DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT,
            TexturePixelFormat.R16G16_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R16G16_TYPELESS,
            TexturePixelFormat.R16G16_UNORM => DXGI_FORMAT.DXGI_FORMAT_R16G16_UNORM,
            TexturePixelFormat.R16G16_SNORM => DXGI_FORMAT.DXGI_FORMAT_R16G16_SNORM,
            TexturePixelFormat.R16G16_UINT => DXGI_FORMAT.DXGI_FORMAT_R16G16_UINT,
            TexturePixelFormat.R16G16_SINT => DXGI_FORMAT.DXGI_FORMAT_R16G16_SINT,
            TexturePixelFormat.R16G16_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R16G16_FLOAT,
            TexturePixelFormat.R11G11B10_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R11G11B10_FLOAT,
            TexturePixelFormat.R10G10B10A2_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_TYPELESS,
            TexturePixelFormat.R10G10B10A2_UNORM => DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM,
            TexturePixelFormat.R10G10B10A2_UINT => DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UINT,
            TexturePixelFormat.R8G8B8A8_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_TYPELESS,
            TexturePixelFormat.R8G8B8A8_UNORM => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM,
            TexturePixelFormat.R8G8B8A8_UNORM_SRGB => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB,
            TexturePixelFormat.R8G8B8A8_UINT => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UINT,
            TexturePixelFormat.R8G8B8A8_SNORM => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SNORM,
            TexturePixelFormat.R8G8B8A8_SINT => DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SINT,
            TexturePixelFormat.R32G32_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32G32_TYPELESS,
            TexturePixelFormat.R32G32_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT,
            TexturePixelFormat.R32G32_UINT => DXGI_FORMAT.DXGI_FORMAT_R32G32_UINT,
            TexturePixelFormat.R32G32_SINT => DXGI_FORMAT.DXGI_FORMAT_R32G32_SINT,
            TexturePixelFormat.R16G16B16A16_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_TYPELESS,
            TexturePixelFormat.R16G16B16A16_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT,
            TexturePixelFormat.R16G16B16A16_UNORM => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM,
            TexturePixelFormat.R16G16B16A16_UINT => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UINT,
            TexturePixelFormat.R16G16B16A16_SNORM => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SNORM,
            TexturePixelFormat.R16G16B16A16_SINT => DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SINT,
            TexturePixelFormat.R32G32B32_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32G32B32_TYPELESS,
            TexturePixelFormat.R32G32B32_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT,
            TexturePixelFormat.R32G32B32_UINT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32_UINT,
            TexturePixelFormat.R32G32B32_SINT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32_SINT,
            TexturePixelFormat.R32G32B32A32_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_TYPELESS,
            TexturePixelFormat.R32G32B32A32_UINT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_UINT,
            TexturePixelFormat.R32G32B32A32_SINT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_SINT,
            TexturePixelFormat.R32G32B32A32_FLOAT => DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT,
            TexturePixelFormat.R32G8X24_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32G8X24_TYPELESS,
            TexturePixelFormat.X32_TYPELESS_G8X24_UINT => DXGI_FORMAT.DXGI_FORMAT_X32_TYPELESS_G8X24_UINT,
            TexturePixelFormat.R32_FLOAT_X8X24_TYPELESS => DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS,
            TexturePixelFormat.D32_FLOAT_S8X24_UINT => DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT_S8X24_UINT,
            TexturePixelFormat.BC1_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM,
            TexturePixelFormat.BC1_UNORM_SRGB => DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB,
            TexturePixelFormat.BC2_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM,
            TexturePixelFormat.BC2_UNORM_SRGB => DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM_SRGB,
            TexturePixelFormat.BC3_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM,
            TexturePixelFormat.BC3_UNORM_SRGB => DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB,
            TexturePixelFormat.BC4_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM,
            TexturePixelFormat.BC4_SNORM => DXGI_FORMAT.DXGI_FORMAT_BC4_SNORM,
            TexturePixelFormat.BC5_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM,
            TexturePixelFormat.BC5_SNORM => DXGI_FORMAT.DXGI_FORMAT_BC5_SNORM,
            TexturePixelFormat.BC6H_UF16 => DXGI_FORMAT.DXGI_FORMAT_BC6H_UF16,
            TexturePixelFormat.BC6H_SF16 => DXGI_FORMAT.DXGI_FORMAT_BC6H_SF16,
            TexturePixelFormat.BC7_UNORM => DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM,
            TexturePixelFormat.BC7_UNORM_SRGB => DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB,
            _ => throw new NotSupportedException($"TextureFormat {format} not supported."),
        };
    }

    public static TexturePixelFormat DxgiFormatToTexPixelFormat(DXGI_FORMAT format)
    {
        return format switch
        {
            DXGI_FORMAT.DXGI_FORMAT_R8_TYPELESS => TexturePixelFormat.R8_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R8_UNORM => TexturePixelFormat.R8_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_A8_UNORM => TexturePixelFormat.A8_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8_SNORM => TexturePixelFormat.R8_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8_UINT => TexturePixelFormat.R8_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R8_SINT => TexturePixelFormat.R8_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R16_TYPELESS => TexturePixelFormat.R16_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R16_UNORM => TexturePixelFormat.R16_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16_SNORM => TexturePixelFormat.R16_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16_UINT => TexturePixelFormat.R16_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R16_SINT => TexturePixelFormat.R16_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R16_FLOAT => TexturePixelFormat.R16_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_D16_UNORM => TexturePixelFormat.D16_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8G8_TYPELESS => TexturePixelFormat.R8G8_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R8G8_UNORM => TexturePixelFormat.R8G8_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8G8_UINT => TexturePixelFormat.R8G8_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R8G8_SNORM => TexturePixelFormat.R8G8_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8G8_SINT => TexturePixelFormat.R8G8_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32_TYPELESS => TexturePixelFormat.R32_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R32_UINT => TexturePixelFormat.R32_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R32_SINT => TexturePixelFormat.R32_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT => TexturePixelFormat.R32_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT => TexturePixelFormat.D32_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_TYPELESS => TexturePixelFormat.R16G16_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_UNORM => TexturePixelFormat.R16G16_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_SNORM => TexturePixelFormat.R16G16_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_UINT => TexturePixelFormat.R16G16_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_SINT => TexturePixelFormat.R16G16_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16_FLOAT => TexturePixelFormat.R16G16_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R11G11B10_FLOAT => TexturePixelFormat.R11G11B10_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_TYPELESS => TexturePixelFormat.R10G10B10A2_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UNORM => TexturePixelFormat.R10G10B10A2_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R10G10B10A2_UINT => TexturePixelFormat.R10G10B10A2_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_TYPELESS => TexturePixelFormat.R8G8B8A8_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM => TexturePixelFormat.R8G8B8A8_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM_SRGB => TexturePixelFormat.R8G8B8A8_UNORM_SRGB,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UINT => TexturePixelFormat.R8G8B8A8_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SNORM => TexturePixelFormat.R8G8B8A8_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_SINT => TexturePixelFormat.R8G8B8A8_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32_TYPELESS => TexturePixelFormat.R32G32_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R32G32_FLOAT => TexturePixelFormat.R32G32_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32_UINT => TexturePixelFormat.R32G32_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32_SINT => TexturePixelFormat.R32G32_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_TYPELESS => TexturePixelFormat.R16G16B16A16_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_FLOAT => TexturePixelFormat.R16G16B16A16_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UNORM => TexturePixelFormat.R16G16B16A16_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_UINT => TexturePixelFormat.R16G16B16A16_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SNORM => TexturePixelFormat.R16G16B16A16_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_R16G16B16A16_SINT => TexturePixelFormat.R16G16B16A16_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32_TYPELESS => TexturePixelFormat.R32G32B32_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32_FLOAT => TexturePixelFormat.R32G32B32_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32_UINT => TexturePixelFormat.R32G32B32_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32_SINT => TexturePixelFormat.R32G32B32_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_TYPELESS => TexturePixelFormat.R32G32B32A32_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_UINT => TexturePixelFormat.R32G32B32A32_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_SINT => TexturePixelFormat.R32G32B32A32_SINT,
            DXGI_FORMAT.DXGI_FORMAT_R32G32B32A32_FLOAT => TexturePixelFormat.R32G32B32A32_FLOAT,
            DXGI_FORMAT.DXGI_FORMAT_R32G8X24_TYPELESS => TexturePixelFormat.R32G8X24_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_X32_TYPELESS_G8X24_UINT => TexturePixelFormat.X32_TYPELESS_G8X24_UINT,
            DXGI_FORMAT.DXGI_FORMAT_R32_FLOAT_X8X24_TYPELESS => TexturePixelFormat.R32_FLOAT_X8X24_TYPELESS,
            DXGI_FORMAT.DXGI_FORMAT_D32_FLOAT_S8X24_UINT => TexturePixelFormat.D32_FLOAT_S8X24_UINT,
            DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM => TexturePixelFormat.BC1_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC1_UNORM_SRGB => TexturePixelFormat.BC1_UNORM_SRGB,
            DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM => TexturePixelFormat.BC2_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC2_UNORM_SRGB => TexturePixelFormat.BC2_UNORM_SRGB,
            DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM => TexturePixelFormat.BC3_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC3_UNORM_SRGB => TexturePixelFormat.BC3_UNORM_SRGB,
            DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM => TexturePixelFormat.BC4_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC4_SNORM => TexturePixelFormat.BC4_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC5_UNORM => TexturePixelFormat.BC5_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC5_SNORM => TexturePixelFormat.BC5_SNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC6H_UF16 => TexturePixelFormat.BC6H_UF16,
            DXGI_FORMAT.DXGI_FORMAT_BC6H_SF16 => TexturePixelFormat.BC6H_SF16,
            DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM => TexturePixelFormat.BC7_UNORM,
            DXGI_FORMAT.DXGI_FORMAT_BC7_UNORM_SRGB => TexturePixelFormat.BC7_UNORM_SRGB,
            _ => throw new NotSupportedException($"TextureFormat {format} not supported."),
        };
    }
}
