// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class UpdateMmAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mm_xxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>多模态应用xxxxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public UpdateMmAppRequestBindingConfig BindingConfig { get; set; }
        public class UpdateMmAppRequestBindingConfig : TeaModel {
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<UpdateMmAppRequestBindingConfigCommands> Commands { get; set; }
            public class UpdateMmAppRequestBindingConfigCommands : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>724366858658</para>
                /// </summary>
                [NameInMap("DomainCode")]
                [Validation(Required=false)]
                public string DomainCode { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<UpdateMmAppRequestBindingConfigCommandsTools> Tools { get; set; }
                public class UpdateMmAppRequestBindingConfigCommandsTools : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7293782043943</para>
                    /// </summary>
                    [NameInMap("ToolId")]
                    [Validation(Required=false)]
                    public string ToolId { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CUSTOM</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("ConversationConfig")]
        [Validation(Required=false)]
        public UpdateMmAppRequestConversationConfig ConversationConfig { get; set; }
        public class UpdateMmAppRequestConversationConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Paraformer</para>
            /// </summary>
            [NameInMap("AsrModel")]
            [Validation(Required=false)]
            public string AsrModel { get; set; }

            [NameInMap("OpenAsr")]
            [Validation(Required=false)]
            public bool? OpenAsr { get; set; }

            [NameInMap("OpenTts")]
            [Validation(Required=false)]
            public bool? OpenTts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cosyvoice-v2</para>
            /// </summary>
            [NameInMap("TtsModel")]
            [Validation(Required=false)]
            public string TtsModel { get; set; }

        }

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public UpdateMmAppRequestModelConfig ModelConfig { get; set; }
        public class UpdateMmAppRequestModelConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HistoryLimit")]
            [Validation(Required=false)]
            public int? HistoryLimit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MMH</para>
            /// </summary>
            [NameInMap("ModelType")]
            [Validation(Required=false)]
            public string ModelType { get; set; }

            [NameInMap("OpenWebSearch")]
            [Validation(Required=false)]
            public bool? OpenWebSearch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-mmh-high-speed</para>
            /// </summary>
            [NameInMap("TextModal")]
            [Validation(Required=false)]
            public string TextModal { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>提示词，不超过8000字符</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-xxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
