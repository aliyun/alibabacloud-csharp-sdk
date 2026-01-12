// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateKnowledgeBaseInput : TeaModel {
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> ProviderSettings { get; set; }

        [NameInMap("retrieveSettings")]
        [Validation(Required=false)]
        public Dictionary<string, object> RetrieveSettings { get; set; }

    }

}
