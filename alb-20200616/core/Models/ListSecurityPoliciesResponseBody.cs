// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The supported security policies.
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// The supported cipher suites.
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The security policy ID.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The name of the security policy.
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// The status of the security policy. Valid values:
            /// 
            /// *   **Configuring**
            /// *   **Available**
            /// </summary>
            [NameInMap("SecurityPolicyStatus")]
            [Validation(Required=false)]
            public string SecurityPolicyStatus { get; set; }

            /// <summary>
            /// The supported TLS protocol versions.
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSecurityPoliciesResponseBodySecurityPoliciesTags> Tags { get; set; }
            public class ListSecurityPoliciesResponseBodySecurityPoliciesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
