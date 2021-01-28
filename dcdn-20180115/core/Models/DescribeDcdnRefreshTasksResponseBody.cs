// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnRefreshTasksResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDcdnRefreshTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDcdnRefreshTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDcdnRefreshTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDcdnRefreshTasksResponseBodyTasksTask : TeaModel {
                public string Status { get; set; }
                public string CreationTime { get; set; }
                public string ObjectType { get; set; }
                public string Process { get; set; }
                public string Description { get; set; }
                public string ObjectPath { get; set; }
                public string TaskId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
