// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretRotationPolicyRequest : TeaModel {
        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
