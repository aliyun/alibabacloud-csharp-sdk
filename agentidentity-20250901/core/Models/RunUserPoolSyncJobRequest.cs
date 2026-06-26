// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class RunUserPoolSyncJobRequest : TeaModel {
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        [NameInMap("MaxSyncUsers")]
        [Validation(Required=false)]
        public string MaxSyncUsers { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
