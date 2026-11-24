// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of translation features. Valid values: <c>speech</c> and <c>visual</c>. You can select both. At least one feature must be specified. Duplicate values are not accepted.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public string CapabilitiesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the quality check for on-screen text processing. This parameter takes effect only when <c>visual</c> is included and explicitly set to <c>true</c>. If only <c>speech</c> is selected, this parameter is ignored, no quality check is performed, no quality check fields are returned, and no error is reported due to this parameter. Enabling the quality check may increase the processing time. Do not enable it unless necessary. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableQualityCheck")]
        [Validation(Required=false)]
        public bool? EnableQualityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to only erase on-screen text without translation. This parameter is valid only when <c>visual</c> is included. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Erases the on-screen text without translation.</description></item>
        /// <item><description><c>false</c>: Translates the on-screen text.
        /// Default value: <c>false</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EraseOnly")]
        [Validation(Required=false)]
        public bool? EraseOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether to erase brand logos. This parameter is valid only when <c>visual</c> is included. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Erases brand logos.</description></item>
        /// <item><description><c>false</c>: Retains brand logos.
        /// Default value: <c>false</c>. This parameter is independent of <c>EraseOnly</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RemoveLogo")]
        [Validation(Required=false)]
        public bool? RemoveLogo { get; set; }

        /// <summary>
        /// <para>The original language of the video (source language). For supported languages, see Language support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The subtitle processing mode. This parameter is valid only when <c>speech</c> is included. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>erase</c>: Erases only the original subtitles.</description></item>
        /// <item><description><c>replace</c>: Replaces the original subtitles with translated subtitles. This erases the original subtitles and adds subtitles synchronized with the translated speech.</description></item>
        /// <item><description>If this parameter is not specified, the original subtitles are not processed. This means the original subtitles are not erased and no new subtitles are added.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>replace</para>
        /// </summary>
        [NameInMap("SubtitleMode")]
        [Validation(Required=false)]
        public string SubtitleMode { get; set; }

        /// <summary>
        /// <para>The target language. This parameter is required when <c>speech</c> is included. If only <c>visual</c> is included and <c>EraseOnly</c> is set to true, this parameter is optional and will be ignored if provided. In other cases, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
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
