// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyResponseBody : TeaModel {
        /// <summary>
        /// The primary/secondary switchover policy for address pool groups. Valid values:
        /// 
        /// *   AUTO: performs automatic switchover between the primary and secondary address pool groups upon failures.
        /// *   DEFAULT: uses the primary address pool group.
        /// *   FAILOVER: uses the secondary address pool group.
        /// </summary>
        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        /// <summary>
        /// The time when the access policy was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp that indicates when the access policy was created.
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// The status of the primary address pool group. Valid values:
        /// 
        /// *   AVAILABLE: available
        /// *   NOT_AVAILABLE: unavailable
        /// </summary>
        [NameInMap("DefaultAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolGroupStatus { get; set; }

        /// <summary>
        /// The type of the primary address pool. Valid values:
        /// 
        /// *   IPV4
        /// *   IPV6
        /// *   DOMAIN
        /// </summary>
        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        /// <summary>
        /// The address pools in the primary address pool group.
        /// </summary>
        [NameInMap("DefaultAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools DefaultAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools : TeaModel {
            [NameInMap("DefaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool> DefaultAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool : TeaModel {
                /// <summary>
                /// The number of addresses in the address pool.
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// The ID of the address pool.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The weight of the address pool.
                /// </summary>
                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                /// <summary>
                /// The name of the address pool.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The number of available addresses in the primary address pool.
        /// </summary>
        [NameInMap("DefaultAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultAvailableAddrNum { get; set; }

        /// <summary>
        /// Indicates whether scheduling optimization for latency resolution was enabled for the primary address pool group. Valid values:
        /// 
        /// *   OPEN: enabled
        /// *   CLOSE: disabled
        /// </summary>
        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        /// <summary>
        /// The load balancing policy of the primary address pool group. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=false)]
        public string DefaultLbaStrategy { get; set; }

        /// <summary>
        /// The maximum number of addresses returned from the primary address pool group.
        /// </summary>
        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        /// <summary>
        /// The minimum number of available addresses in the primary address pool group.
        /// </summary>
        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        /// <summary>
        /// The type of the active address pool group. Valid values:
        /// 
        /// *   DEFAULT: the primary address pool group
        /// *   FAILOVER: the secondary address pool group
        /// </summary>
        [NameInMap("EffectiveAddrPoolGroupType")]
        [Validation(Required=false)]
        public string EffectiveAddrPoolGroupType { get; set; }

        /// <summary>
        /// The status of the secondary address pool group. Valid values:
        /// 
        /// *   AVAILABLE: available
        /// *   NOT_AVAILABLE: unavailable
        /// </summary>
        [NameInMap("FailoverAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolGroupStatus { get; set; }

        /// <summary>
        /// The type of the secondary address pool. Valid values:
        /// 
        /// *   IPV4
        /// *   IPV6
        /// *   DOMAIN
        /// </summary>
        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=false)]
        public string FailoverAddrPoolType { get; set; }

        /// <summary>
        /// The address pools in the secondary address pool group.
        /// </summary>
        [NameInMap("FailoverAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools FailoverAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools : TeaModel {
            [NameInMap("FailoverAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool> FailoverAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool : TeaModel {
                /// <summary>
                /// The number of addresses in the address pool.
                /// </summary>
                [NameInMap("AddrCount")]
                [Validation(Required=false)]
                public int? AddrCount { get; set; }

                /// <summary>
                /// The ID of the address pool.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The weight of the address pool.
                /// </summary>
                [NameInMap("LbaWeight")]
                [Validation(Required=false)]
                public int? LbaWeight { get; set; }

                /// <summary>
                /// The name of the address pool.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// The number of available addresses in the secondary address pool.
        /// </summary>
        [NameInMap("FailoverAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverAvailableAddrNum { get; set; }

        /// <summary>
        /// Indicates whether scheduling optimization for latency resolution was enabled for the secondary address pool group. Valid values:
        /// 
        /// *   OPEN: enabled
        /// *   CLOSE: disabled
        /// </summary>
        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        /// <summary>
        /// The load balancing policy of the secondary address pool group. Valid values:
        /// 
        /// *   ALL_RR: returns all addresses.
        /// *   RATIO: returns addresses by weight.
        /// </summary>
        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=false)]
        public string FailoverLbaStrategy { get; set; }

        /// <summary>
        /// The maximum number of addresses returned from the secondary address pool group.
        /// </summary>
        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        /// <summary>
        /// The minimum number of available addresses in the secondary address pool group.
        /// </summary>
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        /// <summary>
        /// The ID of the associated instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The source regions.
        /// </summary>
        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                /// <summary>
                /// The code of the source region group.
                /// </summary>
                [NameInMap("GroupCode")]
                [Validation(Required=false)]
                public string GroupCode { get; set; }

                /// <summary>
                /// The name of the source region group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// The line code of the source region.
                /// </summary>
                [NameInMap("LineCode")]
                [Validation(Required=false)]
                public string LineCode { get; set; }

                /// <summary>
                /// The line name of the source region.
                /// </summary>
                [NameInMap("LineName")]
                [Validation(Required=false)]
                public string LineName { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the access policy.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        /// <summary>
        /// The type of the access policy. Valid values:
        /// 
        /// *   GEO: geographical location-based
        /// *   LATENCY: latency-based
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        /// <summary>
        /// The name of the access policy.
        /// </summary>
        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

    }

}
