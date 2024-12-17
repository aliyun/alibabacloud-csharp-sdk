// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class ModifyScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The description of the scheduled task. The description must be 2 to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test scheduled task.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The expected number of instances in the scaling group if you specify the ScalingGroupId parameter.</para>
        /// <remarks>
        /// <para>You must specify the <c>DesiredCapacity</c> parameter when you create a scaling group.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>The time period during which the failed scheduled task is retried. Unit: seconds. Valid values: 0 to 1800.</para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("LaunchExpirationTime")]
        [Validation(Required=false)]
        public int? LaunchExpirationTime { get; set; }

        /// <summary>
        /// <para>The point in time at which the scheduled task is triggered. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time must be in UTC. You cannot enter a time point later than 90 days from the point in time at which the scheduled task is modified.</para>
        /// <list type="bullet">
        /// <item><description>If you specify the <c>RecurrenceType</c> parameter, the task is repeatedly executed at the time point that is specified by the LaunchTime parameter.</description></item>
        /// <item><description>If you do not specify the <c>RecurrenceType</c> parameter, the task is executed only once at the point in time that is specified by the LaunchTime parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2014-08-18T10:52Z</para>
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public string LaunchTime { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group if you specify the ScalingGroupId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxValue")]
        [Validation(Required=false)]
        public int? MaxValue { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the scaling group if you specify the ScalingGroupId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MinValue")]
        [Validation(Required=false)]
        public int? MinValue { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The end time of the scheduled task. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time must be in UTC. You cannot enter a point in time that is later than 365 days from the point in time at which the scheduled task is modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-08-20T16:55Z</para>
        /// </summary>
        [NameInMap("RecurrenceEndTime")]
        [Validation(Required=false)]
        public string RecurrenceEndTime { get; set; }

        /// <summary>
        /// <para>The interval at which the scheduled task is repeated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: The scheduled task is executed once every specified number of days.</description></item>
        /// <item><description>Weekly: The scheduled task is executed on each specified day of the week.</description></item>
        /// <item><description>Monthly: The scheduled task is executed on each specified day of the month.</description></item>
        /// <item><description>Cron: The scheduled task is executed based on the specified cron expression.</description></item>
        /// </list>
        /// <para>After you modify the scheduled task, the values that you specify for the <c>RecurrenceType</c> and <c>RecurrenceValue</c> parameters must be valid at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The number of recurrences of the scheduled task.</para>
        /// <list type="bullet">
        /// <item><description>If you set the <c>RecurrenceType</c> parameter to <c>Daily</c>, you can specify only one value for this parameter. Valid values: 1 to 31.</description></item>
        /// <item><description>If you set the <c>RecurrenceType</c> parameter to <c>Weekly</c>, you can specify multiple values for this parameter. Separate the values with commas (,). The values that correspond to Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0, 1, 2, 3, 4, 5, and 6.``</description></item>
        /// <item><description>If you set the <c>RecurrenceType</c> parameter to <c>Monthly</c>, you can specify two values in the <c>A-B</c> format for this parameter. Valid values of A and B: 1 to 31. B must be greater than or equal to A.</description></item>
        /// <item><description>If you set the <c>RecurrenceType</c> parameter to <c>Cron</c>, you can specify a cron expression. A cron expression is written in UTC time and consists of the following fields: minute, hour, day, month, and week. The expression can contain the letters L and W and the following wildcard characters: commas (,), question marks (?), hyphens (-), asterisks (\*), number signs (#), and forward slashes (/).</description></item>
        /// </list>
        /// <para>After you modify the scheduled task, the values that you specify for the <c>RecurrenceType</c> and <c>RecurrenceValue</c> parameters must be valid at the same time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

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
        /// <para>The ID of the scaling group whose number of instances must be modified when the scheduled task is triggered. If you specify the <c>ScalingGroupId</c> parameter for a scheduled task, you must specify the minimum, maximum, or expected numbers of instances for a scaling group in the scheduled task. That is, you must specify at least one of the <c>MinValue</c>, <c>MaxValue</c>, and <c>DesiredCapacity</c> parameters.</para>
        /// <remarks>
        /// <para>You cannot specify the <c>ScheduledAction</c> and <c>ScalingGroupId</c> parameters at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The scaling rule that you want to execute when the scheduled task is triggered. Enter the ID of the scaling rule. To obtain the ID of a scaling rule, go to the scaling rule details page. If you specify <c>ScheduledAction</c>, you must select an existing scaling rule for the scheduled task.</para>
        /// <remarks>
        /// <para> You can specify only one of <c>ScheduledAction</c> and <c>ScalingGroupId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ari:acs:ess:cn-hangzhou:14069264****:scalingrule/asr-bp12tcnol686y1ik****</para>
        /// </summary>
        [NameInMap("ScheduledAction")]
        [Validation(Required=false)]
        public string ScheduledAction { get; set; }

        /// <summary>
        /// <para>The ID of the scheduled task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edRtShc57WGXdt8TlPbr****</para>
        /// </summary>
        [NameInMap("ScheduledTaskId")]
        [Validation(Required=false)]
        public string ScheduledTaskId { get; set; }

        /// <summary>
        /// <para>The name of the scheduled task. The name must be 2 to 64 characters in length, and can contain letters, digits, underscores (_), hyphens (-), and periods (.). It must start with a letter or a digit. The name of the scheduled task must be unique in the region and within the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scheduled****</para>
        /// </summary>
        [NameInMap("ScheduledTaskName")]
        [Validation(Required=false)]
        public string ScheduledTaskName { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the scheduled task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TaskEnabled")]
        [Validation(Required=false)]
        public bool? TaskEnabled { get; set; }

    }

}
