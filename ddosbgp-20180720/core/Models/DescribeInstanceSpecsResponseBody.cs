// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// The specifications of the Anti-DDoS Origin Enterprise instance, including whether best-effort protection is enabled, the number of available best-effort protection sessions, and the number of used best-effort protection sessions.
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// The available best-effort protection sessions.
            /// </summary>
            [NameInMap("AvailableDefenseTimes")]
            [Validation(Required=false)]
            public int? AvailableDefenseTimes { get; set; }

            /// <summary>
            /// The number of times that blackhole filtering can be deactivated.
            /// </summary>
            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=false)]
            public string AvailableDeleteBlackholeCount { get; set; }

            /// <summary>
            /// The percentage of the used best-effort protection sessions. Unit: %.
            /// </summary>
            [NameInMap("DefenseTimesPercent")]
            [Validation(Required=false)]
            public int? DefenseTimesPercent { get; set; }

            [NameInMap("DowngradeStatus")]
            [Validation(Required=false)]
            public int? DowngradeStatus { get; set; }

            /// <summary>
            /// The region ID of the Anti-DDoS Origin Enterprise instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether best-effort protection is enabled. Valid values:
            /// 
            /// *   **0**: Best-effort protection is disabled.
            /// *   **1**: Best-effort protection is enabled.
            /// </summary>
            [NameInMap("IsFullDefenseMode")]
            [Validation(Required=false)]
            public int? IsFullDefenseMode { get; set; }

            /// <summary>
            /// The configurations of the Anti-DDoS Origin Enterprise instance, including the number of protected IP addresses and protection bandwidth.
            /// </summary>
            [NameInMap("PackConfig")]
            [Validation(Required=false)]
            public DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig PackConfig { get; set; }
            public class DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig : TeaModel {
                /// <summary>
                /// The bandwidth. Unit: Gbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The number of IP addresses that are protected by the Anti-DDoS Origin Enterprise instance.
                /// </summary>
                [NameInMap("BindIpCount")]
                [Validation(Required=false)]
                public int? BindIpCount { get; set; }

                [NameInMap("ElasticBwMbps")]
                [Validation(Required=false)]
                public int? ElasticBwMbps { get; set; }

                [NameInMap("ElasticBwMode")]
                [Validation(Required=false)]
                public string ElasticBwMode { get; set; }

                /// <summary>
                /// The burstable protection bandwidth of each protected IP address. Unit: Gbit/s.
                /// </summary>
                [NameInMap("IpAdvanceThre")]
                [Validation(Required=false)]
                public int? IpAdvanceThre { get; set; }

                /// <summary>
                /// The basic protection bandwidth of each protected IP address. Unit: Gbit/s.
                /// </summary>
                [NameInMap("IpBasicThre")]
                [Validation(Required=false)]
                public int? IpBasicThre { get; set; }

                /// <summary>
                /// The number of IP addresses that can be protected by the Anti-DDoS Origin Enterprise instance.
                /// </summary>
                [NameInMap("IpSpec")]
                [Validation(Required=false)]
                public int? IpSpec { get; set; }

                /// <summary>
                /// The clean bandwidth. Unit: Mbit/s.
                /// </summary>
                [NameInMap("NormalBandwidth")]
                [Validation(Required=false)]
                public int? NormalBandwidth { get; set; }

                /// <summary>
                /// The burstable protection bandwidth of the Anti-DDoS Origin Enterprise instance. Unit: Gbit/s.
                /// </summary>
                [NameInMap("PackAdvThre")]
                [Validation(Required=false)]
                public int? PackAdvThre { get; set; }

                /// <summary>
                /// The basic protection bandwidth of the Anti-DDoS Origin Enterprise instance. Unit: Gbit/s.
                /// </summary>
                [NameInMap("PackBasicThre")]
                [Validation(Required=false)]
                public int? PackBasicThre { get; set; }

            }

            /// <summary>
            /// The region ID of the Anti-DDoS Origin Enterprise instance.
            /// 
            /// > You can call the [DescribeRegions](https://help.aliyun.com/document_detail/118703.html) operation to query the name of the region.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The total best-effort protection sessions.
            /// </summary>
            [NameInMap("TotalDefenseTimes")]
            [Validation(Required=false)]
            public int? TotalDefenseTimes { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
