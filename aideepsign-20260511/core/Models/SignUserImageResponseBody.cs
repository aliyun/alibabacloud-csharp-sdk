// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class SignUserImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm used for signing, such as ps256 or es256.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ps256</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The subject information of the signing certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN=AIDeepSign User Certificate,O=Alibaba Cloud</para>
        /// </summary>
        [NameInMap("CertificateSubject")]
        [Validation(Required=false)]
        public string CertificateSubject { get; set; }

        /// <summary>
        /// <para>The business error code. The value &quot;OK&quot; is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. The value 200 is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. The value &quot;success&quot; is returned if the request succeeds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ObjectKey of the signed image in OSS. You can use this value for subsequent API calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepsign/123456789/signed/abc12345-def6-7890-abcd-ef1234567890.png</para>
        /// </summary>
        [NameInMap("ObjectKey")]
        [Validation(Required=false)]
        public string ObjectKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The signing time in ISO 8601 format, such as <c>2026-01-15T08:30:00Z</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-06-18T10:30:00Z</para>
        /// </summary>
        [NameInMap("SignTime")]
        [Validation(Required=false)]
        public string SignTime { get; set; }

        /// <summary>
        /// <para>The pre-signed download URL of the signed image.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://bucket.oss-cn-hangzhou.aliyuncs.com/deepsign/123456789/signed/abc12345.png?Expires=1718700000&OSSAccessKeyId=">https://bucket.oss-cn-hangzhou.aliyuncs.com/deepsign/123456789/signed/abc12345.png?Expires=1718700000&amp;OSSAccessKeyId=</a>...</para>
        /// </summary>
        [NameInMap("SignedImageUrl")]
        [Validation(Required=false)]
        public string SignedImageUrl { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
