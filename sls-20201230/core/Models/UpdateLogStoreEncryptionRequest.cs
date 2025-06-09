// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateLogStoreEncryptionRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the encryption feature. After you update the encryption configuration of the Logstore, you can modify only the enable parameter in subsequent update requests. You cannot modify the encryptType or userCmkInfo parameters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The encryption algorithm. Valid values: default, m4, sm4_ecb, sm4_cbc, sm4_gcm, aes_ecb, aes_cbc, aes_cfb, aes_ofb, and aes_gcm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("encryptType")]
        [Validation(Required=false)]
        public string EncryptType { get; set; }

        /// <summary>
        /// <para>Optional. If you use a BYOK key to encrypt logs, you must specify this parameter. If you use the service key of Simple Log Service to encrypt logs, you do not need to specify this parameter.</para>
        /// </summary>
        [NameInMap("userCmkInfo")]
        [Validation(Required=false)]
        public UpdateLogStoreEncryptionRequestUserCmkInfo UserCmkInfo { get; set; }
        public class UpdateLogStoreEncryptionRequestUserCmkInfo : TeaModel {
            /// <summary>
            /// <para>The ID of the CMK to which the BYOK key belongs. You can create a CMK in KMS. The CMK must be in the same region as the endpoint of Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>f5136b95-2420-ab31-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("keyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

            /// <summary>
            /// <para>The region ID. Example: cn-hangzhou.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role.The value is in the acs:ram::12344\<em>\</em>\*:role/xxxxx format. To use a BYOK key to encrypt logs, you must create a RAM role and grant the AliyunKMSReadOnlyAccess and AliyunKMSCryptoUserAccess permissions to the RAM role. You must grant the API caller the PassRole permission on the RAM role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::12344***:role/xxxxx</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

    }

}
