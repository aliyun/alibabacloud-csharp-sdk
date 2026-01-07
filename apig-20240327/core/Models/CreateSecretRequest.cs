// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateSecretRequest : TeaModel {
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("kmsConfig")]
        [Validation(Required=false)]
        public KMSConfig KmsConfig { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("secretData")]
        [Validation(Required=false)]
        public string SecretData { get; set; }

        [NameInMap("secretSource")]
        [Validation(Required=false)]
        public string SecretSource { get; set; }

    }

}
