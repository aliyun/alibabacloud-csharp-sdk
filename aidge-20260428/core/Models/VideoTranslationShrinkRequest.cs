// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of translation features. Valid values: speech and visual. You can select both. At least one feature is required. Duplicate values are not accepted.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public string CapabilitiesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the quality check for on-screen text processing. Default value: false. The quality check is enabled when visual is included and this parameter is explicitly set to true. If only speech is selected, this parameter is ignored, no quality check is performed, no quality check fields are returned, and no errors are reported due to this parameter. Enabling the quality check may increase the waiting time. Do not enable it unless necessary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableQualityCheck")]
        [Validation(Required=false)]
        public bool? EnableQualityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to only erase the source language text in the video frames without translating it. This parameter is valid only when visual is included. Valid values: true (erases only) and false (translates the on-screen text). Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EraseOnly")]
        [Validation(Required=false)]
        public bool? EraseOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether to erase brand logos. This parameter is valid only when visual is included. Valid values: true (erases brand logos) and false (retains logos). Default value: false. This parameter is independent of eraseOnly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RemoveLogo")]
        [Validation(Required=false)]
        public bool? RemoveLogo { get; set; }

        /// <summary>
        /// <para>The source language. For supported languages, see Language support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The subtitle processing mode. This parameter is valid only when speech is included. Valid values: erase (erases only the original subtitles) and replace (erases the original subtitles and adds new subtitles). If this parameter is omitted, the original subtitles are not processed and no new subtitles are added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>erase</para>
        /// </summary>
        [NameInMap("SubtitleMode")]
        [Validation(Required=false)]
        public string SubtitleMode { get; set; }

        /// <summary>
        /// <para>The target language. This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ru</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The URL of the video. Supported formats: MP4 and MOV. Maximum size: 200 MB.</para>
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
