// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class EcsSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>GPU</para>
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>470.199.02</para>
        /// </summary>
        [NameInMap("DefaultGPUDriver")]
        [Validation(Required=false)]
        public string DefaultGPUDriver { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("GpuMemory")]
        [Validation(Required=false)]
        public int? GpuMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NVIDIA v100</para>
        /// </summary>
        [NameInMap("GpuType")]
        [Validation(Required=false)]
        public string GpuType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ecs.gn6e-c12g1.3xlarge</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAvailable")]
        [Validation(Required=false)]
        public bool? IsAvailable { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>92</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("NonProtectSpotDiscount")]
        [Validation(Required=false)]
        public float? NonProtectSpotDiscount { get; set; }

        [NameInMap("PaymentTypes")]
        [Validation(Required=false)]
        public List<string> PaymentTypes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WithStock</para>
        /// </summary>
        [NameInMap("SpotStockStatus")]
        [Validation(Required=false)]
        public string SpotStockStatus { get; set; }

        [NameInMap("SupportedGPUDrivers")]
        [Validation(Required=false)]
        public List<string> SupportedGPUDrivers { get; set; }

    }

}
