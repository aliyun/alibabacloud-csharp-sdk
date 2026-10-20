// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of translation features. Valid values: <c>speech</c> and <c>visual</c>. You can select both. At least one feature must be specified. Duplicate values are not allowed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public List<string> Capabilities { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the quality check for on-screen text processing. Default value: <c>false</c>. The quality check is enabled only when <c>visual</c> is included and this parameter is explicitly set to <c>true</c>. If only <c>speech</c> is selected, this parameter is ignored. No quality check is performed, no quality check fields are returned, and no errors are reported due to this parameter. Enabling the quality check may increase the waiting time. Do not enable it unless necessary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableQualityCheck")]
        [Validation(Required=false)]
        public bool? EnableQualityCheck { get; set; }

        /// <summary>
        /// <para>Specifies whether to only erase the source language text on the screen without translating it. This parameter is valid only when <c>visual</c> is included. Valid values: <c>true</c> (only erases the text) and <c>false</c> (translates the on-screen text). Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EraseOnly")]
        [Validation(Required=false)]
        public bool? EraseOnly { get; set; }

        /// <summary>
        /// <para>Specifies whether to remove the brand logo. This parameter is valid only when <c>visual</c> is included. Valid values: <c>true</c> (removes the brand logo) and <c>false</c> (retains the logo). Default value: <c>false</c>. This parameter is independent of <c>EraseOnly</c>.</para>
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
        /// <para>The subtitle processing mode. This parameter is valid only when <c>speech</c> is included. Valid values: <c>erase</c> (removes only the original subtitles) and <c>replace</c> (removes the original subtitles and adds new subtitles). If this parameter is omitted, the original subtitles are not processed and no new subtitles are added.</para>
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

