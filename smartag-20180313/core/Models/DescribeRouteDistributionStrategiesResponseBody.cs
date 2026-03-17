// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeRouteDistributionStrategiesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>944C2533-1BB7-4578-B6EB-DA05BB61C02A</para>
        /// </summary>
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
                [NameInMap("ConflictInfo")]
                [Validation(Required=false)]
                public string ConflictInfo { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("DestCidrBlock")]
                [Validation(Required=false)]
                public string DestCidrBlock { get; set; }

                [NameInMap("HcInstanceId")]
                [Validation(Required=false)]
                public string HcInstanceId { get; set; }

                [NameInMap("IsConflict")]
                [Validation(Required=false)]
                public bool? IsConflict { get; set; }

                [NameInMap("RouteDistribution")]
                [Validation(Required=false)]
                public string RouteDistribution { get; set; }

                [NameInMap("RouteSource")]
                [Validation(Required=false)]
                public string RouteSource { get; set; }

                [NameInMap("SmartAGId")]
                [Validation(Required=false)]
                public string SmartAGId { get; set; }

                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StrategyPublishStatus")]
                [Validation(Required=false)]
                public string StrategyPublishStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of routes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
