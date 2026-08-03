// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetInsightsEventsCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Insights events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetInsightsEventsCountResponseBodyData> Data { get; set; }
        public class GetInsightsEventsCountResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of Insights events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The type of the Insights event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>IpInsight: IP request events.</para>
            /// </description></item>
            /// <item><description><para>ApiCallRateInsight: High-risk API call events.</para>
            /// </description></item>
            /// <item><description><para>ApiErrorRateInsight: API error events.</para>
            /// </description></item>
            /// <item><description><para>AkInsight: AccessKey pair call events.</para>
            /// </description></item>
            /// <item><description><para>PolicyChangeInsight: Permission change events.</para>
            /// </description></item>
            /// <item><description><para>PasswordChangeInsight: Password change events.</para>
            /// </description></item>
            /// <item><description><para>TrailConcealmentInsight: Trail concealment events.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IpInsight</para>
            /// </summary>
            [NameInMap("InsightType")]
            [Validation(Required=false)]
            public string InsightType { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VjE6bHJlTGoxdm1M****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4ABAEA6E-C740-5CE2-A003-643E5519****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
