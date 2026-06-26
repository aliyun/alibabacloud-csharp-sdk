// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateAPIKeyCredentialProviderRequest : TeaModel {
        [NameInMap("APIKey")]
        [Validation(Required=false)]
        public string APIKey { get; set; }

        [NameInMap("APIKeyCredentialProviderName")]
        [Validation(Required=false)]
        public string APIKeyCredentialProviderName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

    }

}
