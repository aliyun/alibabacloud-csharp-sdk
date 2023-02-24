// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether automatic rotation is enabled. Valid values:
        /// 
        /// *   Enabled: indicates that automatic rotation is enabled.
        /// *   Disabled: indicates that automatic rotation is disabled.
        /// *   Invalid: indicates that the status of automatic rotation is abnormal. In this case, Secrets Manager cannot automatically rotate the secret.
        /// 
        /// >  This parameter is returned only for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        /// <summary>
        /// The time when the secret was created.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The extended configuration of the secret.
        /// 
        /// >  This parameter is returned if you set the FetchExtendedConfig parameter to true. This parameter is returned only for a managed ApsaraDB RDS secret, a managed RAM secret, or a managed ECS secret.
        /// </summary>
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// The time when the last rotation was performed.
        /// 
        /// >  This parameter is returned if the secret was rotated.
        /// </summary>
        [NameInMap("LastRotationDate")]
        [Validation(Required=false)]
        public string LastRotationDate { get; set; }

        /// <summary>
        /// The time when the next rotation will be performed.
        /// 
        /// >  This parameter is returned if automatic rotation is enabled.
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The interval for automatic rotation.
        /// 
        /// The value is in the `integer[unit]` format. The `unit` field has a fixed value of s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.
        /// 
        /// >  This parameter is returned if automatic rotation is enabled.
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// The secret value. Secrets Manager decrypts the ciphertext of the secret value and returns the plaintext of the secret value in this parameter.
        /// 
        /// *   For a generic secret, the secret value of the specified version is returned.
        /// 
        /// *   For a managed ApsaraDB RDS secret, the value is returned in the following format:`{"AccountName":"","AccountPassword":""}` .
        /// 
        /// *   For a managed RAM secret, the secret value is returned in the following format: `{"AccessKeyId":"Adfdsfd","AccessKeySecret":"fdsfdsf","GenerateTimestamp": "2016-03-25T10:42:40Z"}`.
        /// 
        /// *   For a managed ECS secret, the secret value is returned in one of the following formats:
        /// 
        ///     *   `{"UserName":"root","Password":"H5asdasdsads****"}`: The secret value is returned in this format if the ECS secret is a password.
        ///     *   `{"UserName":"root","PublicKey":"ssh-rsa ****mKwnVix9YTFY9Rs= imported-openssh-key","PrivateKey": "d6bee1cb-2e14-4277-ba6b-73786b21****"}`: The secret value is returned in this format is the ECS secret is a pair of SSH keys. The private key is in the Privacy Enhanced Mail (PEM) format.
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// The type of the secret value. Valid values:
        /// 
        /// *   text
        /// *   binary
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// The name of the secret.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The type of the secret. Valid values:
        /// 
        /// *   Generic: indicates a generic secret.
        /// *   Rds: indicates a managed ApsaraDB RDS secret.
        /// *   RAMCredentials: indicates a managed RAM secret.
        /// *   ECS: indicates a managed ECS secret.
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// The version number of the secret value.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// The stage labels that mark the secret versions.
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public GetSecretValueResponseBodyVersionStages VersionStages { get; set; }
        public class GetSecretValueResponseBodyVersionStages : TeaModel {
            [NameInMap("VersionStage")]
            [Validation(Required=false)]
            public List<string> VersionStage { get; set; }

        }

    }

}
