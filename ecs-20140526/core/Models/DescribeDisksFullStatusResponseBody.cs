// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
        [NameInMap("DiskFullStatusSet")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusResponseBodyDiskFullStatusSet DiskFullStatusSet { get; set; }
        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSet : TeaModel {
            [NameInMap("DiskFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType> DiskFullStatusType { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType : TeaModel {
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                [NameInMap("DiskEventSet")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet DiskEventSet { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSet : TeaModel {
                    [NameInMap("DiskEventType")]
                    [Validation(Required=false)]
                    public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType> DiskEventType { get; set; }
                    public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventType : TeaModel {
                        [NameInMap("EventEndTime")]
                        [Validation(Required=false)]
                        public string EventEndTime { get; set; }

                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        [NameInMap("EventTime")]
                        [Validation(Required=false)]
                        public string EventTime { get; set; }

                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType EventType { get; set; }
                        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType : TeaModel {
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                    }

                }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus Status { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of EBS devices for which full status information is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
