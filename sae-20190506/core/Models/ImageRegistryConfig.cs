// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ImageRegistryConfig : TeaModel {
        /// <summary>
        /// <para>The authentication configuration for the image repository.</para>
        /// </summary>
        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public RegistryAuthenticationConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The certificate configuration for the image repository.</para>
        /// </summary>
        [NameInMap("CertConfig")]
        [Validation(Required=false)]
        public RegistryCertificateConfig CertConfig { get; set; }

    }

}
