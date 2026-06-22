// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineCheckSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the image baseline check list.</para>
        /// </summary>
        [NameInMap("BaselineResultSummary")]
        [Validation(Required=false)]
        public List<DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary> BaselineResultSummary { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyBaselineResultSummary : TeaModel {
            /// <summary>
            /// <para>The baseline category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unauthorized access</para>
            /// </summary>
            [NameInMap("BaselineClassAlias")]
            [Validation(Required=false)]
            public string BaselineClassAlias { get; set; }

            /// <summary>
            /// <para>The keyword of the baseline category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc_image_exploit</para>
            /// </summary>
            [NameInMap("BaselineClassKey")]
            [Validation(Required=false)]
            public string BaselineClassKey { get; set; }

            /// <summary>
            /// <para>The baseline name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unauthorized access</para>
            /// </summary>
            [NameInMap("BaselineNameAlias")]
            [Validation(Required=false)]
            public string BaselineNameAlias { get; set; }

            /// <summary>
            /// <para>The keyword of the baseline name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hc_image_exploit</para>
            /// </summary>
            [NameInMap("BaselineNameKey")]
            [Validation(Required=false)]
            public string BaselineNameKey { get; set; }

            /// <summary>
            /// <para>The risk level of the baseline. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>high</b>: high risk</para>
            /// </description></item>
            /// <item><description><para><b>medium</b>: medium risk</para>
            /// </description></item>
            /// <item><description><para><b>low</b>: low risk.</para>
            /// </description></item>
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
            /// <para>1626628760000</para>
            /// </summary>
            [NameInMap("FirstScanTime")]
            [Validation(Required=false)]
            public long? FirstScanTime { get; set; }

            /// <summary>
            /// <para>The number of images with a <b>high</b> risk level that have baseline risk issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("HighRiskImage")]
            [Validation(Required=false)]
            public int? HighRiskImage { get; set; }

            /// <summary>
            /// <para>The timestamp of the most recent scan, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1626628760000</para>
            /// </summary>
            [NameInMap("LastScanTime")]
            [Validation(Required=false)]
            public long? LastScanTime { get; set; }

            /// <summary>
            /// <para>The number of images with a <b>low</b> risk level that have baseline risk issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LowRiskImage")]
            [Validation(Required=false)]
            public int? LowRiskImage { get; set; }

            /// <summary>
            /// <para>The number of images with a <b>medium</b> risk level that have baseline risk issues.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MiddleRiskImage")]
            [Validation(Required=false)]
            public int? MiddleRiskImage { get; set; }

            /// <summary>
            /// <para>The fix status of the baseline risk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Unfixed.</description></item>
            /// <item><description><b>1</b>: Fixed.</description></item>
            /// <item><description><b>2</b>: Pending verification.</description></item>
            /// <item><description><b>3</b>: Fix failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        /// <summary>
        /// <para>The paging information displayed on the page in a paged query.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeImageBaselineCheckSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeImageBaselineCheckSummaryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries on the current page in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The current page number in a paged query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of image baseline check results per page in a paged query. Default value: <b>20</b>, which indicates that 20 image baseline check results are displayed per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of query results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request. Alibaba Cloud generates a unique identifier for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5BD95679-D63A-4151-97D0-188432F4A57</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
