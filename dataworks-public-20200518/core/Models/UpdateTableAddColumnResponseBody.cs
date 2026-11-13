// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateTableAddColumnResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request task information. After a request task is submitted, it is divided into multiple subtasks that are executed in sequence. The next subtask is executed only after the current subtask succeeds. The request task ends when all subtasks are completed. The request task is terminated in the following scenarios. You must troubleshoot the issue based on the error code and resubmit the request task:</para>
        /// <list type="bullet">
        /// <item><description>The request task fails to be submitted.</description></item>
        /// <item><description>Any subtask fails after the request task is successfully submitted.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public UpdateTableAddColumnResponseBodyTaskInfo TaskInfo { get; set; }
        public class UpdateTableAddColumnResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The detailed execution status of the current subtask. Details:</para>
            /// <list type="bullet">
            /// <item><description>If the execution succeeds, success is displayed.</description></item>
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
            /// <para>The ID of the next subtask to be executed. If this field is empty, it indicates that all subtasks are completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc1</para>
            /// </summary>
            [NameInMap("NextTaskId")]
            [Validation(Required=false)]
            public string NextTaskId { get; set; }

            /// <summary>
            /// <para>The status of the subtask that is being executed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>operating: The subtask is being executed.</description></item>
            /// <item><description>success: The subtask is executed successfully.</description></item>
            /// <item><description>failure: The subtask failed. For more information about the error details, see the Content parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the subtask that is being executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc2</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
