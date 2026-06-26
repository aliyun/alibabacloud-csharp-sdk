// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the input parameters of the asynchronous task.</para>
        /// <list type="bullet">
        /// <item><description><para>true: If this parameter is set to true, the <c>invocationPayload</c> field is returned.</para>
        /// </description></item>
        /// <item><description><para>false: If this parameter is set to false, the <c>invocationPayload</c> field is not returned.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The <c>invocationPayload</c> field specifies the input parameters of the function for the asynchronous task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// <para>The number of asynchronous tasks to return. The default value is 20. The value must be in the range of [1, 100].</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token to return more results. You do not need to provide this parameter for the first query. Obtain the token for a subsequent query from the response to the previous query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNCNhYmM=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The prefix of the asynchronous task ID. The system returns a list of asynchronous tasks that match the prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-</para>
        /// </summary>
        [NameInMap("prefix")]
        [Validation(Required=false)]
        public string Prefix { get; set; }

        /// <summary>
        /// <para>The version or alias of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LATEST</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The sorting order of the returned asynchronous tasks.</para>
        /// <list type="bullet">
        /// <item><description><para>asc: ascending order</para>
        /// </description></item>
        /// <item><description><para>desc: descending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        /// <summary>
        /// <para>The start of the time range when the asynchronous task was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966400000</para>
        /// </summary>
        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        /// <summary>
        /// <para>The end of the time range when the asynchronous task was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966400000</para>
        /// </summary>
        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        /// <summary>
        /// <para>The execution status of the asynchronous task.</para>
        /// <list type="bullet">
        /// <item><description><para>Enqueued: The asynchronous message is enqueued and waits for processing.</para>
        /// </description></item>
        /// <item><description><para>Dequeued: The asynchronous message is dequeued and waits to be triggered.</para>
        /// </description></item>
        /// <item><description><para>Running: The invocation is in progress.</para>
        /// </description></item>
        /// <item><description><para>Succeeded: The invocation succeeded.</para>
        /// </description></item>
        /// <item><description><para>Failed: The invocation failed.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The invocation was stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The invocation is being stopped.</para>
        /// </description></item>
        /// <item><description><para>Expired: The task was discarded because its configured maximum queuing duration was exceeded. The task was not executed.</para>
        /// </description></item>
        /// <item><description><para>Invalid: The execution is invalid because the function was deleted or for other reasons. The task was not executed.</para>
        /// </description></item>
        /// <item><description><para>Retrying: The asynchronous invocation is being retried because of an execution error.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
