// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The name of the calling application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baidufanyi</para>
        /// </summary>
        [NameInMap("appName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The extended parameters that control translation features.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public BatchTranslateRequestExt Ext { get; set; }
        public class BatchTranslateRequestExt : TeaModel {
            /// <summary>
            /// <para>Controls the translation behavior.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public BatchTranslateRequestExtConfig Config { get; set; }
            public class BatchTranslateRequestExtConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to skip the Content Moderation check. To set this to true, you must first complete the required process to disable Content Moderation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipCsiCheck")]
                [Validation(Required=false)]
                public bool? SkipCsiCheck { get; set; }

            }

            /// <summary>
            /// <para>A natural language instruction in English that guides the model\&quot;s translation style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this sentence from an e-commerce product image, please provide a translation that is both highly concise and no more than 1.2 times the length of the original.</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            /// <summary>
            /// <para>A list of translation examples.</para>
            /// </summary>
            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<BatchTranslateRequestExtExamples> Examples { get; set; }
            public class BatchTranslateRequestExtExamples : TeaModel {
                /// <summary>
                /// <para>The source text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The target text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to enable automatic detection of the source language. If set to true, the <c>sourceLanguage</c> parameter is ignored.</para>
            /// </summary>
            [NameInMap("langDetect")]
            [Validation(Required=false)]
            public bool? LangDetect { get; set; }

            /// <summary>
            /// <para>Extended parameters for applying custom terminology that is isolated by user or business scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bizUserld&quot;:&quot;123456&quot;,&quot;bizType&quot;:session&quot;}</para>
            /// </summary>
            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            /// <summary>
            /// <para>A list of sensitive terms.</para>
            /// </summary>
            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            /// <summary>
            /// <para>A list of custom terminology for overriding translations.</para>
            /// </summary>
            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<BatchTranslateRequestExtTerminologies> Terminologies { get; set; }
            public class BatchTranslateRequestExtTerminologies : TeaModel {
                /// <summary>
                /// <para>The source text to be overridden.</para>
                /// 
                /// <b>Example:</b>
                /// <para>应用接口</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The target text to use for the override.</para>
                /// 
                /// <b>Example:</b>
                /// <para>API</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>Specifies case transformations for the translated text.</para>
            /// </summary>
            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public BatchTranslateRequestExtTextTransform TextTransform { get; set; }
            public class BatchTranslateRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <para>Specifies whether to convert the entire translated text to lowercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                /// <summary>
                /// <para>Specifies whether to convert the entire translated text to title case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                /// <summary>
                /// <para>Specifies whether to convert the entire translated text to uppercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toUpper")]
                [Validation(Required=false)]
                public bool? ToUpper { get; set; }

            }

        }

        /// <summary>
        /// <para>The translation format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The translation model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-turbo</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The source language.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>A map of texts to translate, in which the key is a custom identifier and the value is the source text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;0&quot;:&quot;明天天气怎么样？&quot;,&quot;1&quot;:&quot;你中午吃饭了吗&quot;}</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public Dictionary<string, object> Text { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace used for this request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-kqtrcpdee4xm29xx</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
