// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class DetectImageBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image. Only HTTP/HTTPS protocols are supported. Specify either <c>ImageUrl</c> or <c>ObjectKey</c>. At least one of them is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/photo.jpg">https://example.com/photo.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
