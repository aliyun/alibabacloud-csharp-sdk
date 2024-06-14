// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueRequest : TeaModel {
        /// <summary>
        /// The secret value. The value is encrypted and then stored in the new version.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        /// <summary>
        /// The type of the secret value. Valid values:
        /// 
        /// *   text: This is the default value.
        /// *   binary
        /// </summary>
        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The new version of the secret value. Version numbers must be unique in each secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        /// <summary>
        /// The stage labels that are used to mark the new version. If you do not specify this parameter, Secrets Manager marks the new version with ACSCurrent.
        /// </summary>
        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public string VersionStages { get; set; }

    }

}
