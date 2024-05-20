// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class CreateWorkflowResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateWorkflowResponseBodyData Data { get; set; }
        public class CreateWorkflowResponseBodyData : TeaModel {
            [NameInMap("workflowId")]
            [Validation(Required=false)]
            public string WorkflowId { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
