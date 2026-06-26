// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdatePolicyShrinkRequest : TeaModel {
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string DefinitionShrink { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("PolicySetName")]
        [Validation(Required=false)]
        public string PolicySetName { get; set; }

    }

}
