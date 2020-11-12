// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetPolicyRequest : TeaModel {
        [NameInMap("PolicyName")]
        [Validation(Required=true)]
        public string PolicyName { get; set; }

        [NameInMap("PolicyType")]
        [Validation(Required=true)]
        public string PolicyType { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

    }

}
