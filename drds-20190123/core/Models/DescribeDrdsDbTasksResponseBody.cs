// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsDbTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsDbTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsDbTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsDbTasksResponseBodyTasksTask : TeaModel {
                public bool? AllowCancel { get; set; }
                public int? DbComputeLength { get; set; }
                public string DetailTaskId { get; set; }
                public string ExpandType { get; set; }
                public long? GmtCreate { get; set; }
                public string Label { get; set; }
                public string ParentJobId { get; set; }
                public int? Progress { get; set; }
                public bool? ShowProgress { get; set; }
                public long? TargetId { get; set; }
                public string TaskDetail { get; set; }
                public string TaskName { get; set; }
                public string TaskPhase { get; set; }
                public int? TaskStatus { get; set; }
                public int? TaskType { get; set; }
                public int? TbComputeLength { get; set; }
            }
        };

    }

}
