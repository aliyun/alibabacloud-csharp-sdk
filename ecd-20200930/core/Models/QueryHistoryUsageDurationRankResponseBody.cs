// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryUsageDurationRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The token used to retrieve the next page of results. If this parameter is not returned, there are no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWvmfbFWy0uSlxZ6pIAKAnuwt1ezsRqxI6hPibm27fMH</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of matching entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of usage duration metrics.</para>
        /// </summary>
        [NameInMap("UsageDurationList")]
        [Validation(Required=false)]
        public List<QueryHistoryUsageDurationRankResponseBodyUsageDurationList> UsageDurationList { get; set; }
        public class QueryHistoryUsageDurationRankResponseBodyUsageDurationList : TeaModel {
            /// <summary>
            /// <para>The <b>charge type</b>. Valid values: <c>POST_PAID</c> (post-paid), <c>PRE_PAID</c> (pre-paid), <c>MONTH_PACKAGE</c> (monthly subscription), and <c>DURATION</c> (duration package).</para>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para><b>The ID of the cloud desktop.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-8cndajrdrd424sb99</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para><b>The name of the cloud desktop.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>TestName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para><b>The end user ID.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>endUserId</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The <b>usage duration</b>, in seconds. Note: This is a <c>Long</c> value. Ensure your client can handle the precision.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20000</para>
            /// </summary>
            [NameInMap("UsageDuration")]
            [Validation(Required=false)]
            public long? UsageDuration { get; set; }

        }

    }

}
