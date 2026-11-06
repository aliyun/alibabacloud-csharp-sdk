// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PromptAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed by the requester, which is echoed back as is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1021418411</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Fixed to 2.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("Jsonrpc")]
        [Validation(Required=false)]
        public string Jsonrpc { get; set; }

        /// <summary>
        /// <para>The business parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public PromptAgentSessionRequestParams Params { get; set; }
        public class PromptAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The extended metadata.</para>
            /// <remarks>
            /// <para>Notice: If the agent name bound to the specified session is dataworks_ai_assistant_agent (AI Assistant Service), you must provide the instance ID of the AI Assistant Service in the Context.agent.instanceId field of the extended metadata.</notice></para>
            /// </remarks>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public PromptAgentSessionRequestParamsMeta Meta { get; set; }
            public class PromptAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>A map. In custom agent scenarios, you can use this value to replace specific placeholder parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{
                ///    &quot;key1&quot;: &quot;value1&quot;,
                ///    &quot;key2&quot;: &quot;value2&quot;
                /// }</para>
                /// </summary>
                [NameInMap("Context")]
                [Validation(Required=false)]
                public object Context { get; set; }

            }

            /// <summary>
            /// <para>The array of user message content blocks. For more information, see <a href="https://agentclientprotocol.com/protocol/content">https://agentclientprotocol.com/protocol/content</a>.</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public List<PromptAgentSessionRequestParamsPrompt> Prompt { get; set; }
            public class PromptAgentSessionRequestParamsPrompt : TeaModel {
                /// <summary>
                /// <para>The file description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to resource_link. Example: Sales order details.csv</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The DataWorks extended prompt metadata.</para>
                /// </summary>
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public PromptAgentSessionRequestParamsPromptMeta Meta { get; set; }
                public class PromptAgentSessionRequestParamsPromptMeta : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to hide the prompt from the user. For example, if a user asks a question in the chat dialog box, such as &quot;Sales amount in the last 7 days&quot;, and the calling system retrieves business domain knowledge through RAG before calling the API operation to supplement the agent context without displaying it to the user, set this parameter to true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Hide")]
                    [Validation(Required=false)]
                    public bool? Hide { get; set; }

                }

                /// <summary>
                /// <para>The MIME type of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to resource_link. Example: text/csv</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to resource_link. Example: xxx.csv</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the file, in bytes.</para>
                /// <para>Valid only when Type is set to <c>resource_link</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para><b>Text content</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to text. Example: Sales amount in the last 7 days</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The file title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to resource_link. Example: Sales order details.csv</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para><b>Content block type</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Currently supported values: text and resource_link</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URI of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Valid when Type is set to resource_link. Example: oss://${bucket}/${ossKey}</para>
                /// </summary>
                [NameInMap("Uri")]
                [Validation(Required=false)]
                public string Uri { get; set; }

            }

            /// <summary>
            /// <para>The ID of the target session. If the session does not exist, an SSE error frame is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sess_0f12abc34</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

    }

}
