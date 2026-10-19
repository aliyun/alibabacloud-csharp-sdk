// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The archive status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Archived</b>: The event is archived.</description></item>
        /// <item><description><b>UnArchived</b>: The event is not archived.</description></item>
        /// <item><description><b>All</b>: All events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Archived</para>
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// <para>The category of the system event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exception</b>: Exception events.</description></item>
        /// <item><description><b>Optimize</b>: Optimization events.</description></item>
        /// <item><description><b>Notification</b>: Notification events.</description></item>
        /// <item><description><b>Maintenance</b>: Scheduled O&amp;M events.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exception</para>
        /// </summary>
        [NameInMap("EventCategory")]
        [Validation(Required=false)]
        public string EventCategory { get; set; }

        /// <summary>
        /// <para>The ID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5345398</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The event level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INFO</b>: Information.</description></item>
        /// <item><description><b>WARN</b>: Warning.</description></item>
        /// <item><description><b>CRITICAL</b>: Critical.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inquiring</b>: Inquiring.</description></item>
        /// <item><description><b>Scheduled</b>: Scheduled.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Succeed</b>: Succeeded.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Canceled</b>: Canceled.<remarks>
        /// <para>To query events in multiple statuses, separate the statuses with commas (,).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Scheduled</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// <para>The type of the system event. The EventType parameter is valid only when the InstanceEventType.N parameter is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>SystemMaintenance.Reboot: The instance is restarted due to system maintenance.</description></item>
        /// <item><description>SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description>SystemFailure.Reboot: The instance is restarted due to a system failure.</description></item>
        /// <item><description>SystemFailure.Redeploy: The instance is redeployed due to a system failure.</description></item>
        /// <item><description>SystemFailure.Delete: The instance is released due to a creation failure.</description></item>
        /// <item><description>InstanceFailure.Reboot: The instance is restarted due to an instance failure.</description></item>
        /// <item><description>InstanceExpiration.Stop: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description>InstanceExpiration.Delete: The subscription instance is released due to expiration.</description></item>
        /// <item><description>AccountUnbalanced.Stop: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description>AccountUnbalanced.Delete: The pay-as-you-go instance is released due to an overdue payment.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about event types, see <a href="https://help.aliyun.com/document_detail/66574.html">Overview of system events</a>. The value of this parameter can only be an instance system event, not a cloud disk system event.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemFailure.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The earliest start time of the query task. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and less than or equal to the maximum integer value. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/473763.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfnuslkubs****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: Instance resources.</description></item>
        /// <item><description><b>Host</b>: Host resources.</description></item>
        /// <item><description><b>User</b>: User resources.<remarks>
        /// <para>If you do not specify this parameter, all resource types are queried.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The ID of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>578678678</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The latest start time of the query task. Specify the time in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC and later than the earliest start time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
