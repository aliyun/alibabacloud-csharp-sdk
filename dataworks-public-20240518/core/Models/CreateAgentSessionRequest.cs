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
                /// <para>The agent configuration for the session. Valid values are the results returned by the ListAgents operation.</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CreateAgentSessionRequestParamsMetaAgent Agent { get; set; }
                public class CreateAgentSessionRequestParamsMetaAgent : TeaModel {
                    /// <summary>
                    /// <para>The name of the agent bound to the session. This parameter is required.</para>
                    /// <list type="bullet">
                    /// <item><description>dataworks_data_agent: DataWorks built-in agent — Data Agent, which provides intelligent data development AI capabilities covering the entire workflow of data integration, development, O&amp;M, governance, and analytics.</description></item>
                    /// <item><description>dataworks_chatbi_agent: DataWorks built-in agent — ChatBI, which uses natural language processing and intelligent analytics technologies to automate the entire analysis workflow from requirement parsing, data extraction, and automatic code generation to visualization report output through conversational interaction.</description></item>
                    /// <item><description>dataworks_ai_assistant_agent: DataWorks built-in agent — AI Assistant Service, which is a DataWorks enterprise-grade dedicated AI assistant built on open source frameworks such as OpenClaw and Hermes Agent.</description></item>
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
                    /// <para>The session source identifier for retrieval by source. For example, if an agent is used on both page A and page B, and you want page A to display only sessions created from page A, you can filter based on this parameter. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
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
                        /// <para>The session tag. You can filter sessions based on session tags. For example, if you use a fixed RAM user to call OpenAPI operations but your calling system has its own account system, you can pass the account ID of your calling system as this tag to filter the session list by account ID. The value can be up to 128 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
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
                    /// <item><description>chat: conversation mode only. Suitable for simple Q&amp;A scenarios. Advantages: fast response and low token consumption. Disadvantages: cannot handle complex problems.</description></item>
                    /// <item><description>cli: sandbox mode. Suitable for complex data analytics, data processing, and code writing scenarios. Advantages: can handle complex problems with the model autonomously performing analysis and problem resolution. Disadvantages: slower processing speed and higher token consumption compared to chat mode.</description></item>
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
                    /// <item><description>yolo: automatic authorization. No human intervention is required, and the model can process tasks automatically.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>yolo</para>
                    /// </summary>
                    [NameInMap("Mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

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
                    /// <para>The names of custom skills to load. Separate multiple names with commas (,).</para>
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
