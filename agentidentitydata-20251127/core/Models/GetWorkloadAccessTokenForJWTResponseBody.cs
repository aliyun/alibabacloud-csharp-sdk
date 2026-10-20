// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class GetWorkloadAccessTokenForJWTResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserContext")]
        [Validation(Required=false)]
        public GetWorkloadAccessTokenForJWTResponseBodyUserContext UserContext { get; set; }
        public class GetWorkloadAccessTokenForJWTResponseBodyUserContext : TeaModel {
            [NameInMap("JwtClaims")]
            [Validation(Required=false)]
            public GetWorkloadAccessTokenForJWTResponseBodyUserContextJwtClaims JwtClaims { get; set; }
            public class GetWorkloadAccessTokenForJWTResponseBodyUserContextJwtClaims : TeaModel {
                [NameInMap("Audiences")]
                [Validation(Required=false)]
                public string Audiences { get; set; }

                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                [NameInMap("JTI")]
                [Validation(Required=false)]
                public string JTI { get; set; }

                [NameInMap("Subject")]
                [Validation(Required=false)]
                public string Subject { get; set; }

            }

        }

        [NameInMap("WorkloadAccessToken")]
        [Validation(Required=false)]
        public string WorkloadAccessToken { get; set; }

        [NameInMap("WorkloadIdentityArn")]
        [Validation(Required=false)]
        public string WorkloadIdentityArn { get; set; }

    }

}
