// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceRequest : TeaModel {
        /// <summary>
        /// <para>The BestEffort policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>besteffort: BestEffort</para>
        /// </description></item>
        /// <item><description><para>try-besteffort: BestEffort preferred</para>
        /// </description></item>
        /// <item><description><para>default: default</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("BestEffortType")]
        [Validation(Required=false)]
        public string BestEffortType { get; set; }

        /// <summary>
        /// <para>The number of CPU cores required for each instance. Unit: millicores. This value cannot be 0. Only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>500</b></para>
        /// </description></item>
        /// <item><description><para><b>1000</b></para>
        /// </description></item>
        /// <item><description><para><b>2000</b></para>
        /// </description></item>
        /// <item><description><para><b>4000</b></para>
        /// </description></item>
        /// <item><description><para><b>8000</b></para>
        /// </description></item>
        /// <item><description><para><b>12000</b></para>
        /// </description></item>
        /// <item><description><para><b>16000</b></para>
        /// </description></item>
        /// <item><description><para><b>32000</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        [NameInMap("GpuA10")]
        [Validation(Required=false)]
        public string GpuA10 { get; set; }

        [NameInMap("GpuPpu810e")]
        [Validation(Required=false)]
        public string GpuPpu810e { get; set; }

        /// <summary>
        /// <para>The amount of memory required for each instance. Unit: MB. This value cannot be 0. The memory size must correspond to the CPU specification. Only the following defined specifications are supported:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1024</b>: Corresponds to 500 millicores and 1,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>2048</b>: Corresponds to 500, 1,000, and 2,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>4096</b>: Corresponds to 1,000, 2,000, and 4,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>8192</b>: Corresponds to 2,000, 4,000, and 8,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>12288</b>: Corresponds to 12,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>16384</b>: Corresponds to 4,000, 8,000, and 16,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>24576</b>: Corresponds to 12,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>32768</b>: Corresponds to 16,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>65536</b>: Corresponds to 8,000, 16,000, and 32,000 millicores of CPU.</para>
        /// </description></item>
        /// <item><description><para><b>131072</b>: Corresponds to 32,000 millicores of CPU.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The application version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>lite: Lightweight Edition</para>
        /// </description></item>
        /// <item><description><para>std: Standard Edition</para>
        /// </description></item>
        /// <item><description><para>pro: Professional Edition</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>std</para>
        /// </summary>
        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values: NULL (default), default, and haiguang (Haiguang server).</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The application scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>web</para>
        /// </description></item>
        /// <item><description><para>micro_service</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Web</para>
        /// </summary>
        [NameInMap("Workload")]
        [Validation(Required=false)]
        public string Workload { get; set; }

    }

}
