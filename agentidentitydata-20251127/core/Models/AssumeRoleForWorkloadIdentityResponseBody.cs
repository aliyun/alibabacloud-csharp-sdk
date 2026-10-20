// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentityData20251127.Models
{
    public class AssumeRoleForWorkloadIdentityResponseBody : TeaModel {
        [NameInMap("AssumedRoleUser")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyAssumedRoleUser AssumedRoleUser { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyAssumedRoleUser : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("AssumedRoleId")]
            [Validation(Required=false)]
            public string AssumedRoleId { get; set; }

        }

        [NameInMap("Credentials")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyCredentials Credentials { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyCredentials : TeaModel {
            [NameInMap("AccessKeyId")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("AccessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public string Expiration { get; set; }

            [NameInMap("SecurityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadContextInfo")]
        [Validation(Required=false)]
        public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfo WorkloadContextInfo { get; set; }
        public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfo : TeaModel {
            [NameInMap("UserContext")]
            [Validation(Required=false)]
            public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContext UserContext { get; set; }
            public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContext : TeaModel {
                [NameInMap("JwtClaims")]
                [Validation(Required=false)]
                public AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContextJwtClaims JwtClaims { get; set; }
                public class AssumeRoleForWorkloadIdentityResponseBodyWorkloadContextInfoUserContextJwtClaims : TeaModel {
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

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("WorkloadIdentityArn")]
            [Validation(Required=false)]
            public string WorkloadIdentityArn { get; set; }

        }

    }

}
