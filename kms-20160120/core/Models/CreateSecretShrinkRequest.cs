// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretShrinkRequest : TeaModel {
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public string ExtendedConfigShrink { get; set; }

        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

    }

}
