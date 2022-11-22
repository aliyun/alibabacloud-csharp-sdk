// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyItems Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            [NameInMap("TaskProgressInfo")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyItemsTaskProgressInfo> TaskProgressInfo { get; set; }
            public class DescribeTasksResponseBodyItemsTaskProgressInfo : TeaModel {
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
                public string Progress { get; set; }

                [NameInMap("ProgressInfo")]
                [Validation(Required=false)]
                public string ProgressInfo { get; set; }

                [NameInMap("Remain")]
                [Validation(Required=false)]
                public int? Remain { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

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

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
