// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeConfigurationPriceRequest : TeaModel {
        /// <summary>
        /// <para>The CPU specifications that are required for each instance. Unit: millicores. This parameter cannot be set to 0. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>500</b></description></item>
        /// <item><description><b>1000</b></description></item>
        /// <item><description><b>2000</b></description></item>
        /// <item><description><b>4000</b></description></item>
        /// <item><description><b>8000</b></description></item>
        /// <item><description><b>12000</b></description></item>
        /// <item><description><b>16000</b></description></item>
        /// <item><description><b>32000</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The memory size that is required by each instance. Unit: MB. This parameter cannot be set to 0. The values of this parameter correspond to the values of the Cpu parameter:</para>
        /// <list type="bullet">
        /// <item><description>This parameter is set to <b>1024</b> if the Cpu parameter is set to 500 or 1000.</description></item>
        /// <item><description>This parameter is set to <b>2048</b> if the Cpu parameter is set to 500, 1000, or 2000.</description></item>
        /// <item><description>This parameter is set to <b>4096</b> if the Cpu parameter is set to 1000, 2000, or 4000.</description></item>
        /// <item><description>This parameter is set to <b>8192</b> if the Cpu parameter is set to 2000, 4000, or 8,000.</description></item>
        /// <item><description>This parameter is set to <b>12288</b> if the Cpu parameter is set to 12000.</description></item>
        /// <item><description>This parameter is set to <b>16384</b> if the Cpu parameter is set to 4000, 8000, or 16000.</description></item>
        /// <item><description>This parameter is set to <b>24576</b> if the Cpu parameter is set to 12000.</description></item>
        /// <item><description>This parameter is set to <b>32768</b> if the Cpu parameter is set to 16000.</description></item>
        /// <item><description>This parameter is set to <b>65536</b> if the Cpu parameter is set to 8000, 16000, or 32000.</description></item>
        /// <item><description>This parameter is set to <b>131072</b> if the Cpu parameter is set to 32000.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4096</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("NewSaeVersion")]
        [Validation(Required=false)]
        public string NewSaeVersion { get; set; }

        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Scenarios:</para>
        /// <list type="bullet">
        /// <item><description>Web</description></item>
        /// <item><description>micro_service</description></item>
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
