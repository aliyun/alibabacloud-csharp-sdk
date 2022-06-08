// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretRequest : TeaModel {
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public UpdateSecretRequestExtendedConfig ExtendedConfig { get; set; }
        public class UpdateSecretRequestExtendedConfig : TeaModel {
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public Dictionary<string, string> CustomData { get; set; }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
