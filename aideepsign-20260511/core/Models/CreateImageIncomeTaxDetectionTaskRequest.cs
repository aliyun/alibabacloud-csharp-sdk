// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateImageIncomeTaxDetectionTaskRequest : TeaModel {
        /// <summary>
        /// <para>The idempotency parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The URL of the income tax screenshot to detect. Only HTTP/HTTPS URLs are supported. The image size cannot exceed 10 MB. External images are not supported. Only URLs accessible from the Chinese mainland public network are supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/incometax.png">https://example.com/incometax.png</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
