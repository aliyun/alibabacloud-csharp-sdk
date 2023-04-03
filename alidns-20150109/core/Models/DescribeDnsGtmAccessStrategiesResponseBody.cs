// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategiesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The access policies.
        /// </summary>
        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeDnsGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy : TeaModel {
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
                /// The type of the active address pool group. Valid values:
                /// 
                /// *   DEFAULT: the primary address pool group
                /// *   FAILOVER: the secondary address pool group
                /// </summary>
                [NameInMap("EffectiveAddrPoolGroupType")]
                [Validation(Required=false)]
                public string EffectiveAddrPoolGroupType { get; set; }

                /// <summary>
                /// The type of the active address pools. Valid values:
                /// 
                /// *   IPV4
                /// *   IPV6
                /// *   DOMAIN
                /// </summary>
                [NameInMap("EffectiveAddrPoolType")]
                [Validation(Required=false)]
                public string EffectiveAddrPoolType { get; set; }

                /// <summary>
                /// The active address pool groups.
                /// </summary>
                [NameInMap("EffectiveAddrPools")]
                [Validation(Required=false)]
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools EffectiveAddrPools { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools : TeaModel {
                    [NameInMap("EffectiveAddrPool")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool> EffectiveAddrPool { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool : TeaModel {
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
                /// The load balancing policy of the active address pool group. Data is returned when StrategyMode is set to GEO. Valid values: 
                /// 
                /// - ALL_RR: returns all addresses.
                /// - RATIO: returns addresses by weight.
                /// </summary>
                [NameInMap("EffectiveLbaStrategy")]
                [Validation(Required=false)]
                public string EffectiveLbaStrategy { get; set; }

                /// <summary>
                /// The source regions. Data is returned when StrategyMode is set to GEO. Valid values:
                /// </summary>
                [NameInMap("Lines")]
                [Validation(Required=false)]
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines Lines { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine : TeaModel {
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
                /// The ID of the access policy.
                /// </summary>
                [NameInMap("StrategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

                /// <summary>
                /// The name of the access policy.
                /// </summary>
                [NameInMap("StrategyName")]
                [Validation(Required=false)]
                public string StrategyName { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned on all pages.
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// The total number of pages returned.
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
