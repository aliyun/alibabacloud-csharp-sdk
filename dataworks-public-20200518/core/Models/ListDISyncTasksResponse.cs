// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListDISyncTasksResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=true)]
        public ListDISyncTasksResponseTaskList TaskList { get; set; }
        public class ListDISyncTasksResponseTaskList : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("RealTimeSolutionList")]
            [Validation(Required=true)]
            public List<ListDISyncTasksResponseTaskListRealTimeSolutionList> RealTimeSolutionList { get; set; }
            public class ListDISyncTasksResponseTaskListRealTimeSolutionList : TeaModel {
                public long? ProcessId { get; set; }
                public string ProcessName { get; set; }
                public string TaskStatus { get; set; }
                public string TaskType { get; set; }
                public long? CreateTime { get; set; }
            }
        };

    }

}
