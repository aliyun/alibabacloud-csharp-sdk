// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupInsightEventsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The default value is the current time.</para>
        /// <para>Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-07T07:10:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>An array of fliter conditions.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify one or two query conditions. For more information, see <a href="https://help.aliyun.com/document_detail/3011147.html">Limitations</a>.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("LookupAttribute")]
        [Validation(Required=false)]
        public List<LookupInsightEventsRequestLookupAttribute> LookupAttribute { get; set; }
        public class LookupInsightEventsRequestLookupAttribute : TeaModel {
            /// <summary>
            /// <para>The attribute key. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/3011147.html">How do I configure the LookupAttribute parameter when calling LookupInsightEvents?</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>InsightType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The attribute value. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/3011147.html">How do I configure the LookupAttribute parameter when calling LookupInsightEvents?</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>IpInsight</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values: 1 to 50.</para>
        /// </description></item>
        /// <item><description><para>Default value: 20.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter for the first request.</para>
        /// </description></item>
        /// <item><description><para>You must specify the token that is obtained from the previous query as the value of <c>NextToken</c>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VjE6dLbnNpVmbz06****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The default value is seven days before the current time.</para>
        /// <para>Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The maximum time range that can be queried is 93 days. If the specified time range is longer than 93 days, only events from the last 93 days are returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-07T04:10:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
