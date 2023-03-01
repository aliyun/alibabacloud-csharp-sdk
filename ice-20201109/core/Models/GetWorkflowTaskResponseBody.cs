// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetWorkflowTaskResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkflowTask")]
        [Validation(Required=false)]
        public GetWorkflowTaskResponseBodyWorkflowTask WorkflowTask { get; set; }
        public class GetWorkflowTaskResponseBodyWorkflowTask : TeaModel {
            [NameInMap("ActivityResults")]
            [Validation(Required=false)]
            public string ActivityResults { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskInput")]
            [Validation(Required=false)]
            public string TaskInput { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            [NameInMap("Workflow")]
            [Validation(Required=false)]
            public GetWorkflowTaskResponseBodyWorkflowTaskWorkflow Workflow { get; set; }
            public class GetWorkflowTaskResponseBodyWorkflowTaskWorkflow : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("WorkflowId")]
                [Validation(Required=false)]
                public string WorkflowId { get; set; }

            }

        }

    }

}
