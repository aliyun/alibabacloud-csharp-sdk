// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class CreatePolicyVersionRequest : TeaModel {
        [NameInMap("PolicyName")]
        [Validation(Required=true)]
        public string PolicyName { get; set; }

        [NameInMap("PolicyDocument")]
        [Validation(Required=true)]
        public string PolicyDocument { get; set; }

        [NameInMap("SetAsDefault")]
        [Validation(Required=false)]
        public bool? SetAsDefault { get; set; }

    }

}
