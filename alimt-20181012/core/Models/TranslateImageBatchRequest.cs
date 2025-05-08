// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class TranslateImageBatchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my_awesome_task_1</para>
        /// </summary>
        [NameInMap("CustomTaskId")]
        [Validation(Required=false)]
        public string CustomTaskId { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/1.jpg,https://example.com/2.jpg,https://example.com/3.jpg">https://example.com/1.jpg,https://example.com/2.jpg,https://example.com/3.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrls")]
        [Validation(Required=false)]
        public string ImageUrls { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

    }

}
