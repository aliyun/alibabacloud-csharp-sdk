// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class ImageRemovalProAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The business order ID of the caller. This ID is recorded when the request is accepted and returned as-is when you query the asynchronous task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The URL of the original image. The image must be in the JPG, JPEG, PNG, BMP, or WEBP format.
        /// · Resolution: 256×256 to 3000×3000. File size: ≤ 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
