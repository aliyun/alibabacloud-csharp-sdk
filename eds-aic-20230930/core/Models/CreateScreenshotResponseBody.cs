// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScreenshotResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID of the request. If you encounter an issue, provide this request ID for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AF82CE1-2801-52CE-BF64-B491DD7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<CreateScreenshotResponseBodyTasks> Tasks { get; set; }
        public class CreateScreenshotResponseBodyTasks : TeaModel {
            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acp-bwhtebzah2fse****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <para>The screenshot ID. The generated screenshot is named &quot;ScreenshotId_AndroidInstanceId.png.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>image</para>
            /// </summary>
            [NameInMap("ScreenshotId")]
            [Validation(Required=false)]
            public string ScreenshotId { get; set; }

            /// <summary>
            /// <para>The task ID. You can use this ID to call the DescribeTasks operation and query the screenshot task. When the task is complete, you can get the download link for the screenshot.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
