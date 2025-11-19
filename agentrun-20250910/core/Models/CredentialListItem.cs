// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CredentialListItem : TeaModel {
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

        [NameInMap("credentialSourceType")]
        [Validation(Required=false)]
        public string CredentialSourceType { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("relatedResourceCount")]
        [Validation(Required=false)]
        public int? RelatedResourceCount { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
