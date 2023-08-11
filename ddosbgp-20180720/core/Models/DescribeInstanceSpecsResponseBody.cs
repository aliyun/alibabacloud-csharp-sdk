// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// The number of IP addresses that are protected by the Anti-DDoS Origin Enterprise instance.
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// The ID of the Anti-DDoS Origin Enterprise instance. This parameter value is a string consisting of JSON arrays. Each element in a JSON array indicates an instance ID. If you want to query more than one instance, separate instance IDs with commas (,).
            /// 
            /// >  You can call the [DescribeInstanceList](~~118698~~) operation to query the IDs of all Anti-DDoS Origin Enterprise instances in a specific region.
            /// </summary>
            [NameInMap("AvailableDefenseTimes")]
            [Validation(Required=false)]
            public int? AvailableDefenseTimes { get; set; }

            /// <summary>
            /// The basic protection bandwidth of the Anti-DDoS Origin Enterprise instance. Unit: Gbit/s.
            /// </summary>
            [NameInMap("AvailableDeleteBlackholeCount")]
            [Validation(Required=false)]
            public string AvailableDeleteBlackholeCount { get; set; }

            /// <summary>
            /// The number of IP addresses that can be protected by the Anti-DDoS Origin Enterprise instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The region ID of the Anti-DDoS Origin Enterprise instance.
            /// 
            /// >  You can call the [DescribeRegions](~~118703~~) operation to query the name of the region.
            /// </summary>
            [NameInMap("IsFullDefenseMode")]
            [Validation(Required=false)]
            public int? IsFullDefenseMode { get; set; }

            /// <summary>
            /// The specifications of the Anti-DDoS Origin Enterprise instance, including whether the unlimited protection feature is enabled, and the numbers of times that the unlimited protection feature can be enabled and has been enabled.
            /// </summary>
            [NameInMap("PackConfig")]
            [Validation(Required=false)]
            public DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig PackConfig { get; set; }
            public class DescribeInstanceSpecsResponseBodyInstanceSpecsPackConfig : TeaModel {
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The ID of the Anti-DDoS Origin Enterprise instance.
                /// </summary>
                [NameInMap("BindIpCount")]
                [Validation(Required=false)]
                public int? BindIpCount { get; set; }

                /// <summary>
                /// DescribeInstanceSpecs
                /// </summary>
                [NameInMap("IpAdvanceThre")]
                [Validation(Required=false)]
                public int? IpAdvanceThre { get; set; }

                /// <summary>
                /// WB269094
                /// </summary>
                [NameInMap("IpBasicThre")]
                [Validation(Required=false)]
                public int? IpBasicThre { get; set; }

                [NameInMap("IpSpec")]
                [Validation(Required=false)]
                public int? IpSpec { get; set; }

                /// <summary>
                /// DescribeInstanceSpecs
                /// </summary>
                [NameInMap("NormalBandwidth")]
                [Validation(Required=false)]
                public int? NormalBandwidth { get; set; }

                /// <summary>
                /// All Alibaba Cloud API operations must include common request parameters. For more information about common request parameters, see [Common parameters](~~118841~~).
                /// 
                /// For more information about sample requests, see the **"Examples"** section of this topic.
                /// </summary>
                [NameInMap("PackAdvThre")]
                [Validation(Required=false)]
                public int? PackAdvThre { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("PackBasicThre")]
                [Validation(Required=false)]
                public int? PackBasicThre { get; set; }

            }

            /// <summary>
            /// The number of times that blackhole filtering can be deactivated.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The number of times that the unlimited protection feature can be enabled.
            /// </summary>
            [NameInMap("TotalDefenseTimes")]
            [Validation(Required=false)]
            public int? TotalDefenseTimes { get; set; }

        }

        /// <summary>
        /// The number of times that the unlimited protection feature can be enabled.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
