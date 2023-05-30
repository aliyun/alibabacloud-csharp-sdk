// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretResponseBody : TeaModel {
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// The type of the secret. Valid values:
        /// 
        /// *   Generic: indicates a generic secret.
        /// *   Rds: indicates a managed ApsaraDB RDS secret.
        /// *   RAMCredentials: indicates a managed RAM secret.
        /// *   ECS: indicates a managed ECS secret.
        /// </summary>
        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

        [NameInMap("DKMSInstanceId")]
        [Validation(Required=false)]
        public string DKMSInstanceId { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        /// <summary>
        /// The extended configuration of the secret.
        /// 
        /// >  This parameter is returned if you set the SecretType parameter to Rds, RAMCredentials, or ECS.
        /// </summary>
        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        /// <summary>
        /// The time when the next rotation will be performed.
        /// 
        /// >  This parameter is returned if automatic rotation is enabled.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        /// <summary>
        /// The interval for automatic rotation.
        /// 
        /// The value is in the `integer[unit]` format. The value of the `unit` field is fixed as s. For example, if the value is 604800s, automatic rotation is performed at a 7-day interval.
        /// 
        /// >  This parameter is returned if automatic rotation is enabled.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The ID of the dedicated KMS instance.
        /// </summary>
        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the secret.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
