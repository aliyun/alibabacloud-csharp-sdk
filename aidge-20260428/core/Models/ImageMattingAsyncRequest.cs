// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageMattingAsyncRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the background format of the returned image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WHITE_BACKGROUND: Returns an image with a white background.</description></item>
        /// <item><description>TRANSPARENT: Returns an image with a transparent background.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE_BACKGROUND</para>
        /// </summary>
        [NameInMap("BackGroundType")]
        [Validation(Required=false)]
        public string BackGroundType { get; set; }

        /// <summary>
        /// <para>The BGR color value of the background. Default value: white.</para>
        /// 
        /// <b>Example:</b>
        /// <para>255,255,255</para>
        /// </summary>
        [NameInMap("BgColor")]
        [Validation(Required=false)]
        public string BgColor { get; set; }

        /// <summary>
        /// <para>The business order ID of the caller. It is recorded upon acceptance and returned as is when you query the result of the asynchronous task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The URL of the original image. The image must be in JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 100 × 100 and 3000 × 3000 pixels, and the file size must not exceed 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The expected height of the cropped image. If you do not specify this parameter, the original height of the image is used. Unit: pixels. Valid values: 100 to 5000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetHeight")]
        [Validation(Required=false)]
        public int? TargetHeight { get; set; }

        /// <summary>
        /// <para>The expected width of the cropped image. If you do not specify this parameter, the original width of the image is used. Unit: pixels. Valid values: 100 to 5000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("TargetWidth")]
        [Validation(Required=false)]
        public int? TargetWidth { get; set; }

    }

}
