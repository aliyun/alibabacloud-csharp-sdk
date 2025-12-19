// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class IncludedOAuth2ProviderConfig : TeaModel {
        [NameInMap("AuthorizationEndpoint")]
        [Validation(Required=false)]
        public string AuthorizationEndpoint { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("TokenEndpoint")]
        [Validation(Required=false)]
        public string TokenEndpoint { get; set; }

    }

}
