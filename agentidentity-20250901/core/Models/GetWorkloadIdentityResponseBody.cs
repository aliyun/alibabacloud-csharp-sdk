// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetWorkloadIdentityResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WorkloadIdentity")]
        [Validation(Required=false)]
        public GetWorkloadIdentityResponseBodyWorkloadIdentity WorkloadIdentity { get; set; }
        public class GetWorkloadIdentityResponseBodyWorkloadIdentity : TeaModel {
            [NameInMap("AllowedResourceOAuth2ReturnURLs")]
            [Validation(Required=false)]
            public List<string> AllowedResourceOAuth2ReturnURLs { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IdentityProviderName")]
            [Validation(Required=false)]
            public string IdentityProviderName { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("SessionBindingEnabled")]
            [Validation(Required=false)]
            public bool? SessionBindingEnabled { get; set; }

            [NameInMap("SourceAgentArn")]
            [Validation(Required=false)]
            public string SourceAgentArn { get; set; }

            [NameInMap("SourcePlatform")]
            [Validation(Required=false)]
            public string SourcePlatform { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("WorkloadIdentityArn")]
            [Validation(Required=false)]
            public string WorkloadIdentityArn { get; set; }

            [NameInMap("WorkloadIdentityName")]
            [Validation(Required=false)]
            public string WorkloadIdentityName { get; set; }

        }

    }

}
