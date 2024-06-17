using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Cloo
{

    [StructLayout(LayoutKind.Sequential)]
    public struct ComputeImageDescription
    {
        public ComputeMemoryType ImageType;
        public UIntPtr Width;
        public UIntPtr Height;
        public UIntPtr Depth;
        public UIntPtr ArraySize;
        public UIntPtr RowPitch;
        public UIntPtr SlicePitch;
        public uint MipLevels;
        public uint Samples;
        public IntPtr Buffer;

        public static ComputeImageDescription Create2D(uint width, uint height)
        {
            return new ComputeImageDescription()
            {
                ImageType = ComputeMemoryType.Image2D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)1,
            };
        }

        public static ComputeImageDescription Create2D(uint width, uint height, uint rowPitch)
        {
            return new ComputeImageDescription()
            {
                ImageType = ComputeMemoryType.Image2D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)1,
                RowPitch = (UIntPtr)rowPitch
            };
        }

        public static ComputeImageDescription Create3D(uint width, uint height, uint depth)
        {
            return new ComputeImageDescription()
            {
                ImageType = ComputeMemoryType.Image3D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)depth,
            };
        }

        public static ComputeImageDescription Create3D(uint width, uint height, uint depth, uint rowPitch, uint slicePitch)
        {
            return new ComputeImageDescription()
            {
                ImageType = ComputeMemoryType.Image3D,
                Width = (UIntPtr)width,
                Height = (UIntPtr)height,
                Depth = (UIntPtr)depth,
                RowPitch = (UIntPtr)rowPitch,
                SlicePitch = (UIntPtr)slicePitch
            };
        }
    }
}
