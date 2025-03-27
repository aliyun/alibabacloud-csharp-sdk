// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Antiddos_public20170518.Models
{
    public class DescribeInstanceIpAddressResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of details of the instance.</para>
        /// </summary>
        [NameInMap("InstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstanceIpAddressResponseBodyInstanceList> InstanceList { get; set; }
        public class DescribeInstanceIpAddressResponseBodyInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1cb6x80tfgocid****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>launch-advisor-2021****</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The DDoS mitigation status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: not under DDoS attacks.</description></item>
            /// <item><description><b>abnormal</b>: under DDoS attacks.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public string InstanceStatus { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ecs</b></description></item>
            /// <item><description><b>slb</b></description></item>
            /// <item><description><b>eip</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>An array that consists of the details of the asset.</para>
            /// </summary>
            [NameInMap("IpAddressConfig")]
            [Validation(Required=false)]
            public List<DescribeInstanceIpAddressResponseBodyInstanceListIpAddressConfig> IpAddressConfig { get; set; }
            public class DescribeInstanceIpAddressResponseBodyInstanceListIpAddressConfig : TeaModel {
                /// <summary>
                /// <para>The basic protection threshold for the asset. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5200</para>
                /// </summary>
                [NameInMap("BlackholeThreshold")]
                [Validation(Required=false)]
                public int? BlackholeThreshold { get; set; }

                /// <summary>
                /// <para>The traffic scrubbing threshold for the asset measured in Mbit/s. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("DefenseBpsThreshold")]
                [Validation(Required=false)]
                public int? DefenseBpsThreshold { get; set; }

                /// <summary>
                /// <para>The traffic scrubbing threshold for the asset measured in packets per second (PPS). Unit: PPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>70000</para>
                /// </summary>
                [NameInMap("DefensePpsThreshold")]
                [Validation(Required=false)]
                public int? DefensePpsThreshold { get; set; }

                /// <summary>
                /// <para>The burstable protection threshold for the asset. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12310</para>
                /// </summary>
                [NameInMap("ElasticThreshold")]
                [Validation(Required=false)]
                public int? ElasticThreshold { get; set; }

                /// <summary>
                /// <para>The IP address of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.0.XX.XX</para>
                /// </summary>
                [NameInMap("InstanceIp")]
                [Validation(Required=false)]
                public string InstanceIp { get; set; }

                /// <summary>
                /// <para>The DDoS mitigation status of the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mitigating</b>: indicates that traffic scrubbing is in progress.</description></item>
                /// <item><description><b>blackholed</b>: indicates that blackhole filtering is triggered for the asset.</description></item>
                /// <item><description><b>normal</b>: indicates that no DDoS attacks are launched against the asset.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("IpStatus")]
                [Validation(Required=false)]
                public string IpStatus { get; set; }

                /// <summary>
                /// <para>The IP version of the IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>v4</b>: IPv4.</description></item>
                /// <item><description><b>v6</b>: IPv6.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the asset is added to the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsBgppack")]
                [Validation(Required=false)]
                public bool? IsBgppack { get; set; }

                /// <summary>
                /// <para>Indicates whether best-effort protection is enabled for the asset. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: no.</description></item>
                /// <item><description><b>1</b>: yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsFullProtection")]
                [Validation(Required=false)]
                public int? IsFullProtection { get; set; }

                /// <summary>
                /// <para>The region code of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-dg-a01</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BC0907F8-A9F3-5E11-977B-D59CD98C64ED</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the assets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
