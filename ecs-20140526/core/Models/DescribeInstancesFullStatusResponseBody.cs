// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstancesFullStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried instances.</para>
        /// <remarks>
        /// <para> If no instances exist, this parameter is empty.</para>
        /// </remarks>
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
                /// <para>The health state of the instance.</para>
                /// </summary>
                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus HealthStatus { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeHealthStatus : TeaModel {
                    /// <summary>
                    /// <para>The code of the health state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The name of the health state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Warning</para>
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
                /// <para>The system events that are in the Scheduled or Inquiring state.</para>
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
                        /// <para>The state of the system event.</para>
                        /// </summary>
                        [NameInMap("EventCycleStatus")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventCycleStatus : TeaModel {
                            /// <summary>
                            /// <para>The code of the system event state.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>24</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            /// <summary>
                            /// <para>The name of the system event state.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Scheduled</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The system event ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e-bp1hygp5b04o56l0****</para>
                        /// </summary>
                        [NameInMap("EventId")]
                        [Validation(Required=false)]
                        public string EventId { get; set; }

                        /// <summary>
                        /// <para>The time when the system event was published. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2017-11-30T06:32:31Z</para>
                        /// </summary>
                        [NameInMap("EventPublishTime")]
                        [Validation(Required=false)]
                        public string EventPublishTime { get; set; }

                        /// <summary>
                        /// <para>The type of the system event.</para>
                        /// </summary>
                        [NameInMap("EventType")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType EventType { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeEventType : TeaModel {
                            /// <summary>
                            /// <para>The code of the system event type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("Code")]
                            [Validation(Required=false)]
                            public int? Code { get; set; }

                            /// <summary>
                            /// <para>The name of the system event type.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>SystemMaintenance.Reboot</para>
                            /// </summary>
                            [NameInMap("Name")]
                            [Validation(Required=false)]
                            public string Name { get; set; }

                        }

                        /// <summary>
                        /// <para>The extended attributes of system events generated for instances that have local disks attached.</para>
                        /// <para>The return values vary based on the system event type.</para>
                        /// <para>If the system event type is not one of the following types, this parameter is empty:</para>
                        /// <list type="bullet">
                        /// <item><description>SystemMaintenance.StopAndRepair</description></item>
                        /// <item><description>SystemMaintenance.CleanInactiveDisks</description></item>
                        /// <item><description>SecurityPunish.Locked</description></item>
                        /// <item><description>SecurityPunish.WebsiteBanned</description></item>
                        /// <item><description>SystemUpgrade.Migrate</description></item>
                        /// <item><description>SystemMaintenance.RebootAndIsolateErrorDisk</description></item>
                        /// <item><description>SystemMaintenance.RebootAndReInitErrorDisk</description></item>
                        /// <item><description>SystemMaintenance.ReInitErrorDisk</description></item>
                        /// <item><description>SystemMaintenance.IsolateErrorDisk</description></item>
                        /// </list>
                        /// </summary>
                        [NameInMap("ExtendedAttribute")]
                        [Validation(Required=false)]
                        public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                        public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeScheduledSystemEventSetScheduledSystemEventTypeExtendedAttribute : TeaModel {
                            /// <summary>
                            /// <para>The device name of the local disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>/dev/vdb</para>
                            /// </summary>
                            [NameInMap("Device")]
                            [Validation(Required=false)]
                            public string Device { get; set; }

                            /// <summary>
                            /// <para>The ID of the local disk.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>d-bp67acfmxazb4p****</para>
                            /// </summary>
                            [NameInMap("DiskId")]
                            [Validation(Required=false)]
                            public string DiskId { get; set; }

                            /// <summary>
                            /// <para>The inactive disks that have been released and must be cleared.</para>
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
                                    /// <para>The time when the disk was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2018-07-27T13:53:25Z</para>
                                    /// </summary>
                                    [NameInMap("CreationTime")]
                                    [Validation(Required=false)]
                                    public string CreationTime { get; set; }

                                    /// <summary>
                                    /// <para>The category of the disk. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>cloud: basic disk</description></item>
                                    /// <item><description>cloud_efficiency: ultra disk</description></item>
                                    /// <item><description>cloud_ssd: standard SSD</description></item>
                                    /// <item><description>cloud_essd: Enterprise SSD (ESSD)</description></item>
                                    /// <item><description>local_ssd_pro: I/O-intensive local disk</description></item>
                                    /// <item><description>local_hdd_pro: throughput-intensive local disk</description></item>
                                    /// <item><description>ephemeral: retired local disk</description></item>
                                    /// <item><description>ephemeral_ssd: retired local SSD</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>cloud_ssd</para>
                                    /// </summary>
                                    [NameInMap("DeviceCategory")]
                                    [Validation(Required=false)]
                                    public string DeviceCategory { get; set; }

                                    /// <summary>
                                    /// <para>The size of the disk. Unit: GiB.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>80</para>
                                    /// </summary>
                                    [NameInMap("DeviceSize")]
                                    [Validation(Required=false)]
                                    public string DeviceSize { get; set; }

                                    /// <summary>
                                    /// <para>The type of the disk. Valid values:</para>
                                    /// <list type="bullet">
                                    /// <item><description>system</description></item>
                                    /// <item><description>data</description></item>
                                    /// </list>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>system</para>
                                    /// </summary>
                                    [NameInMap("DeviceType")]
                                    [Validation(Required=false)]
                                    public string DeviceType { get; set; }

                                    /// <summary>
                                    /// <para>The time when the disk was released. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>2019-07-27T13:53:25Z</para>
                                    /// </summary>
                                    [NameInMap("ReleaseTime")]
                                    [Validation(Required=false)]
                                    public string ReleaseTime { get; set; }

                                }

                            }

                        }

                        /// <summary>
                        /// <para>The impact level of the system event.</para>
                        /// <remarks>
                        /// <para> If the user is not in a whitelist, this parameter is empty.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("ImpactLevel")]
                        [Validation(Required=false)]
                        public string ImpactLevel { get; set; }

                        /// <summary>
                        /// <para>The scheduled time at which to execute the O\&amp;M task related to the system event. The time is displayed in UTC.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2017-12-07T00:00:00Z</para>
                        /// </summary>
                        [NameInMap("NotBefore")]
                        [Validation(Required=false)]
                        public string NotBefore { get; set; }

                        /// <summary>
                        /// <para>The reason why the system event was scheduled.</para>
                        /// <remarks>
                        /// <para> If the exception cause is not detected, this parameter is empty.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>A simulated event.</para>
                        /// </summary>
                        [NameInMap("Reason")]
                        [Validation(Required=false)]
                        public string Reason { get; set; }

                    }

                }

                /// <summary>
                /// <para>The lifecycle state of the instance.</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus Status { get; set; }
                public class DescribeInstancesFullStatusResponseBodyInstanceFullStatusSetInstanceFullStatusTypeStatus : TeaModel {
                    /// <summary>
                    /// <para>The code of the instance lifecycle state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The name of the instance lifecycle state.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Running</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
