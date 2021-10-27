// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsInstanceLevelTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsInstanceLevelTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsInstanceLevelTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsInstanceLevelTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsInstanceLevelTasksResponseBodyTasksTask : TeaModel {
                public bool? AllowCancel { get; set; }
                public string ErrMsg { get; set; }
                public long? GmtCreate { get; set; }
                public int? Progress { get; set; }
                public string ProgressDescription { get; set; }
                public bool? ShowProgress { get; set; }
                public long? TargetId { get; set; }
                public string TaskName { get; set; }
                public string TaskPhase { get; set; }
                public int? TaskStatus { get; set; }
                public int? TaskType { get; set; }
            }
        };

    }

}
