// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class ListStatefulAsyncInvocationsRequest : TeaModel {
        /// <summary>
        /// - **true**: returns the invocationPayload parameter in the response. 
        /// - **false**: does not return the invocationPayload parameter in the response. 
        /// 
        /// > The `invocationPayload` parameter indicates the input parameters of an asynchronous task.
        /// </summary>
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// The name prefix of the asynchronous invocation. The names of returned resources must contain the prefix. For example, if invocationidPrefix is set to job, the names of returned resources must start with job.
        /// </summary>
        [NameInMap("invocationIdPrefix")]
        [Validation(Required=false)]
        public string InvocationIdPrefix { get; set; }

        /// <summary>
        /// The maximum number of asynchronous invocations to return. Valid values: [1, 100]. Default value: 50.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token used to obtain more results. If the number of resources exceeds the limit, the nextToken parameter is returned. You can include the parameter in subsequent calls to obtain more results. You do not need to provide this parameter in the first call.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The version or alias of the service to which the asynchronous task belongs.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// The order in which the returned asynchronous invocations are sorted. Valid values:
        /// 
        /// - **asc**: in ascending order 
        /// - **desc**: in descending order
        /// </summary>
        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        /// <summary>
        /// The start time of the asynchronous task.
        /// </summary>
        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        /// <summary>
        /// The end time of the asynchronous task.
        /// </summary>
        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        /// <summary>
        /// The status of the asynchronous task. 
        /// 
        /// - **Enqueued**: The asynchronous invocation is enqueued and is waiting to be executed. 
        /// - **Succeeded**: The invocation is successful. 
        /// - **Failed**: The invocation fails. 
        /// - **Running**: The invocation is being executed. 
        /// - **Stopped**: The invocation is terminated. 
        /// - **Stopping**: The invocation is being terminated. 
        /// - **Invalid**: The invocation is invalid and not executed due to specific reasons. For example, the function is deleted. 
        /// - **Expired**: The maximum validity period of messages is specified for asynchronous invocation. The invocation is discarded and not executed because the specified maximum validity period of messages expires. 
        /// - **Retrying**: The asynchronous invocation is being retried due to an execution error.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
