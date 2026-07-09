// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class DetectImageBasicInfoRequest : TeaModel {
        /// <summary>
        /// <para>The URL of the image. Only HTTP and HTTPS protocols are supported. Specify either ImageUrl or ObjectKey. At least one of them is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/photo.jpg">https://example.com/photo.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ObjectKey of the image in OSS. When using ObjectKey, ensure that the key belongs to the namespace of the current caller. Specify either ImageUrl or ObjectKey. At least one of them is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepsign/123456789/image-generation/abc12345-def6-7890-abcd-ef1234567890.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
