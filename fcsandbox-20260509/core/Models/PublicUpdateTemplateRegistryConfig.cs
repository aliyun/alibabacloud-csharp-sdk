// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicUpdateTemplateRegistryConfig : TeaModel {
        /// <summary>
        /// <para>The image repository authentication configuration.</para>
        /// </summary>
        [NameInMap("authConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryAuthConfig AuthConfig { get; set; }

        /// <summary>
        /// <para>The image repository certificate configuration.</para>
        /// </summary>
        [NameInMap("certConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryCertConfig CertConfig { get; set; }

        /// <summary>
        /// <para>The image repository network configuration.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
