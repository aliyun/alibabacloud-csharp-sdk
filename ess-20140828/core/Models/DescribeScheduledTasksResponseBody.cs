// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScheduledTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ScheduledTasks")]
        [Validation(Required=false)]
        public DescribeScheduledTasksResponseBodyScheduledTasks ScheduledTasks { get; set; }
        public class DescribeScheduledTasksResponseBodyScheduledTasks : TeaModel {
            [NameInMap("ScheduledTask")]
            [Validation(Required=false)]
            public List<DescribeScheduledTasksResponseBodyScheduledTasksScheduledTask> ScheduledTask { get; set; }
            public class DescribeScheduledTasksResponseBodyScheduledTasksScheduledTask : TeaModel {
                public bool? TaskEnabled { get; set; }
                public string RecurrenceValue { get; set; }
                public string RecurrenceType { get; set; }
                public int? MaxValue { get; set; }
                public string ScheduledTaskName { get; set; }
                public string RecurrenceEndTime { get; set; }
                public int? DesiredCapacity { get; set; }
                public string ScheduledTaskId { get; set; }
                public int? MinValue { get; set; }
                public string ScalingGroupId { get; set; }
                public int? LaunchExpirationTime { get; set; }
                public string Description { get; set; }
                public string ScheduledAction { get; set; }
                public string LaunchTime { get; set; }
            }
        };

    }

}
