// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class VideoTranslationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The array of translation capabilities. Valid values: [&quot;visual&quot;].</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Capabilities")]
        [Validation(Required=false)]
        public string CapabilitiesShrink { get; set; }

        /// <summary>
        /// <para>The source language. This parameter is optional. Default value: auto (automatic detection).</para>
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
        /// <para>The video URL (MP4/MOV, ≤ 200 MB).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/video.mp4">https://example.com/video.mp4</a></para>
        /// </summary>
        [NameInMap("VideoUrl")]
        [Validation(Required=false)]
        public string VideoUrl { get; set; }

    }

}
