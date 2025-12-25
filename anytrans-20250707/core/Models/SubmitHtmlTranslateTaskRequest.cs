// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitHtmlTranslateTaskRequest : TeaModel {
        [NameInMap("ext")]
        [Validation(Required=false)]
        public SubmitHtmlTranslateTaskRequestExt Ext { get; set; }
        public class SubmitHtmlTranslateTaskRequestExt : TeaModel {
            [NameInMap("config")]
            [Validation(Required=false)]
            public SubmitHtmlTranslateTaskRequestExtConfig Config { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtConfig : TeaModel {
                [NameInMap("callbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                [NameInMap("skipCsiCheck")]
                [Validation(Required=false)]
                public bool? SkipCsiCheck { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>technology</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<SubmitHtmlTranslateTaskRequestExtExamples> Examples { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtExamples : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<SubmitHtmlTranslateTaskRequestExtTerminologies> Terminologies { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtTerminologies : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ML</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public SubmitHtmlTranslateTaskRequestExtTextTransform TextTransform { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toUpper")]
                [Validation(Required=false)]
                public bool? ToUpper { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mt-turbo</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
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
