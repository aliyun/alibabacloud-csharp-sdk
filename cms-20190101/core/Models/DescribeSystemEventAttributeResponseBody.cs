// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventAttributeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The message that is returned. If the call is successful, `success` is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful. Valid values: True: The call is successful. false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The details of the event.
        /// </summary>
        [NameInMap("SystemEvents")]
        [Validation(Required=false)]
        public DescribeSystemEventAttributeResponseBodySystemEvents SystemEvents { get; set; }
        public class DescribeSystemEventAttributeResponseBodySystemEvents : TeaModel {
            [NameInMap("SystemEvent")]
            [Validation(Required=false)]
            public List<DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent> SystemEvent { get; set; }
            public class DescribeSystemEventAttributeResponseBodySystemEventsSystemEvent : TeaModel {
                /// <summary>
                /// The details of the event.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The ID of the application group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The event ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The instance name.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The level of the event. Valid values:
                /// 
                /// *   CRITICAL
                /// *   WARN
                /// *   INFO
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The event name.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The abbreviation of the service name.
                /// </summary>
                [NameInMap("Product")]
                [Validation(Required=false)]
                public string Product { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The status of the event.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The time when the event occurred. The value is a timestamp.
                /// 
                /// Unit: milliseconds.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public long? Time { get; set; }

            }

        }

    }

}
