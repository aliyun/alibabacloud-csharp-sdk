// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteSecretRequest : TeaModel {
        /// <summary>
        /// Specifies whether to forcibly delete the secret. If this parameter is set to true, the secret cannot be recovered.
        /// 
        /// Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default value)
        /// </summary>
        [NameInMap("ForceDeleteWithoutRecovery")]
        [Validation(Required=false)]
        public string ForceDeleteWithoutRecovery { get; set; }

        /// <summary>
        /// Specifies the recovery period of the secret if you do not forcibly delete it. Default value: 30. Unit: Days.
        /// </summary>
        [NameInMap("RecoveryWindowInDays")]
        [Validation(Required=false)]
        public string RecoveryWindowInDays { get; set; }

        /// <summary>
        /// The name of the secret.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
