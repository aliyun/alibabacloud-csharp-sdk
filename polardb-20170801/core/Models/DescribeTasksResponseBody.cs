// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeTasksResponseBodyTasksTask : TeaModel {
                [NameInMap("BeginTime")]
                [Validation(Required=false)]
                public string BeginTime { get; set; }

                [NameInMap("CurrentStepName")]
                [Validation(Required=false)]
                public string CurrentStepName { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("ExpectedFinishTime")]
                [Validation(Required=false)]
                public string ExpectedFinishTime { get; set; }

                [NameInMap("FinishTime")]
                [Validation(Required=false)]
                public string FinishTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                [NameInMap("StepProgressInfo")]
                [Validation(Required=false)]
                public string StepProgressInfo { get; set; }

                [NameInMap("StepsInfo")]
                [Validation(Required=false)]
                public string StepsInfo { get; set; }

                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

                [NameInMap("TaskErrorCode")]
                [Validation(Required=false)]
                public string TaskErrorCode { get; set; }

                [NameInMap("TaskErrorMessage")]
                [Validation(Required=false)]
                public string TaskErrorMessage { get; set; }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
