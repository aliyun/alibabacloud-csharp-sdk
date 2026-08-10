// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nis20211216.Models
{
    public class SendNapalStreamMessageRequest : TeaModel {
        /// <summary>
        /// <para>The request configuration object.</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public SendNapalStreamMessageRequestConfiguration Configuration { get; set; }
        public class SendNapalStreamMessageRequestConfiguration : TeaModel {
            /// <summary>
            /// <para>The accepted output modes. Default value: [&quot;text/event-stream&quot;], which indicates that SSE streaming responses are accepted.</para>
            /// </summary>
            [NameInMap("AcceptedOutputModes")]
            [Validation(Required=false)]
            public List<string> AcceptedOutputModes { get; set; }

            /// <summary>
            /// <para>The history message length. Controls the number of historical messages carried in multi-turn conversations. Default value: 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("HistoryLength")]
            [Validation(Required=false)]
            public int? HistoryLength { get; set; }

            /// <summary>
            /// <para>Specifies whether to return immediately. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>false (default): Returns responses in streaming mode.</description></item>
            /// <item><description>true: Returns the task ID immediately and processes the request asynchronously.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ReturnImmediately")]
            [Validation(Required=false)]
            public bool? ReturnImmediately { get; set; }

        }

        /// <summary>
        /// <para>The message object that contains user input and session context information.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public SendNapalStreamMessageRequestMessage Message { get; set; }
        public class SendNapalStreamMessageRequestMessage : TeaModel {
            /// <summary>
            /// <para>The session context ID. Do not specify this parameter for the first conversation. The server creates a new session. For multi-turn conversations, pass the contextId from the previous response to maintain context continuity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>context-xxx</para>
            /// </summary>
            [NameInMap("ContextId")]
            [Validation(Required=false)]
            public string ContextId { get; set; }

            /// <summary>
            /// <para>The list of extension information.</para>
            /// </summary>
            [NameInMap("Extensions")]
            [Validation(Required=false)]
            public List<string> Extensions { get; set; }

            /// <summary>
            /// <para>The message ID. If not specified, the server automatically generates one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m_msijl2sv_pcfge8r7l</para>
            /// </summary>
            [NameInMap("MessageId")]
            [Validation(Required=false)]
            public string MessageId { get; set; }

            /// <summary>
            /// <para>The extended metadata, used to pass additional context information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The list of message content parts. Multiple parts are supported.</para>
            /// </summary>
            [NameInMap("Parts")]
            [Validation(Required=false)]
            public List<SendNapalStreamMessageRequestMessageParts> Parts { get; set; }
            public class SendNapalStreamMessageRequestMessageParts : TeaModel {
                /// <summary>
                /// <para>The structured data, used to pass JSON-formatted structured content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;key&quot;:&quot;value&quot;}</para>
                /// </summary>
                [NameInMap("Data")]
                [Validation(Required=false)]
                public object Data { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>report.txt</para>
                /// </summary>
                [NameInMap("Filename")]
                [Validation(Required=false)]
                public string Filename { get; set; }

                /// <summary>
                /// <para>The media type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>application/json</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The raw content, used to pass non-text data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmVzZXJ2ZWQ=</para>
                /// </summary>
                [NameInMap("Raw")]
                [Validation(Required=false)]
                public string Raw { get; set; }

                /// <summary>
                /// <para>The text content. The natural language instruction entered by the user, such as a diagnostic request or question consultation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Diagnose this instance ngw-xxx</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The file URL, used to pass file-type content.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/file.txt">https://example.com/file.txt</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The list of referenced historical task IDs, used for context association.</para>
            /// </summary>
            [NameInMap("ReferenceTaskIds")]
            [Validation(Required=false)]
            public List<string> ReferenceTaskIds { get; set; }

            /// <summary>
            /// <para>The message role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The task ID. Pass the ID of the previous task in follow-up conversation scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>task-xxx</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

        }

        /// <summary>
        /// <para>The additional request information.</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, string> Metadata { get; set; }

    }

}
