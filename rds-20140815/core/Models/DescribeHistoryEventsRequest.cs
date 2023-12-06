// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// Archive status.
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// Event category.
        /// </summary>
        [NameInMap("EventCategory")]
        [Validation(Required=false)]
        public string EventCategory { get; set; }

        /// <summary>
        /// The event ID.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// Event Level.
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// The status of the exception. Valid values:
        /// 
        /// *   **1**: pending handling
        /// *   **2**: ignored
        /// *   **4**: confirmed
        /// *   **8**: marked as a false positive
        /// *   **16**: handling
        /// *   **32**: handled
        /// *   **64**: expired
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// The type of the system event.
        /// 
        /// You can call the DescribeSystemEventMetaList operation to obtain the value of the response parameter `EventType`. The value of the EventType parameter indicates the types of system events that occurred for all cloud services in your Alibaba Cloud account. For more information, see [DescribeSystemEventMetaList](~~114972~~).
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Only tasks that have a start time later than or equal to the time specified by this parameter are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The start time can be up to 30 days earlier than the current time. If you set this parameter to a time more than 30 days earlier than the current time, the specified time is automatically converted to a time that is exactly 30 days earlier than the current time.
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The number of the page to return. Valid values: any non-zero positive integer.
        /// 
        /// Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid value: **30 to 200**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The type of resource. Set the value to INSTANCE.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The task ID.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// The end of the time range to query. Only tasks that have a start time earlier than or equal to the time specified by this parameter are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
