// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitHtmlTranslateTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Extended parameters to control translation behavior.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

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
