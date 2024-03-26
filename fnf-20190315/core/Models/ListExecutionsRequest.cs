// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListExecutionsRequest : TeaModel {
        /// <summary>
        /// The name prefix of the execution.
        /// </summary>
        [NameInMap("ExecutionNamePrefix")]
        [Validation(Required=false)]
        public string ExecutionNamePrefix { get; set; }

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
        /// The maximum number of executions to be queried. Valid values: 1 to 100.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The name of the execution to start the query. You can obtain the value from the response data. You do not need to specify this parameter for the first request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The beginning of the time range to query executions. Specify the value in the UTC RFC3339 format.
        /// </summary>
        [NameInMap("StartedTimeBegin")]
        [Validation(Required=false)]
        public string StartedTimeBegin { get; set; }

        /// <summary>
        /// The end of the time range to query executions. Specify the value in the UTC RFC3339 format.
        /// </summary>
        [NameInMap("StartedTimeEnd")]
        [Validation(Required=false)]
        public string StartedTimeEnd { get; set; }

        /// <summary>
        /// The status of the execution that you want to filter. Valid values:
        /// 
        /// *   **Starting**
        /// *   **Running**
        /// *   **Stopped**
        /// *   **Succeeded**
        /// *   **Failed**
        /// *   **TimedOut**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
