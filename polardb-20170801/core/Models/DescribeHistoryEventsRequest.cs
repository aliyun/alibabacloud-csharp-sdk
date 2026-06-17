// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Archived: The event is archived.</para>
        /// </description></item>
        /// <item><description><para>UnArchived: The event is not archived.</para>
        /// </description></item>
        /// <item><description><para>All: All events.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// <para>The category of the system event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Exception</b>: anomalous activity</para>
        /// </description></item>
        /// <item><description><para><b>Optimize</b>: optimization events</para>
        /// </description></item>
        /// <item><description><para><b>Notification</b>: notification events</para>
        /// </description></item>
        /// <item><description><para><b>Maintenance</b>: scheduled O\&amp;M events</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Exception</para>
        /// </summary>
        [NameInMap("EventCategory")]
        [Validation(Required=false)]
        public string EventCategory { get; set; }

        /// <summary>
        /// <para>The event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5345398</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        /// <summary>
        /// <para>The event level. Valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>INFO</b>: Notification</para>
        /// </description></item>
        /// <item><description><para><b>WARN</b>: Warning</para>
        /// </description></item>
        /// <item><description><para><b>CRITICAL</b>: Critical</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Inquiring</b>: The event is being inquired.</para>
        /// </description></item>
        /// <item><description><para><b>Scheduled</b>: The event is scheduled.</para>
        /// </description></item>
        /// <item><description><para><b>Running</b>: The event is in progress.</para>
        /// </description></item>
        /// <item><description><para><b>Succeed</b>: The event is successful.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: The event failed.</para>
        /// </description></item>
        /// <item><description><para><b>Canceled</b>: The event is canceled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To query multiple statuses, separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// <para>The type of the system event. This parameter is valid only when InstanceEventType.N is not specified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</para>
        /// </description></item>
        /// <item><description><para><b>SystemMaintenance.Redeploy</b>: The instance is redeployed due to system maintenance.</para>
        /// </description></item>
        /// <item><description><para><b>SystemFailure.Reboot</b>: The instance is restarted due to a system fault.</para>
        /// </description></item>
        /// <item><description><para><b>SystemFailure.Redeploy</b>: The instance is redeployed due to a system fault.</para>
        /// </description></item>
        /// <item><description><para><b>SystemFailure.Delete</b>: The instance is released because it failed to be created.</para>
        /// </description></item>
        /// <item><description><para><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</para>
        /// </description></item>
        /// <item><description><para><b>InstanceExpiration.Stop</b>: The subscription instance is stopped because its subscription expires.</para>
        /// </description></item>
        /// <item><description><para><b>InstanceExpiration.Delete</b>: The subscription instance is released because its subscription expires.</para>
        /// </description></item>
        /// <item><description><para><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</para>
        /// </description></item>
        /// <item><description><para><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The value of this parameter can only be an instance system event, not a disk system event.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>SystemFailure.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query tasks based on their start time. The tasks that started after this time are queried. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. You can query data from the last 30 days. If the specified time is more than 30 days ago, the system automatically sets it to 30 days ago.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The resource ID. Use this parameter to query tasks for a specific resource. To query tasks for multiple resources, separate the resource IDs with commas (,). You can specify up to 30 resource IDs. If you leave this parameter empty, all resources are queried.</para>
        /// <remarks>
        /// <para>Currently, only cluster IDs are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pc-2zed3m89cw***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number to query. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
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
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-**********</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b>: instance resource</para>
        /// </description></item>
        /// <item><description><para><b>Host</b>: host resource</para>
        /// </description></item>
        /// <item><description><para><b>User</b>: user resource</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task that you want to cancel.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/199648.html">DescribeScheduleTasks</a> operation to view information about all scheduled tasks under the current account, including task IDs.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Only tasks that are pending execution (the <c>Status</c> parameter returns <c>pending</c>) can be canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>32077515</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query tasks based on their start time. The tasks that started before this time are queried. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in <c>UTC</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-03T12:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
