// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetSAMLServiceProviderInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SAMLServiceProviderInfo")]
        [Validation(Required=false)]
        public GetSAMLServiceProviderInfoResponseBodySAMLServiceProviderInfo SAMLServiceProviderInfo { get; set; }
        public class GetSAMLServiceProviderInfoResponseBodySAMLServiceProviderInfo : TeaModel {
            [NameInMap("ACSURL")]
            [Validation(Required=false)]
            public string ACSURL { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            [NameInMap("SPMetadataDocument")]
            [Validation(Required=false)]
            public string SPMetadataDocument { get; set; }

            [NameInMap("UserPoolId")]
            [Validation(Required=false)]
            public string UserPoolId { get; set; }

        }

    }

}
