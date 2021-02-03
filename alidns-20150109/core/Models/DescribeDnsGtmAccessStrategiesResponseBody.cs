// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategiesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeDnsGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategy : TeaModel {
                public string EffectiveLbaStrategy { get; set; }
                public string StrategyId { get; set; }
                public string StrategyName { get; set; }
                public string EffectiveAddrPoolGroupType { get; set; }
                public string CreateTime { get; set; }
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools EffectiveAddrPools { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPools : TeaModel {
                    [NameInMap("EffectiveAddrPool")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool> EffectiveAddrPool { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyEffectiveAddrPoolsEffectiveAddrPool : TeaModel {
                        [NameInMap("LbaWeight")]
                        [Validation(Required=false)]
                        public int? LbaWeight { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("AddrCount")]
                        [Validation(Required=false)]
                        public int? AddrCount { get; set; }

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                    }

                }
                public long? CreateTimestamp { get; set; }
                public string EffectiveAddrPoolType { get; set; }
                public DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines Lines { get; set; }
                public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public List<DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeDnsGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine : TeaModel {
                        [NameInMap("GroupName")]
                        [Validation(Required=false)]
                        public string GroupName { get; set; }

                        [NameInMap("LineCode")]
                        [Validation(Required=false)]
                        public string LineCode { get; set; }

                        [NameInMap("LineName")]
                        [Validation(Required=false)]
                        public string LineName { get; set; }

                        [NameInMap("GroupCode")]
                        [Validation(Required=false)]
                        public string GroupCode { get; set; }

                    }

                }
            }
        };

        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

    }

}
