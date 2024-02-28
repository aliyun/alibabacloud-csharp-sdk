// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListAliyunOfficialEventSourcesResponseBody : TeaModel {
        /// <summary>
        /// The response code. The value Success indicates that the request is successful. Other values indicate that the request failed. For a list of error codes, see Error codes.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAliyunOfficialEventSourcesResponseBodyData Data { get; set; }
        public class ListAliyunOfficialEventSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The event sources.
            /// </summary>
            [NameInMap("EventSourceList")]
            [Validation(Required=false)]
            public List<ListAliyunOfficialEventSourcesResponseBodyDataEventSourceList> EventSourceList { get; set; }
            public class ListAliyunOfficialEventSourcesResponseBodyDataEventSourceList : TeaModel {
                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the event bus.
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// The time when the event source was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("Ctime")]
                [Validation(Required=false)]
                public float? Ctime { get; set; }

                /// <summary>
                /// The description of the event source.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the event source to which the event type belongs.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

                /// <summary>
                /// The event types.
                /// </summary>
                [NameInMap("EventTypes")]
                [Validation(Required=false)]
                public List<ListAliyunOfficialEventSourcesResponseBodyDataEventSourceListEventTypes> EventTypes { get; set; }
                public class ListAliyunOfficialEventSourcesResponseBodyDataEventSourceListEventTypes : TeaModel {
                    /// <summary>
                    /// The name of the event source.
                    /// </summary>
                    [NameInMap("EventSourceName")]
                    [Validation(Required=false)]
                    public string EventSourceName { get; set; }

                    /// <summary>
                    /// The name of the group to which the event type belongs.
                    /// </summary>
                    [NameInMap("GroupName")]
                    [Validation(Required=false)]
                    public string GroupName { get; set; }

                    /// <summary>
                    /// The full name of the event type.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The short name of the event type.
                    /// </summary>
                    [NameInMap("ShortName")]
                    [Validation(Required=false)]
                    public string ShortName { get; set; }

                }

                /// <summary>
                /// The full name of the event source.
                /// </summary>
                [NameInMap("FullName")]
                [Validation(Required=false)]
                public string FullName { get; set; }

                /// <summary>
                /// The name of the event source.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the event source. Valid value: Activated.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the event source.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

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
        /// Indicates whether the operation is successful. If the operation is successful, the value true is returned.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
