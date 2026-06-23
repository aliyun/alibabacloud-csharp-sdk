// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The request ID provided by the client. This ID is returned in the response without modification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4758330557805415712</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The JSON-RPC version. The value is fixed at <c>2.0</c>.</para>
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
        public CreateAgentSessionRequestParams Params { get; set; }
        public class CreateAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The extended metadata, which includes information such as agent binding, session source, and session tags.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public CreateAgentSessionRequestParamsMeta Meta { get; set; }
            public class CreateAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>The agent configuration for this session. The value must be one of the agents returned by the <c>ListAgents</c> API.</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaAgent Agent { get; set; }
                public class CreateAgentSessionRequestParamsMetaAgent : TeaModel {
                    /// <summary>
                    /// <para>The agent name to bind to the session. This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat_cli_chatbi</para>
                    /// </summary>
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                }

                /// <summary>
                /// <para>The configuration parameters for the session, such as filters based on session source and session tags.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaConfig Config { get; set; }
                public class CreateAgentSessionRequestParamsMetaConfig : TeaModel {
                    /// <summary>
                    /// <para>The identifier for the session source. This allows you to search for sessions by their source. For example, if you use an agent on multiple pages, such as Page A and Page B, you can use this parameter to filter and display only the sessions created on Page A. The identifier can be up to 128 characters and can contain letters, digits, hyphens (-), and underscores (_).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openapi_sdk</para>
                    /// </summary>
                    [NameInMap("SessionSource")]
                    [Validation(Required=false)]
                    public string SessionSource { get; set; }

                    /// <summary>
                    /// <para>A list of session tags. You can use these tags to search and filter sessions.</para>
                    /// </summary>
                    [NameInMap("SessionTags")]
                    [Validation(Required=false)]
                    public List<CreateAgentSessionRequestParamsMetaConfigSessionTags> SessionTags { get; set; }
                    public class CreateAgentSessionRequestParamsMetaConfigSessionTags : TeaModel {
                        /// <summary>
                        /// <para>The session tag. You can use session tags to filter sessions. For example, if your application calls the API with a fixed RAM sub-account but maintains its own user account system, you can pass a user\&quot;s account ID as a tag. This allows you to filter the session list by your internal account IDs. The tag can be up to 128 characters and can contain letters, digits, hyphens (-), and underscores (_).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>chatbi</para>
                        /// </summary>
                        [NameInMap("SessionTagCode")]
                        [Validation(Required=false)]
                        public string SessionTagCode { get; set; }

                    }

                }

                [NameInMap("InitialConfigOptions")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaInitialConfigOptions InitialConfigOptions { get; set; }
                public class CreateAgentSessionRequestParamsMetaInitialConfigOptions : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>chat，cli</para>
                    /// </summary>
                    [NameInMap("ExecutionLane")]
                    [Validation(Required=false)]
                    public string ExecutionLane { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>yolo</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                }

            }

        }

    }

}
