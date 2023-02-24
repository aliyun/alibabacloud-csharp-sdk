// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeSecretResponseBody : TeaModel {
        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the secret.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

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
        /// The ID of the dedicated KMS instance.
        /// </summary>
        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        /// <summary>
        /// The description of the secret.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of the customer master key (CMK) that is used to encrypt the secret value.
        /// </summary>
        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        /// <summary>
        /// The extended configuration of the secret.
        /// 
        /// >  This parameter is returned only for a managed ApsaraDB RDS secret, a managed Resource Access Management (RAM) secret, or a managed Elastic Compute Service (ECS) secret.
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
        /// >  This parameter is returned when automatic rotation is enabled.
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// The time when the secret is scheduled to be deleted.
        /// </summary>
        [NameInMap("PlannedDeleteTime")]
        [Validation(Required=false)]
        public string PlannedDeleteTime { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The interval for automatic rotation.
        /// 
        /// The value is in the `integer[unit]` format. `integer` indicates the length of time. `unit`: indicates the time unit. The value of `unit` is fixed as s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.
        /// 
        /// >  This parameter is returned when automatic rotation is enabled.
        /// </summary>
        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

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
        /// The resource tags of the secret.
        /// 
        /// This parameter is not returned if you set the FetchTags parameter to false or you do not specify the FetchTags parameter.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeSecretResponseBodyTags Tags { get; set; }
        public class DescribeSecretResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeSecretResponseBodyTagsTag> Tag { get; set; }
            public class DescribeSecretResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The time when the secret was updated.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
