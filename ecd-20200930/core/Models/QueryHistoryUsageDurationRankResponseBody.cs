// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class QueryHistoryUsageDurationRankResponseBody : TeaModel {
        /// <summary>
        /// <para>The paging token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWvmfbFWy0uSlxZ6pIAKAnuwt1ezsRqxI6hPibm27fMH</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of user usage duration metrics.</para>
        /// </summary>
        [NameInMap("UsageDurationList")]
        [Validation(Required=false)]
        public List<QueryHistoryUsageDurationRankResponseBodyUsageDurationList> UsageDurationList { get; set; }
        public class QueryHistoryUsageDurationRankResponseBodyUsageDurationList : TeaModel {
            /// <summary>
            /// <para>The billing type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>POST_PAID: pay-as-you-go.</description></item>
            /// <item><description>PRE_PAID: subscription.</description></item>
            /// <item><description>MONTH_PACKAGE: monthly package.</description></item>
            /// <item><description>DURATION: duration-based package.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The cloud desktop ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-8cndajrdrd424sb99</para>
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// <para>The cloud desktop name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestName</para>
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// <para>The end user ID.</para>
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
            /// <para>The usage duration, in seconds. This value is of the Long type. Handle precision conversion on the frontend.</para>
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
