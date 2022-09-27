// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsResponseBody : TeaModel {
        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet InstanceSystemEventSet { get; set; }
        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            [NameInMap("InstanceSystemEventType")]
            [Validation(Required=false)]
            public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType> InstanceSystemEventType { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType : TeaModel {
                [NameInMap("EventCycleStatus")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("EventFinishTime")]
                [Validation(Required=false)]
                public string EventFinishTime { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("EventPublishTime")]
                [Validation(Required=false)]
                public string EventPublishTime { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType EventType { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("ExtendedAttribute")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute : TeaModel {
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    [NameInMap("HostId")]
                    [Validation(Required=false)]
                    public string HostId { get; set; }

                    [NameInMap("HostType")]
                    [Validation(Required=false)]
                    public string HostType { get; set; }

                    [NameInMap("InactiveDisks")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks InactiveDisks { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks : TeaModel {
                        [NameInMap("InactiveDisk")]
                        [Validation(Required=false)]
                        public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk> InactiveDisk { get; set; }
                        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk : TeaModel {
                            [NameInMap("CreationTime")]
                            [Validation(Required=false)]
                            public string CreationTime { get; set; }

                            [NameInMap("DeviceCategory")]
                            [Validation(Required=false)]
                            public string DeviceCategory { get; set; }

                            [NameInMap("DeviceSize")]
                            [Validation(Required=false)]
                            public string DeviceSize { get; set; }

                            [NameInMap("DeviceType")]
                            [Validation(Required=false)]
                            public string DeviceType { get; set; }

                            [NameInMap("ReleaseTime")]
                            [Validation(Required=false)]
                            public string ReleaseTime { get; set; }

                        }

                    }

                    [NameInMap("MigrationOptions")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions MigrationOptions { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions : TeaModel {
                        [NameInMap("MigrationOption")]
                        [Validation(Required=false)]
                        public List<string> MigrationOption { get; set; }

                    }

                    [NameInMap("OnlineRepairPolicy")]
                    [Validation(Required=false)]
                    public string OnlineRepairPolicy { get; set; }

                    [NameInMap("Rack")]
                    [Validation(Required=false)]
                    public string Rack { get; set; }

                }

                [NameInMap("ImpactLevel")]
                [Validation(Required=false)]
                public string ImpactLevel { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("NotBefore")]
                [Validation(Required=false)]
                public string NotBefore { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
