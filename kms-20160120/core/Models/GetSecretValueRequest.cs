// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetSecretValueRequest : TeaModel {
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("FetchExtendedConfig")]
        [Validation(Required=false)]
        public bool? FetchExtendedConfig { get; set; }

    }

}
