// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListAppEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>2xx</b>: The call was successful.</description></item>
        /// <item><description><b>3xx</b>: The call was redirected.</description></item>
        /// <item><description><b>4xx</b>: The call failed.</description></item>
        /// <item><description><b>5xx</b>: A server error occurred.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAppEventsResponseBodyData Data { get; set; }
        public class ListAppEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The events.</para>
            /// </summary>
            [NameInMap("AppEventEntity")]
            [Validation(Required=false)]
            public List<ListAppEventsResponseBodyDataAppEventEntity> AppEventEntity { get; set; }
            public class ListAppEventsResponseBodyDataAppEventEntity : TeaModel {
                /// <summary>
                /// <para>The type of the event. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// <para>The timestamp of the first occurrence of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-19T05:01:28Z</para>
                /// </summary>
                [NameInMap("FirstTimestamp")]
                [Validation(Required=false)]
                public string FirstTimestamp { get; set; }

                /// <summary>
                /// <para>The timestamp of the last occurrence of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-19T05:01:28Z</para>
                /// </summary>
                [NameInMap("LastTimestamp")]
                [Validation(Required=false)]
                public string LastTimestamp { get; set; }

                /// <summary>
                /// <para>The information about the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created container</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The type of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Pod</para>
                /// </summary>
                [NameInMap("ObjectKind")]
                [Validation(Required=false)]
                public string ObjectKind { get; set; }

                /// <summary>
                /// <para>The name of the object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>errew-b86bf540-b4dc-47d8-a42f-b4997c14bd8f-5595cbddd6-2****</para>
                /// </summary>
                [NameInMap("ObjectName")]
                [Validation(Required=false)]
                public string ObjectName { get; set; }

                /// <summary>
                /// <para>The cause of the event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Created</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The number of the returned page.</para>
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
            /// <para>The total number of events that occurred in an application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the call failed. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If the call is successful, the <b>ErrorCode</b> parameter is not returned.</description></item>
        /// <item><description>If the call fails, the <b>ErrorCode</b> parameter is returned. For more information, see the &quot;<b>Error codes</b>&quot; section in this topic.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>Indicates whether the events that occurred in the application were queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The events were queried.</description></item>
        /// <item><description><b>false</b>: The events failed to be queried.</description></item>
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
