// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
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

        [NameInMap("DiskFullStatusSet")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusResponseBodyDiskFullStatusSet DiskFullStatusSet { get; set; }
        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSet : TeaModel {
            [NameInMap("DiskFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType> DiskFullStatusType { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType : TeaModel {
                public string DiskId { get; set; }
                public string InstanceId { get; set; }
                public string Device { get; set; }
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet DiskEventSet { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet : TeaModel {
                    [NameInMap("DiskEventType")]
                    [Validation(Required=false)]
                    public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType> DiskEventType { get; set; }
                    public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType : TeaModel {
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
                        public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType EventType { get; set; }
                        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType : TeaModel {
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }
                        };

                    }

                }
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus Status { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                }
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus : TeaModel {
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
