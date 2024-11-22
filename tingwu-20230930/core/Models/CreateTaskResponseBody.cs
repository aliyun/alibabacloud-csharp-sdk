// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTaskResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTaskResponseBodyData Data { get; set; }
        public class CreateTaskResponseBodyData : TeaModel {
            [NameInMap("MeetingJoinUrl")]
            [Validation(Required=false)]
            public string MeetingJoinUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>c5394c6ee0fb474899d42215a3925c7e</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>35124E1C-AE99-5D6C-A52E-BD689D8D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
