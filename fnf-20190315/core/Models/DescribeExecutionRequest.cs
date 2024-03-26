// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class DescribeExecutionRequest : TeaModel {
        /// <summary>
        /// The name of the execution, which is unique within a flow. Set this parameter based on the following rules:
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
        /// The name of the flow. The name is unique within the region and cannot be modified after the flow is created. Set this parameter based on the following rules:
        /// 
        /// *   The name can contain letters, digits, underscores (\_), and hyphens (-).
        /// *   The name must start with a letter or an underscore (\_).
        /// *   The name is case-sensitive.
        /// *   The name must be 1 to 128 characters in length.
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
