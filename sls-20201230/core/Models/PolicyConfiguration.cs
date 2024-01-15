// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PolicyConfiguration : TeaModel {
        [NameInMap("actionPolicyId")]
        [Validation(Required=false)]
        public string ActionPolicyId { get; set; }

        [NameInMap("alertPolicyId")]
        [Validation(Required=false)]
        public string AlertPolicyId { get; set; }

        [NameInMap("repeatInterval")]
        [Validation(Required=false)]
        public string RepeatInterval { get; set; }

    }

}
