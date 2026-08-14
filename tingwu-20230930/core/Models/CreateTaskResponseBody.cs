// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tingwu20230930.Models
{
    public class CreateTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTaskResponseBodyData Data { get; set; }
        public class CreateTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The stream ingestion URL. Push audio streams to this URL for real-time transcription.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wss://tingwu-realtime-cn-beijing.aliyuncs.com/api/ws/v1?mc=****</para>
            /// </summary>
            [NameInMap("MeetingJoinUrl")]
            [Validation(Required=false)]
            public string MeetingJoinUrl { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c5394c6ee0fb474899d42215a3925c7e</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The custom identifier specified during task creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task_tingwu_123</para>
            /// </summary>
            [NameInMap("TaskKey")]
            [Validation(Required=false)]
            public string TaskKey { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONGOING</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The status message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, used for troubleshooting only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>35124E1C-AE99-5D6C-A52E-BD689D8D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
