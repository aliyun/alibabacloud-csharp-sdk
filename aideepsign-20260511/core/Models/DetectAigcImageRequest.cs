// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class DetectAigcImageRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image to detect. Only HTTP/HTTPS protocols are supported. You must provide at least one of <c>ImageUrl</c> and <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/photo.jpg">https://example.com/photo.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
