// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AnyTrans20250707.Models
{
    public class SubmitImageTranslateTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Extended parameters to control translation features.</para>
        /// </summary>
        [NameInMap("ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

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
        public string TargetLanguageShrink { get; set; }

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
