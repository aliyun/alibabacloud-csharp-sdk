// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateSecretRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableAutomaticRotation")]
        [Validation(Required=false)]
        public bool? EnableAutomaticRotation { get; set; }

        [NameInMap("EncryptionKeyId")]
        [Validation(Required=false)]
        public string EncryptionKeyId { get; set; }

        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtendedConfig { get; set; }

        [NameInMap("RotationInterval")]
        [Validation(Required=false)]
        public string RotationInterval { get; set; }

        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("SecretType")]
        [Validation(Required=false)]
        public string SecretType { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
