// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeRouteDistributionStrategiesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Strategies")]
        [Validation(Required=false)]
        public DescribeRouteDistributionStrategiesResponseBodyStrategies Strategies { get; set; }
        public class DescribeRouteDistributionStrategiesResponseBodyStrategies : TeaModel {
            [NameInMap("Strategy")]
            [Validation(Required=false)]
            public List<DescribeRouteDistributionStrategiesResponseBodyStrategiesStrategy> Strategy { get; set; }
            public class DescribeRouteDistributionStrategiesResponseBodyStrategiesStrategy : TeaModel {
                public string ConflictInfo { get; set; }
                public long? CreateTime { get; set; }
                public string DestCidrBlock { get; set; }
                public string HcInstanceId { get; set; }
                public bool? IsConflict { get; set; }
                public string RouteDistribution { get; set; }
                public string RouteSource { get; set; }
                public string SmartAGId { get; set; }
                public string SourceType { get; set; }
                public string Status { get; set; }
                public string StrategyPublishStatus { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
