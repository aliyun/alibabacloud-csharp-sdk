// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ImageRegistryConfig : TeaModel {
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public RegistryAuthenticationConfig AuthConfig { get; set; }

        [NameInMap("CertConfig")]
        [Validation(Required=false)]
        public RegistryCertificateConfig CertConfig { get; set; }

    }

}
