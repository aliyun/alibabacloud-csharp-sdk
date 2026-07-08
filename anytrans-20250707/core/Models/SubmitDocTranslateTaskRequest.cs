// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitDocTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Extension parameters that control translation features.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public SubmitDocTranslateTaskRequestExt Ext { get; set; }
        public class SubmitDocTranslateTaskRequestExt : TeaModel {
            /// <summary>
            /// <para>Configuration settings for the translation job.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public SubmitDocTranslateTaskRequestExtConfig Config { get; set; }
            public class SubmitDocTranslateTaskRequestExtConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to generate a bilingual document containing both the source and target text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isBilingual")]
                [Validation(Required=false)]
                public bool? IsBilingual { get; set; }

                /// <summary>
                /// <para>Specifies whether to translate images in PDF documents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipImgTrans")]
                [Validation(Required=false)]
                public bool? SkipImgTrans { get; set; }

            }

            /// <summary>
            /// <para>A prompt that tailors the translation style to a specific domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This text comes from a rigorous academic paper. Please provide a translation that complies with academic standards.</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            /// <summary>
            /// <para>A map for advanced configuration. Use <c>bizUserId</c> to apply terminologies on a per-user basis and <c>bizType</c> to apply them on a per-scenario basis. This prevents terminology conflicts between different users or scenarios.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bizUserld&quot;:&quot;123456&quot;,&quot;bizType&quot;:session&quot;}</para>
            /// </summary>
            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            /// <summary>
            /// <para>The glossary to apply to the translation.</para>
            /// </summary>
            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<SubmitDocTranslateTaskRequestExtTerminologies> Terminologies { get; set; }
            public class SubmitDocTranslateTaskRequestExtTerminologies : TeaModel {
                /// <summary>
                /// <para>The source text that the custom translation will replace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机器学习</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The custom translation for the corresponding source term.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ML</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>User-defined pass-through data. The service does not process this data and returns it as-is in the response. This is useful for scenarios such as tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;trace_123456&quot;}</para>
            /// </summary>
            [NameInMap("trackingData")]
            [Validation(Required=false)]
            public string TrackingData { get; set; }

        }

        /// <summary>
        /// <para>The format for the translation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>The translation model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-turbo</para>
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// <para>The source language code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The URL of the document to translate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx-hangzhou.aliyuncs.com/docs/tmp/%E6%A0%B7%E4%BE%8B_%E6%97%A0%E5%9B%BE.pdf">https://xxx-hangzhou.aliyuncs.com/docs/tmp/%E6%A0%B7%E4%BE%8B_%E6%97%A0%E5%9B%BE.pdf</a></para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace for the current request.</para>
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
