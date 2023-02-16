// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class UpdateControlPolicyRequest : TeaModel {
        [NameInMap("NewDescription")]
        [Validation(Required=false)]
        public string NewDescription { get; set; }

        [NameInMap("NewPolicyDocument")]
        [Validation(Required=false)]
        public string NewPolicyDocument { get; set; }

        [NameInMap("NewPolicyName")]
        [Validation(Required=false)]
        public string NewPolicyName { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

    }

}
