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
        /// <para>The information about the request task. After a request task is submitted, it is divided into multiple subtasks that are run in sequence. After the current subtask is complete, the next subtask starts to run. After all subtasks are complete, the request task is complete. If a request task is aborted due to one of the following issues, address the issue based on the error code and initiate the request task again:</para>
        /// <list type="bullet">
        /// <item><description>The request task fails to be submitted.</description></item>
        /// <item><description>After the request task is submitted, a subtask fails to run.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public UpdateTableAddColumnResponseBodyTaskInfo TaskInfo { get; set; }
        public class UpdateTableAddColumnResponseBodyTaskInfo : TeaModel {
            /// <summary>
            /// <para>The details about the status of the current subtask.</para>
            /// <list type="bullet">
            /// <item><description>If the current subtask is successful, success is returned.</description></item>
            /// <item><description>If the current subtask fails, the error details are displayed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the subtask that you want to run. If this parameter is left empty, all subtasks are complete.</para>
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
            /// <item><description>operating: The subtask is running.</description></item>
            /// <item><description>success: The subtask succeeds.</description></item>
            /// <item><description>failure: The subtask fails to run. For more information about the error details, see the Content parameter.</description></item>
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
            /// <para>abc2</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
