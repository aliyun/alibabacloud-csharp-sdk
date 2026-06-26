// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateUserPoolClientRequest : TeaModel {
        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public string AccessTokenValidity { get; set; }

        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        [NameInMap("EnforcePKCE")]
        [Validation(Required=false)]
        public bool? EnforcePKCE { get; set; }

        [NameInMap("RedirectURIs")]
        [Validation(Required=false)]
        public List<string> RedirectURIs { get; set; }

        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public string RefreshTokenValidity { get; set; }

        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
