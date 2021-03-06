// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct AccelerationStructureGeometryKHR
    {
        public AccelerationStructureGeometryKHR
        (
            StructureType sType = StructureType.AccelerationStructureGeometryKhr,
            void* pNext = default,
            GeometryTypeKHR geometryType = default,
            AccelerationStructureGeometryDataKHR geometry = default,
            GeometryFlagsKHR flags = default
        )
        {
           SType = sType;
           PNext = pNext;
           GeometryType = geometryType;
           Geometry = geometry;
           Flags = flags;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public GeometryTypeKHR GeometryType;
/// <summary></summary>
        public AccelerationStructureGeometryDataKHR Geometry;
/// <summary></summary>
        public GeometryFlagsKHR Flags;
    }
}
