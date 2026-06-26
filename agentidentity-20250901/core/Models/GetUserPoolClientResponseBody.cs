// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetUserPoolClientResponseBody : TeaModel {
        [NameInMap("Client")]
        [Validation(Required=false)]
        public GetUserPoolClientResponseBodyClient Client { get; set; }
        public class GetUserPoolClientResponseBodyClient : TeaModel {
            [NameInMap("AccessTokenValidity")]
            [Validation(Required=false)]
            public string AccessTokenValidity { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

            [NameInMap("ClientName")]
            [Validation(Required=false)]
            public string ClientName { get; set; }

            [NameInMap("ClientScopes")]
            [Validation(Required=false)]
            public List<GetUserPoolClientResponseBodyClientClientScopes> ClientScopes { get; set; }
            public class GetUserPoolClientResponseBodyClientClientScopes : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("ScopeName")]
                [Validation(Required=false)]
                public string ScopeName { get; set; }

            }

            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

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

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserPoolName")]
            [Validation(Required=false)]
            public string UserPoolName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
