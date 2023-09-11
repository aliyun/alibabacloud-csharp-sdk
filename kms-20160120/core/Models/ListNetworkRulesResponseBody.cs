// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListNetworkRulesResponseBody : TeaModel {
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public ListNetworkRulesResponseBodyNetworkRules NetworkRules { get; set; }
        public class ListNetworkRulesResponseBodyNetworkRules : TeaModel {
            [NameInMap("NetworkRule")]
            [Validation(Required=false)]
            public List<ListNetworkRulesResponseBodyNetworkRulesNetworkRule> NetworkRule { get; set; }
            public class ListNetworkRulesResponseBodyNetworkRulesNetworkRule : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
