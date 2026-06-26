// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class ListUserPoolClientsResponseBody : TeaModel {
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public List<ListUserPoolClientsResponseBodyClients> Clients { get; set; }
        public class ListUserPoolClientsResponseBodyClients : TeaModel {
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
            public List<ListUserPoolClientsResponseBodyClientsClientScopes> ClientScopes { get; set; }
            public class ListUserPoolClientsResponseBodyClientsClientScopes : TeaModel {
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

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
