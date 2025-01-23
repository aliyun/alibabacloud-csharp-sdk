// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScreenshotResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3AF82CE1-2801-52CE-BF64-B491DD7C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public List<CreateScreenshotResponseBodyTasks> Tasks { get; set; }
        public class CreateScreenshotResponseBodyTasks : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>acp-bwhtebzah2fse****</para>
            /// </summary>
            [NameInMap("AndroidInstanceId")]
            [Validation(Required=false)]
            public string AndroidInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>t-imr0fufqd7cle****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

    }

}
