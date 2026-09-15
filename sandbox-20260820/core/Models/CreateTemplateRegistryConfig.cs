// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateRegistryConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryAuthConfig AuthConfig { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryCertConfig CertConfig { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
