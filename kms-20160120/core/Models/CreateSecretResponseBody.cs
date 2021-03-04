// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretResponseBody : TeaModel {
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("NextRotationDate")]
        [Validation(Required=false)]
        public string NextRotationDate { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfig { get; set; }

        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        [NameInMap("AutomaticRotation")]
        [Validation(Required=false)]
        public string AutomaticRotation { get; set; }

    }

}
