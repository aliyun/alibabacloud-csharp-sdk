// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WuyingAI20260311.Models
{
    public class ChatRequest : TeaModel {
        /// <summary>
        /// <para>Bearer + JWT returned by GetAccessToken. URL-encode the entire string and pass it as a query parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bearer%20eyJhb****...****k</para>
        /// </summary>
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public string Authorization { get; set; }

        /// <summary>
        /// <para>The user ID from the external system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-user</para>
        /// </summary>
        [NameInMap("ExternalUserId")]
        [Validation(Required=false)]
        public string ExternalUserId { get; set; }

        /// <summary>
        /// <para>The message list (JSON string), sorted in chronological order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Role&quot;:&quot;user&quot;,&quot;Content&quot;:[{&quot;Type&quot;:&quot;text&quot;,&quot;Text&quot;:&quot;你好&quot;}]}]</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public List<ChatRequestInput> Input { get; set; }
        public class ChatRequestInput : TeaModel {
            /// <summary>
            /// <para>The content block list.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ChatRequestInputContent> Content { get; set; }
            public class ChatRequestInputContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>report.pdf</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The file path or URL (Type=file).</para>
                /// 
                /// <b>Example:</b>
                /// <para>/workspace/report.pdf</para>
                /// </summary>
                [NameInMap("FileUrl")]
                [Validation(Required=false)]
                public string FileUrl { get; set; }

                /// <summary>
                /// <para>The image URL or Base64-encoded string (Type=image).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/img.jpg">https://example.com/img.jpg</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The text content (Type=text).</para>
                /// 
                /// <b>Example:</b>
                /// <para>帮我分析这张图片</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The content type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("Resume")]
        [Validation(Required=false)]
        public bool? Resume { get; set; }

        /// <summary>
        /// <para>The routing key that specifies the backend instance to process the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("RoutingKey")]
        [Validation(Required=false)]
        public string RoutingKey { get; set; }

        /// <summary>
        /// <para>The session ID for multi-turn conversation context persistence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-session-001</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The additional settings. Contains the output file mode control parameter OutputFileMode (string, valid values: url or base64. Defaults to base64 for legacy compatibility. We recommend url).</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OutputFileMode&quot;: &quot;url&quot;}</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public ChatRequestSettings Settings { get; set; }
        public class ChatRequestSettings : TeaModel {
            /// <summary>
            /// <para>Controls the file output mode. Valid values: url or base64. If this parameter is not specified, base64 is used by default for legacy compatibility.</para>
            /// 
            /// <b>Example:</b>
            /// <para>base64</para>
            /// </summary>
            [NameInMap("OutputFileMode")]
            [Validation(Required=false)]
            public string OutputFileMode { get; set; }

        }

        /// <summary>
        /// <para>The streaming output control options. Contains IncludeReasoning (boolean, default true, specifies whether to include the model thinking process) and IncludeToolCalls (boolean, default true, specifies whether to include tool invocation details). If not specified or set to a null object, the behavior is consistent with the legacy version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;IncludeReasoning&quot;: false, &quot;IncludeToolCalls&quot;: false}</para>
        /// </summary>
        [NameInMap("StreamOptions")]
        [Validation(Required=false)]
        public ChatRequestStreamOptions StreamOptions { get; set; }
        public class ChatRequestStreamOptions : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include the model thinking process. When set to false, the SSE stream does not include messages with Type=&quot;reasoning&quot; or their content events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeReasoning")]
            [Validation(Required=false)]
            public bool? IncludeReasoning { get; set; }

            /// <summary>
            /// <para>Specifies whether to include tool invocation details. When set to false, the SSE stream does not include messages of type plugin_call, plugin_call_output, mcp_call, or mcp_call_output, or their content events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IncludeToolCalls")]
            [Validation(Required=false)]
            public bool? IncludeToolCalls { get; set; }

        }

        /// <summary>
        /// <para>The agent template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template-abc123</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
