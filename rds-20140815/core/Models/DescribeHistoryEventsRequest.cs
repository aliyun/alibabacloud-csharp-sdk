// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Archived</b>: archived.</description></item>
        /// <item><description><b>UnArchived</b>: not archived.</description></item>
        /// <item><description><b>All</b>: all.</description></item>
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
        /// <item><description><b>Exception</b>: abnormal event.</description></item>
        /// <item><description><b>Optimize</b>: optimization events.</description></item>
        /// <item><description><b>Notification</b>: notification event.</description></item>
        /// <item><description><b>Maintenance</b>: scheduled maintenance event.</description></item>
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
        /// <para>The event level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>INFO</b>: notification.</description></item>
        /// <item><description><b>WARN</b>: warning.</description></item>
        /// <item><description><b>CRITICAL</b>: critical.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("EventLevel")]
        [Validation(Required=false)]
        public string EventLevel { get; set; }

        /// <summary>
        /// <para>The event status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inquiring</b>: inquiring.</description></item>
        /// <item><description><b>Scheduled</b>: scheduled.</description></item>
        /// <item><description><b>Running</b>: running.</description></item>
        /// <item><description><b>Succeed</b>: completed.</description></item>
        /// <item><description><b>Failed</b>: failed.</description></item>
        /// <item><description><b>Canceled</b>: canceled.<remarks>
        /// <para>To query multiple statuses, separate them with commas (,).</para>
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
        /// <para>The system event type. This parameter takes effect only when InstanceEventType.N is not specified. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>SystemMaintenance.Reboot</b>: The instance is restarted due to system maintenance.</description></item>
        /// <item><description><b>SystemMaintenance.Redeploy</b>: The instance is redeployed due to system maintenance.</description></item>
        /// <item><description><b>SystemFailure.Reboot</b>: The instance is restarted due to a system error.</description></item>
        /// <item><description><b>SystemFailure.Redeploy</b>: The instance is redeployed due to a system error.</description></item>
        /// <item><description><b>SystemFailure.Delete</b>: The instance is released due to an instance creation failure.</description></item>
        /// <item><description><b>InstanceFailure.Reboot</b>: The instance is restarted due to an instance error.</description></item>
        /// <item><description><b>InstanceExpiration.Stop</b>: The instance is stopped due to subscription expiration.</description></item>
        /// <item><description><b>InstanceExpiration.Delete</b>: The instance is released due to subscription expiration.</description></item>
        /// <item><description><b>AccountUnbalanced.Stop</b>: The pay-as-you-go instance is stopped due to an overdue payment.</description></item>
        /// <item><description><b>AccountUnbalanced.Delete</b>: The pay-as-you-go instance is released due to an overdue payment.<remarks>
        /// <para>The value of this parameter can only be an instance system event, not a cloud disk system event.</para>
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
        /// <para>The beginning of the time range for the task start time. Tasks whose start time is later than this time are queried. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in <c>UTC +0</c>. The earliest supported time is 30 days before the current time. If the specified time is more than 30 days before the current time, it is automatically converted to 30 days before the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-02T11:31:03Z</para>
        /// </summary>
        [NameInMap("FromStartTime")]
        [Validation(Required=false)]
        public string FromStartTime { get; set; }

        /// <summary>
        /// <para>The ApsaraDB RDS instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than 0 and cannot exceed the maximum value of the integer type. Default value: <b>1</b>.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: instance resource.</description></item>
        /// <item><description><b>Host</b>: host resource.</description></item>
        /// <item><description><b>User</b>: user resource.<remarks>
        /// <para>If this parameter is not specified, all resource types are queried.</para>
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
        /// <para>The task ID. Specify this parameter to retrieve data for a specific task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>241535739</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The end of the time range for the task start time. Tasks whose start time is earlier than this time are queried. Specify the time in the ISO 8601 standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time must be in <c>UTC +0</c>.</para>
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
