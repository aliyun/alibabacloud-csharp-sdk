// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class DescribeScdnRefreshTasksResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeScdnRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeScdnRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeScdnRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeScdnRefreshTasksResponseBodyTasksTask : TeaModel {
                public string CreationTime { get; set; }
                public string Description { get; set; }
                public string ObjectPath { get; set; }
                public string ObjectType { get; set; }
                public string Process { get; set; }
                public string Status { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
