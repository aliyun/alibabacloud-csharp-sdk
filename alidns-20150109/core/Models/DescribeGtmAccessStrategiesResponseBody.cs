// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeGtmAccessStrategiesResponseBody : TeaModel {
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
        public DescribeGtmAccessStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeGtmAccessStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeGtmAccessStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategy : TeaModel {
                public string AccessMode { get; set; }
                public string StrategyName { get; set; }
                public string DefaultAddrPoolMonitorStatus { get; set; }
                public string StrategyMode { get; set; }
                public string CreateTime { get; set; }
                public string DefaultAddrPoolStatus { get; set; }
                public string InstanceId { get; set; }
                public DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLines Lines { get; set; }
                public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLines : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public List<DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine> Line { get; set; }
                    public class DescribeGtmAccessStrategiesResponseBodyStrategiesStrategyLinesLine : TeaModel {
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
                public string FailoverAddrPoolId { get; set; }
                public string DefaultAddrPoolId { get; set; }
                public string StrategyId { get; set; }
                public string FailoverAddrPoolStatus { get; set; }
                public string AccessStatus { get; set; }
                public string FailoverAddrPoolMonitorStatus { get; set; }
                public string DefaultAddrPoolName { get; set; }
                public string FailoverAddrPoolName { get; set; }
                public long? CreateTimestamp { get; set; }
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
