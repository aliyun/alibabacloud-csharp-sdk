// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribePolicyBasedRoutingsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PolicyBasedRoutings")]
        [Validation(Required=false)]
        public DescribePolicyBasedRoutingsResponseBodyPolicyBasedRoutings PolicyBasedRoutings { get; set; }
        public class DescribePolicyBasedRoutingsResponseBodyPolicyBasedRoutings : TeaModel {
            [NameInMap("PolicyBasedRouting")]
            [Validation(Required=false)]
            public List<DescribePolicyBasedRoutingsResponseBodyPolicyBasedRoutingsPolicyBasedRouting> PolicyBasedRouting { get; set; }
            public class DescribePolicyBasedRoutingsResponseBodyPolicyBasedRoutingsPolicyBasedRouting : TeaModel {
                public string Description { get; set; }
                public string PbrInstanceId { get; set; }
                public int? Priority { get; set; }
                public string Name { get; set; }
            }
        };

    }

}
