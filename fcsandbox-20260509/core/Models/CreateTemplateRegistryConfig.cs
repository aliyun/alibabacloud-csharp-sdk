// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateRegistryConfig : TeaModel {
        /// <summary>
        /// <para>The image repository authentication configuration.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The image repository certificate configuration.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryCertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The image repository network configuration.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
