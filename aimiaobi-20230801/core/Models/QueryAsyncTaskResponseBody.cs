// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class QueryAsyncTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Business data</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryAsyncTaskResponseBodyData Data { get; set; }
        public class QueryAsyncTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Creation date</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-25 14:34:33</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Creator</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;12121&quot;</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>Task ID, indicates the specific task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaterialDocumentUpload</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <para>Task execution error message</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <para>Unique task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Intermediate task execution result. When a task has multiple steps, save the output of each step here. When resuming from a pause, read the intermediate result and continue from there.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{}&quot;</para>
            /// </summary>
            [NameInMap("TaskIntermediateResult")]
            [Validation(Required=false)]
            public string TaskIntermediateResult { get; set; }

            /// <summary>
            /// <para>Task name</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务名称</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>Task execution input parameters, JSON format</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;fileKey\&quot;:\&quot;oss://default/xxxx/xxxx/xxx\&quot;,\&quot;fileName\&quot;:\&quot;xxxxx.doc\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("TaskParam")]
            [Validation(Required=false)]
            public string TaskParam { get; set; }

            /// <summary>
            /// <para>Task execution progress message</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{}&quot;</para>
            /// </summary>
            [NameInMap("TaskProgressMessage")]
            [Validation(Required=false)]
            public string TaskProgressMessage { get; set; }

            /// <summary>
            /// <para>Task execution result message</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{}&quot;</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <para>Number of task retries</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;3&quot;</para>
            /// </summary>
            [NameInMap("TaskRetryCount")]
            [Validation(Required=false)]
            public string TaskRetryCount { get; set; }

            /// <summary>
            /// <para>Task execution status: 0-Pending, 1-Executing, 2-Execution successful, 3-Paused, 4-Execution failed (retryable), 5-Execution failed (not retryable), 6-Task canceled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>Update date</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-27 18:07:43</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>Updater</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;12121&quot;</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error description</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Unique request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>867C4ABE-4381-5BC2-9810-5A5F334F71CF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Success status: true for success, false for failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
