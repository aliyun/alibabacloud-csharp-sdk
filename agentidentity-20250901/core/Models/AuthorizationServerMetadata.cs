// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class AuthorizationServerMetadata : TeaModel {
        [NameInMap("AuthorizationRequest")]
        [Validation(Required=false)]
        public AuthorizationRequest AuthorizationRequest { get; set; }

        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        [NameInMap("PKCE")]
        [Validation(Required=false)]
        public PKCE PKCE { get; set; }

        [NameInMap("TokenRequest")]
        [Validation(Required=false)]
        public TokenReqeust TokenRequest { get; set; }

    }

}
