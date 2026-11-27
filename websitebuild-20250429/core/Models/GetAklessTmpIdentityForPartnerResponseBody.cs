// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetAklessTmpIdentityForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The business response data. If the call is successful, this field contains the temporary credentials for the selected zero-trust role.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAklessTmpIdentityForPartnerResponseBodyData Data { get; set; }
        public class GetAklessTmpIdentityForPartnerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ciphertext strings of the three temporary credentials returned in the same call. Decrypt them separately and use them as a set.</para>
            /// </summary>
            [NameInMap("Credentials")]
            [Validation(Required=false)]
            public GetAklessTmpIdentityForPartnerResponseBodyDataCredentials Credentials { get; set; }
            public class GetAklessTmpIdentityForPartnerResponseBodyDataCredentials : TeaModel {
                /// <summary>
                /// <para>The ciphertext of the temporary AccessKey ID. Decode the string by using standard Base64, take the first 16 bytes as the initialization vector, and decrypt the remaining bytes by using AES/CBC/PKCS5Padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AQEBAQEBAQEBAQEBAQEBATGaJNzEdbS0zT+Sgseto+jKej8wWgHwzjOczWVj8AGR</para>
                /// </summary>
                [NameInMap("EncryptedAccessKeyId")]
                [Validation(Required=false)]
                public string EncryptedAccessKeyId { get; set; }

                /// <summary>
                /// <para>The ciphertext of the temporary AccessKey secret. Decode the string by using standard Base64, take the first 16 bytes as the initialization vector, and decrypt the remaining bytes by using AES/CBC/PKCS5Padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgICAgICAgICAgICAgICAs+sp9yHakZDA+poFujaJexJbkzXm6PqZwKvcU02cIpA</para>
                /// </summary>
                [NameInMap("EncryptedAccessKeySecret")]
                [Validation(Required=false)]
                public string EncryptedAccessKeySecret { get; set; }

                /// <summary>
                /// <para>The ciphertext of the temporary security token. Decode the string by using standard Base64, take the first 16 bytes as the initialization vector, and decrypt the remaining bytes by using AES/CBC/PKCS5Padding.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AwMDAwMDAwMDAwMDAwMDAzRAieKgJULKm3/u+5GoCPQvvekE5/6+8sjz+1FNHYzA</para>
                /// </summary>
                [NameInMap("EncryptedSecurityToken")]
                [Validation(Required=false)]
                public string EncryptedSecurityToken { get; set; }

            }

        }

        /// <summary>
        /// <para>The business error code. If the call fails, you can identify the cause of the failure by using this code in combination with the Code in the gateway response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.Validation.Error</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The business error message. If the call fails, you can troubleshoot the issue by using this message in combination with the Message and request ID in the gateway response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Parameter %s%s</para>
        /// </summary>
        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// <para>The request ID of the current call. Provide this value for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89AB-CDEF-0123-456789ABCDEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the business call is successful. A value of true indicates that you can read Data.Credentials. A value of false indicates that the credential retrieval failed.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
