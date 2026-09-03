// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260622.Models
{
    public class GetSessionContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The conversation text content.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public List<GetSessionContentResponseBodyContent> Content { get; set; }
        public class GetSessionContentResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The detailed conversation content.</para>
            /// </summary>
            [NameInMap("agentContents")]
            [Validation(Required=false)]
            public List<GetSessionContentResponseBodyContentAgentContents> AgentContents { get; set; }
            public class GetSessionContentResponseBodyContentAgentContents : TeaModel {
                /// <summary>
                /// <para>The detailed conversation chunk content. All chunks compose the complete response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;id\&quot;:\&quot;16aa7737-9e6a-4500-abd2-96c5f17d1188\&quot;,\&quot;object\&quot;:\&quot;chat.completion.chunk\&quot;,\&quot;created\&quot;:1788408524,\&quot;model\&quot;:\&quot;oss-agent\&quot;,\&quot;choices\&quot;:[{\&quot;index\&quot;:0,\&quot;delta\&quot;:{\&quot;role\&quot;:\&quot;assistant\&quot;,\&quot;content\&quot;:\&quot;，Hello， I am OSS Agent\&quot;}}]}</para>
                /// </summary>
                [NameInMap("agentContent")]
                [Validation(Required=false)]
                public string AgentContent { get; set; }

                /// <summary>
                /// <para>The time when the content was generated, in the yyyy-MM-dd HH:mm:ss,SSS format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1774577589</para>
                /// </summary>
                [NameInMap("timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The time when the session occurred, in the yyyy-MM-dd HH:mm:ss,SSS format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-03 04:08:30,637</para>
            /// </summary>
            [NameInMap("timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>Indicates whether tool confirmation is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("toolConfirm")]
            [Validation(Required=false)]
            public bool? ToolConfirm { get; set; }

            /// <summary>
            /// <para>The user content of the first message in the session.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;role\&quot;:\&quot;user\&quot;,\&quot;content\&quot;:\&quot;Hi OSS\&quot;}]</para>
            /// </summary>
            [NameInMap("userContent")]
            [Validation(Required=false)]
            public string UserContent { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UUID</para>
        /// </summary>
        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

    }

}
