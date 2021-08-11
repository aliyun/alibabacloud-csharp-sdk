// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateControlPolicyRequest : TeaModel {
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        [NameInMap("NewPolicyName")]
        [Validation(Required=false)]
        public string NewPolicyName { get; set; }

        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("NewPolicyDocument")]
        [Validation(Required=false)]
        public string NewPolicyDocument { get; set; }

    }

}
