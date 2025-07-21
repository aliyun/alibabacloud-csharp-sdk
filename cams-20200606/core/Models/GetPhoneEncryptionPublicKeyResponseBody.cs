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
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>The value OK indicates that the request was successful.</description></item>
        /// <item><description>For more information about other response codes, see <a href="https://help.aliyun.com/document_detail/196974.html">Error codes</a>.</description></item>
        /// </list>
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
            /// <para>-----BEGIN PUBLIC KEY-----
            /// AAA
            /// BBB
            /// CCC
            /// DDD
            /// EEE
            /// FFF
            /// GGG
            /// -----END PUBLIC KEY-----</para>
            /// </summary>
            [NameInMap("EncryptionPublicKey")]
            [Validation(Required=false)]
            public string EncryptionPublicKey { get; set; }

            /// <summary>
            /// <para>The validity state of the public key. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MISMATCH: The public key is invalid.</description></item>
            /// <item><description>VALID: The public key is valid.</description></item>
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
            /// <para>86138000**</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

        }

        /// <summary>
        /// <para>Error description information.</para>
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
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
