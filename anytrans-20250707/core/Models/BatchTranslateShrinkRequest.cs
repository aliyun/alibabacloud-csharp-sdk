// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class BatchTranslateShrinkRequest : TeaModel {
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
        public string ExtShrink { get; set; }

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
        public string TextShrink { get; set; }

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
