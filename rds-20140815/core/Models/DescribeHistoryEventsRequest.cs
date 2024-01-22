// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// The resource status. Valid values: **importing**, failed, checksuccess, and deleted.
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// The system event category. For more information, see [View the event history of an ApsaraDB RDS instance](~~129759~~).
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
        /// The event level. Valid values: ***high***, **medium**, and **low**.
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// The status of the exception. Valid values:
        /// 
        /// *   1: pending
        /// *   2: ignored
        /// *   4: confirmed
        /// *   8: marked as false positive
        /// *   16: handling
        /// *   32: handled
        /// *   64: expired
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// The system event type. This parameter takes effect only when InstanceEventType.N is not specified. Valid values: SystemMaintenance.Reboot: The instance is restarted due to system maintenance. SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance. SystemFailure.Reboot: The instance is restarted due to a system error. SystemFailure.Redeploy: The instance is redeployed due to a system error. SystemFailure.Delete: The instance is released due to an instance creation failure. InstanceFailure.Reboot: The instance is restarted due to an instance error. InstanceExpiration.Stop: The subscription instance is stopped due to expiration. InstanceExpiration.Delete: The subscription instance is released due to expiration. AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment. AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment. For more information, see Overview. The values of this parameter are applicable only to instance system events, but not to disk system events.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The beginning of the time range to query. Only tasks that have a start time later than or equal to the time specified by this parameter are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The start time can be up to 30 days earlier than the current time. If you set this parameter to a time more than 30 days earlier than the current time, this time is automatically converted to a time that is exactly 30 days earlier than the current time.
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The page number. Valid values: any non-zero positive integer. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~610399~~) operation to query the most recent region list.
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
        /// The resource type. Set the value to **INSTANCE**.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The task ID. This value is used to query the data of a specific task.
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
