// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class TextTranslateRequest : TeaModel {
        /// <summary>
        /// <para>Extended parameters to control translation behavior</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public TextTranslateRequestExt Ext { get; set; }
        public class TextTranslateRequestExt : TeaModel {
            /// <summary>
            /// <para>Expert agent</para>
            /// 
            /// <b>Example:</b>
            /// <para>game</para>
            /// </summary>
            [NameInMap("agent")]
            [Validation(Required=false)]
            public string Agent { get; set; }

            /// <summary>
            /// <para>Translation Behavior Control</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public TextTranslateRequestExtConfig Config { get; set; }
            public class TextTranslateRequestExtConfig : TeaModel {
                /// <summary>
                /// <para>Whether to skip the Green Web check. (To use this option, you must first complete the process to disable Green Web before making the API call.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>fasle</para>
                /// </summary>
                [NameInMap("skipCsiCheck")]
                [Validation(Required=false)]
                public bool? SkipCsiCheck { get; set; }

            }

            /// <summary>
            /// <para>Domain hint</para>
            /// 
            /// <b>Example:</b>
            /// <para>technology</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            /// <summary>
            /// <para>List of Translation Examples</para>
            /// </summary>
            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<TextTranslateRequestExtExamples> Examples { get; set; }
            public class TextTranslateRequestExtExamples : TeaModel {
                /// <summary>
                /// <para>Source text</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>Target text</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("langDetect")]
            [Validation(Required=false)]
            public bool? LangDetect { get; set; }

            /// <summary>
            /// <para>Extended parameter configuration (bizUserld: A business-level user ID that distinguishes between different business users. It implements &quot;user-based isolation&quot; for terminology intervention so that interventions for one user do not affect others. bizType: A business scenario type or identifier that distinguishes between different scenarios. It implements &quot;scenario-based isolation&quot; for terminology intervention so that interventions for one scenario do not affect others.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bizUserld&quot;:&quot;123456&quot;,&quot;bizType&quot;:session&quot;}</para>
            /// </summary>
            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            /// <summary>
            /// <para>Prefix Configuration</para>
            /// 
            /// <b>Example:</b>
            /// <para>Today\&quot;s weather</para>
            /// </summary>
            [NameInMap("prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// <para>Sensitive word list</para>
            /// </summary>
            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            /// <summary>
            /// <para>Translation terminology</para>
            /// </summary>
            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<TextTranslateRequestExtTerminologies> Terminologies { get; set; }
            public class TextTranslateRequestExtTerminologies : TeaModel {
                /// <summary>
                /// <para>Source text</para>
                /// 
                /// <b>Example:</b>
                /// <para>机器学习</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>Target text</para>
                /// 
                /// <b>Example:</b>
                /// <para>ML</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>Translated Text Conversion</para>
            /// </summary>
            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public TextTranslateRequestExtTextTransform TextTransform { get; set; }
            public class TextTranslateRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <para>Convert to lowercase</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                /// <summary>
                /// <para>First letter capitalized</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                /// <summary>
                /// <para>Convert to uppercase</para>
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
        /// <para>text format</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>Model type</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-turbo</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>Source language code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>Target Language Code</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>Text to be translated</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>今天天气怎么样</para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>Workspace ID</para>
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
