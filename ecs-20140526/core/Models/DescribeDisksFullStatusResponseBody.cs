// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
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

        [NameInMap("DiskFullStatusSet")]
        [Validation(Required=false)]
        public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSet> DiskFullStatusSet { get; set; }
        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSet : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public DescribeDisksFullStatusResponseBodyDiskFullStatusSetStatus Status { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetStatus : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }
            };

            [NameInMap("DiskEventSet")]
            [Validation(Required=false)]
            public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskEventSet> DiskEventSet { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskEventSet : TeaModel {
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                [NameInMap("EventEndTime")]
                [Validation(Required=false)]
                public string EventEndTime { get; set; }

                [NameInMap("EventTime")]
                [Validation(Required=false)]
                public string EventTime { get; set; }

                [NameInMap("ImpactLevel")]
                [Validation(Required=false)]
                public string ImpactLevel { get; set; }

                [NameInMap("EventType")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskEventSetEventType EventType { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskEventSetEventType : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }
                };

            }

            [NameInMap("Device")]
            [Validation(Required=false)]
            public string Device { get; set; }

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public DescribeDisksFullStatusResponseBodyDiskFullStatusSetHealthStatus HealthStatus { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetHealthStatus : TeaModel {
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
