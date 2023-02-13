// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
        /// <summary>
        /// The collection of full status information of the EBS devices.
        /// </summary>
        [NameInMap("DiskFullStatusSet")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusResponseBodyDiskFullStatusSet DiskFullStatusSet { get; set; }
        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSet : TeaModel {
            [NameInMap("DiskFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType> DiskFullStatusType { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType : TeaModel {
                /// <summary>
                /// The name of the EBS device that is attached to an instance. Example: /dev/xvdb.
                /// 
                /// This parameter has a value only when the value of `Status` is `In_use`.
                /// 
                /// > This parameter will be deprecated in the future. To ensure future compatibility, we recommend that you do not use this parameter.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The events about the EBS device.
                /// </summary>
                [NameInMap("DiskEventSet")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet DiskEventSet { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet : TeaModel {
                    [NameInMap("DiskEventType")]
                    [Validation(Required=false)]
                    public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType> DiskEventType { get; set; }
                    public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType : TeaModel {
                        /// <summary>
                        /// The time when the event ended.
                        /// </summary>
                        [NameInMap("EventEndTime")]
                        [Validation(Required=false)]
                        public string EventEndTime { get; set; }

                        /// <summary>
                        /// The ID of the event.
                        /// </summary>
                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        /// <summary>
                        /// The time when the event occurred.
                        /// </summary>
                        [NameInMap("EventTime")]
                        [Validation(Required=false)]
                        public string EventTime { get; set; }

                        /// <summary>
                        /// The type of the event.
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType EventType { get; set; }
                        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType : TeaModel {
                            /// <summary>
                            /// The code of the event type.
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            /// <summary>
                            /// The name of the event type. Valid values:
                            /// 
                            /// *   Degraded: The performance of the EBS device was degraded.
                            /// *   SeverelyDegraded: The performance of the EBS device was severely degraded.
                            /// *   Stalled: The performance of the EBS device was severely affected.
                            /// *   ErrorDetected: The local disk was damaged.
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// The impact level of the event.
                        /// </summary>
                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                    }

                }

                /// <summary>
                /// The ID of EBS device N.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The health status of the EBS device.
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus : TeaModel {
                    /// <summary>
                    /// The code of the health status of the EBS device.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The name of the health status of the EBS device.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// The ID of the instance that you query.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The lifecycle status of the EBS device.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus Status { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus : TeaModel {
                    /// <summary>
                    /// The code of the lifecycle status of the EBS device.
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// The name of the lifecycle status of the EBS device.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of EBS devices for which full status information is returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
