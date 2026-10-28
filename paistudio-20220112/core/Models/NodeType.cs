// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeType : TeaModel {
        /// <summary>
        /// <para>The accelerator type of the resource node specifications (CPU/GPU).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The number of allocatable CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("AllocatableCPU")]
        [Validation(Required=false)]
        public string AllocatableCPU { get; set; }

        /// <summary>
        /// <para>The allocatable memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2Gi</para>
        /// </summary>
        [NameInMap("AllocatableMemory")]
        [Validation(Required=false)]
        public string AllocatableMemory { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("CPU")]
        [Validation(Required=false)]
        public string CPU { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GPU")]
        [Validation(Required=false)]
        public string GPU { get; set; }

        /// <summary>
        /// <para>The GPU memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80G</para>
        /// </summary>
        [NameInMap("GPUMemory")]
        [Validation(Required=false)]
        public string GPUMemory { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A10</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64Gi</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public string Memory { get; set; }

        /// <summary>
        /// <para>The resource node specifications type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.g6.4xlarge</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType_ { get; set; }

        /// <summary>
        /// <para>The number of system-reserved CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SystemReservedCPU")]
        [Validation(Required=false)]
        public string SystemReservedCPU { get; set; }

        /// <summary>
        /// <para>The system-reserved memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2Gi</para>
        /// </summary>
        [NameInMap("SystemReservedMemory")]
        [Validation(Required=false)]
        public string SystemReservedMemory { get; set; }

    }

}
