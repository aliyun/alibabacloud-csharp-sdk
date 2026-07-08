// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitImageTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Extended parameters to control translation features.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public SubmitImageTranslateTaskRequestExt Ext { get; set; }
        public class SubmitImageTranslateTaskRequestExt : TeaModel {
            /// <summary>
            /// <para>An English string that guides the translation style of the large language model (LLM).</para>
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
            public List<SubmitImageTranslateTaskRequestExtExamples> Examples { get; set; }
            public class SubmitImageTranslateTaskRequestExtExamples : TeaModel {
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
            /// <para>Parameters for isolating terminology to prevent interference between different users or business scenarios. Use <c>bizUserId</c> for user-level isolation and <c>bizType</c> for scenario-level isolation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bizUserld&quot;:&quot;123456&quot;,&quot;bizType&quot;:session&quot;}</para>
            /// </summary>
            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            /// <summary>
            /// <para>A list of sensitive words.</para>
            /// </summary>
            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            /// <summary>
            /// <para>A list of custom term pairs to apply to the translation.</para>
            /// </summary>
            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<SubmitImageTranslateTaskRequestExtTerminologies> Terminologies { get; set; }
            public class SubmitImageTranslateTaskRequestExtTerminologies : TeaModel {
                /// <summary>
                /// <para>The source text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机器学习</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The custom translation for the source text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ML</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>Specifies case conversion for the translated text.</para>
            /// </summary>
            [NameInMap("textTransform")]
            [Validation(Required=false)]
            public SubmitImageTranslateTaskRequestExtTextTransform TextTransform { get; set; }
            public class SubmitImageTranslateTaskRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <para>Set to <c>true</c> to convert the entire translated text to lowercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                /// <summary>
                /// <para>Set to <c>true</c> to convert the entire translated text to title case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                /// <summary>
                /// <para>Set to <c>true</c> to convert the entire translated text to uppercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toUpper")]
                [Validation(Required=false)]
                public bool? ToUpper { get; set; }

            }

            /// <summary>
            /// <para>User-defined pass-through data that the service returns unmodified in the response. This is typically used for analytics tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;trace_123456&quot;}</para>
            /// </summary>
            [NameInMap("trackingData")]
            [Validation(Required=false)]
            public string TrackingData { get; set; }

        }

        /// <summary>
        /// <para>The translation format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image</para>
        /// </summary>
        [NameInMap("format")]
        [Validation(Required=false)]
        public string Format { get; set; }

        /// <summary>
        /// <para>Specifies the translation model.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flash</para>
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
        /// <para>A list of target languages.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public List<string> TargetLanguage { get; set; }

        /// <summary>
        /// <para>The URL of the image to translate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i3/2214557014466/O1CN0174Thmb1irTsyTXYFO_!!4611686018427386306-0-item_pic.jpg">https://img.alicdn.com/imgextra/i3/2214557014466/O1CN0174Thmb1irTsyTXYFO_!!4611686018427386306-0-item_pic.jpg</a></para>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <para>The ID of the Model Studio workspace.</para>
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
