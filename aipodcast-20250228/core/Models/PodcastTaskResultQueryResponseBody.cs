// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIPodcast20250228.Models
{
    public class PodcastTaskResultQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;success&quot;</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public PodcastTaskResultQueryResponseBodyData Data { get; set; }
        public class PodcastTaskResultQueryResponseBodyData : TeaModel {
            [NameInMap("extraResult")]
            [Validation(Required=false)]
            public object ExtraResult { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///             &quot;audio&quot;: &quot;<a href="http://note-ai-file.oss-cn-beijing.aliyuncs.com/202503241702148295/audio.mp3?OSSAccessKeyId=LTAI5tPLWJfJHNkZbfnQv245&Expires=1742810788&Signature=b5p83nh443Gr7foqdvgrI4%2FKZVM%3D">http://note-ai-file.oss-cn-beijing.aliyuncs.com/202503241702148295/audio.mp3?OSSAccessKeyId=LTAI5tPLWJfJHNkZbfnQv245&amp;Expires=1742810788&amp;Signature=b5p83nh443Gr7foqdvgrI4%2FKZVM%3D</a>&quot;,
            ///             &quot;script&quot;: &quot;<a href="http://note-ai-file.oss-cn-beijing.aliyuncs.com/202503241702148295/script.txt?OSSAccessKeyId=LTAI5tPLWJfJHNkZbfnQv245&Expires=1742810622&Signature=TBBdikHzOWW3YqDw3sNMTXiMo6A%3D">http://note-ai-file.oss-cn-beijing.aliyuncs.com/202503241702148295/script.txt?OSSAccessKeyId=LTAI5tPLWJfJHNkZbfnQv245&amp;Expires=1742810622&amp;Signature=TBBdikHzOWW3YqDw3sNMTXiMo6A%3D</a>&quot;
            /// }</para>
            /// </summary>
            [NameInMap("resultUrl")]
            [Validation(Required=false)]
            public object ResultUrl { get; set; }

            [NameInMap("script")]
            [Validation(Required=false)]
            public string Script { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>63c4e0eaab3b4c0db208ecafa990e8d1</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCEEDED</para>
            /// </summary>
            [NameInMap("taskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;success&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C38F034D-7F36-531C-95AC-0C752F80E840</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
