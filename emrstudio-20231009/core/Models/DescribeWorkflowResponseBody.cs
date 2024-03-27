// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20231009.Models
{
    public class DescribeWorkflowResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("taskRelations")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTaskRelations> TaskRelations { get; set; }
        public class DescribeWorkflowResponseBodyTaskRelations : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("postTaskId")]
            [Validation(Required=false)]
            public long? PostTaskId { get; set; }

            [NameInMap("postTaskVersion")]
            [Validation(Required=false)]
            public int? PostTaskVersion { get; set; }

            [NameInMap("preTaskId")]
            [Validation(Required=false)]
            public long? PreTaskId { get; set; }

            [NameInMap("preTaskVersion")]
            [Validation(Required=false)]
            public int? PreTaskVersion { get; set; }

        }

        [NameInMap("tasks")]
        [Validation(Required=false)]
        public List<DescribeWorkflowResponseBodyTasks> Tasks { get; set; }
        public class DescribeWorkflowResponseBodyTasks : TeaModel {
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("taskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

    }

}
