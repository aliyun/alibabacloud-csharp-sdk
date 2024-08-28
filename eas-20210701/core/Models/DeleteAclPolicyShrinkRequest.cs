// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DeleteAclPolicyShrinkRequest : TeaModel {
        [NameInMap("AclPolicyList")]
        [Validation(Required=false)]
        public string AclPolicyListShrink { get; set; }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
