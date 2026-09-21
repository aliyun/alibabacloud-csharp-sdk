// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentSessionRequest : TeaModel {
        /// <summary>
        /// <para>The request ID passed by the caller. The value is returned as-is.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4758330557805415712</para>
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
        public CreateAgentSessionRequestParams Params { get; set; }
        public class CreateAgentSessionRequestParams : TeaModel {
            /// <summary>
            /// <para>The extended metadata that carries agent binding, session source, tags, and other information.</para>
            /// </summary>
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public CreateAgentSessionRequestParamsMeta Meta { get; set; }
            public class CreateAgentSessionRequestParamsMeta : TeaModel {
                /// <summary>
                /// <para>The agent configuration for this session. Valid values are those returned by the ListAgents operation.</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaAgent Agent { get; set; }
                public class CreateAgentSessionRequestParamsMetaAgent : TeaModel {
                    /// <summary>
                    /// <para>The name of the agent to bind to the session. This parameter is required. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>dataworks_data_agent: DataWorks built-in agent — Data Agent. Provides intelligent data development AI capabilities that cover the entire workflow of data integration, development, O&amp;M, governance, and analytics.</description></item>
                    /// <item><description>dataworks_chatbi_agent: DataWorks built-in agent — ChatBI. Uses natural language processing and intelligent analytics to automate the entire analysis workflow through conversational interaction, from requirement parsing, data extraction, and automatic code generation to visual report output.</description></item>
                    /// <item><description>dataworks_ai_assistant_agent: DataWorks built-in agent — AI Assistant Service. An enterprise-grade dedicated AI assistant for DataWorks built on open source frameworks such as OpenClaw and Hermes Agent.</description></item>
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
                /// <para>The session parameter settings, such as filtering parameter settings based on session source and session tags.</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaConfig Config { get; set; }
                public class CreateAgentSessionRequestParamsMetaConfig : TeaModel {
                    /// <summary>
                    /// <para>The session source identifier, which facilitates retrieval by source. For example, if an agent is used on both Page A and Page B, and you want Page A to display only sessions created on Page A, you can filter by this parameter. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>openapi_sdk</para>
                    /// </summary>
                    [NameInMap("SessionSource")]
                    [Validation(Required=false)]
                    public string SessionSource { get; set; }

                    /// <summary>
                    /// <para>The list of session tags. You can use session tags for search and filtering.</para>
                    /// </summary>
                    [NameInMap("SessionTags")]
                    [Validation(Required=false)]
                    public List<CreateAgentSessionRequestParamsMetaConfigSessionTags> SessionTags { get; set; }
                    public class CreateAgentSessionRequestParamsMetaConfigSessionTags : TeaModel {
                        /// <summary>
                        /// <para>The session tag. You can filter sessions by tag. For example, if you use a fixed RAM user to call the OpenAPI but your system has its own account system, you can pass the account ID of your system as this tag to filter the session list by account ID. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
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
                    /// <para>The exec mode. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>chat: Conversation mode only. Suitable for simple Q&amp;A scenarios. Advantages: fast response and low token consumption. Disadvantages: cannot handle complex problems.</description></item>
                    /// <item><description>cli: Sandbox mode. Suitable for complex data analytics, data processing, and code writing scenarios. Advantages: can handle complex problems, and the model autonomously performs analysis and problem resolution. Disadvantages: slower processing speed and higher token consumption compared to the conversation mode.</description></item>
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
                    /// <item><description>yolo: Automatic authorization. No manual intervention is required, and the model processes tasks automatically.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yolo</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The DataWorks workspace ID. Used to initialize the session project context. If omitted, the session is treated as having no project context. You can later correct or switch the project context by using PromptAgentSession.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

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
                    /// <para>The names of custom skills to load. Separate multiple skill names with commas (,).</para>
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
