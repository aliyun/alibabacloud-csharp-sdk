// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeInstanceHistoryEventsRequestEventPublishTime : TeaModel {
            /// <summary>
            /// The end of the time range in which to query published system events. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// The beginning of the time range in which to query published system events. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsRequestNotBefore NotBefore { get; set; }
        public class DescribeInstanceHistoryEventsRequestNotBefore : TeaModel {
            /// <summary>
            /// The end time of the scheduled execution period for the system event. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// The start time of the scheduled execution period for the system event. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// The lifecycle state of the system event. This parameter is valid only when the InstanceEventCycleStatus.N parameter is not specified. Valid values:
        /// 
        /// *   Scheduled
        /// *   Avoided
        /// *   Executing
        /// *   Executed
        /// *   Canceled
        /// *   Failed
        /// *   Inquiring
        /// </summary>
        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        /// <summary>
        /// The ID of system event N. Valid values of N: 1 to 100. Specify multiple event IDs in the repeated list form.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// The type of the system event. This parameter is valid only when the InstanceEventType.N parameter is not specified. Valid values:
        /// 
        /// *   SystemMaintenance.Reboot: The instance is restarted due to system maintenance.
        /// *   SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.
        /// *   SystemFailure.Reboot: The instance is restarted due to a system failure.
        /// *   SystemFailure.Redeploy: The instance is redeployed due to a system failure.
        /// *   SystemFailure.Delete: The instance is released due to an instance creation failure.
        /// *   InstanceFailure.Reboot: The instance is restarted due to an instance failure.
        /// *   InstanceExpiration.Stop: The instance is stopped due to subscription expiration.
        /// *   InstanceExpiration.Delete: The instance is released due to subscription expiration.
        /// *   AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.
        /// *   AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.
        /// 
        /// > For more information, see [Overview](~~66574~~). The values of this parameter are applicable only to instance system events, but not to disk system events.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// > This parameter is unavailable.
        /// </summary>
        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        /// <summary>
        /// The lifecycle state of system event N. Valid values of N: 1 to 7. Specify multiple states in the repeated list form. Valid values:
        /// 
        /// *   Scheduled
        /// *   Avoided
        /// *   Executing
        /// *   Executed
        /// *   Canceled
        /// *   Failed
        /// *   Inquiring
        /// </summary>
        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        /// <summary>
        /// The type of system event N. Valid values of N: 1 to 30. Specify multiple types in the repeated list form. Valid values:
        /// 
        /// *   SystemMaintenance.Reboot: The instance is restarted due to system maintenance.
        /// *   SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.
        /// *   SystemFailure.Reboot: The instance is restarted due to a system failure.
        /// *   SystemFailure.Redeploy: The instance is redeployed due to a system failure.
        /// *   SystemFailure.Delete: The instance is released due to an instance creation failure.
        /// *   InstanceFailure.Reboot: The instance is restarted due to an instance failure.
        /// *   InstanceExpiration.Stop: The instance is stopped due to subscription expiration.
        /// *   InstanceExpiration.Delete: The instance is released due to subscription expiration.
        /// *   AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.
        /// *   AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.
        /// 
        /// > For more information, see [Overview](~~66574~~). The values of this parameter are applicable only to instance system events, but not to disk system events.
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// The ID of the instance. If this parameter is not specified, the system events of all instances within the specified region are queried.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be a positive integer.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the resource. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the resource belongs.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of resource N. Valid values of N: 1 to 100. Specify multiple resource IDs in the repeated list form. Valid values:
        /// 
        /// *   When the `ResourceType` parameter is set to instance, the ResourceId.N parameter specifies the ID of instance N.
        /// *   When the `ResourceType` parameter is set to ddh, the ResourceId.N parameter specifies the ID of dedicated host N.
        /// *   When the `ResourceType` parameter is set to managedhost, the ResourceId.N parameter specifies the ID of physical machine N in a smart hosting pool.
        /// 
        /// If this parameter is not specified, the system events of all resources of the resource type specified by `ResourceType` within the region specified by `RegionId` are queried.
        /// 
        /// > We recommend that you use the `ResourceId.N` parameter to specify one or more resource IDs. If you specify both the ` ResourceId.N  `and `InstanceId` parameters, the `ResourceId.N` parameter takes precedence by default.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of resource. Valid values:
        /// 
        /// *   instance: Elastic Compute Service (ECS) instance
        /// *   ddh: dedicated host
        /// *   managehost: physical machine in a smart hosting pool
        /// 
        /// Default value: instance.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags that are supported by system events.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeInstanceHistoryEventsRequestTag> Tag { get; set; }
        public class DescribeInstanceHistoryEventsRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the resource.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the resource.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
