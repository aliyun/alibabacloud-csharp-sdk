// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class GetWorkflowStatusResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetWorkflowStatusResponseBodyData Data { get; set; }
        public class GetWorkflowStatusResponseBodyData : TeaModel {
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("stepStatus")]
            [Validation(Required=false)]
            public List<GetWorkflowStatusResponseBodyDataStepStatus> StepStatus { get; set; }
            public class GetWorkflowStatusResponseBodyDataStepStatus : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("workflowTasks")]
                [Validation(Required=false)]
                public List<GetWorkflowStatusResponseBodyDataStepStatusWorkflowTasks> WorkflowTasks { get; set; }
                public class GetWorkflowStatusResponseBodyDataStepStatusWorkflowTasks : TeaModel {
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

        }

        [NameInMap("msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

    }

}
