// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeGPUMetric : TeaModel {
        /// <summary>
        /// <para>The accelerator type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The GPU count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("GPUCount")]
        [Validation(Required=false)]
        public int? GPUCount { get; set; }

        /// <summary>
        /// <para>The GPU metrics.</para>
        /// </summary>
        [NameInMap("GPUMetrics")]
        [Validation(Required=false)]
        public List<GPUMetric> GPUMetrics { get; set; }

        /// <summary>
        /// <para>The GPU type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>V100</para>
        /// </summary>
        [NameInMap("GPUType")]
        [Validation(Required=false)]
        public string GPUType { get; set; }

        /// <summary>
        /// <para>The memory utilization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MemoryUtil")]
        [Validation(Required=false)]
        public float? MemoryUtil { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingj19q90jp66nq-mg1a2kc92f9nn8yd-20</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>The node type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs.c8i.xlarge</para>
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// <para>The total memory.</para>
        /// </summary>
        [NameInMap("TotalMemory")]
        [Validation(Required=false)]
        public float? TotalMemory { get; set; }

        /// <summary>
        /// <para>The used memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("UsedMemory")]
        [Validation(Required=false)]
        public float? UsedMemory { get; set; }

    }

}
