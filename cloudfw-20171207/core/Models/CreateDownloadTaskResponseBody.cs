// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class CreateDownloadTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
        /// <item><description><para>finish: The task is completed. You can call a task query operation to obtain the download URL of the task file.</para>
        /// </description></item>
        /// <item><description><para>start: The task has started.</para>
        /// </description></item>
        /// <item><description><para>error: The task failed.</para>
        /// </description></item>
        /// <item><description><para>expire: The task has expired. The task file is no longer valid and cannot be downloaded.</para>
        /// </description></item>
        /// </list>
        /// <para>This field is returned only under specific conditions, such as when the task is completed synchronously. In regular responses, only RequestId is returned. Use a task query operation to obtain the real-time status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>start</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task ID, which uniquely identifies the task. This field is returned only under specific conditions, such as when the task is completed synchronously. In regular responses, only RequestId is returned. Use a task query operation to obtain the task status and download URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The name of the file download task. This field is returned only under specific conditions, such as when the task is completed synchronously. In regular responses, only RequestId is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-IPv4</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
