// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryEventTracesResponseBody : TeaModel {
        /// <summary>
        /// The status code returned. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The name of the event source.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryEventTracesResponseBodyData> Data { get; set; }
        public class QueryEventTracesResponseBodyData : TeaModel {
            /// <summary>
            /// The type of the event trace. Valid values: PutEvent: a delivery event. FilterEvent: a filtering event. PushEvent: a pushing event.
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The execution time of the event trace.
            /// </summary>
            [NameInMap("ActionTime")]
            [Validation(Required=false)]
            public long? ActionTime { get; set; }

            /// <summary>
            /// The endpoint of the event target. This parameter is returned if the value of the Action parameter is PushEvent.
            /// </summary>
            [NameInMap("Endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

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
            /// The name of the event source.
            /// </summary>
            [NameInMap("EventSource")]
            [Validation(Required=false)]
            public string EventSource { get; set; }

            /// <summary>
            /// The delivery delay of the event target. This parameter is returned if the value of the Action parameter is PushEvent.
            /// </summary>
            [NameInMap("NotifyLatency")]
            [Validation(Required=false)]
            public string NotifyLatency { get; set; }

            /// <summary>
            /// The event target delivery status.
            /// </summary>
            [NameInMap("NotifyStatus")]
            [Validation(Required=false)]
            public string NotifyStatus { get; set; }

            /// <summary>
            /// The delivery time of the event target. This parameter is returned if the value of the Action parameter is PushEvent.
            /// </summary>
            [NameInMap("NotifyTime")]
            [Validation(Required=false)]
            public long? NotifyTime { get; set; }

            /// <summary>
            /// The time when the event was delivered to the event bus. This parameter is returned if the value of the Action parameter is PutEvent.
            /// </summary>
            [NameInMap("ReceivedTime")]
            [Validation(Required=false)]
            public long? ReceivedTime { get; set; }

            /// <summary>
            /// The time when the event rule was matched. This parameter is returned if the value of the Action parameter is FilterEvent.
            /// </summary>
            [NameInMap("RuleMatchingTime")]
            [Validation(Required=false)]
            public string RuleMatchingTime { get; set; }

            /// <summary>
            /// The name of the event rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

        }

        /// <summary>
        /// The error message that is returned if the request failed.
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
