// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transpose_matrix")]
    public abstract unsafe partial class ArbTransposeMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transpose_matrix";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        public abstract unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB")]
        public abstract void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        public abstract unsafe void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB")]
        public abstract void LoadTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        public abstract unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] float* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB")]
        public abstract void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<float> m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        public abstract unsafe void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] double* m);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="m">
        /// To be added.
        /// This parameter contains 16 elements.
        /// </param>
        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB")]
        public abstract void MultTransposeMatrix([Count(Count = 16), Flow(FlowDirection.In)] Span<double> m);

        public ArbTransposeMatrix(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

