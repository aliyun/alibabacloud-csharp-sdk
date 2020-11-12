// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class AttachPolicyRequest : TeaModel {
        [NameInMap("ResourceGroupId")]
        [Validation(Required=true)]
        public string ResourceGroupId { get; set; }

        [NameInMap("PolicyType")]
        [Validation(Required=true)]
        public string PolicyType { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=true)]
        public string PolicyName { get; set; }

        [NameInMap("PrincipalType")]
        [Validation(Required=true)]
        public string PrincipalType { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=true)]
        public string PrincipalName { get; set; }

    }

}
