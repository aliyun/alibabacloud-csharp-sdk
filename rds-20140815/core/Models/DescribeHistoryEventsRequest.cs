// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The archive status of the event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Archived</b>: archived</description></item>
        /// <item><description><b>UnArchived</b>: unarchived</description></item>
        /// <item><description><b>All</b>: all</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ArchiveStatus")]
        [Validation(Required=false)]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// <para>The system event categorization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Exception</b>: abnormal event</description></item>
        /// <item><description><b>Optimize</b>: optimization events</description></item>
        /// <item><description><b>Notification</b>: notification event</description></item>
        /// <item><description><b>Maintenance</b>: scheduled maintenance event</description></item>
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
        /// <item><description><b>INFO</b>: information</description></item>
        /// <item><description><b>WARN</b>: warning</description></item>
        /// <item><description><b>CRITICAL</b>: critical</description></item>
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
        /// <item><description><b>Inquiring</b>: inquiring</description></item>
        /// <item><description><b>Scheduled</b>: scheduled</description></item>
        /// <item><description><b>Running</b>: running</description></item>
        /// <item><description><b>Succeed</b>: succeeded</description></item>
        /// <item><description><b>Failed</b>: failed</description></item>
        /// <item><description><b>Canceled</b>: canceled<remarks>
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
        /// <para>The system event type. This parameter is valid only when InstanceEventType.N is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</description></item>
        /// <item><description><b>SystemMaintenance.Redeploy</b>: The instance undergoes redeployment due to system maintenance.</description></item>
        /// <item><description><b>SystemFailure.Reboot</b>: The instance is restarted due to a system fault.</description></item>
        /// <item><description><b>SystemFailure.Redeploy</b>: The instance undergoes redeployment due to a system fault.</description></item>
        /// <item><description><b>SystemFailure.Delete</b>: The instance is released because instance creation failed.</description></item>
        /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance fault.</description></item>
        /// <item><description><b>InstanceExpiration.Stop</b>: The subscription instance is stopped due to expiration.</description></item>
        /// <item><description><b>InstanceExpiration.Delete</b>: The subscription instance is released due to expiration.</description></item>
        /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.<remarks>
        /// <para>You can specify only instance system events for this parameter. Disk system events are not supported.</para>
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
        /// <para>The start time of the time range to query the task start time. This parameter specifies that the start time of the task must be later than the specified time. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in <c>UTC +0</c>. The earliest supported time is 30 days ago. If the specified time is more than 30 days before the current time, it is automatically converted to 30 days ago.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The RDS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of an integer. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> operation to query the region ID.</para>
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
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the resource. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: instance</description></item>
        /// <item><description><b>Host</b>: host</description></item>
        /// <item><description><b>User</b>: user<remarks>
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
        /// <para>The ID of the task. Specify this parameter to obtain the data of a specific task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>241535739</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The end time of the time range to query the task start time. This parameter specifies that the start time of the task must be earlier than the specified time. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in <c>UTC +0</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-01-12T07:06:19Z</para>
        /// </summary>
        [NameInMap("ToStartTime")]
        [Validation(Required=false)]
        public string ToStartTime { get; set; }

    }

}
