// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instance system events.</para>
        /// </summary>
        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet InstanceSystemEventSet { get; set; }
        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            [NameInMap("InstanceSystemEventType")]
            [Validation(Required=false)]
            public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType> InstanceSystemEventType { get; set; }
            public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventType : TeaModel {
                /// <summary>
                /// <para>The lifecycle status of the system event.</para>
                /// </summary>
                [NameInMap("EventCycleStatus")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus EventCycleStatus { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventCycleStatus : TeaModel {
                    /// <summary>
                    /// <para>The state code of the system event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The state name of the system event.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Executed</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The time when the system event ended. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-01T06:35:31Z</para>
                /// </summary>
                [NameInMap("EventFinishTime")]
                [Validation(Required=false)]
                public string EventFinishTime { get; set; }

                /// <summary>
                /// <para>The ID of the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e-uf64yvznlao4jl2c****</para>
                /// </summary>
                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The time when the system event was published. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
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
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType EventType { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeEventType : TeaModel {
                    /// <summary>
                    /// <para>The code of the system event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public int? Code { get; set; }

                    /// <summary>
                    /// <para>The name of the system event type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InstanceExpiration.Stop</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The extended attribute of the system event.</para>
                /// </summary>
                [NameInMap("ExtendedAttribute")]
                [Validation(Required=false)]
                public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute ExtendedAttribute { get; set; }
                public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttribute : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the event can be handled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("CanAccept")]
                    [Validation(Required=false)]
                    public string CanAccept { get; set; }

                    /// <summary>
                    /// <para>The code of the security violation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PR111</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The device name of the local disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/dev/vda</para>
                    /// </summary>
                    [NameInMap("Device")]
                    [Validation(Required=false)]
                    public string Device { get; set; }

                    /// <summary>
                    /// <para>The ID of the local disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-diskid1</para>
                    /// </summary>
                    [NameInMap("DiskId")]
                    [Validation(Required=false)]
                    public string DiskId { get; set; }

                    /// <summary>
                    /// <para>The ID of the host.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dh-bp1ewce1gk3iwv2****</para>
                    /// </summary>
                    [NameInMap("HostId")]
                    [Validation(Required=false)]
                    public string HostId { get; set; }

                    /// <summary>
                    /// <para>The type of the host. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>ddh: dedicated host</description></item>
                    /// <item><description>managehost: physical machine in a smart hosting pool</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ddh</para>
                    /// </summary>
                    [NameInMap("HostType")]
                    [Validation(Required=false)]
                    public string HostType { get; set; }

                    /// <summary>
                    /// <para>The inactive disks that were released and whose data must be cleared.</para>
                    /// </summary>
                    [NameInMap("InactiveDisks")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks InactiveDisks { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisks : TeaModel {
                        [NameInMap("InactiveDisk")]
                        [Validation(Required=false)]
                        public List<DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk> InactiveDisk { get; set; }
                        public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeInactiveDisksInactiveDisk : TeaModel {
                            /// <summary>
                            /// <para>The time when the disk was created. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2018-11-30T06:32:31Z</para>
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
                            /// <para>cloud_efficiency</para>
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
                            /// <item><description>system: system disk</description></item>
                            /// <item><description>data: data disk</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>data</para>
                            /// </summary>
                            [NameInMap("DeviceType")]
                            [Validation(Required=false)]
                            public string DeviceType { get; set; }

                            /// <summary>
                            /// <para>The time when the disk was released. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2019-11-30T06:32:31Z</para>
                            /// </summary>
                            [NameInMap("ReleaseTime")]
                            [Validation(Required=false)]
                            public string ReleaseTime { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The migration solution of the instance. Valid value: MigrationPlan. Instances can be migrated only by using migration plans.</para>
                    /// </summary>
                    [NameInMap("MigrationOptions")]
                    [Validation(Required=false)]
                    public DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions MigrationOptions { get; set; }
                    public class DescribeInstanceHistoryEventsResponseBodyInstanceSystemEventSetInstanceSystemEventTypeExtendedAttributeMigrationOptions : TeaModel {
                        [NameInMap("MigrationOption")]
                        [Validation(Required=false)]
                        public List<string> MigrationOption { get; set; }

                    }

                    /// <summary>
                    /// <para>The online repair policy for the damaged disk. Valid value: IsolateOnly, which indicates that damaged disks are isolated but not repaired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IsolateOnly</para>
                    /// </summary>
                    [NameInMap("OnlineRepairPolicy")]
                    [Validation(Required=false)]
                    public string OnlineRepairPolicy { get; set; }

                    /// <summary>
                    /// <para>The illegal domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1228.test.com</para>
                    /// </summary>
                    [NameInMap("PunishDomain")]
                    [Validation(Required=false)]
                    public string PunishDomain { get; set; }

                    /// <summary>
                    /// <para>The type of the penalty.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ecs_message_alert</para>
                    /// </summary>
                    [NameInMap("PunishType")]
                    [Validation(Required=false)]
                    public string PunishType { get; set; }

                    /// <summary>
                    /// <para>The illegal URL.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://1228.test.com/1">http://1228.test.com/1</a></para>
                    /// </summary>
                    [NameInMap("PunishUrl")]
                    [Validation(Required=false)]
                    public string PunishUrl { get; set; }

                    /// <summary>
                    /// <para>The rack number of the cloud box.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A01</para>
                    /// </summary>
                    [NameInMap("Rack")]
                    [Validation(Required=false)]
                    public string Rack { get; set; }

                    /// <summary>
                    /// <para>The response result of the event. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The event was handled.</description></item>
                    /// <item><description>false: The event failed to be handled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("ResponseResult")]
                    [Validation(Required=false)]
                    public string ResponseResult { get; set; }

                }

                /// <summary>
                /// <para>The impact level of the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ImpactLevel")]
                [Validation(Required=false)]
                public string ImpactLevel { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-uf678mass4zvr9n1****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The scheduled start time of the system event. The time follows the <a href="https://help.aliyun.com/document_detail/25696.html">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-06T00:00:00Z</para>
                /// </summary>
                [NameInMap("NotBefore")]
                [Validation(Required=false)]
                public string NotBefore { get; set; }

                /// <summary>
                /// <para>The reason why the system event occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System maintenance is scheduled due to ***.</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The reason code category for the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPCMigrationEcs</para>
                /// </summary>
                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>instance: ECS instance</description></item>
                /// <item><description>ddh: dedicated host</description></item>
                /// <item><description>managehost: physical machine in a smart hosting pool</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>instance</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> If the NextToken parameter is not returned when you use the MaxResults and NextToken parameters to perform a paged query, no more data is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f1c9fa9de5752***</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If MaxResults and NextToken are used to query results by page, ignore this parameter.</para>
        /// </description></item>
        /// <item><description><para>This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If MaxResults and NextToken are used to query results by page, ignore this parameter.</para>
        /// </description></item>
        /// <item><description><para>This parameter will be removed in the future. We recommend that you use the NextToken and MaxResults parameters for a paged query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
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
        /// <para>The total number of instances.</para>
        /// <remarks>
        /// <para> If you specify the MaxResults and NextToken request parameters to perform a paged query, the value of the TotalCount response parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
