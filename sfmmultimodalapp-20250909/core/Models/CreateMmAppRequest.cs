// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class CreateMmAppRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>多模态xxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public CreateMmAppRequestBindingConfig BindingConfig { get; set; }
        public class CreateMmAppRequestBindingConfig : TeaModel {
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<CreateMmAppRequestBindingConfigCommands> Commands { get; set; }
            public class CreateMmAppRequestBindingConfigCommands : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3686786786</para>
                /// </summary>
                [NameInMap("DomainCode")]
                [Validation(Required=false)]
                public string DomainCode { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<CreateMmAppRequestBindingConfigCommandsTools> Tools { get; set; }
                public class CreateMmAppRequestBindingConfigCommandsTools : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>54645646</para>
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
        public CreateMmAppRequestConversationConfig ConversationConfig { get; set; }
        public class CreateMmAppRequestConversationConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxx</para>
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
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("TtsModel")]
            [Validation(Required=false)]
            public string TtsModel { get; set; }

        }

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public CreateMmAppRequestModelConfig ModelConfig { get; set; }
        public class CreateMmAppRequestModelConfig : TeaModel {
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
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("TextModal")]
            [Validation(Required=false)]
            public string TextModal { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>提示词</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm-xxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
