// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class OAuth2ProviderConfig : TeaModel {
        [NameInMap("CustomOAuth2ProviderConfig")]
        [Validation(Required=false)]
        public CustomOAuth2ProviderConfig CustomOAuth2ProviderConfig { get; set; }

        [NameInMap("IncludedOAuth2ProviderConfig")]
        [Validation(Required=false)]
        public IncludedOAuth2ProviderConfig IncludedOAuth2ProviderConfig { get; set; }

    }

}
