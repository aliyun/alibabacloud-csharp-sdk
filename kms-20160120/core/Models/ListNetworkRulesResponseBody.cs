// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListNetworkRulesResponseBody : TeaModel {
        /// <summary>
        /// A list of access control rules.
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public ListNetworkRulesResponseBodyNetworkRules NetworkRules { get; set; }
        public class ListNetworkRulesResponseBodyNetworkRules : TeaModel {
            [NameInMap("NetworkRule")]
            [Validation(Required=false)]
            public List<ListNetworkRulesResponseBodyNetworkRulesNetworkRule> NetworkRule { get; set; }
            public class ListNetworkRulesResponseBodyNetworkRulesNetworkRule : TeaModel {
                /// <summary>
                /// The name of the access control rule.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The network type. The value is fixed as Private. Self-managed applications can access KMS instances only over a private virtual private cloud (VPC).
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
