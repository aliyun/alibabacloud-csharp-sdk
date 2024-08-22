// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncTasksRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return input parameters of the asynchronous tasks. Valid values:
        /// 
        /// *   true: returns the `invocationPayload` parameter in the response.
        /// *   false: does not return the `invocationPayload` parameter in the response.
        /// 
        /// >  The `invocationPayload` parameter indicates the input parameters of an asynchronous task.
        /// </summary>
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// The number of asynchronous tasks to return. Valid values: [1,100]. Default value: 50.
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID prefix of asynchronous tasks. If this parameter is specified, a list of asynchronous tasks whose IDs match the prefix is returned.
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// The version or alias of the function.
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// The order in which the returned asynchronous tasks are sorted.
        /// 
        /// *   asc: in ascending order.
        /// *   desc: in descending order.
        /// </summary>
        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        /// <summary>
        /// The start time of the period during which the asynchronous tasks are initiated.
        /// </summary>
        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        /// <summary>
        /// The end time of the period during which the asynchronous tasks are initiated.
        /// </summary>
        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        /// <summary>
        /// The state of asynchronous tasks. The following items list the states of an asynchronous task:
        /// 
        /// *   Enqueued: The asynchronous invocation is enqueued and is waiting to be executed.
        /// *   Succeeded: The invocation is successful.
        /// *   Failed: The invocation fails.
        /// *   Running: The invocation is being executed.
        /// *   Stopped: The invocation is terminated.
        /// *   Stopping: The invocation is being terminated.
        /// *   Invalid: The invocation is invalid and not executed due to specific reasons. For example, the function is deleted.
        /// *   Expired: The maximum validity period of messages is specified for asynchronous invocation. The invocation is discarded and not executed because the specified maximum validity period has elapsed.
        /// *   Retrying: The asynchronous invocation is being retried due to an execution error.
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
