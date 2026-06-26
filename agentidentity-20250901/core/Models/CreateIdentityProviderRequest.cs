// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateIdentityProviderRequest : TeaModel {
        [NameInMap("AllowedAudience")]
        [Validation(Required=false)]
        public List<string> AllowedAudience { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DiscoveryURL")]
        [Validation(Required=false)]
        public string DiscoveryURL { get; set; }

        [NameInMap("IdentityProviderName")]
        [Validation(Required=false)]
        public string IdentityProviderName { get; set; }

    }

}
