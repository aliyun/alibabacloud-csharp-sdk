// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class PromptAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed in by the caller. The value is returned as-is in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1021418411</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. Fixed value: 2.0.</para>
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
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public PromptAgentSessionRequestParamsMeta Meta { get; set; }
            public class PromptAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>A Map-type value. In custom agent scenarios, you can use this parameter to replace placeholder parameters.</para>
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
            /// <para>The array of user message content blocks. For more information, see https\://agentclientprotocol.com/protocol/content</para>
            /// </summary>
            [NameInMap("Prompt")]
            [Validation(Required=false)]
            public List<PromptAgentSessionRequestParamsPrompt> Prompt { get; set; }
            public class PromptAgentSessionRequestParamsPrompt : TeaModel {
                /// <summary>
                /// <para>The description of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales_Order_Details.csv</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The prompt metadata extended by DataWorks.</para>
                /// </summary>
                [NameInMap("Meta")]
                [Validation(Required=false)]
                public PromptAgentSessionRequestParamsPromptMeta Meta { get; set; }
                public class PromptAgentSessionRequestParamsPromptMeta : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether to hide the prompt from the user. For example, if a user asks &quot;Sales amount in the last 7 days&quot; in a chat dialog, the calling system may use RAG to retrieve relevant business domain knowledge and append it to the agent context before calling the API. If you do not want to display this supplemental information to the user, set this parameter to true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true or false</para>
                    /// </summary>
                    [NameInMap("Hide")]
                    [Validation(Required=false)]
                    public bool? Hide { get; set; }

                }

                /// <summary>
                /// <para>The MIME type of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text/csv‌</para>
                /// </summary>
                [NameInMap("MimeType")]
                [Validation(Required=false)]
                public string MimeType { get; set; }

                /// <summary>
                /// <para>The file name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx.csv</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The size of the file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1231231</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para><b>The text content.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales in the last 7 days</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The title of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sales_Order_Details.csv</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para><b>The content block type.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The URI of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss://${bucket}/${ossKey}</para>
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
