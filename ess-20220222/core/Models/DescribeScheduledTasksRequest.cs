// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScheduledTasksRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the scheduled task list. Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The recurrence type of the scheduled task. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>Daily: The scheduled task is executed once every specified number of days. </description></item>
        /// <item><description>Weekly: The scheduled task is executed on specified days of each week. </description></item>
        /// <item><description>Monthly: The scheduled task is executed on specified days of each month. </description></item>
        /// <item><description>Cron: The scheduled task is executed based on a specified cron expression.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Weekly</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The recurrence value of the scheduled task.</para>
        /// <para>This parameter is supported only when RecurrenceType is set to Weekly. You can specify multiple values separated by commas (,). For example, the values for Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0, 1, 2, 3, 4, 5, and 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

        /// <summary>
        /// <para>The region ID of the scaling group to which the scheduled task belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling group that executes the scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp1bo5tca4m56nap****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The scaling rules that are used when the scheduled tasks are triggered. This parameter is valid only when a scaling rule is specified for the scheduled task.</para>
        /// </summary>
        [NameInMap("ScheduledActions")]
        [Validation(Required=false)]
        public List<string> ScheduledActions { get; set; }

        /// <summary>
        /// <para>The IDs of the scheduled tasks to be queried.</para>
        /// </summary>
        [NameInMap("ScheduledTaskIds")]
        [Validation(Required=false)]
        public List<string> ScheduledTaskIds { get; set; }

        /// <summary>
        /// <para>The names of the scheduled tasks to be queried.</para>
        /// </summary>
        [NameInMap("ScheduledTaskNames")]
        [Validation(Required=false)]
        public List<string> ScheduledTaskNames { get; set; }

        /// <summary>
        /// <para>Specifies whether the scheduled task is started. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The task is started.</description></item>
        /// <item><description>false: The task is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TaskEnabled")]
        [Validation(Required=false)]
        public bool? TaskEnabled { get; set; }

        /// <summary>
        /// <para>The name of the task. Fuzzy match by keyword is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scheduled****</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
