// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetImageTranslateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;have_ocr&quot;: &quot;false&quot;, &quot;without_text&quot;:&quot;true&quot;, &quot;have_psd&quot;: &quot;false&quot;, &quot;ignore_entity&quot;: &quot;false&quot;}</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxxxxx.oss-cn-shenzhen.aliyuncs.com/xxxxxx.jpg">http://xxxxxxx.oss-cn-shenzhen.aliyuncs.com/xxxxxx.jpg</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
