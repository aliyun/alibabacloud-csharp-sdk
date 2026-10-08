// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceIpAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of instances to which the assets that are assigned public IP addresses belong.</para>
        /// </summary>
        [NameInMap("RCInstanceList")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceIpAddressResponseBodyRCInstanceList> RCInstanceList { get; set; }
        public class DescribeRCInstanceIpAddressResponseBodyRCInstanceList : TeaModel {
            /// <summary>
            /// <para>The Custom instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-kti8hw44yy0x53******</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The Custom instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-kti8hw44yy0x53******</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The DDoS mitigation status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: Normal.</description></item>
            /// <item><description><b>abnormal</b>: Under attack.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The type of the assets that are assigned public IP addresses. The value is fixed as <b>ecs</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The details of the assets that are assigned public IP addresses.</para>
            /// </summary>
            [NameInMap("IpAddressConfig")]
            [Validation(Required=false)]
            public List<DescribeRCInstanceIpAddressResponseBodyRCInstanceListIpAddressConfig> IpAddressConfig { get; set; }
            public class DescribeRCInstanceIpAddressResponseBodyRCInstanceListIpAddressConfig : TeaModel {
                /// <summary>
                /// <para>The basic DDoS Mitigation Threshold of the assets that are assigned public IP addresses. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5200</para>
                /// </summary>
                [NameInMap("BlackholeThreshold")]
                [Validation(Required=false)]
                public int? BlackholeThreshold { get; set; }

                /// <summary>
                /// <para>The traffic scrubbing threshold of the assets that are assigned public IP addresses. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("DefenseBpsThreshold")]
                [Validation(Required=false)]
                public int? DefenseBpsThreshold { get; set; }

                /// <summary>
                /// <para>The message rate scrubbing threshold of the assets that are assigned public IP addresses. Unit: pps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70000</para>
                /// </summary>
                [NameInMap("DefensePpsThreshold")]
                [Validation(Required=false)]
                public int? DefensePpsThreshold { get; set; }

                /// <summary>
                /// <para>The DDoS burstable Mitigation Threshold of the assets that are assigned public IP addresses. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12310</para>
                /// </summary>
                [NameInMap("ElasticThreshold")]
                [Validation(Required=false)]
                public int? ElasticThreshold { get; set; }

                /// <summary>
                /// <para>The IP address of the assets that are assigned public IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>39.105.XXX.XXX</para>
                /// </summary>
                [NameInMap("InstanceIp")]
                [Validation(Required=false)]
                public string InstanceIp { get; set; }

                /// <summary>
                /// <para>The DDoS mitigation status of the assets that are assigned public IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mitigating</b>: Cleaning.</description></item>
                /// <item><description><b>blackholed</b>: Black Hole Activated.</description></item>
                /// <item><description><b>normal</b>: Normal.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                /// <summary>
                /// <para>The IP protocol version of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v4</b></description></item>
                /// <item><description><b>v6</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the assets that are assigned public IP addresses is attached to Anti-DDoS Origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Attached.</description></item>
                /// <item><description><b>false</b>: Not attached.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsBgppack")]
                [Validation(Required=false)]
                public bool? IsBgppack { get; set; }

                /// <summary>
                /// <para>Indicates whether best-effort protection is enabled for the assets that are assigned public IP addresses in Anti-DDoS Origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: Best-effort protection is not enabled.</description></item>
                /// <item><description><b>1</b>: Best-effort protection is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsFullProtection")]
                [Validation(Required=false)]
                public int? IsFullProtection { get; set; }

                /// <summary>
                /// <para>The region encoding of the assets that are assigned public IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-wt97-a01</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C048E440-EA84-5E97-8C81-2A7060D0****_th**</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of assets that are assigned public IP addresses returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
