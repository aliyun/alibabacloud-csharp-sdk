// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class RotateSecretRequest : TeaModel {
        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// The version number of the secret after the secret is rotated.
        /// 
        /// >  The version number is used to ensure the idempotence of the request. Secrets Manager uses this version number to prevent your application from creating the same version of the secret when the application retries a request. If a version number already exists, Secrets Manager ignores the request for rotation and returns a success message.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
