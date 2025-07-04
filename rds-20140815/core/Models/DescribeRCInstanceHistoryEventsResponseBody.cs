// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceHistoryEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instance system event.</para>
        /// </summary>
        [NameInMap("InstanceSystemEventSet")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSet> InstanceSystemEventSet { get; set; }
        public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSet : TeaModel {
            /// <summary>
            /// <para>The lifecycle state of the system event.</para>
            /// </summary>
            [NameInMap("EventCycleStatus")]
            [Validation(Required=false)]
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus EventCycleStatus { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventCycleStatus : TeaModel {
                /// <summary>
                /// <para>The state code of the system event.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

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
            /// <para>The time when the system event ended. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-01T06:32:31Z</para>
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
            /// <para>The time when the system event was published. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("EventPublishTime")]
            [Validation(Required=false)]
            public string EventPublishTime { get; set; }

            /// <summary>
            /// <para>The type of the system event.</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType EventType { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetEventType : TeaModel {
                /// <summary>
                /// <para>The code of the system event type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>34</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

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
            public DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute ExtendedAttribute { get; set; }
            public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttribute : TeaModel {
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
                /// <para>rcd-****</para>
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
                /// <item><description><b>ddh</b>: dedicated host</description></item>
                /// <item><description><b>managehost</b>: physical machine in a smart hosting pool</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ddh</para>
                /// </summary>
                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                /// <summary>
                /// <para>The inactive disks that have been released and whose data must be cleared.</para>
                /// </summary>
                [NameInMap("InactiveDisks")]
                [Validation(Required=false)]
                public List<DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks> InactiveDisks { get; set; }
                public class DescribeRCInstanceHistoryEventsResponseBodyInstanceSystemEventSetExtendedAttributeInactiveDisks : TeaModel {
                    /// <summary>
                    /// <para>The time when the disk was created. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-03-26T03:33:56Z</para>
                    /// </summary>
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    /// <summary>
                    /// <para>The category of the cloud disk or local disk. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>cloud_efficiency</b>: ultra disk</description></item>
                    /// <item><description><b>cloud_ssd</b>: standard SSD</description></item>
                    /// <item><description><b>cloud_essd</b>: ESSD</description></item>
                    /// <item><description><b>cloud_auto</b>: Premium ESSD</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cloud_auto</para>
                    /// </summary>
                    [NameInMap("DeviceCategory")]
                    [Validation(Required=false)]
                    public string DeviceCategory { get; set; }

                    /// <summary>
                    /// <para>The size of the disk. Unit: GiB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40</para>
                    /// </summary>
                    [NameInMap("DeviceSize")]
                    [Validation(Required=false)]
                    public string DeviceSize { get; set; }

                    /// <summary>
                    /// <para>The disk type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>system</b>: system disk.</description></item>
                    /// <item><description><b>data</b>: data disk.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data</para>
                    /// </summary>
                    [NameInMap("DeviceType")]
                    [Validation(Required=false)]
                    public string DeviceType { get; set; }

                    /// <summary>
                    /// <para>The time when the disk was released. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-03-26T03:33:56Z</para>
                    /// </summary>
                    [NameInMap("ReleaseTime")]
                    [Validation(Required=false)]
                    public string ReleaseTime { get; set; }

                }

                /// <summary>
                /// <para>The migration solutions of the instance.</para>
                /// </summary>
                [NameInMap("MigrationOptions")]
                [Validation(Required=false)]
                public List<string> MigrationOptions { get; set; }

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
                /// <item><description><b>true</b>: the event was handled.</description></item>
                /// <item><description><b>false</b>: the event failed to be handled.</description></item>
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
            /// <para>The impact level of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ImpactLevel")]
            [Validation(Required=false)]
            public string ImpactLevel { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rc-yuf59nplc45t2tzn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The start time of the scheduled execution of the system event. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-01T06:32:31Z</para>
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
            /// <para>The resource type. The value is fixed to INSTANCE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>866F5EB8-4650-4061-87F0-379F6F968BCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instance events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
