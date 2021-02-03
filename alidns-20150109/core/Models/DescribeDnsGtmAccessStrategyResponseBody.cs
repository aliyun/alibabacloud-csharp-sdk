// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyResponseBody : TeaModel {
        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=false)]
        public string DefaultAddrPoolType { get; set; }

        [NameInMap("DefaultAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultAvailableAddrNum { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

        [NameInMap("FailoverAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string FailoverAddrPoolGroupStatus { get; set; }

        [NameInMap("FailoverAvailableAddrNum")]
        [Validation(Required=false)]
        public int? FailoverAvailableAddrNum { get; set; }

        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=false)]
        public string FailoverLbaStrategy { get; set; }

        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=false)]
        public string DefaultLbaStrategy { get; set; }

        [NameInMap("DefaultAddrPoolGroupStatus")]
        [Validation(Required=false)]
        public string DefaultAddrPoolGroupStatus { get; set; }

        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=false)]
        public string FailoverAddrPoolType { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("FailoverAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools FailoverAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPools : TeaModel {
            [NameInMap("FailoverAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool> FailoverAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyFailoverAddrPoolsFailoverAddrPool : TeaModel {
                public int? LbaWeight { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=false)]
        public string DefaultLatencyOptimization { get; set; }

        [NameInMap("EffectiveAddrPoolGroupType")]
        [Validation(Required=false)]
        public string EffectiveAddrPoolGroupType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("DefaultAddrPools")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools DefaultAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPools : TeaModel {
            [NameInMap("DefaultAddrPool")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool> DefaultAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyDefaultAddrPoolsDefaultAddrPool : TeaModel {
                public int? LbaWeight { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=false)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=false)]
        public string FailoverLatencyOptimization { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public string StrategyName { get; set; }

        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=false)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        [NameInMap("AccessMode")]
        [Validation(Required=false)]
        public string AccessMode { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=false)]
        public DescribeDnsGtmAccessStrategyResponseBodyLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseBodyLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=false)]
            public List<DescribeDnsGtmAccessStrategyResponseBodyLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseBodyLinesLine : TeaModel {
                public string GroupName { get; set; }
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
            }
        };

    }

}
