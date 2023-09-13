// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventBusesResponseBody : TeaModel {
        /// <summary>
        /// The returned HTTP status code. The HTTP status code 200 indicates that the request is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListEventBusesResponseBodyData Data { get; set; }
        public class ListEventBusesResponseBodyData : TeaModel {
            /// <summary>
            /// The timestamp that indicates when the event bus was created.
            /// </summary>
            [NameInMap("EventBuses")]
            [Validation(Required=false)]
            public List<ListEventBusesResponseBodyDataEventBuses> EventBuses { get; set; }
            public class ListEventBusesResponseBodyDataEventBuses : TeaModel {
                /// <summary>
                /// The timestamp that indicates when the event bus was created.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The description of the queried event bus.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The Alibaba Cloud Resource Name (ARN) of the queried event bus.
                /// </summary>
                [NameInMap("EventBusARN")]
                [Validation(Required=false)]
                public string EventBusARN { get; set; }

                /// <summary>
                /// The name of the queried event bus.
                /// </summary>
                [NameInMap("EventBusName")]
                [Validation(Required=false)]
                public string EventBusName { get; set; }

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
        /// Indicates whether the event buses are successfully queried. Valid values: true and false.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
