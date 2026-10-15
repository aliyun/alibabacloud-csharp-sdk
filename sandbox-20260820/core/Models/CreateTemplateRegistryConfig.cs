// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateRegistryConfig : TeaModel {
        /// <summary>
        /// <para>The logon credentials for the image repository. No configuration is required when accessing a public repository.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The certificate validation configuration for accessing the image repository.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryCertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The VPC configuration used to access the image repository. Configuration is required only when the repository is reachable only within a VPC.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
