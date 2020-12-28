// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("InstanceFullStatusSet")]
        [Validation(Required=false)]
        public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet> InstanceFullStatusSet { get; set; }
        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSet : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetStatus Status { get; set; }
            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("ScheduledSystemEventSet")]
            [Validation(Required=false)]
            public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSet> ScheduledSystemEventSet { get; set; }
            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSet : TeaModel {
                [NameInMap("EventPublishTime")]
                [Validation(Required=false)]
                public string EventPublishTime { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("ImpactLevel")]
                [Validation(Required=false)]
                public string ImpactLevel { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetEventType EventType { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetEventType : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                };

                [NameInMap("ExtendedAttribute")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetExtendedAttribute ExtendedAttribute { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetExtendedAttribute : TeaModel {
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }
                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }
                    [NameInMap("InactiveDisks")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetExtendedAttributeInactiveDisks> InactiveDisks { get; set; }
                    public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetExtendedAttributeInactiveDisks : TeaModel {
                        public string CreationTime { get; set; }
                        public string DeviceCategory { get; set; }
                        public string DeviceType { get; set; }
                        public string ReleaseTime { get; set; }
                        public string DeviceSize { get; set; }
                    }
                };

                [NameInMap("NotBefore")]
                [Validation(Required=false)]
                public string NotBefore { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("EventCycleStatus")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetEventCycleStatus EventCycleStatus { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetScheduledSystemEventSetEventCycleStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                };

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetHealthStatus HealthStatus { get; set; }
            public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetHealthStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

        }

    }

}
