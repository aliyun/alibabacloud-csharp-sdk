// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetSpecificIdentityProviderResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SpecificIdentityProviderConfiguration")]
        [Validation(Required=false)]
        public GetSpecificIdentityProviderResponseBodySpecificIdentityProviderConfiguration SpecificIdentityProviderConfiguration { get; set; }
        public class GetSpecificIdentityProviderResponseBodySpecificIdentityProviderConfiguration : TeaModel {
            [NameInMap("IDPMetadata")]
            [Validation(Required=false)]
            public string IDPMetadata { get; set; }

            [NameInMap("IdentityProviderType")]
            [Validation(Required=false)]
            public string IdentityProviderType { get; set; }

            [NameInMap("SSOStatus")]
            [Validation(Required=false)]
            public string SSOStatus { get; set; }

        }

    }

}
