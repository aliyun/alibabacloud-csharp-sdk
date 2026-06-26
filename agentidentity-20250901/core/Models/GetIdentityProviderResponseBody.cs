// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetIdentityProviderResponseBody : TeaModel {
        [NameInMap("IdentityProvider")]
        [Validation(Required=false)]
        public GetIdentityProviderResponseBodyIdentityProvider IdentityProvider { get; set; }
        public class GetIdentityProviderResponseBodyIdentityProvider : TeaModel {
            [NameInMap("AllowedAudience")]
            [Validation(Required=false)]
            public List<string> AllowedAudience { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DiscoveryURL")]
            [Validation(Required=false)]
            public string DiscoveryURL { get; set; }

            [NameInMap("IdentityProviderArn")]
            [Validation(Required=false)]
            public string IdentityProviderArn { get; set; }

            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
