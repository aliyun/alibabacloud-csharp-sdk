// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListTasksInTaskFlowResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public ListTasksInTaskFlowResponseBodyTasks Tasks { get; set; }
        public class ListTasksInTaskFlowResponseBodyTasks : TeaModel {
            [NameInMap("Task")]
            [Validation(Required=false)]
            public List<ListTasksInTaskFlowResponseBodyTasksTask> Task { get; set; }
            public class ListTasksInTaskFlowResponseBodyTasksTask : TeaModel {
                [NameInMap("GraphParam")]
                [Validation(Required=false)]
                public string GraphParam { get; set; }

                [NameInMap("NodeConfig")]
                [Validation(Required=false)]
                public string NodeConfig { get; set; }

                [NameInMap("NodeContent")]
                [Validation(Required=false)]
                public string NodeContent { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("NodeOutput")]
                [Validation(Required=false)]
                public string NodeOutput { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("TimeVariables")]
                [Validation(Required=false)]
                public string TimeVariables { get; set; }

            }

        }

    }

}
