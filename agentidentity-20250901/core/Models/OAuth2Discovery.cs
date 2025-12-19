// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class OAuth2Discovery : TeaModel {
        [NameInMap("AuthorizationServerMetadata")]
        [Validation(Required=false)]
        public AuthorizationServerMetadata AuthorizationServerMetadata { get; set; }

        [NameInMap("DiscoveryURL")]
        [Validation(Required=false)]
        public string DiscoveryURL { get; set; }

    }

}
