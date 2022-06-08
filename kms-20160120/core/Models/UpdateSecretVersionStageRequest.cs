// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretVersionStageRequest : TeaModel {
        [NameInMap("MoveToVersion")]
        [Validation(Required=false)]
        public string MoveToVersion { get; set; }

        [NameInMap("RemoveFromVersion")]
        [Validation(Required=false)]
        public string RemoveFromVersion { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionStage")]
        [Validation(Required=false)]
        public string VersionStage { get; set; }

    }

}
