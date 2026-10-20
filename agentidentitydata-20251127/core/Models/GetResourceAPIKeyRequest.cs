// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetResourceAPIKeyRequest : TeaModel {
        [NameInMap("ResourceCredentialProviderName")]
        [Validation(Required=false)]
        public string ResourceCredentialProviderName { get; set; }

        [NameInMap("TokenVaultName")]
        [Validation(Required=false)]
        public string TokenVaultName { get; set; }

        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

    }

}
