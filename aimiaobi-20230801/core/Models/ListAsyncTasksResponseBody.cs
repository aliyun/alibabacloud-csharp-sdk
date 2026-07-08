// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAsyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAsyncTasksResponseBodyData> Data { get; set; }
        public class ListAsyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-12-23 15:41:58</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The creator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <para>The primary key ID of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The task identifier, which specifies the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaterialDocumentUpload</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <para>The optional task definition configuration in JSON format. These parameters overwrite the system\&quot;s default configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskDefinition")]
            [Validation(Required=false)]
            public string TaskDefinition { get; set; }

            /// <summary>
            /// <para>The actual end time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-09 00:00:00</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public string TaskEndTime { get; set; }

            /// <summary>
            /// <para>The error message from the task execution for the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>系统内部错误</para>
            /// </summary>
            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <para>The time when the task is scheduled to run. The system polls only for tasks that are due. If this parameter is empty, the task runs immediately.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-14 14:30:00</para>
            /// </summary>
            [NameInMap("TaskExecuteTime")]
            [Validation(Required=false)]
            public string TaskExecuteTime { get; set; }

            /// <summary>
            /// <para>The unique task ID. It is equivalent to the Id parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The internal error message from the task execution. Sensitive information, such as exception stacks and internal thread stacks, is recorded here.</para>
            /// 
            /// <b>Example:</b>
            /// <para>系统错误</para>
            /// </summary>
            [NameInMap("TaskInnerErrorMessage")]
            [Validation(Required=false)]
            public string TaskInnerErrorMessage { get; set; }

            /// <summary>
            /// <para>The intermediate result of the task execution. If a task consists of multiple steps, the output of each step can be saved here. When the task resumes from a paused state, it can read this intermediate result and continue execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskIntermediateResult")]
            [Validation(Required=false)]
            public string TaskIntermediateResult { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务名</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The input parameters for the task execution, in JSON format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskParam")]
            [Validation(Required=false)]
            public string TaskParam { get; set; }

            /// <summary>
            /// <para>The progress information of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskProgressMessage")]
            [Validation(Required=false)]
            public string TaskProgressMessage { get; set; }

            /// <summary>
            /// <para>The result information of the task execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <para>The number of times the task has been retried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskRetryCount")]
            [Validation(Required=false)]
            public string TaskRetryCount { get; set; }

            /// <summary>
            /// <para>The actual start time of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-20 10:53:00</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

            /// <summary>
            /// <para>The execution status of the task. Valid values: 0 (Pending), 1 (Running), 2 (Succeeded), 3 (Paused), 4 (Failed and retriable), 5 (Failed and not retriable), 6 (Canceled).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The task categories. Multiple categories are separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The update date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-16 10:29:16</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The user who performed the update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>428DCC0D-3C63-5306-BD1B-124396AB97BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. true: The request was successful. false: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
