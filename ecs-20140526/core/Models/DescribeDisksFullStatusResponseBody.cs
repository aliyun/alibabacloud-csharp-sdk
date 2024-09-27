// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The collection of full status information of the EBS devices.</para>
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
                /// <para>The name of the EBS device that is attached to an instance. Example: /dev/xvdb.</para>
                /// <para>This parameter has a value only when the value of <c>Status</c> is <c>In_use</c>.</para>
                /// <remarks>
                /// <para>This parameter will be deprecated in the future. To ensure future compatibility, we recommend that you do not use this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// <para>The events about the EBS device.</para>
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
                        /// <para>The time when the event ended.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-05-06T02:48:52Z</para>
                        /// </summary>
                        [NameInMap("EventEndTime")]
                        [Validation(Required=false)]
                        public string EventEndTime { get; set; }

                        /// <summary>
                        /// <para>The ID of the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e-bp67acfmxazb4p****</para>
                        /// </summary>
                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        /// <summary>
                        /// <para>The time when the event occurred.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2018-05-08T02:43:10Z</para>
                        /// </summary>
                        [NameInMap("EventTime")]
                        [Validation(Required=false)]
                        public string EventTime { get; set; }

                        /// <summary>
                        /// <para>The type of the event.</para>
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType EventType { get; set; }
                        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeDiskEventSetDiskEventTypeEventType : TeaModel {
                            /// <summary>
                            /// <para>The code of the event type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>7</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            /// <summary>
                            /// <para>The name of the event type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>Degraded: The performance of the EBS device is degraded.</description></item>
                            /// <item><description>SeverelyDegraded: The performance of the EBS device is severely degraded.</description></item>
                            /// <item><description>Stalled: The performance of the EBS device is severely affected.</description></item>
                            /// <item><description>ErrorDetected: The local disk is damaged.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Stalled</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The impact level of the event.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                    }

                }

                /// <summary>
                /// <para>The EBS device ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The health status of the EBS device.</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeHealthStatus : TeaModel {
                    /// <summary>
                    /// <para>The code of the health status of the EBS device.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The name of the health status of the EBS device.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Impaired</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The lifecycle status of the EBS device.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus Status { get; set; }
                public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusTypeStatus : TeaModel {
                    /// <summary>
                    /// <para>The code of the lifecycle status of the EBS device.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>129</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The name of the lifecycle status of the EBS device.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
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
