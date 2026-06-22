// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class GetPhoneEncryptionPublicKeyResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The error code. For more information, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPhoneEncryptionPublicKeyResponseBodyData Data { get; set; }
        public class GetPhoneEncryptionPublicKeyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The public key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>-----BEGIN PUBLIC KEY-----\nMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAt+PMrYw4zUDEk+VeTrp0\n8LZaoVpiVFErX7iuoDjUs4F9vkxMQuIABjcXw\/swzTMEopLORQV28uqN\/2\/x9hjU\****\/Zwa\/Vk5Svp4\niVY4e22FsJCCWUEMvayO8Q+3UGq0eXXQ+8SlUWEMq1VaJ4pwCLsMnmgybA+VmJxi\nkwIDAQAB\n-----END PUBLIC KEY-----&quot;</para>
            /// </summary>
            [NameInMap("EncryptionPublicKey")]
            [Validation(Required=false)]
            public string EncryptionPublicKey { get; set; }

            /// <summary>
            /// <para>The status of the public key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>MISMATCH: The public key is invalid.</para>
            /// </description></item>
            /// <item><description><para>VALID: The public key is valid.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VALID</para>
            /// </summary>
            [NameInMap("EncryptionPublicKeyStatus")]
            [Validation(Required=false)]
            public string EncryptionPublicKeyStatus { get; set; }

            /// <summary>
            /// <para>The phone number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>861526377****</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DAC72B08-3327-33EF-BEDC-8EC3E83A6575</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
