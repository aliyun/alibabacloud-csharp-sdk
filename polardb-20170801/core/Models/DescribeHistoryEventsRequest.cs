// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The archive status of the event. Valid values:</para>
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
        /// <item><description><b>INFO</b>: Notification.</description></item>
        /// <item><description><b>WARN</b>: Warning.</description></item>
        /// <item><description><b>CRITICAL</b>: Alerting.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
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
        /// <para>To query multiple statuses, separate them with commas (,).</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeed</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public string EventStatus { get; set; }

        /// <summary>
        /// <para>The system event type. This parameter is valid only when InstanceEventType.N is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</description></item>
        /// <item><description><b>SystemMaintenance.Redeploy</b>: Redeployment of the instance due to system maintenance.</description></item>
        /// <item><description><b>SystemFailure.Reboot</b>: The instance is restarted due to a system fault.</description></item>
        /// <item><description><b>SystemFailure.Redeploy</b>: Redeployment of the instance due to a system fault.</description></item>
        /// <item><description><b>SystemFailure.Delete</b>: The instance is released because instance creation failed.</description></item>
        /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</description></item>
        /// <item><description><b>InstanceExpiration.Stop</b>: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description><b>InstanceExpiration.Delete</b>: The subscription instance is released due to expiration.</description></item>
        /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.<remarks>
        /// <para>The value of this parameter must be an instance system event, not a disk system event.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SystemFailure.Reboot</para>
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <para>The start time of the task start time range. This parameter specifies that the start time of the queried tasks must be later than this time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC. The earliest supported time is 30 days ago. If the specified time is more than 30 days before the current time, it is automatically converted to 30 days ago. This parameter is actually required. If it is not provided, the API returns Param.Invalid (HTTP 400). Note: This parameter is required. If it is not provided, the API returns Param.Invalid (HTTP 400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The ID of the resource. This parameter is used to query tasks for the corresponding resource. You can specify up to 30 IDs and separate them with commas (,). Default value: empty, which indicates no limit.</para>
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
        /// <para>The page number. Default value: 1.</para>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-**********</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: Instance resources.</description></item>
        /// <item><description><b>Instance</b>: Host: Host resources.</description></item>
        /// <item><description><b>Instance</b>: User: User resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task to be canceled.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/199648.html">DescribeScheduleTasks</a> operation to query the information of all scheduled tasks under the current account, including the task IDs.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Only tasks in the pending state (where the return value of the <c>Status</c> parameter is <c>pending</c>) can be canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>32077515</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The end time of the task start time range. This parameter specifies that the start time of the queried tasks must be earlier than this time. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-03T12:31:03Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
