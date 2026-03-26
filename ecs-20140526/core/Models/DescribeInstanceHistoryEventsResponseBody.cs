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
                    [NameInMap("CanAccept")]
                    [Validation(Required=false)]
                    public string CanAccept { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

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

                    [NameInMap("MetricName")]
                    [Validation(Required=false)]
                    public string MetricName { get; set; }

                    [NameInMap("MetricValue")]
                    [Validation(Required=false)]
                    public string MetricValue { get; set; }

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

                    [NameInMap("PunishDomain")]
                    [Validation(Required=false)]
                    public string PunishDomain { get; set; }

                    [NameInMap("PunishType")]
                    [Validation(Required=false)]
                    public string PunishType { get; set; }

                    [NameInMap("PunishUrl")]
                    [Validation(Required=false)]
                    public string PunishUrl { get; set; }

                    [NameInMap("Rack")]
                    [Validation(Required=false)]
                    public string Rack { get; set; }

                    [NameInMap("ResponseResult")]
                    [Validation(Required=false)]
                    public string ResponseResult { get; set; }

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

                [NameInMap("ReasonCode")]
                [Validation(Required=false)]
                public string ReasonCode { get; set; }

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
