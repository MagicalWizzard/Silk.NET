// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_conditional_rendering")]
    public abstract unsafe partial class ExtConditionalRendering : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_conditional_rendering";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        public abstract unsafe void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ConditionalRenderingBeginInfoEXT* pConditionalRenderingBegin);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginConditionalRenderingEXT")]
        public abstract void CmdBeginConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref ConditionalRenderingBeginInfoEXT pConditionalRenderingBegin);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndConditionalRenderingEXT")]
        public abstract void CmdEndConditionalRendering([Count(Count = 0)] CommandBuffer commandBuffer);

        public ExtConditionalRendering(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

