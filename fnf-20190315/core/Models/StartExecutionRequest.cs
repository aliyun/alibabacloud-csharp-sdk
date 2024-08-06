// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StartExecutionRequest : TeaModel {
        /// <summary>
        /// Specifies that the **TaskToken**-related tasks are called back after the execution in the flow ends.
        /// </summary>
        [NameInMap("CallbackFnFTaskToken")]
        [Validation(Required=false)]
        public string CallbackFnFTaskToken { get; set; }

        /// <summary>
        /// The name of the execution. The execution name is unique within a workflow. Configure this parameter based on the following rules:
        /// 
        /// *   The name must start with a letter or an underscore (_).
        /// *   The name can contain letters, digits, underscores (_), and hyphens (-).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// The name of the workflow to be executed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The input of the execution, which is in the JSON format.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

    }

}
