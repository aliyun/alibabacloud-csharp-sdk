// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SfmMultiModalApp20250909.Models
{
    public class DescribeMmAppResponseBody : TeaModel {
        [NameInMap("AppConfig")]
        [Validation(Required=false)]
        public DescribeMmAppResponseBodyAppConfig AppConfig { get; set; }
        public class DescribeMmAppResponseBodyAppConfig : TeaModel {
            [NameInMap("EnableTransition")]
            [Validation(Required=false)]
            public bool? EnableTransition { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mm_xxxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>多模态应用xxxx</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("BindingConfig")]
        [Validation(Required=false)]
        public DescribeMmAppResponseBodyBindingConfig BindingConfig { get; set; }
        public class DescribeMmAppResponseBodyBindingConfig : TeaModel {
            [NameInMap("Commands")]
            [Validation(Required=false)]
            public List<DescribeMmAppResponseBodyBindingConfigCommands> Commands { get; set; }
            public class DescribeMmAppResponseBodyBindingConfigCommands : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("DomainCode")]
                [Validation(Required=false)]
                public string DomainCode { get; set; }

                [NameInMap("Tools")]
                [Validation(Required=false)]
                public List<string> Tools { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BAILIAN</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Mcps")]
            [Validation(Required=false)]
            public List<DescribeMmAppResponseBodyBindingConfigMcps> Mcps { get; set; }
            public class DescribeMmAppResponseBodyBindingConfigMcps : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ToolList")]
                [Validation(Required=false)]
                public List<string> ToolList { get; set; }

            }

            [NameInMap("RagConfig")]
            [Validation(Required=false)]
            public DescribeMmAppResponseBodyBindingConfigRagConfig RagConfig { get; set; }
            public class DescribeMmAppResponseBodyBindingConfigRagConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableSearch")]
                [Validation(Required=false)]
                public string EnableSearch { get; set; }

                [NameInMap("KnowledgeBaseCodeList")]
                [Validation(Required=false)]
                public List<string> KnowledgeBaseCodeList { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>top_k</para>
                /// </summary>
                [NameInMap("PromptStrategy")]
                [Validation(Required=false)]
                public string PromptStrategy { get; set; }

                [NameInMap("RankWeights")]
                [Validation(Required=false)]
                public Dictionary<string, double?> RankWeights { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("RetrieveMaxLength")]
                [Validation(Required=false)]
                public int? RetrieveMaxLength { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public int? TopK { get; set; }

            }

        }

        [NameInMap("ConversationConfig")]
        [Validation(Required=false)]
        public DescribeMmAppResponseBodyConversationConfig ConversationConfig { get; set; }
        public class DescribeMmAppResponseBodyConversationConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxx</para>
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
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("TtsModel")]
            [Validation(Required=false)]
            public string TtsModel { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>243433</para>
        /// </summary>
        [NameInMap("CreateUserId")]
        [Validation(Required=false)]
        public string CreateUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("CreateUserName")]
        [Validation(Required=false)]
        public string CreateUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("ModelConfig")]
        [Validation(Required=false)]
        public DescribeMmAppResponseBodyModelConfig ModelConfig { get; set; }
        public class DescribeMmAppResponseBodyModelConfig : TeaModel {
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

            [NameInMap("OpenMemory")]
            [Validation(Required=false)]
            public bool? OpenMemory { get; set; }

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
        /// <para>56673435</para>
        /// </summary>
        [NameInMap("ModifyUserId")]
        [Validation(Required=false)]
        public string ModifyUserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("ModifyUserName")]
        [Validation(Required=false)]
        public string ModifyUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>提示词xxxx</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PublishVersion")]
        [Validation(Required=false)]
        public long? PublishVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
