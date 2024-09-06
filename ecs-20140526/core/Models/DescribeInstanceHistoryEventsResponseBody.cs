// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// Details about the instance system events.
        /// </summary>
        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet InstanceSystemEventSet { get; set; }
        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            [NameInMap("InstanceSystemEventType")]
            [Validation(Required=false)]
            public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType> InstanceSystemEventType { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType : TeaModel {
                /// <summary>
                /// The lifecycle status of the system event.
                /// </summary>
                [NameInMap("EventCycleStatus")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus : TeaModel {
                    /// <summary>
                    /// The state code of the system event.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The state name of the system event.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The time when the system event ended. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EventFinishTime")]
                [Validation(Required=false)]
                public string EventFinishTime { get; set; }

                /// <summary>
                /// The ID of the system event.
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// The time when the system event was published. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EventPublishTime")]
                [Validation(Required=false)]
                public string EventPublishTime { get; set; }

                /// <summary>
                /// The type of the system event.
                /// </summary>
                [NameInMap("EventType")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType EventType { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType : TeaModel {
                    /// <summary>
                    /// The code of the system event type.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The name of the system event type.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The extended attribute of the system event.
                /// </summary>
                [NameInMap("ExtendedAttribute")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute : TeaModel {
                    /// <summary>
                    /// Indicates whether the event can be handled.
                    /// </summary>
                    [NameInMap("CanAccept")]
                    [Validation(Required=false)]
                    public string CanAccept { get; set; }

                    /// <summary>
                    /// The code of the security violation.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// The device name of the local disk.
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// The ID of the local disk.
                    /// </summary>
                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    /// <summary>
                    /// The ID of the host.
                    /// </summary>
                    [NameInMap("HostId")]
                    [Validation(Required=false)]
                    public string HostId { get; set; }

                    /// <summary>
                    /// The type of the host. Valid values:
                    /// 
                    /// *   ddh: dedicated host
                    /// *   managehost: physical machine in a smart hosting pool
                    /// </summary>
                    [NameInMap("HostType")]
                    [Validation(Required=false)]
                    public string HostType { get; set; }

                    /// <summary>
                    /// The inactive disks that were released and whose data must be cleared.
                    /// </summary>
                    [NameInMap("InactiveDisks")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks InactiveDisks { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks : TeaModel {
                        [NameInMap("InactiveDisk")]
                        [Validation(Required=false)]
                        public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk> InactiveDisk { get; set; }
                        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk : TeaModel {
                            /// <summary>
                            /// The time when the disk was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                            /// </summary>
                            [NameInMap("CreationTime")]
                            [Validation(Required=false)]
                            public string CreationTime { get; set; }

                            /// <summary>
                            /// The category of the disk. Valid values:
                            /// 
                            /// *   cloud: basic disk
                            /// *   cloud_efficiency: ultra disk
                            /// *   cloud_ssd: standard SSD
                            /// *   cloud_essd: Enterprise SSD (ESSD)
                            /// *   local_ssd_pro: I/O-intensive local disk
                            /// *   local_hdd_pro: throughput-intensive local disk
                            /// *   ephemeral: retired local disk
                            /// *   ephemeral_ssd: retired local SSD
                            /// </summary>
                            [NameInMap("DeviceCategory")]
                            [Validation(Required=false)]
                            public string DeviceCategory { get; set; }

                            /// <summary>
                            /// The size of the disk. Unit: GiB.
                            /// </summary>
                            [NameInMap("DeviceSize")]
                            [Validation(Required=false)]
                            public string DeviceSize { get; set; }

                            /// <summary>
                            /// The type of the disk. Valid values:
                            /// 
                            /// *   system: system disk
                            /// *   data: data disk
                            /// </summary>
                            [NameInMap("DeviceType")]
                            [Validation(Required=false)]
                            public string DeviceType { get; set; }

                            /// <summary>
                            /// The time when the disk was released. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                            /// </summary>
                            [NameInMap("ReleaseTime")]
                            [Validation(Required=false)]
                            public string ReleaseTime { get; set; }

                        }

                    }

                    /// <summary>
                    /// The migration solution of the instance. Valid value: MigrationPlan. Instances can be migrated only by using migration plans.
                    /// </summary>
                    [NameInMap("MigrationOptions")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions MigrationOptions { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions : TeaModel {
                        [NameInMap("MigrationOption")]
                        [Validation(Required=false)]
                        public List<string> MigrationOption { get; set; }

                    }

                    /// <summary>
                    /// The online repair policy for the damaged disk. Valid value: IsolateOnly, which indicates that damaged disks are isolated but not repaired.
                    /// </summary>
                    [NameInMap("OnlineRepairPolicy")]
                    [Validation(Required=false)]
                    public string OnlineRepairPolicy { get; set; }

                    /// <summary>
                    /// The illegal domain name.
                    /// </summary>
                    [NameInMap("PunishDomain")]
                    [Validation(Required=false)]
                    public string PunishDomain { get; set; }

                    /// <summary>
                    /// The type of the penalty.
                    /// </summary>
                    [NameInMap("PunishType")]
                    [Validation(Required=false)]
                    public string PunishType { get; set; }

                    /// <summary>
                    /// The illegal URL.
                    /// </summary>
                    [NameInMap("PunishUrl")]
                    [Validation(Required=false)]
                    public string PunishUrl { get; set; }

                    /// <summary>
                    /// The rack number of the cloud box.
                    /// </summary>
                    [NameInMap("Rack")]
                    [Validation(Required=false)]
                    public string Rack { get; set; }

                    /// <summary>
                    /// The response result of the event. Valid values:
                    /// 
                    /// *   true: The event was handled.
                    /// *   false: The event failed to be handled.
                    /// </summary>
                    [NameInMap("ResponseResult")]
                    [Validation(Required=false)]
                    public string ResponseResult { get; set; }

                }

                /// <summary>
                /// The impact level of the system event.
                /// </summary>
                [NameInMap("ImpactLevel")]
                [Validation(Required=false)]
                public string ImpactLevel { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The scheduled start time of the system event. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("NotBefore")]
                [Validation(Required=false)]
                public string NotBefore { get; set; }

                /// <summary>
                /// The reason why the system event occurred.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// The reason code category for the system event.
                /// </summary>
                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// The type of the resource. Valid values:
                /// 
                /// *   instance: ECS instance
                /// *   ddh: dedicated host
                /// *   managehost: physical machine in a smart hosting pool
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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
