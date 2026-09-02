// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicTemplateRegistryConfig : TeaModel {
        /// <summary>
        /// <para>The network configuration of the image repository.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public PublicTemplateRegistryNetworkConfig NetworkConfig { get; set; }

    }

}
