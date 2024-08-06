// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeExecutionRequest : TeaModel {
        /// <summary>
        /// The name of the execution.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ExecutionName")]
        [Validation(Required=false)]
        public string ExecutionName { get; set; }

        /// <summary>
        /// The name of the workflow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The maximum period of time for long polling waits. Valid values: 0 to 60. Unit: seconds. Configure this parameter based on the following rules:
        /// 
        /// *   If the value is 0, the system immediately returns the current execution status.
        /// *   If the value is greater than 0, the long polling request waits until the execution ends or the specified period elapses.
        /// </summary>
        [NameInMap("WaitTimeSeconds")]
        [Validation(Required=false)]
        public int? WaitTimeSeconds { get; set; }

    }

}
