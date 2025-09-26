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

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("relatedWorloads")]
        [Validation(Required=false)]
        public List<RelatedWorkload> RelatedWorloads { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
