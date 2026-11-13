// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7F333E0-7B70-54DA-A307-4B2B49DEE923</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The task status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>finish: The task is completed. You can query the task to obtain the download URL of the task file.</description></item>
        /// <item><description>start: The task is started.</description></item>
        /// <item><description>error: The task failed.</description></item>
        /// <item><description>expire: The task has expired. The task file is invalid and cannot be downloaded.</description></item>
        /// </list>
        /// <para>Note: This field is returned only under specific conditions, such as when the task is completed synchronously. A standard response returns only RequestId. To query the real-time status, call a task query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The unique identifier of the task. Note: This field is returned only under specific conditions, such as when the task is completed synchronously. A standard response returns only RequestId. To obtain the task status and download URL, call a task query operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The name of the file download task. Note: This field is returned only under specific conditions, such as when the task is completed synchronously. A standard response returns only RequestId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-IPv4</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
