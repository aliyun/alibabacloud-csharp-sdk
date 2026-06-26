// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSpecificIdentityProviderRequest : TeaModel {
        [NameInMap("IDPMetadata")]
        [Validation(Required=false)]
        public string IDPMetadata { get; set; }

        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
