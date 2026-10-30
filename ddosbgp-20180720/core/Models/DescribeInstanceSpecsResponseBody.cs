// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// <para>The specification information of the Anti-DDoS Origin instance, including the enabling status of best-effort protection, and the available and used best-effort protection times.</para>
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// <para>The available best-effort protection times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AvailableDefenseTimes")]
            [Validation(Required=false)]
            public int? AvailableDefenseTimes { get; set; }

            /// <summary>
            /// <para>The available quota for deactivating blackhole filtering.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=false)]
            public string AvailableDeleteBlackholeCount { get; set; }

            /// <summary>
            /// <para>The usage percentage of best-effort protection times. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("DefenseTimesPercent")]
            [Validation(Required=false)]
            public int? DefenseTimesPercent { get; set; }

            /// <summary>
            /// <para>The downgrade status of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>8</b>: The instance is downgraded because the clean bandwidth exceeds the limit.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("DowngradeStatus")]
            [Validation(Required=false)]
            public int? DowngradeStatus { get; set; }

            /// <summary>
            /// <para>The ID of the Anti-DDoS Origin instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ddosbgp-cn-n6w1r7nz****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether best-effort protection mode is enabled for the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Best-effort protection mode is disabled.</description></item>
            /// <item><description><b>1</b>: Best-effort protection mode is enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsFullDefenseMode")]
            [Validation(Required=false)]
            public int? IsFullDefenseMode { get; set; }

            /// <summary>
            /// <para>The configuration information of the Anti-DDoS Origin instance, including the number of protected IP addresses and protection bandwidth information.</para>
            /// </summary>
            [NameInMap("PackConfig")]
            [Validation(Required=false)]
            public DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig PackConfig { get; set; }
            public class DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig : TeaModel {
                /// <summary>
                /// <para>The bandwidth. Unit: Gbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The number of protected IP addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BindIpCount")]
                [Validation(Required=false)]
                public int? BindIpCount { get; set; }

                /// <summary>
                /// <para>The burstable clean bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ElasticBwMbps")]
                [Validation(Required=false)]
                public int? ElasticBwMbps { get; set; }

                /// <summary>
                /// <para>The burstable clean bandwidth mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>month</b>: Monthly 95th percentile metering method.</description></item>
                /// <item><description><b>day</b>: Daily 95th percentile metering method.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("ElasticBwMode")]
                [Validation(Required=false)]
                public string ElasticBwMode { get; set; }

                /// <summary>
                /// <para>The burstable protection threshold for the protected IP address. Unit: Gbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("IpAdvanceThre")]
                [Validation(Required=false)]
                public int? IpAdvanceThre { get; set; }

                /// <summary>
                /// <para>The basic protection threshold for the protected IP address. Unit: Gbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("IpBasicThre")]
                [Validation(Required=false)]
                public int? IpBasicThre { get; set; }

                /// <summary>
                /// <para>The number of IP addresses that can be added for protection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("IpSpec")]
                [Validation(Required=false)]
                public int? IpSpec { get; set; }

                /// <summary>
                /// <para>The normal clean bandwidth. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("NormalBandwidth")]
                [Validation(Required=false)]
                public int? NormalBandwidth { get; set; }

                /// <summary>
                /// <para>The burstable protection bandwidth of the Anti-DDoS Origin instance. Unit: Gbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("PackAdvThre")]
                [Validation(Required=false)]
                public int? PackAdvThre { get; set; }

                /// <summary>
                /// <para>The basic protection bandwidth of the Anti-DDoS Origin instance. Unit: Gbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("PackBasicThre")]
                [Validation(Required=false)]
                public int? PackBasicThre { get; set; }

            }

            /// <summary>
            /// <para>The region ID of the Anti-DDoS Origin instance.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/118703.html">DescribeRegions</a> operation to query the details of region IDs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The total available best-effort protection times.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("TotalDefenseTimes")]
            [Validation(Required=false)]
            public int? TotalDefenseTimes { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5840AB9F-1419-4620-807D-5EA476090247</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
