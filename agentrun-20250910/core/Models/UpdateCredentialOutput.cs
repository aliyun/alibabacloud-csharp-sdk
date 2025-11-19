// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateCredentialOutput : TeaModel {
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("credentialAuthType")]
        [Validation(Required=false)]
        public string CredentialAuthType { get; set; }

        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("credentialPublicConfig")]
        [Validation(Required=false)]
        public Dictionary<string, string> CredentialPublicConfig { get; set; }

        [NameInMap("credentialSecret")]
        [Validation(Required=false)]
        public string CredentialSecret { get; set; }

        [NameInMap("credentialSourceType")]
        [Validation(Required=false)]
        public string CredentialSourceType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("relatedResources")]
        [Validation(Required=false)]
        public List<RelatedResource> RelatedResources { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
