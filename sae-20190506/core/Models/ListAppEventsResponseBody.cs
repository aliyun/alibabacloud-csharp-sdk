// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned for the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2xx</b>: Success.</para>
        /// </description></item>
        /// <item><description><para><b>3xx</b>: Redirection.</para>
        /// </description></item>
        /// <item><description><para><b>4xx</b>: Client error.</para>
        /// </description></item>
        /// <item><description><para><b>5xx</b>: Server error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The event list.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppEventsResponseBodyData Data { get; set; }
        public class ListAppEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of application events.</para>
            /// </summary>
            [NameInMap("AppEventEntity")]
            [Validation(Required=false)]
            public List<ListAppEventsResponseBodyDataAppEventEntity> AppEventEntity { get; set; }
            public class ListAppEventsResponseBodyDataAppEventEntity : TeaModel {
                /// <summary>
                /// <para>The cause analysis.</para>
                /// </summary>
                [NameInMap("CauseAnalysis")]
                [Validation(Required=false)]
                public string CauseAnalysis { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The timestamp of the event\&quot;s first occurrence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-19T05:01:28Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp of the event\&quot;s last occurrence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-19T05:01:28Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The event message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created container</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The object kind.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pod</para>
                /// </summary>
                [NameInMap("ObjectKind")]
                [Validation(Required=false)]
                public string ObjectKind { get; set; }

                /// <summary>
                /// <para>The object name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>errew-b86bf540-b4dc-47d8-a42f-b4997c14bd8f-5595cbddd6-2****</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The reason for the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

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
            /// <para>The total count of application events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// <list type="bullet">
        /// <item><description><para>If the request is successful, the <b>ErrorCode</b> parameter is not returned.</para>
        /// </description></item>
        /// <item><description><para>If the request fails, the <b>ErrorCode</b> parameter is returned. For more information, see the <b>Error Codes</b> section.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>Additional information about the request result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4D805CA-926D-41B1-8E63-7AD0C1ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
