// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcdef</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the request task. After a request task is submitted, it is divided into multiple subtasks that are executed in sequence. The next subtask is executed only after the current subtask is executed. The request task ends when all subtasks are completed.</para>
        /// <para>The request task is terminated in the following scenarios. You must troubleshoot the issue based on the error code and resubmit the request task:</para>
        /// <list type="bullet">
        /// <item><description>The request task fails to be submitted.</description></item>
        /// <item><description>A subtask fails to be executed after the request task is submitted.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public CreateTableResponseBodyTaskInfo TaskInfo { get; set; }
        public class CreateTableResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The detailed execution status of the current subtask. Details:</para>
            /// <list type="bullet">
            /// <item><description>If the execution is successful, success is displayed.</description></item>
            /// <item><description>If the execution fails, the corresponding error details are displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the next subtask to be executed. If this parameter is empty, all subtasks are completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc1</para>
            /// </summary>
            [NameInMap("NextTaskId")]
            [Validation(Required=false)]
            public string NextTaskId { get; set; }

            /// <summary>
            /// <para>The status of the current subtask. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>operating: The subtask is being executed.</description></item>
            /// <item><description>success: The subtask is executed successfully.</description></item>
            /// <item><description>failure: The subtask fails to be executed. For more information about the error details, see the Content parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the current subtask.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
