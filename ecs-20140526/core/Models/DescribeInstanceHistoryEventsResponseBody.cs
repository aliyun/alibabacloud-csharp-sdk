// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsResponseBody : TeaModel {
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

        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet> InstanceSystemEventSet { get; set; }
        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("EventPublishTime")]
            [Validation(Required=false)]
            public string EventPublishTime { get; set; }

            [NameInMap("EventFinishTime")]
            [Validation(Required=false)]
            public string EventFinishTime { get; set; }

            [NameInMap("ImpactLevel")]
            [Validation(Required=false)]
            public string ImpactLevel { get; set; }

            [NameInMap("EventType")]
            [Validation(Required=false)]
            public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType EventType { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("ExtendedAttribute")]
            [Validation(Required=false)]
            public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute ExtendedAttribute { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute : TeaModel {
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }
                [NameInMap("InactiveDisks")]
                [Validation(Required=false)]
                public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks> InactiveDisks { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks : TeaModel {
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

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("EventCycleStatus")]
            [Validation(Required=false)]
            public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus EventCycleStatus { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus : TeaModel {
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
