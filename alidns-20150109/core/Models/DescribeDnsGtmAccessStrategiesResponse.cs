// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategiesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=true)]
        public int? TotalItems { get; set; }

        [NameInMap("TotalPages")]
        [Validation(Required=true)]
        public int? TotalPages { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategiesResponseStrategies Strategies { get; set; }
        public class DescribeDnsGtmAccessStrategiesResponseStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategiesResponseStrategiesStrategy> Strategy { get; set; }
            public class DescribeDnsGtmAccessStrategiesResponseStrategiesStrategy : TeaModel {
                public string StrategyId { get; set; }
                public string StrategyName { get; set; }
                public string CreateTime { get; set; }
                public long? CreateTimestamp { get; set; }
                public string EffectiveAddrPoolGroupType { get; set; }
                public string EffectiveAddrPoolType { get; set; }
                public string EffectiveLbaStrategy { get; set; }
                public DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyLines Lines { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=true)]
                    public List<DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyLinesLine : TeaModel {
                        [NameInMap("LineCode")]
                        [Validation(Required=true)]
                        public string LineCode { get; set; }

                        [NameInMap("LineName")]
                        [Validation(Required=true)]
                        public string LineName { get; set; }

                        [NameInMap("GroupCode")]
                        [Validation(Required=true)]
                        public string GroupCode { get; set; }

                        [NameInMap("GroupName")]
                        [Validation(Required=true)]
                        public string GroupName { get; set; }

                    }

                }
                public DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyEffectiveAddrPools EffectiveAddrPools { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyEffectiveAddrPools : TeaModel {
                    [NameInMap("EffectiveAddrPool")]
                    [Validation(Required=true)]
                    public List<DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool> EffectiveAddrPool { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool : TeaModel {
                        [NameInMap("Id")]
                        [Validation(Required=true)]
                        public string Id { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=true)]
                        public string Name { get; set; }

                        [NameInMap("AddrCount")]
                        [Validation(Required=true)]
                        public int? AddrCount { get; set; }

                        [NameInMap("LbaWeight")]
                        [Validation(Required=true)]
                        public int? LbaWeight { get; set; }

                    }

                }
            }
        };

    }

}
