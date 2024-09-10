// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBinarySecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The information about security policies.
        /// </summary>
        [NameInMap("BinarySecurityPolicies")]
        [Validation(Required=false)]
        public List<DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPolicies> BinarySecurityPolicies { get; set; }
        public class DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPolicies : TeaModel {
            /// <summary>
            /// The information about clusters.
            /// </summary>
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPoliciesClusters> Clusters { get; set; }
            public class DescribeBinarySecurityPoliciesResponseBodyBinarySecurityPoliciesClusters : TeaModel {
                /// <summary>
                /// The ID of the cluster.
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// The namespaces.
                /// </summary>
                [NameInMap("Namespaces")]
                [Validation(Required=false)]
                public List<string> Namespaces { get; set; }

            }

            /// <summary>
            /// The name of the policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The content of the policy. The value is in the JSON format. A key supports the following values:
            /// 
            /// *   **policyMode**: the type of the policy. Default value: requireAttestor.
            /// *   **requiredAttestors**: the required witnesses.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public Dictionary<string, object> Policy { get; set; }

            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            /// <summary>
            /// The status of the policy. Valid values:
            /// 
            /// *   **enabled**
            /// *   **disabled**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBinarySecurityPoliciesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBinarySecurityPoliciesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
