// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListPolicyVersionsRequest : TeaModel {
        [NameInMap("PolicyType")]
        [Validation(Required=true)]
        public string PolicyType { get; set; }

        [NameInMap("PolicyName")]
        [Validation(Required=true)]
        public string PolicyName { get; set; }

    }

}
