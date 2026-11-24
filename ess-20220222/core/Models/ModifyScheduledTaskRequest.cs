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
        /// <para>The expected number of instances in the scaling group. This parameter is required when the scaling method of the scheduled task is set to specify the number of instances in the scaling group.</para>
        /// <remarks>
        /// <para>The scaling group must support the expected number of instances. This means that DesiredCapacity must be specified when the scaling group is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("DesiredCapacity")]
        [Validation(Required=false)]
        public int? DesiredCapacity { get; set; }

        /// <summary>
        /// <para>The retry period during which Auto Scaling continues to attempt to execute the scheduled task after the triggered operation fails. Unit: seconds. Valid values: 0 to 1800.</para>
        /// <para>Default value: 600.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("LaunchExpirationTime")]
        [Validation(Required=false)]
        public int? LaunchExpirationTime { get; set; }

        /// <summary>
        /// <para>The time at which the scheduled task is executed. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time must be in UTC. You cannot specify a time that is later than 90 days from the date of modification.</para>
        /// <list type="bullet">
        /// <item><description><para>If RecurrenceType is specified, the time specified by this parameter is the default time for recurring execution.</para>
        /// </description></item>
        /// <item><description><para>If RecurrenceType is not specified, the task is executed only once at the specified date and time.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2014-08-18T10:52Z</para>
        /// </summary>
        [NameInMap("LaunchTime")]
        [Validation(Required=false)]
        public string LaunchTime { get; set; }

        /// <summary>
        /// <para>The maximum number of instances in the scaling group. This parameter is required when the scaling method of the scheduled task is set to specify the number of instances in the scaling group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxValue")]
        [Validation(Required=false)]
        public int? MaxValue { get; set; }

        /// <summary>
        /// <para>The minimum number of instances in the scaling group. This parameter is required when the scaling method of the scheduled task is set to specify the number of instances in the scaling group.</para>
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
        /// <para>The end time of the scheduled task that is executed repeatedly. Specify the time in the ISO 8601 standard in the YYYY-MM-DDThh:mmZ format. The time must be in UTC. You cannot specify a time that is later than 365 days from the date of modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2014-08-20T16:55Z</para>
        /// </summary>
        [NameInMap("RecurrenceEndTime")]
        [Validation(Required=false)]
        public string RecurrenceEndTime { get; set; }

        /// <summary>
        /// <para>The recurrence type of the scheduled task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Daily: The scheduled task is executed once every specified number of days.</description></item>
        /// <item><description>Weekly: The scheduled task is executed on specified days of each week.</description></item>
        /// <item><description>Monthly: The scheduled task is executed on specified days of each month.</description></item>
        /// <item><description>Cron: The scheduled task is executed based on the specified cron expression.</description></item>
        /// </list>
        /// <para>After modification, both RecurrenceType and RecurrenceValue must be valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("RecurrenceType")]
        [Validation(Required=false)]
        public string RecurrenceType { get; set; }

        /// <summary>
        /// <para>The recurrence value of the scheduled task.</para>
        /// <list type="bullet">
        /// <item><description>If RecurrenceType is set to Daily, you can specify only one value. Valid values: 1 to 31.</description></item>
        /// <item><description>If RecurrenceType is set to Weekly, you can specify multiple values separated by commas (,). For example, the values for Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, and Saturday are 0,1,2,3,4,5,6.</description></item>
        /// <item><description>If RecurrenceType is set to Monthly, the format is A-B. Valid values of A and B: 1 to 31. B must be greater than or equal to A.</description></item>
        /// <item><description>If RecurrenceType is set to Cron, the value specifies a cron expression in UTC. The expression supports five fields: minute, hour, day, month, and week. It supports wildcards such as commas (,), question marks (?), hyphens (-), asterisks (*), number signs (#), forward slashes (/), L, and W.</description></item>
        /// </list>
        /// <para>After modification, both RecurrenceType and RecurrenceValue must be valid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecurrenceValue")]
        [Validation(Required=false)]
        public string RecurrenceValue { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The ID of the scaling group in which you want to modify the number of instances or adjust the warm pool capacity when the scheduled task is triggered.</para>
        /// <para>After you specify ScalingGroupId, the scaling method of the scheduled task is set to specify the number of instances in the scaling group or adjust the warm pool capacity.</para>
        /// <list type="bullet">
        /// <item><description>Specify the number of instances in the scaling group: You must specify at least one of the MinValue, MaxValue, and DesiredCapacity parameters.</description></item>
        /// <item><description>Adjust the warm pool capacity: You must specify WarmPoolCapacityOptions.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You cannot specify both ScheduledAction and ScalingGroupId at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>asg-bp18p2yfxow2dloq****</para>
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling rule to execute. This parameter is available only when the scaling method is set to execute an existing scaling rule. You can view the ID on the details page of the scaling rule.</para>
        /// <remarks>
        /// <para>You cannot specify both ScheduledAction and ScalingGroupId at the same time.</para>
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
        /// <para>The name of the scheduled task. The name must be 2 to 64 characters in length and can contain periods (.), underscores (_), and hyphens (-). It must start with a letter, digit, or Chinese character. The name must be unique within the same region and Alibaba Cloud account.</para>
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
        /// <item><description>true: enables the scheduled task.</description></item>
        /// <item><description>false: disables the scheduled task.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TaskEnabled")]
        [Validation(Required=false)]
        public bool? TaskEnabled { get; set; }

        /// <summary>
        /// <para>The warm pool capacity configuration of the scaling group. This parameter is valid only when a warm pool is configured for the scaling group.</para>
        /// <remarks>
        /// <para>You must specify ScalingGroupId when you specify this parameter.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("WarmPoolCapacityOptions")]
        [Validation(Required=false)]
        public ModifyScheduledTaskRequestWarmPoolCapacityOptions WarmPoolCapacityOptions { get; set; }
        public class ModifyScheduledTaskRequestWarmPoolCapacityOptions : TeaModel {
            /// <summary>
            /// <para>The expected number of prepared instances. The system maintains the sum of the current number of instances in the scaling group and the number of instances in the warm pool at this value. Default value: the maximum number of instances in the scaling group, which is specified by MaxSize.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("DesiredGroupPreparedCapacity")]
            [Validation(Required=false)]
            public int? DesiredGroupPreparedCapacity { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the warm pool. The system always retains at least this number of prepared instances in the warm pool to ensure that instances can be quickly added from the warm pool during scale-out. Default value: 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public int? MinCapacity { get; set; }

        }

    }

}
