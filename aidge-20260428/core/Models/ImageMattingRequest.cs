// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageMattingRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image to process.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE_BACKGROUND</para>
        /// </summary>
        [NameInMap("BackGroundType")]
        [Validation(Required=false)]
        public string BackGroundType { get; set; }

        /// <summary>
        /// <para>The target image height in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255,255,255</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public string BgColor { get; set; }

        /// <summary>
        /// <para>The URL of the original image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256 × 256 and 3000 × 3000 pixels. The file size cannot exceed 10 MB.<br><b>Example</b>: <c>&quot;https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg&quot;</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sc02.alicdn.com/kf/H09364d2c7fc942e685d3b0f656261b24Q.png">https://sc02.alicdn.com/kf/H09364d2c7fc942e685d3b0f656261b24Q.png</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The target image width in pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>The background type of the returned image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WHITE_BACKGROUND: white background.</description></item>
        /// <item><description>TRANSPARENT: transparent background.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetWidth")]
        [Validation(Required=false)]
        public int? TargetWidth { get; set; }

    }

}
