// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeEventsResponseBody : TeaModel {
        /// <summary>
        /// The events.
        /// </summary>
        [NameInMap("EventItems")]
        [Validation(Required=false)]
        public DescribeEventsResponseBodyEventItems EventItems { get; set; }
        public class DescribeEventsResponseBodyEventItems : TeaModel {
            [NameInMap("EventItems")]
            [Validation(Required=false)]
            public List<DescribeEventsResponseBodyEventItemsEventItems> EventItems { get; set; }
            public class DescribeEventsResponseBodyEventItemsEventItems : TeaModel {
                /// <summary>
                /// The ID of the user who executed the event.
                /// </summary>
                [NameInMap("CallerUid")]
                [Validation(Required=false)]
                public long? CallerUid { get; set; }

                /// <summary>
                /// The event ID.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public int? EventId { get; set; }

                /// <summary>
                /// The event name.
                /// </summary>
                [NameInMap("EventName")]
                [Validation(Required=false)]
                public string EventName { get; set; }

                /// <summary>
                /// The request or context parameters of the event.
                /// </summary>
                [NameInMap("EventPayload")]
                [Validation(Required=false)]
                public string EventPayload { get; set; }

                /// <summary>
                /// The source of the event.
                /// </summary>
                [NameInMap("EventReason")]
                [Validation(Required=false)]
                public string EventReason { get; set; }

                /// <summary>
                /// The time when the event was recorded. The time is slightly later than the time the event occurred.
                /// </summary>
                [NameInMap("EventRecordTime")]
                [Validation(Required=false)]
                public string EventRecordTime { get; set; }

                /// <summary>
                /// The time when the event occurred.
                /// </summary>
                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                /// <summary>
                /// The event type.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public string EventType { get; set; }

                /// <summary>
                /// The type of the user who executed the event.
                /// </summary>
                [NameInMap("EventUserType")]
                [Validation(Required=false)]
                public string EventUserType { get; set; }

                /// <summary>
                /// The region ID.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The name of the resource associated with the event. Only instance IDs are supported for this parameter.
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The type of the resource associated with the event. Only instances are supported for this parameter.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
