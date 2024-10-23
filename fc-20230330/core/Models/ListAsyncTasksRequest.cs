// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ListAsyncTasksRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return input parameters of the asynchronous tasks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the <c>invocationPayload</c> parameter in the response.</description></item>
        /// <item><description>false: does not return the <c>invocationPayload</c> parameter in the response.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The <c>invocationPayload</c> parameter indicates the input parameters of an asynchronous task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includePayload")]
        [Validation(Required=false)]
        public bool? IncludePayload { get; set; }

        /// <summary>
        /// <para>The number of asynchronous tasks to return. Valid values: [1,100]. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNCNhYmM=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID prefix of asynchronous tasks. If this parameter is specified, a list of asynchronous tasks whose IDs match the prefix is returned.</para>
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
        /// <para>The order in which the returned asynchronous tasks are sorted.</para>
        /// <list type="bullet">
        /// <item><description>asc: in ascending order.</description></item>
        /// <item><description>desc: in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("sortOrderByTime")]
        [Validation(Required=false)]
        public string SortOrderByTime { get; set; }

        /// <summary>
        /// <para>The start time of the period during which the asynchronous tasks are initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966400000</para>
        /// </summary>
        [NameInMap("startedTimeBegin")]
        [Validation(Required=false)]
        public long? StartedTimeBegin { get; set; }

        /// <summary>
        /// <para>The end time of the period during which the asynchronous tasks are initiated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640966400000</para>
        /// </summary>
        [NameInMap("startedTimeEnd")]
        [Validation(Required=false)]
        public long? StartedTimeEnd { get; set; }

        /// <summary>
        /// <para>The state of asynchronous tasks. The following items list the states of an asynchronous task:</para>
        /// <list type="bullet">
        /// <item><description>Enqueued: The asynchronous invocation is enqueued and is waiting to be executed.</description></item>
        /// <item><description>Succeeded: The invocation is successful.</description></item>
        /// <item><description>Failed: The invocation fails.</description></item>
        /// <item><description>Running: The invocation is being executed.</description></item>
        /// <item><description>Stopped: The invocation is terminated.</description></item>
        /// <item><description>Stopping: The invocation is being terminated.</description></item>
        /// <item><description>Invalid: The invocation is invalid and not executed due to specific reasons. For example, the function is deleted.</description></item>
        /// <item><description>Expired: The maximum validity period of messages is specified for asynchronous invocation. The invocation is discarded and not executed because the specified maximum validity period has elapsed.</description></item>
        /// <item><description>Retrying: The asynchronous invocation is being retried due to an execution error.</description></item>
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
