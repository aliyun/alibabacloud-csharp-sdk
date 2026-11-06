// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The ID passed by the requester. The value is returned as is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4758330557805415712</para>
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
        public CreateAgentSessionRequestParams Params { get; set; }
        public class CreateAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The extended metadata that carries agent binding, session source, and tags.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public CreateAgentSessionRequestParamsMeta Meta { get; set; }
            public class CreateAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>The agent configuration for the session. Valid values are the results returned by the ListAgents operation.</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaAgent Agent { get; set; }
                public class CreateAgentSessionRequestParamsMetaAgent : TeaModel {
                    /// <summary>
                    /// <para>The name of the agent bound to the session. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>dataworks_data_agent: DataWorks built-in agent - Data Agent. It provides AI capabilities for the entire data development lifecycle, including data integration, development, O&amp;M, governance, and analysis.</description></item>
                    /// <item><description>dataworks_chatbi_agent: DataWorks built-in agent - ChatBI. Based on natural language processing and intelligent analysis technologies, it automates the entire analysis process from requirement parsing, data extraction, and automatic code generation to visual report output through conversational interaction.</description></item>
                    /// <item><description>dataworks_ai_assistant_agent: DataWorks built-in agent - AI Assistant. An enterprise-grade AI assistant for DataWorks built on open-source frameworks such as OpenClaw and Hermes Agent.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dataworks_data_agent</para>
                    /// </summary>
                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                }

                /// <summary>
                /// <para>The session parameter settings, such as filter parameter settings based on the session source and session tags.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaConfig Config { get; set; }
                public class CreateAgentSessionRequestParamsMetaConfig : TeaModel {
                    /// <summary>
                    /// <para>The session source identifier, which facilitates retrieval by source. For example, if an agent is used on both Page A and Page B, and you want to display only sessions created on Page A when you are on Page A, you can filter sessions based on this parameter. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openapi_sdk</para>
                    /// </summary>
                    [NameInMap("SessionSource")]
                    [Validation(Required=false)]
                    public string SessionSource { get; set; }

                    /// <summary>
                    /// <para>The list of session tags. You can search and filter sessions based on session tags later.</para>
                    /// </summary>
                    [NameInMap("SessionTags")]
                    [Validation(Required=false)]
                    public List<CreateAgentSessionRequestParamsMetaConfigSessionTags> SessionTags { get; set; }
                    public class CreateAgentSessionRequestParamsMetaConfigSessionTags : TeaModel {
                        /// <summary>
                        /// <para>The session tag. You can filter sessions based on session tags. For example, if you use a fixed RAM user to call an API operation but the calling system has its own account system, and you need to filter the session list based on the account ID, you can pass the account ID of the calling system as this tag. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>chatbi</para>
                        /// </summary>
                        [NameInMap("SessionTagCode")]
                        [Validation(Required=false)]
                        public string SessionTagCode { get; set; }

                    }

                }

                /// <summary>
                /// <para>The advanced parameter settings for the agent execution environment.</para>
                /// </summary>
                [NameInMap("InitialConfigOptions")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaInitialConfigOptions InitialConfigOptions { get; set; }
                public class CreateAgentSessionRequestParamsMetaInitialConfigOptions : TeaModel {
                    /// <summary>
                    /// <para>The compute unit (CU) specifications of the session instance. Only 2, 4, 8, and 12 are supported. If this parameter is omitted, the instance CU is not specified, and reuse in shared mode is not constrained by the CU. If this parameter is specified, shared mode reuses only instances with the same CU. If the CU does not match, a new instance is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cu")]
                    [Validation(Required=false)]
                    public string Cu { get; set; }

                    /// <summary>
                    /// <para>Execution mode:</para>
                    /// <list type="bullet">
                    /// <item><description>chat: conversation-only mode, suitable for simple data querying and Q&amp;A scenarios. The advantage is that it is fast and consumes fewer tokens, but the disadvantage is that it cannot handle complex problems.</description></item>
                    /// <item><description>cli: sandbox mode, suitable for complex data analytics, data processing, and code writing scenarios. The advantage is that it can handle complex problems, and the model independently analyzes and handles problems. The disadvantage is that the processing speed is slower and token consumption is higher compared to the chat mode.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat，cli</para>
                    /// </summary>
                    [NameInMap("ExecutionLane")]
                    [Validation(Required=false)]
                    public string ExecutionLane { get; set; }

                    /// <summary>
                    /// <para>The authorization mode for script execution. OpenAPI currently supports only the yolo mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>yolo: automatic authorization. No manual intervention is required, and the model can process automatically.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yolo</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The model ID. Use the full model identifier supported by the target environment. If this parameter is omitted, the default model is used. If this parameter is passed, the server verifies its availability and applies it before the session is created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen3.7-max(openai)</para>
                    /// </summary>
                    [NameInMap("Model")]
                    [Validation(Required=false)]
                    public string Model { get; set; }

                    /// <summary>
                    /// <para>The DataWorks workspace ID. It is used to initialize the session project context. If this parameter is omitted, it is processed as having no project. The project context can be corrected or switched later by the project context of PromptAgentSession.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The reasoning configuration. The value must be supported by the target model. A value of none disables reasoning, and default uses the model\&quot;s default configuration. If an unsupported value is used or the configuration fails to apply, session creation fails. If this parameter is omitted, the existing reasoning configuration is not modified. A successful configuration updates the default value of the daemon workspace, which affects not only the current request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>none</para>
                    /// </summary>
                    [NameInMap("ReasoningEffort")]
                    [Validation(Required=false)]
                    public string ReasoningEffort { get; set; }

                    /// <summary>
                    /// <para>The ID of the resource group used for initialization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Serverless_res_group_123123123_564657857</para>
                    /// </summary>
                    [NameInMap("ResourceGroupId")]
                    [Validation(Required=false)]
                    public string ResourceGroupId { get; set; }

                    /// <summary>
                    /// <para>The names of the loaded custom skills. Separate multiple names with commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>skill-name-1,skill-name2,skill-name-3</para>
                    /// </summary>
                    [NameInMap("Skills")]
                    [Validation(Required=false)]
                    public string Skills { get; set; }

                }

            }

        }

    }

}
