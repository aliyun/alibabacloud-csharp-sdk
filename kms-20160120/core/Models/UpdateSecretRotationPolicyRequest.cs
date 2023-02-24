// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretRotationPolicyRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic rotation. Valid values:
        /// 
        /// *   true: enables automatic rotation.
        /// *   false: does not enable automatic rotation. This is the default value.
        /// </summary>
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        /// <summary>
        /// The interval for automatic rotation. Valid values: 6 hours to 8,760 hours (365 days).
        /// 
        /// The value is in the `integer[unit]` format.````
        /// 
        /// The unit can be d (day), h (hour), m (minute), or s (second). For example, both 7d and 604800s indicate a seven-day interval.
        /// 
        /// >  This parameter is required if you set the EnableAutomaticRotation parameter to true. This parameter is ignored if you set the EnableAutomaticRotation parameter to false or does not specify the EnableAutomaticRotation parameter.
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

    }

}
