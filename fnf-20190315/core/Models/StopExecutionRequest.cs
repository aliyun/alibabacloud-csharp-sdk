// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class StopExecutionRequest : TeaModel {
        /// <summary>
        /// The reason for stopping the execution. The value must be 1 to 4,096 characters in length.
        /// </summary>
        [NameInMap("Cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// The error for stopping the execution. The value must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("Error")]
        [Validation(Required=false)]
        public string Error { get; set; }

        /// <summary>
        /// The name of the execution that you want to stop. You can call the **ListExecutions** operation to obtain the value of this parameter. The name is unique in a flow. Set this parameter based on the following rules:
        /// 
        /// *   The name can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (\_).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// The name of the flow in which that you want to stop the execution. You can call the **ListFlows** operation to obtain the value of this parameter. The name is unique within the same region and cannot be modified after the flow is created. Set this parameter based on the following rules:
        /// 
        /// *   The name can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (\_).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

    }

}
