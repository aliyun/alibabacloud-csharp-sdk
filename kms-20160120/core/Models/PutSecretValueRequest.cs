// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueRequest : TeaModel {
        [NameInMap("SecretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        [NameInMap("SecretDataType")]
        [Validation(Required=false)]
        public string SecretDataType { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public string VersionStages { get; set; }

    }

}
