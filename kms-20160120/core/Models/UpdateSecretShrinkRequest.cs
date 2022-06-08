// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdateSecretShrinkRequest : TeaModel {
        [NameInMap("ExtendedConfig")]
        [Validation(Required=false)]
        public UpdateSecretShrinkRequestExtendedConfig ExtendedConfig { get; set; }
        public class UpdateSecretShrinkRequestExtendedConfig : TeaModel {
            [NameInMap("CustomData")]
            [Validation(Required=false)]
            public string CustomData { get; set; }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
