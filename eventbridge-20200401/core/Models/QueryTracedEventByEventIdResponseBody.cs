// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryTracedEventByEventIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <para>Success: The request was successful.</para>
        /// <para>Other codes: The request failed. For information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTracedEventByEventIdResponseBodyData> Data { get; set; }
        public class QueryTracedEventByEventIdResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The events.</para>
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<QueryTracedEventByEventIdResponseBodyDataEvents> Events { get; set; }
            public class QueryTracedEventByEventIdResponseBodyDataEvents : TeaModel {
                /// <summary>
                /// <para>The name of the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// <para>The event ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>37C-1P6Yn6EM7TcH37Vod8w7rbSeimJ</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The time when the event was delivered to the event bus.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1661773573100</para>
                /// </summary>
                [NameInMap("EventReceivedTime")]
                [Validation(Required=false)]
                public long? EventReceivedTime { get; set; }

                /// <summary>
                /// <para>The name of the event source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert-api</para>
                /// </summary>
                [NameInMap("EventSource")]
                [Validation(Required=false)]
                public string EventSource { get; set; }

                /// <summary>
                /// <para>The event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eventbridge:Events:HTTPEvent</para>
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            /// <summary>
            /// <para>If excess return values exist, this parameter is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBusNotExist</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5D7B9F4-BF96-51A9-90B1-928955FABB5B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. If the operation was successful, the value true is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
