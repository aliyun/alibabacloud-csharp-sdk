// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RegistryConfig : TeaModel {
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public RegistryAuthConfig AuthConfig { get; set; }

        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public RegistryCertConfig CertConfig { get; set; }

    }

}
