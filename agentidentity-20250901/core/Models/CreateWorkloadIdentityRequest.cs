// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class CreateWorkloadIdentityRequest : TeaModel {
        [NameInMap("AllowedResourceOAuth2ReturnURLs")]
        [Validation(Required=false)]
        public List<string> AllowedResourceOAuth2ReturnURLs { get; set; }

        [NameInMap("CreateRAMRole")]
        [Validation(Required=false)]
        public bool? CreateRAMRole { get; set; }

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

        [NameInMap("WorkloadIdentityName")]
        [Validation(Required=false)]
        public string WorkloadIdentityName { get; set; }

    }

}
