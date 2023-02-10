// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeOnceTaskResponseBody : TeaModel {
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeOnceTaskResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeOnceTaskResponseBodyPageInfo : TeaModel {
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskManageResponseList")]
        [Validation(Required=false)]
        public List<DescribeOnceTaskResponseBodyTaskManageResponseList> TaskManageResponseList { get; set; }
        public class DescribeOnceTaskResponseBodyTaskManageResponseList : TeaModel {
            [NameInMap("DetailData")]
            [Validation(Required=false)]
            public string DetailData { get; set; }

            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            [NameInMap("ResultInfo")]
            [Validation(Required=false)]
            public string ResultInfo { get; set; }

            [NameInMap("SuccessCount")]
            [Validation(Required=false)]
            public int? SuccessCount { get; set; }

            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public long? TaskEndTime { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public long? TaskStartTime { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskStatusText")]
            [Validation(Required=false)]
            public string TaskStatusText { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

    }

}
