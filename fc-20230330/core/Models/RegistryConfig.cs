// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RegistryConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public RegistryAuthConfig AuthConfig { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public RegistryCertConfig CertConfig { get; set; }

        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public RegistryNetworkConfig NetworkConfig { get; set; }

    }

}
