// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class CreateSensitiveScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. The client generates this parameter value, which must be unique across different requests. <c>ClientToken</c> supports only ASCII characters and cannot exceed 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The URL of the image to be scanned. Only HTTP/HTTPS protocols are supported. The image size cannot exceed 10 MB. You must specify either <c>ImageUrl</c> or <c>ObjectKey</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/document.jpg">https://example.com/document.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

    }

}
