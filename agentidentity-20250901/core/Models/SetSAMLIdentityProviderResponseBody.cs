// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class SetSAMLIdentityProviderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SSOIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfiguration SSOIdentityProviderConfiguration { get; set; }
        public class SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfiguration : TeaModel {
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

            [NameInMap("X509Certificates")]
            [Validation(Required=false)]
            public List<SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfigurationX509Certificates> X509Certificates { get; set; }
            public class SetSAMLIdentityProviderResponseBodySSOIdentityProviderConfigurationX509Certificates : TeaModel {
                [NameInMap("CertificateId")]
                [Validation(Required=false)]
                public string CertificateId { get; set; }

                [NameInMap("X509Certificate")]
                [Validation(Required=false)]
                public string X509Certificate { get; set; }

            }

        }

    }

}
