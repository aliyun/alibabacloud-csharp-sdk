// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitDocTranslateTaskRequest : TeaModel {
        [NameInMap("ext")]
        [Validation(Required=false)]
        public SubmitDocTranslateTaskRequestExt Ext { get; set; }
        public class SubmitDocTranslateTaskRequestExt : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>This text comes from a rigorous academic paper. Please provide a translation that complies with academic standards.</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<SubmitDocTranslateTaskRequestExtExamples> Examples { get; set; }
            public class SubmitDocTranslateTaskRequestExtExamples : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>llm</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<SubmitDocTranslateTaskRequestExtTerminologies> Terminologies { get; set; }
            public class SubmitDocTranslateTaskRequestExtTerminologies : TeaModel {
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>llm</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public SubmitDocTranslateTaskRequestExtTextTransform TextTransform { get; set; }
            public class SubmitDocTranslateTaskRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
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
                /// <para>true</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spoke-llm</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx-hangzhou.aliyuncs.com/docs/tmp/%E6%A0%B7%E4%BE%8B_%E6%97%A0%E5%9B%BE.pdf">https://xxx-hangzhou.aliyuncs.com/docs/tmp/%E6%A0%B7%E4%BE%8B_%E6%97%A0%E5%9B%BE.pdf</a></para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-kqtrcpdee4xm29xc</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
