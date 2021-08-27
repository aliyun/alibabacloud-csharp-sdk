// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("InstanceFullStatusSet")]
        [Validation(Required=false)]
        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet InstanceFullStatusSet { get; set; }
        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet : TeaModel {
            [NameInMap("InstanceFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusType> InstanceFullStatusType { get; set; }
            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusType : TeaModel {
                public string InstanceId { get; set; }
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSet ScheduledSystemEventSet { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSet : TeaModel {
                    [NameInMap("ScheduledSystemEventType")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventType> ScheduledSystemEventType { get; set; }
                    public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventType : TeaModel {
                        [NameInMap("EventPublishTime")]
                        [Validation(Required=false)]
                        public string EventPublishTime { get; set; }

                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public string NotBefore { get; set; }

                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                        [NameInMap("EventCycleStatus")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }
                        };

                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType EventType { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }
                        };

                        [NameInMap("ExtendedAttribute")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute : TeaModel {
                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }
                            [NameInMap("DiskId")]
                            [Validation(Required=false)]
                            public string DiskId { get; set; }
                            [NameInMap("InactiveDisks")]
                            [Validation(Required=false)]
                            public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisks InactiveDisks { get; set; }
                            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisks : TeaModel {
                                [NameInMap("InactiveDisk")]
                                [Validation(Required=false)]
                                public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk> InactiveDisk { get; set; }
                                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk : TeaModel {
                                    [NameInMap("CreationTime")]
                                    [Validation(Required=false)]
                                    public string CreationTime { get; set; }

                                    [NameInMap("DeviceSize")]
                                    [Validation(Required=false)]
                                    public string DeviceSize { get; set; }

                                    [NameInMap("DeviceCategory")]
                                    [Validation(Required=false)]
                                    public string DeviceCategory { get; set; }

                                    [NameInMap("DeviceType")]
                                    [Validation(Required=false)]
                                    public string DeviceType { get; set; }

                                    [NameInMap("ReleaseTime")]
                                    [Validation(Required=false)]
                                    public string ReleaseTime { get; set; }

                                }

                            }
                        };

                    }

                }
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus Status { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }
            }
        };

    }

}
