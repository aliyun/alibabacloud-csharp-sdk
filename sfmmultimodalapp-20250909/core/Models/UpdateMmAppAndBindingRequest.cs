// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class UpdateMmAppAndBindingRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public UpdateMmAppAndBindingRequestBindingConfig BindingConfig { get; set; }
        public class UpdateMmAppAndBindingRequestBindingConfig : TeaModel {
            [NameInMap("Agents")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestBindingConfigAgents> Agents { get; set; }
            public class UpdateMmAppAndBindingRequestBindingConfigAgents : TeaModel {
                [NameInMap("AgentCode")]
                [Validation(Required=false)]
                public string AgentCode { get; set; }

                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                [NameInMap("AgentType")]
                [Validation(Required=false)]
                public string AgentType { get; set; }

                [NameInMap("CentralConfig")]
                [Validation(Required=false)]
                public Dictionary<string, object> CentralConfig { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("IntentFewShotConfig")]
                [Validation(Required=false)]
                public Dictionary<string, List<BindingConfigAgentsIntentFewShotConfigValue>> IntentFewShotConfig { get; set; }

                [NameInMap("OwnConfig")]
                [Validation(Required=false)]
                public Dictionary<string, object> OwnConfig { get; set; }

            }

            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestBindingConfigCommands> Commands { get; set; }
            public class UpdateMmAppAndBindingRequestBindingConfigCommands : TeaModel {
                [NameInMap("DomainCode")]
                [Validation(Required=false)]
                public string DomainCode { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<UpdateMmAppAndBindingRequestBindingConfigCommandsTools> Tools { get; set; }
                public class UpdateMmAppAndBindingRequestBindingConfigCommandsTools : TeaModel {
                    [NameInMap("ReplyMode")]
                    [Validation(Required=false)]
                    public string ReplyMode { get; set; }

                    [NameInMap("ToolDescription")]
                    [Validation(Required=false)]
                    public string ToolDescription { get; set; }

                    [NameInMap("ToolExamples")]
                    [Validation(Required=false)]
                    public List<UpdateMmAppAndBindingRequestBindingConfigCommandsToolsToolExamples> ToolExamples { get; set; }
                    public class UpdateMmAppAndBindingRequestBindingConfigCommandsToolsToolExamples : TeaModel {
                        [NameInMap("Parameters")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> Parameters { get; set; }

                        [NameInMap("Query")]
                        [Validation(Required=false)]
                        public string Query { get; set; }

                    }

                    [NameInMap("ToolId")]
                    [Validation(Required=false)]
                    public string ToolId { get; set; }

                    [NameInMap("ToolName")]
                    [Validation(Required=false)]
                    public string ToolName { get; set; }

                    [NameInMap("ToolParams")]
                    [Validation(Required=false)]
                    public List<UpdateMmAppAndBindingRequestBindingConfigCommandsToolsToolParams> ToolParams { get; set; }
                    public class UpdateMmAppAndBindingRequestBindingConfigCommandsToolsToolParams : TeaModel {
                        [NameInMap("ParamDesc")]
                        [Validation(Required=false)]
                        public string ParamDesc { get; set; }

                        [NameInMap("ParamExample")]
                        [Validation(Required=false)]
                        public string ParamExample { get; set; }

                        [NameInMap("ParamName")]
                        [Validation(Required=false)]
                        public string ParamName { get; set; }

                        [NameInMap("ParamType")]
                        [Validation(Required=false)]
                        public string ParamType { get; set; }

                        [NameInMap("Required")]
                        [Validation(Required=false)]
                        public bool? Required { get; set; }

                    }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Mcps")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestBindingConfigMcps> Mcps { get; set; }
            public class UpdateMmAppAndBindingRequestBindingConfigMcps : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ToolList")]
                [Validation(Required=false)]
                public List<string> ToolList { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Plugins")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestBindingConfigPlugins> Plugins { get; set; }
            public class UpdateMmAppAndBindingRequestBindingConfigPlugins : TeaModel {
                [NameInMap("PluginCode")]
                [Validation(Required=false)]
                public string PluginCode { get; set; }

                [NameInMap("PluginName")]
                [Validation(Required=false)]
                public string PluginName { get; set; }

                [NameInMap("PluginType")]
                [Validation(Required=false)]
                public string PluginType { get; set; }

            }

            [NameInMap("RagConfig")]
            [Validation(Required=false)]
            public UpdateMmAppAndBindingRequestBindingConfigRagConfig RagConfig { get; set; }
            public class UpdateMmAppAndBindingRequestBindingConfigRagConfig : TeaModel {
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public bool? EnableSearch { get; set; }

                [NameInMap("KnowledgeBaseCodeList")]
                [Validation(Required=false)]
                public List<string> KnowledgeBaseCodeList { get; set; }

                [NameInMap("PromptStrategy")]
                [Validation(Required=false)]
                public string PromptStrategy { get; set; }

                [NameInMap("RankWeights")]
                [Validation(Required=false)]
                public Dictionary<string, double?> RankWeights { get; set; }

                [NameInMap("RetrieveMaxLength")]
                [Validation(Required=false)]
                public int? RetrieveMaxLength { get; set; }

                [NameInMap("TopK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

        }

        [NameInMap("ConversationConfig")]
        [Validation(Required=false)]
        public UpdateMmAppAndBindingRequestConversationConfig ConversationConfig { get; set; }
        public class UpdateMmAppAndBindingRequestConversationConfig : TeaModel {
            [NameInMap("AsrModel")]
            [Validation(Required=false)]
            public string AsrModel { get; set; }

            [NameInMap("OpenAsr")]
            [Validation(Required=false)]
            public bool? OpenAsr { get; set; }

            [NameInMap("OpenTts")]
            [Validation(Required=false)]
            public bool? OpenTts { get; set; }

            [NameInMap("StopOrRejectFlag")]
            [Validation(Required=false)]
            public bool? StopOrRejectFlag { get; set; }

            [NameInMap("TtsModel")]
            [Validation(Required=false)]
            public string TtsModel { get; set; }

        }

        [NameInMap("MemoryConfig")]
        [Validation(Required=false)]
        public UpdateMmAppAndBindingRequestMemoryConfig MemoryConfig { get; set; }
        public class UpdateMmAppAndBindingRequestMemoryConfig : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestMemoryConfigAttributes> Attributes { get; set; }
            public class UpdateMmAppAndBindingRequestMemoryConfigAttributes : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public UpdateMmAppAndBindingRequestModelConfig ModelConfig { get; set; }
        public class UpdateMmAppAndBindingRequestModelConfig : TeaModel {
            [NameInMap("EnableIntentRecognize")]
            [Validation(Required=false)]
            public bool? EnableIntentRecognize { get; set; }

            [NameInMap("EnableTransition")]
            [Validation(Required=false)]
            public bool? EnableTransition { get; set; }

            [NameInMap("HistoryLimit")]
            [Validation(Required=false)]
            public int? HistoryLimit { get; set; }

            [NameInMap("IntentOnlySwitch")]
            [Validation(Required=false)]
            public bool? IntentOnlySwitch { get; set; }

            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("OpenMemory")]
            [Validation(Required=false)]
            public bool? OpenMemory { get; set; }

            [NameInMap("OpenWebSearch")]
            [Validation(Required=false)]
            public bool? OpenWebSearch { get; set; }

            [NameInMap("SearchModel")]
            [Validation(Required=false)]
            public string SearchModel { get; set; }

            [NameInMap("SearchStrategy")]
            [Validation(Required=false)]
            public string SearchStrategy { get; set; }

            [NameInMap("TextModal")]
            [Validation(Required=false)]
            public string TextModal { get; set; }

            [NameInMap("UserPromptParams")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestModelConfigUserPromptParams> UserPromptParams { get; set; }
            public class UpdateMmAppAndBindingRequestModelConfigUserPromptParams : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("userQueryParams")]
            [Validation(Required=false)]
            public List<UpdateMmAppAndBindingRequestModelConfigUserQueryParams> UserQueryParams { get; set; }
            public class UpdateMmAppAndBindingRequestModelConfigUserQueryParams : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
