// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryTracedEventsResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryTracedEventsResponseBodyData Data { get; set; }
        public class QueryTracedEventsResponseBodyData : TeaModel {
            /// <summary>
            /// The event type.
            /// </summary>
            [NameInMap("Events")]
            [Validation(Required=false)]
            public List<QueryTracedEventsResponseBodyDataEvents> Events { get; set; }
            public class QueryTracedEventsResponseBodyDataEvents : TeaModel {
                /// <summary>
                /// The name of the event bus.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// The event ID.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// The time when the event was delivered to the event bus.
                /// </summary>
                [NameInMap("EventReceivedTime")]
                [Validation(Required=false)]
                public long? EventReceivedTime { get; set; }

                /// <summary>
                /// The name of the event source.
                /// </summary>
                [NameInMap("EventSource")]
                [Validation(Required=false)]
                public string EventSource { get; set; }

                /// <summary>
                /// The event type.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

            }

            /// <summary>
            /// If excess return values exist, this parameter is returned.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// The total number of entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

        /// <summary>
        /// The returned error message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
