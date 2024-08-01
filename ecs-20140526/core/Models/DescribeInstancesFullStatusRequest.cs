// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeInstancesFullStatusRequestEventPublishTime : TeaModel {
            /// <summary>
            /// The end of the time range during which system events are published. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// The beginning of the time range during which system events are published. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusRequestNotBefore NotBefore { get; set; }
        public class DescribeInstancesFullStatusRequestNotBefore : TeaModel {
            /// <summary>
            /// The end of the time range during which O\\&M tasks related to scheduled system events are executed. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// The beginning of the time range during which O\\&M tasks related to scheduled system events are executed. Specify the time in the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// The IDs of the system events. You can specify up to 100 event IDs in a single request.
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// The type of the system event. This parameter is valid only when InstanceEventType.N is not specified. Valid values:
        /// 
        /// *   SystemMaintenance.Reboot: The instance is restarted due to system maintenance.
        /// *   SystemFailure.Reboot: The instance is restarted due to a system failure.
        /// *   InstanceFailure.Reboot: The instance is restarted due to an instance failure.
        /// *   InstanceExpiration.Stop: The subscription instance is stopped due to expiration.
        /// *   InstanceExpiration.Delete: The subscription instance is released due to expiration.
        /// *   AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.
        /// *   AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The health status of the instance. Valid values:
        /// 
        /// *   OK
        /// *   Impaired
        /// *   Initializing
        /// *   InsufficientData
        /// *   NotApplicable
        /// 
        /// All the values are case-sensitive.
        /// </summary>
        [NameInMap("HealthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        /// <summary>
        /// The types of system events. You can specify up to 30 event types in a single request.
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// The IDs of the instances. You can specify up to 100 instance IDs in a single request.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. The value must be a positive integer.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The lifecycle status of the instance. Valid values:
        /// 
        /// *   Starting
        /// *   Running
        /// *   Stopped
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
