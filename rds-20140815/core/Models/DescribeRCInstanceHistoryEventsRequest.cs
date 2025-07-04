// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceHistoryEventsRequest : TeaModel {
        [NameInMap("EventPublishTime")]
        [Validation(Required=false)]
        public DescribeRCInstanceHistoryEventsRequestEventPublishTime EventPublishTime { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestEventPublishTime : TeaModel {
            /// <summary>
            /// <para>The end of the time range in which to query published system events. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The beginning of the time range in which to query published system events. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public DescribeRCInstanceHistoryEventsRequestNotBefore NotBefore { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestNotBefore : TeaModel {
            /// <summary>
            /// <para>The end time of the scheduled execution period for the system event. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-04-01T06:32:31Z</para>
            /// </summary>
            [NameInMap("End")]
            [Validation(Required=false)]
            public string End { get; set; }

            /// <summary>
            /// <para>The start time of the scheduled execution period for the system event. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-30T06:32:31Z</para>
            /// </summary>
            [NameInMap("Start")]
            [Validation(Required=false)]
            public string Start { get; set; }

        }

        /// <summary>
        /// <para>The lifecycle state of the system event. This parameter is valid only when the <b>InstanceEventCycleStatus.N</b> parameter is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Scheduled</b></description></item>
        /// <item><description><b>Avoided</b></description></item>
        /// <item><description><b>Executing</b></description></item>
        /// <item><description><b>Executed</b></description></item>
        /// <item><description><b>Canceled</b></description></item>
        /// <item><description><b>Failed</b></description></item>
        /// <item><description><b>Inquiring</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executed</para>
        /// </summary>
        [NameInMap("EventCycleStatus")]
        [Validation(Required=false)]
        public string EventCycleStatus { get; set; }

        /// <summary>
        /// <para>The IDs of one or more system events.</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public List<string> EventId { get; set; }

        /// <summary>
        /// <para>The system event type. This parameter is valid only when the <b>InstanceEventType.N</b> parameter is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SystemMaintenance.Reboot</b>: The instance was restarted due to system maintenance.</description></item>
        /// <item><description><b>SystemMaintenance.Redeploy</b>: The instance was redeployed due to system maintenance.</description></item>
        /// <item><description><b>SystemFailure.Reboot</b>: The instance was restarted due to system failures.</description></item>
        /// <item><description><b>SystemFailure.Redeploy</b>: The instance was redeployed due to system failures.</description></item>
        /// <item><description><b>SystemFailure.Delete</b>: The instance was released due to an instance creation failure.</description></item>
        /// <item><description><b>InstanceFailure.Reboot</b>: The instance was restarted due to an instance error.</description></item>
        /// <item><description><b>InstanceExpiration.Stop</b>: The subscription instance was stopped due to expiration.</description></item>
        /// <item><description><b>InstanceExpiration.Delete</b>: The subscription instance was released due to expiration.</description></item>
        /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance was released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The values of this parameter are applicable only to instance system events, but not to disk system events.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemMaintenance.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ImpactLevel")]
        [Validation(Required=false)]
        public string ImpactLevel { get; set; }

        /// <summary>
        /// <para>The lifecycle states of system events.</para>
        /// </summary>
        [NameInMap("InstanceEventCycleStatus")]
        [Validation(Required=false)]
        public List<string> InstanceEventCycleStatus { get; set; }

        /// <summary>
        /// <para>The type of system event N.</para>
        /// </summary>
        [NameInMap("InstanceEventType")]
        [Validation(Required=false)]
        public List<string> InstanceEventType { get; set; }

        /// <summary>
        /// <para>The instance ID. If you do not specify an instance ID, system events of all instances in the specified region are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-yuf59nplc45t2tzn****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of resource N.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>An array that consists of the tags that are supported by system events.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeRCInstanceHistoryEventsRequestTag> Tag { get; set; }
        public class DescribeRCInstanceHistoryEventsRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag that is added to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N of the port list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
