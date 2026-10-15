// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of translation features. Valid values: <c>speech</c> and <c>visual</c>. You can select both. At least one feature is required. Duplicate values are not accepted.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public string CapabilitiesShrink { get; set; }

        /// <summary>
        /// <para>Default value: false. If <c>visual</c> is included and this parameter is explicitly set to true, the quality check for on-screen text processing is enabled. If only <c>speech</c> is selected, this parameter is ignored. No quality check is performed, no quality check fields are returned, and no errors are reported due to this parameter. Enabling the quality check may increase the waiting time. Do not enable it unless necessary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableQualityCheck")]
        [Validation(Required=false)]
        public bool? EnableQualityCheck { get; set; }

        /// <summary>
        /// <para>The source language. For supported languages, see &quot;Supported languages&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The target language. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ru</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The video URL. Supported formats: MP4 and MOV. Maximum size: 200 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://cdn.example.com/product-demo.mp4">https://cdn.example.com/product-demo.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
