// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateImageRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;needEditorData&quot;: &quot;false&quot;, &quot;ignoreEntityRecognize&quot;: &quot;true&quot;}</para>
        /// </summary>
        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string Ext { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>general</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/9j/4...H/9k=</para>
        /// </summary>
        [NameInMap("ImageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/example.jpg">https://example.com/example.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
