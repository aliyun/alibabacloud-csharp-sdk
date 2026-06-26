// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSAMLIdentityProviderShrinkRequest : TeaModel {
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        [NameInMap("JITProvisionStatus")]
        [Validation(Required=false)]
        public string JITProvisionStatus { get; set; }

        [NameInMap("JITUpdateStatus")]
        [Validation(Required=false)]
        public string JITUpdateStatus { get; set; }

        [NameInMap("LoginURL")]
        [Validation(Required=false)]
        public string LoginURL { get; set; }

        [NameInMap("SAMLBindingType")]
        [Validation(Required=false)]
        public string SAMLBindingType { get; set; }

        [NameInMap("SSOStatus")]
        [Validation(Required=false)]
        public string SSOStatus { get; set; }

        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

        [NameInMap("X509Certificates")]
        [Validation(Required=false)]
        public string X509CertificatesShrink { get; set; }

    }

}
