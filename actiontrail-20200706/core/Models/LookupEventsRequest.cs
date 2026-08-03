// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class LookupEventsRequest : TeaModel {
        /// <summary>
        /// <para>The order in which events are retrieved. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>FORWARD: Chronological order.</para>
        /// </description></item>
        /// <item><description><para>BACKWARD (default): Reverse chronological order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BACKWARD</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You must specify both <c>StartTime</c> and <c>EndTime</c>, or leave both unspecified. If you leave them unspecified, the default value of <c>EndTime</c> is the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-15T11:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// <remarks>
        /// <para>You can specify one or two filter conditions at a time. For more information, see <a href="https://help.aliyun.com/document_detail/2920829.html">Limitations</a>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LookupAttribute")]
        [Validation(Required=false)]
        public List<LookupEventsRequestLookupAttribute> LookupAttribute { get; set; }
        public class LookupEventsRequestLookupAttribute : TeaModel {
            /// <summary>
            /// <para>The attribute key. For information about valid values, see <a href="https://help.aliyun.com/document_detail/2920829.html">How do I configure the LookupAttribute parameter when calling LookupInsightEvents?</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>ServiceName</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The attribute value. For information about valid values, see <a href="https://help.aliyun.com/document_detail/2920829.html">How do I configure the LookupAttribute parameter when calling LookupInsightEvents?</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>Ecs</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results to return.<br>Valid values: 1 to 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para>You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>eyJhY2NvdW50IjoiMTQyNDM3OTU4NjM4NzE2MSIsImV2ZW50SWQiOiI3MkJDRTExRi02OTU3LTQ0NUItQjY0MC1CNEUyMkM4NUEwQzgiLCJsb2dJZCI6IjgyLTE0MjQzNzk1ODYzODcxNjEiLCJ0aW1lIjoxNjAyMzExNTQwMD****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>You must specify both <c>StartTime</c> and <c>EndTime</c>, or leave both unspecified. If you leave them unspecified, the default value of <c>StartTime</c> is 7 days before the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-08T11:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
