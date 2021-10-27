// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public DescribeDrdsTasksResponseBodyTasks Tasks { get; set; }
        public class DescribeDrdsTasksResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<DescribeDrdsTasksResponseBodyTasksTask> Task { get; set; }
            public class DescribeDrdsTasksResponseBodyTasksTask : TeaModel {
                public string Content { get; set; }
                public long? Id { get; set; }
                public string State { get; set; }
            }
        };

    }

}
