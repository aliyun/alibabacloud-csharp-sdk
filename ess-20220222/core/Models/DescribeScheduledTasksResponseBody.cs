// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScheduledTasksResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information collection of the scheduled tasks.
        /// </summary>
        [NameInMap("ScheduledTasks")]
        [Validation(Required=false)]
        public List<DescribeScheduledTasksResponseBodyScheduledTasks> ScheduledTasks { get; set; }
        public class DescribeScheduledTasksResponseBodyScheduledTasks : TeaModel {
            /// <summary>
            /// The description of the scheduled task.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The expected number of instances in the scaling group. If you set `Scaling Method` to `Configure Number of Instances in Scaling Group`, you can specify this parameter.
            /// </summary>
            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            /// <summary>
            /// The time window during which the scheduled task can be retried. Unit: seconds. Valid values: 0 to 21600.
            /// </summary>
            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            /// <summary>
            /// The point in time at which the scheduled task is triggered.
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            /// <summary>
            /// The maximum number of instances that must be contained in the scaling group. If you set `Scaling Method` to `Configure Number of Instances in Scaling Group`, you can specify this parameter.
            /// </summary>
            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public int? MaxValue { get; set; }

            /// <summary>
            /// The minimum number of instances that must be contained in the scaling group. If you set `Scaling Method` to `Configure Number of Instances in Scaling Group`, you can specify this parameter.
            /// </summary>
            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public int? MinValue { get; set; }

            /// <summary>
            /// The end time of the recurrence of the scheduled task.
            /// </summary>
            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            /// <summary>
            /// The recurring interval of the scheduled task.
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// The frequency of recurrence of the scheduled task.
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// The ID of the scaling group to which the scheduled task belongs.
            /// </summary>
            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            /// <summary>
            /// The scaling rule of the scheduled task. A value is returned for this parameter only after you specify ScheduledActions.
            /// </summary>
            [NameInMap("ScheduledAction")]
            [Validation(Required=false)]
            public string ScheduledAction { get; set; }

            /// <summary>
            /// The ID of the scheduled task.
            /// </summary>
            [NameInMap("ScheduledTaskId")]
            [Validation(Required=false)]
            public string ScheduledTaskId { get; set; }

            /// <summary>
            /// The name of the scheduled task.
            /// </summary>
            [NameInMap("ScheduledTaskName")]
            [Validation(Required=false)]
            public string ScheduledTaskName { get; set; }

            /// <summary>
            /// Indicates whether the scheduled task is enabled.
            /// 
            /// *   true
            /// *   false
            /// 
            /// Default value: true.
            /// </summary>
            [NameInMap("TaskEnabled")]
            [Validation(Required=false)]
            public bool? TaskEnabled { get; set; }

        }

        /// <summary>
        /// The total number of scheduled tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
