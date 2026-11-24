// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScheduledTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the scheduled tasks.</para>
        /// </summary>
        [NameInMap("ScheduledTasks")]
        [Validation(Required=false)]
        public List<DescribeScheduledTasksResponseBodyScheduledTasks> ScheduledTasks { get; set; }
        public class DescribeScheduledTasksResponseBodyScheduledTasks : TeaModel {
            /// <summary>
            /// <para>The description of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test scheduled task.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The expected number of instances in the scaling group. This parameter takes effect when the scaling method of the scheduled task is set to adjust the number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// <para>The time period during which a retry is performed after the scheduled task fails to be triggered. Unit: seconds. Valid values: 0 to 21600.</para>
            /// 
            /// <b>Example:</b>
            /// <para>600</para>
            /// </summary>
            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            /// <summary>
            /// <para>The time at which the scheduled task is triggered. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-18T10:52Z</para>
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            /// <summary>
            /// <para>The maximum number of instances in the scaling group. This parameter takes effect when the scaling method of the scheduled task is set to adjust the number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public int? MaxValue { get; set; }

            /// <summary>
            /// <para>The minimum number of instances in the scaling group. This parameter takes effect when the scaling method of the scheduled task is set to adjust the number of instances in the scaling group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public int? MinValue { get; set; }

            /// <summary>
            /// <para>The end time of the recurring scheduled task. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mmZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2014-08-20T16:55Z</para>
            /// </summary>
            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            /// <summary>
            /// <para>The recurrence type of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>The recurrence value of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

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
            /// <para>The scaling rule used when the scheduled task is executed. This parameter is returned only when a scaling rule is specified for the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ari:acs:ess:cn-hangzhou:1406926474****:scalingrule/asr-bp1id5rhu8edp7kd****</para>
            /// </summary>
            [NameInMap("ScheduledAction")]
            [Validation(Required=false)]
            public string ScheduledAction { get; set; }

            /// <summary>
            /// <para>The ID of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>edRtShc57WGXdt8TlPbr****</para>
            /// </summary>
            [NameInMap("ScheduledTaskId")]
            [Validation(Required=false)]
            public string ScheduledTaskId { get; set; }

            /// <summary>
            /// <para>The name of the scheduled task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>scheduled****</para>
            /// </summary>
            [NameInMap("ScheduledTaskName")]
            [Validation(Required=false)]
            public string ScheduledTaskName { get; set; }

            /// <summary>
            /// <para>Indicates whether the scheduled task is started. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>true: The task is started.</description></item>
            /// <item><description>false: The task is stopped.</description></item>
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
            /// <para>The warm pool capacity configurations of the scaling group.</para>
            /// </summary>
            [NameInMap("WarmPoolCapacityOptions")]
            [Validation(Required=false)]
            public DescribeScheduledTasksResponseBodyScheduledTasksWarmPoolCapacityOptions WarmPoolCapacityOptions { get; set; }
            public class DescribeScheduledTasksResponseBodyScheduledTasksWarmPoolCapacityOptions : TeaModel {
                /// <summary>
                /// <para>The expected number of instances covered by the warm pool. The system maintains the sum of the current number of instances in the scaling group and the number of instances in the warm pool at this value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("DesiredGroupPreparedCapacity")]
                [Validation(Required=false)]
                public int? DesiredGroupPreparedCapacity { get; set; }

                /// <summary>
                /// <para>The minimum number of instances in the warm pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of scheduled tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
