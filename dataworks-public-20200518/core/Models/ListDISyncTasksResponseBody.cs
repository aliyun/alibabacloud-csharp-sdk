// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDISyncTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public ListDISyncTasksResponseBodyTaskList TaskList { get; set; }
        public class ListDISyncTasksResponseBodyTaskList : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("RealTimeSolutionList")]
            [Validation(Required=false)]
            public List<ListDISyncTasksResponseBodyTaskListRealTimeSolutionList> RealTimeSolutionList { get; set; }
            public class ListDISyncTasksResponseBodyTaskListRealTimeSolutionList : TeaModel {
                public long? CreateTime { get; set; }
                public long? ProcessId { get; set; }
                public string ProcessName { get; set; }
                public string TaskStatus { get; set; }
                public string TaskType { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

    }

}
