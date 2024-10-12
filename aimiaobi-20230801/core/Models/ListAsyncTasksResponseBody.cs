// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class ListAsyncTasksResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Current")]
        [Validation(Required=false)]
        public int? Current { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAsyncTasksResponseBodyData> Data { get; set; }
        public class ListAsyncTasksResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2020-12-23 15:41:58</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MaterialDocumentUpload</para>
            /// </summary>
            [NameInMap("TaskCode")]
            [Validation(Required=false)]
            public string TaskCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskDefinition")]
            [Validation(Required=false)]
            public string TaskDefinition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-09 00:00:00</para>
            /// </summary>
            [NameInMap("TaskEndTime")]
            [Validation(Required=false)]
            public string TaskEndTime { get; set; }

            [NameInMap("TaskErrorMessage")]
            [Validation(Required=false)]
            public string TaskErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-10-14 14:30:00</para>
            /// </summary>
            [NameInMap("TaskExecuteTime")]
            [Validation(Required=false)]
            public string TaskExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3f7045e099474ba28ceca1b4eb6d6e21</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskInnerErrorMessage")]
            [Validation(Required=false)]
            public string TaskInnerErrorMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskIntermediateResult")]
            [Validation(Required=false)]
            public string TaskIntermediateResult { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskParam")]
            [Validation(Required=false)]
            public string TaskParam { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskProgressMessage")]
            [Validation(Required=false)]
            public string TaskProgressMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("TaskResult")]
            [Validation(Required=false)]
            public string TaskResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskRetryCount")]
            [Validation(Required=false)]
            public string TaskRetryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-20 10:53:00</para>
            /// </summary>
            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-02-16 10:29:16</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>111</para>
            /// </summary>
            [NameInMap("UpdateUser")]
            [Validation(Required=false)]
            public string UpdateUser { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>428DCC0D-3C63-5306-BD1B-124396AB97BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
