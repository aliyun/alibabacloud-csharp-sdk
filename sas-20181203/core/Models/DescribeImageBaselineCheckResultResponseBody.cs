// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineCheckResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the image baseline check results.</para>
        /// </summary>
        [NameInMap("BaselineResult")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineCheckResultResponseBodyBaselineResult> BaselineResult { get; set; }
        public class DescribeImageBaselineCheckResultResponseBodyBaselineResult : TeaModel {
            /// <summary>
            /// <para>The type key of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identification</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The number of baseline check items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BaselineItemCount")]
            [Validation(Required=false)]
            public int? BaselineItemCount { get; set; }

            /// <summary>
            /// <para>The alias of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>身份鉴别</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The name key of the baseline item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>identification</para>
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// <para>The risk level of the baseline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b>: high risk</description></item>
            /// <item><description><b>medium</b>: medium risk</description></item>
            /// <item><description><b>low</b>: low risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("BaselineNameLevel")]
            [Validation(Required=false)]
            public string BaselineNameLevel { get; set; }

            /// <summary>
            /// <para>The timestamp of the first scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610304058366</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The number of associated high-risk images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HighRiskItemCount")]
            [Validation(Required=false)]
            public int? HighRiskItemCount { get; set; }

            /// <summary>
            /// <para>The timestamp of the most recent scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610304058301</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The number of associated low-risk images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("LowRiskItemCount")]
            [Validation(Required=false)]
            public int? LowRiskItemCount { get; set; }

            /// <summary>
            /// <para>The number of associated medium-risk images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MiddleRiskItemCount")]
            [Validation(Required=false)]
            public int? MiddleRiskItemCount { get; set; }

            /// <summary>
            /// <para>The fix status of the baseline risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unfixed.</description></item>
            /// <item><description><b>1</b>: Fixed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The paging information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineCheckResultResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineCheckResultResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when using paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A20733-10A0-4AF6-BE6B-E3322413****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
