// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeTasksResponseBodyItems Items { get; set; }
        public class DescribeTasksResponseBodyItems : TeaModel {
            [NameInMap("TaskProgressInfo")]
            [Validation(Required=false)]
            public List<DescribeTasksResponseBodyItemsTaskProgressInfo> TaskProgressInfo { get; set; }
            public class DescribeTasksResponseBodyItemsTaskProgressInfo : TeaModel {
                public string Status { get; set; }
                public string FinishTime { get; set; }
                public string Progress { get; set; }
                public string StepsInfo { get; set; }
                public string BeginTime { get; set; }
                public string ExpectedFinishTime { get; set; }
                public string TaskErrorCode { get; set; }
                public string CurrentStepName { get; set; }
                public string ProgressInfo { get; set; }
                public string StepProgressInfo { get; set; }
                public string TaskErrorMessage { get; set; }
                public string TaskAction { get; set; }
                public int? Remain { get; set; }
                public string DBName { get; set; }
                public string TaskId { get; set; }
            }
        };

    }

}
