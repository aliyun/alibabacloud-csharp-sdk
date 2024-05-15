// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusResponseBody : TeaModel {
        /// <summary>
        /// The full status information of the instances.
        /// </summary>
        [NameInMap("InstanceFullStatusSet")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet InstanceFullStatusSet { get; set; }
        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet : TeaModel {
            [NameInMap("InstanceFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusType> InstanceFullStatusType { get; set; }
            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusType : TeaModel {
                /// <summary>
                /// The health state of the instance.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus : TeaModel {
                    /// <summary>
                    /// The code of the health state.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The name of the health state.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// Details about the scheduled system events.
                /// </summary>
                [NameInMap("ScheduledSystemEventSet")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSet ScheduledSystemEventSet { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSet : TeaModel {
                    [NameInMap("ScheduledSystemEventType")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventType> ScheduledSystemEventType { get; set; }
                    public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventType : TeaModel {
                        /// <summary>
                        /// The state of the system event.
                        /// </summary>
                        [NameInMap("EventCycleStatus")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus : TeaModel {
                            /// <summary>
                            /// The code of the system event state.
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            /// <summary>
                            /// The name of the system event state.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// The ID of the system event.
                        /// </summary>
                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        /// <summary>
                        /// The time when the system event was published. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("EventPublishTime")]
                        [Validation(Required=false)]
                        public string EventPublishTime { get; set; }

                        /// <summary>
                        /// The type of the system event.
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType EventType { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType : TeaModel {
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
                        /// The extended attributes of system events generated for instances that have local disks attached.
                        /// </summary>
                        [NameInMap("ExtendedAttribute")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute : TeaModel {
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
                            /// The inactive cloud disks or local disks that have been released and must be cleared.
                            /// </summary>
                            [NameInMap("InactiveDisks")]
                            [Validation(Required=false)]
                            public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisks InactiveDisks { get; set; }
                            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisks : TeaModel {
                                [NameInMap("InactiveDisk")]
                                [Validation(Required=false)]
                                public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk> InactiveDisk { get; set; }
                                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk : TeaModel {
                                    /// <summary>
                                    /// The time when the cloud disk or local disk was created. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                                    /// </summary>
                                    [NameInMap("CreationTime")]
                                    [Validation(Required=false)]
                                    public string CreationTime { get; set; }

                                    /// <summary>
                                    /// The category of the cloud disk or local disk. Valid values:
                                    /// 
                                    /// *   cloud: basic disk.
                                    /// *   cloud_efficiency: ultra disk.
                                    /// *   cloud_ssd: standard SSD.
                                    /// *   cloud_essd: enhanced SSD (ESSD).
                                    /// *   local_ssd_pro: I/O-intensive local disk.
                                    /// *   local_hdd_pro: throughput-intensive local disk.
                                    /// *   ephemeral: retired local disk.
                                    /// *   ephemeral_ssd: retired local SSD.
                                    /// </summary>
                                    [NameInMap("DeviceCategory")]
                                    [Validation(Required=false)]
                                    public string DeviceCategory { get; set; }

                                    /// <summary>
                                    /// The size of the cloud disk or local disk. Unit: GiB.
                                    /// </summary>
                                    [NameInMap("DeviceSize")]
                                    [Validation(Required=false)]
                                    public string DeviceSize { get; set; }

                                    /// <summary>
                                    /// The type of the cloud disk or local disk. Valid values:
                                    /// 
                                    /// *   system: system disk.
                                    /// *   data: data disk.
                                    /// </summary>
                                    [NameInMap("DeviceType")]
                                    [Validation(Required=false)]
                                    public string DeviceType { get; set; }

                                    /// <summary>
                                    /// The time when the cloud disk or local disk was released. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
                                    /// </summary>
                                    [NameInMap("ReleaseTime")]
                                    [Validation(Required=false)]
                                    public string ReleaseTime { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// The impact level of the system event.
                        /// </summary>
                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                        /// <summary>
                        /// The scheduled O\\&M time of the system event. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public string NotBefore { get; set; }

                        /// <summary>
                        /// The reason why the system event was scheduled.
                        /// </summary>
                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                    }

                }

                /// <summary>
                /// The lifecycle state of the instance.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus Status { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus : TeaModel {
                    /// <summary>
                    /// The code of the instance lifecycle state.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The name of the instance lifecycle state.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
