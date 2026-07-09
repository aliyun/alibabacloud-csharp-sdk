// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class SignUserImageRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client generates this value. Make sure the value is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The URL of the image to be signed. HTTP and HTTPS URLs are supported. Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/photo.jpg">https://example.com/photo.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The ObjectKey of the image to be signed in OSS. When you use <c>ObjectKey</c>, make sure the key belongs to the namespace of the current caller. Specify at least one of <c>ImageUrl</c> and <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepsign/123456789/image-generation/abc12345-def6-7890-abcd-ef1234567890.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

    }

}
