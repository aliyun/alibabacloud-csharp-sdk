// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class GetExecutionHistoryRequest : TeaModel {
        /// <summary>
        /// The name of the execution, which is unique within a flow. The name must meet the following conventions:
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
        /// The name of the flow. The name must be unique within the region and cannot be modified after the flow is created. The name must meet the following conventions:
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
        /// The maximum number of steps to be queried. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The name of the event to start the query. You can obtain the value from the response data.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
