// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateCredentialInput : TeaModel {
        [NameInMap("credentialPublicConfig")]
        [Validation(Required=false)]
        public CredentialPublicConfig CredentialPublicConfig { get; set; }

        [NameInMap("credentialSecret")]
        [Validation(Required=false)]
        public string CredentialSecret { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
