// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class DeletePolicyRequest : TeaModel {
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("PolicySetName")]
        [Validation(Required=false)]
        public string PolicySetName { get; set; }

    }

}
