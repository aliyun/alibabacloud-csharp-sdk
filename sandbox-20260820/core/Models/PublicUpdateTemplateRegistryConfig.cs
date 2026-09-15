// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateRegistryConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryAuthConfig AuthConfig { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryCertConfig CertConfig { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
