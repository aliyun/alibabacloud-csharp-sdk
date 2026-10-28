// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class EcsSpec : TeaModel {
        /// <summary>
        /// <para>The accelerator type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The ECS image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-bp1g7004ksh0oeuc****</para>
        /// </summary>
        [NameInMap("EcsImageId")]
        [Validation(Required=false)]
        public string EcsImageId { get; set; }

        /// <summary>
        /// <para>The number of Elastic RDMA Interface (ERI) network interface controllers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("EriQuantity")]
        [Validation(Required=false)]
        public int? EriQuantity { get; set; }

        /// <summary>
        /// <para>The number of GPUs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The GPU computing unit specifications.</para>
        /// </summary>
        [NameInMap("GpuGUSpec")]
        [Validation(Required=false)]
        public string GpuGUSpec { get; set; }

        /// <summary>
        /// <para>The GPU memory size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A100</para>
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <para>The GPU type alias.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A100</para>
        /// </summary>
        [NameInMap("GpuTypeAlias")]
        [Validation(Required=false)]
        public string GpuTypeAlias { get; set; }

        /// <summary>
        /// <para>The instance type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ml.gu7xf.8xlarge-gu108</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The machine model.</para>
        /// </summary>
        [NameInMap("MachineModel")]
        [Validation(Required=false)]
        public string MachineModel { get; set; }

        /// <summary>
        /// <para>The memory resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The network mode.</para>
        /// </summary>
        [NameInMap("NetworkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The planned number of CPU cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("PlannedCpu")]
        [Validation(Required=false)]
        public int? PlannedCpu { get; set; }

        /// <summary>
        /// <para>The planned memory size.</para>
        /// </summary>
        [NameInMap("PlannedMemory")]
        [Validation(Required=false)]
        public int? PlannedMemory { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Specifies whether GPU sharing is supported.</para>
        /// </summary>
        [NameInMap("SupportGPUShare")]
        [Validation(Required=false)]
        public bool? SupportGPUShare { get; set; }

        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public bool? SupportRDMA { get; set; }

        /// <summary>
        /// <para>Specifies whether setting the network interface controller index is supported.</para>
        /// </summary>
        [NameInMap("SupportSetNetworkCardIndex")]
        [Validation(Required=false)]
        public bool? SupportSetNetworkCardIndex { get; set; }

    }

}
