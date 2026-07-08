// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitHtmlTranslateTaskRequest : TeaModel {
        /// <summary>
        /// <para>Extended parameters to control translation behavior.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public SubmitHtmlTranslateTaskRequestExt Ext { get; set; }
        public class SubmitHtmlTranslateTaskRequestExt : TeaModel {
            /// <summary>
            /// <para>Provides specific configuration settings for the translation task.</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public SubmitHtmlTranslateTaskRequestExtConfig Config { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtConfig : TeaModel {
                /// <summary>
                /// <para>The callback URL for receiving translation results.</para>
                /// </summary>
                [NameInMap("callbackUrl")]
                [Validation(Required=false)]
                public string CallbackUrl { get; set; }

                /// <summary>
                /// <para>Specifies whether to skip the Content Moderation check. To skip this check, you must first complete the Content Moderation disablement process before calling the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipCsiCheck")]
                [Validation(Required=false)]
                public bool? SkipCsiCheck { get; set; }

            }

            /// <summary>
            /// <para>A natural language prompt in English to guide the model\&quot;s translation style.</para>
            /// 
            /// <b>Example:</b>
            /// <para>his sentence from an e-commerce product image, please provide a translation that is both highly concise and no more than 1.2 times the length of the original.</para>
            /// </summary>
            [NameInMap("domainHint")]
            [Validation(Required=false)]
            public string DomainHint { get; set; }

            /// <summary>
            /// <para>A list of translation examples.</para>
            /// </summary>
            [NameInMap("examples")]
            [Validation(Required=false)]
            public List<SubmitHtmlTranslateTaskRequestExtExamples> Examples { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtExamples : TeaModel {
                /// <summary>
                /// <para>The source text in the example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>你好</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The target text in the example.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("tgt")]
                [Validation(Required=false)]
                public string Tgt { get; set; }

            }

            /// <summary>
            /// <para>Provides extended parameter configuration. The <c>bizUserId</c> key specifies the business user ID to isolate custom terminology enforcement by user. The <c>bizType</c> key specifies the business scenario type to isolate custom terminology enforcement by scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;bizUserld&quot;:&quot;123456&quot;,&quot;bizType&quot;:session&quot;}</para>
            /// </summary>
            [NameInMap("paramMap")]
            [Validation(Required=false)]
            public object ParamMap { get; set; }

            /// <summary>
            /// <para>A list of sensitive words to filter from the translation.</para>
            /// </summary>
            [NameInMap("sensitives")]
            [Validation(Required=false)]
            public List<string> Sensitives { get; set; }

            /// <summary>
            /// <para>A list of custom terminology pairs to apply to the translation.</para>
            /// </summary>
            [NameInMap("terminologies")]
            [Validation(Required=false)]
            public List<SubmitHtmlTranslateTaskRequestExtTerminologies> Terminologies { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtTerminologies : TeaModel {
                /// <summary>
                /// <para>The source text for the terminology pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>机器学习</para>
                /// </summary>
                [NameInMap("src")]
                [Validation(Required=false)]
                public string Src { get; set; }

                /// <summary>
                /// <para>The target text for the terminology pair.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ML</para>
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
            public SubmitHtmlTranslateTaskRequestExtTextTransform TextTransform { get; set; }
            public class SubmitHtmlTranslateTaskRequestExtTextTransform : TeaModel {
                /// <summary>
                /// <para>Converts the entire translated text to lowercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toLower")]
                [Validation(Required=false)]
                public bool? ToLower { get; set; }

                /// <summary>
                /// <para>Converts the translated text to title case.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toTitle")]
                [Validation(Required=false)]
                public bool? ToTitle { get; set; }

                /// <summary>
                /// <para>Converts the entire translated text to uppercase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("toUpper")]
                [Validation(Required=false)]
                public bool? ToUpper { get; set; }

            }

            /// <summary>
            /// <para>Custom passthrough data that the service returns unprocessed in the response. Useful for tasks such as event tracking.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;traceId&quot;:&quot;trace_123456&quot;}</para>
            /// </summary>
            [NameInMap("trackingData")]
            [Validation(Required=false)]
            public string TrackingData { get; set; }

        }

        /// <summary>
        /// <para>The format of the input text.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("sourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("targetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The HTML content to be translated.</para>
        /// 
        /// <b>Example:</b>
        /// <!DOCTYPE html>
        /// <html lang="zh-CN">
        /// <head>
        ///     <meta charset="UTF-8">
        ///     <meta name="viewport" content="width=device-width, initial-scale=1.0">
        ///     <title>我的第一个网页</title>
        /// </head>
        /// <body>
        ///     <h1>欢迎来到我的网页！</h1>
        ///     <para>这是一个简单的 HTML 页面。</para>
        ///     <para>学习 HTML 是进入网页开发的第一步。</para>
        ///     <a href="https://www.example.com">点击这里访问示例网站</a>
        /// </body>
        /// </html>
        /// </summary>
        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

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
