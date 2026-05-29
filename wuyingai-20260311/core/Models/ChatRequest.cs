// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Bearer%20eyJhb****...****k</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;Role&quot;:&quot;user&quot;,&quot;Content&quot;:[{&quot;Type&quot;:&quot;text&quot;,&quot;Text&quot;:&quot;你好&quot;}]}]</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public List<ChatRequestInput> Input { get; set; }
        public class ChatRequestInput : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ChatRequestInputContent> Content { get; set; }
            public class ChatRequestInputContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/workspace/report.pdf</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example.com/img.jpg">https://example.com/img.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>帮我分析这张图片</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("RoutingKey")]
        [Validation(Required=false)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-session-001</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;OutputFileMode&quot;: &quot;url&quot;}</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public ChatRequestSettings Settings { get; set; }
        public class ChatRequestSettings : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>base64</para>
            /// </summary>
            [NameInMap("OutputFileMode")]
            [Validation(Required=false)]
            public string OutputFileMode { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;IncludeReasoning&quot;: false, &quot;IncludeToolCalls&quot;: false}</para>
        /// </summary>
        [NameInMap("StreamOptions")]
        [Validation(Required=false)]
        public ChatRequestStreamOptions StreamOptions { get; set; }
        public class ChatRequestStreamOptions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeReasoning")]
            [Validation(Required=false)]
            public bool? IncludeReasoning { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeToolCalls")]
            [Validation(Required=false)]
            public bool? IncludeToolCalls { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>template-abc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
