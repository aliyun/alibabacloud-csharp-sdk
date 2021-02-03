// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("StrategyId")]
        [Validation(Required=true)]
        public string StrategyId { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=true)]
        public string StrategyName { get; set; }

        [NameInMap("StrategyMode")]
        [Validation(Required=true)]
        public string StrategyMode { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("DefaultAddrPoolType")]
        [Validation(Required=true)]
        public string DefaultAddrPoolType { get; set; }

        [NameInMap("DefaultLbaStrategy")]
        [Validation(Required=true)]
        public string DefaultLbaStrategy { get; set; }

        [NameInMap("DefaultMinAvailableAddrNum")]
        [Validation(Required=true)]
        public int? DefaultMinAvailableAddrNum { get; set; }

        [NameInMap("DefaultMaxReturnAddrNum")]
        [Validation(Required=true)]
        public int? DefaultMaxReturnAddrNum { get; set; }

        [NameInMap("DefaultLatencyOptimization")]
        [Validation(Required=true)]
        public string DefaultLatencyOptimization { get; set; }

        [NameInMap("DefaultAddrPoolGroupStatus")]
        [Validation(Required=true)]
        public string DefaultAddrPoolGroupStatus { get; set; }

        [NameInMap("FailoverAddrPoolType")]
        [Validation(Required=true)]
        public string FailoverAddrPoolType { get; set; }

        [NameInMap("FailoverLbaStrategy")]
        [Validation(Required=true)]
        public string FailoverLbaStrategy { get; set; }

        [NameInMap("FailoverMinAvailableAddrNum")]
        [Validation(Required=true)]
        public int? FailoverMinAvailableAddrNum { get; set; }

        [NameInMap("FailoverMaxReturnAddrNum")]
        [Validation(Required=true)]
        public int? FailoverMaxReturnAddrNum { get; set; }

        [NameInMap("FailoverLatencyOptimization")]
        [Validation(Required=true)]
        public string FailoverLatencyOptimization { get; set; }

        [NameInMap("FailoverAddrPoolGroupStatus")]
        [Validation(Required=true)]
        public string FailoverAddrPoolGroupStatus { get; set; }

        [NameInMap("AccessMode")]
        [Validation(Required=true)]
        public string AccessMode { get; set; }

        [NameInMap("EffectiveAddrPoolGroupType")]
        [Validation(Required=true)]
        public string EffectiveAddrPoolGroupType { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=true)]
        public string CreateTime { get; set; }

        [NameInMap("CreateTimestamp")]
        [Validation(Required=true)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("DefaultAvailableAddrNum")]
        [Validation(Required=true)]
        public int? DefaultAvailableAddrNum { get; set; }

        [NameInMap("FailoverAvailableAddrNum")]
        [Validation(Required=true)]
        public int? FailoverAvailableAddrNum { get; set; }

        [NameInMap("Lines")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyResponseLines Lines { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseLines : TeaModel {
            [NameInMap("Line")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyResponseLinesLine> Line { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseLinesLine : TeaModel {
                public string LineCode { get; set; }
                public string LineName { get; set; }
                public string GroupCode { get; set; }
                public string GroupName { get; set; }
            }
        };

        [NameInMap("DefaultAddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyResponseDefaultAddrPools DefaultAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseDefaultAddrPools : TeaModel {
            [NameInMap("DefaultAddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyResponseDefaultAddrPoolsDefaultAddrPool> DefaultAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseDefaultAddrPoolsDefaultAddrPool : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public int? LbaWeight { get; set; }
            }
        };

        [NameInMap("FailoverAddrPools")]
        [Validation(Required=true)]
        public DescribeDnsGtmAccessStrategyResponseFailoverAddrPools FailoverAddrPools { get; set; }
        public class DescribeDnsGtmAccessStrategyResponseFailoverAddrPools : TeaModel {
            [NameInMap("FailoverAddrPool")]
            [Validation(Required=true)]
            public List<DescribeDnsGtmAccessStrategyResponseFailoverAddrPoolsFailoverAddrPool> FailoverAddrPool { get; set; }
            public class DescribeDnsGtmAccessStrategyResponseFailoverAddrPoolsFailoverAddrPool : TeaModel {
                public string Id { get; set; }
                public string Name { get; set; }
                public int? AddrCount { get; set; }
                public int? LbaWeight { get; set; }
            }
        };

    }

}
