// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateSensitiveScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The URL of the image to scan. Only HTTP and HTTPS protocols are supported. The image size cannot exceed 10 MB. You must specify at least one of ImageUrl and ObjectKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/document.jpg">https://example.com/document.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ObjectKey of the image to scan in OSS. When you use ObjectKey, make sure that the key belongs to the namespace of the current caller. You must specify at least one of ImageUrl and ObjectKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepsign/123456789/scan/abc12345.jpg</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
