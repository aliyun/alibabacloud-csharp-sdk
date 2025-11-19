// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateModelServiceInput : TeaModel {
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ProviderSettings ProviderSettings { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("statusReason")]
        [Validation(Required=false)]
        public string StatusReason { get; set; }

    }

}
