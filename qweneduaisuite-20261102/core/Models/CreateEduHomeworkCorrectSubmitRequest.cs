// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102.Models
{
    public class CreateEduHomeworkCorrectSubmitRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to correct the image distortion. Default value: <c>true</c>. If you set this parameter to <c>false</c>, the image is not corrected, <c>dewarp_url</c> returns the original image, and the coordinates are based on <c>dewarp_url</c>.</para>
        /// </summary>
        [NameInMap("dewarp")]
        [Validation(Required=false)]
        public bool? Dewarp { get; set; }

        /// <summary>
        /// <para>The pure Base64-encoded string of the image, excluding the <c>data:</c> prefix and MIME declaration. The encoded size cannot exceed 15 MB. If both parameters are specified, <c>image_base64</c> takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The pure Base64-encoded string of the image, excluding the data: prefix and MIME declaration. The encoded size cannot exceed 15 MB. If both parameters are specified, image_base64 takes precedence</para>
        /// </summary>
        [NameInMap("imageBase64")]
        [Validation(Required=false)]
        public string ImageBase64 { get; set; }

        /// <summary>
        /// <para>The publicly accessible HTTP or HTTPS URL of the image. The server downloads the image from this URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/homework.jpg">https://example.com/homework.jpg</a></para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The request ID on the caller side. Use a UUID for reconciliation and troubleshooting. If this parameter is not specified, the server generates a request ID and returns it in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>req-20261116-0001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
