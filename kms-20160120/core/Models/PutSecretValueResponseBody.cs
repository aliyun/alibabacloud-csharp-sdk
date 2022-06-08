// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class PutSecretValueResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

        [NameInMap("VersionStages")]
        [Validation(Required=false)]
        public PutSecretValueResponseBodyVersionStages VersionStages { get; set; }
        public class PutSecretValueResponseBodyVersionStages : TeaModel {
            [NameInMap("VersionStage")]
            [Validation(Required=false)]
            public List<string> VersionStage { get; set; }
        };

    }

}
