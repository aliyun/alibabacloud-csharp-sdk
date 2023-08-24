// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeEncryptionKeyResponseBody : TeaModel {
        /// <summary>
        /// The ID of the Alibaba Cloud account that is used to create the custom key.
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// The time when the custom key is expected to be deleted. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// 
        /// > If the return value is an empty string, the custom key cannot be automatically deleted.
        /// </summary>
        [NameInMap("DeleteDate")]
        [Validation(Required=false)]
        public string DeleteDate { get; set; }

        /// <summary>
        /// The description of the custom key. By default, an empty string is returned.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the custom key.
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// The state of the custom key. Valid values:
        /// 
        /// *   **Enabled**: The custom key is available.
        /// *   **Disabled**: The custom key is unavailable.
        /// </summary>
        [NameInMap("EncryptionKeyStatus")]
        [Validation(Required=false)]
        public string EncryptionKeyStatus { get; set; }

        /// <summary>
        /// The encryption algorithm.
        /// </summary>
        [NameInMap("EncryptionName")]
        [Validation(Required=false)]
        public string EncryptionName { get; set; }

        /// <summary>
        /// The purpose of the custom key. A value of `ENCRYPT/DECRYPT` indicates encryption and decryption.
        /// </summary>
        [NameInMap("KeyUsage")]
        [Validation(Required=false)]
        public string KeyUsage { get; set; }

        /// <summary>
        /// The time when the custom key expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// 
        /// > If the return value is an empty string, the custom key does not expire.
        /// </summary>
        [NameInMap("MaterialExpireTime")]
        [Validation(Required=false)]
        public string MaterialExpireTime { get; set; }

        /// <summary>
        /// The source of the custom key. A value of **Aliyun_KMS** indicates [Key Management Service (KMS)](~~28935~~) of Alibaba Cloud.
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the Resource Access Management (RAM) role to which you want to grant permissions.
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

    }

}
