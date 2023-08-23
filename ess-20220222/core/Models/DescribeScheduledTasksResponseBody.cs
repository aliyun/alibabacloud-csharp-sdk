// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScheduledTasksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduledTasks")]
        [Validation(Required=false)]
        public List<DescribeScheduledTasksResponseBodyScheduledTasks> ScheduledTasks { get; set; }
        public class DescribeScheduledTasksResponseBodyScheduledTasks : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DesiredCapacity")]
            [Validation(Required=false)]
            public int? DesiredCapacity { get; set; }

            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            [NameInMap("MaxValue")]
            [Validation(Required=false)]
            public int? MaxValue { get; set; }

            [NameInMap("MinValue")]
            [Validation(Required=false)]
            public int? MinValue { get; set; }

            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            [NameInMap("ScheduledAction")]
            [Validation(Required=false)]
            public string ScheduledAction { get; set; }

            [NameInMap("ScheduledTaskId")]
            [Validation(Required=false)]
            public string ScheduledTaskId { get; set; }

            [NameInMap("ScheduledTaskName")]
            [Validation(Required=false)]
            public string ScheduledTaskName { get; set; }

            [NameInMap("TaskEnabled")]
            [Validation(Required=false)]
            public bool? TaskEnabled { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
