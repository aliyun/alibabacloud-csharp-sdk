// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListSecurityPolicyResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If NextToken is empty, no next page exists.
        /// *   If a value is returned for NextToken, specify the value in the next request to retrieve a new page of results.
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
        /// A list of TLS security policies.
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSecurityPolicyResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// The supported cipher suites, which are determined by the TLS protocol version. You can specify at most 32 cipher suites.
            /// 
            /// TLS 1.0 and TLS 1.1 support the following cipher suites:
            /// 
            /// *   **ECDHE-ECDSA-AES128-SHA**
            /// *   **ECDHE-ECDSA-AES256-SHA**
            /// *   **ECDHE-RSA-AES128-SHA**
            /// *   **ECDHE-RSA-AES256-SHA**
            /// *   **AES128-SHA**
            /// *   **AES256-SHA**
            /// *   **DES-CBC3-SHA**
            /// 
            /// TLS 1.2 supports the following cipher suites:
            /// 
            /// *   **ECDHE-ECDSA-AES128-SHA**
            /// *   **ECDHE-ECDSA-AES256-SHA**
            /// *   **ECDHE-RSA-AES128-SHA**
            /// *   **ECDHE-RSA-AES256-SHA**
            /// *   **AES128-SHA**
            /// *   **AES256-SHA**
            /// *   **DES-CBC3-SHA**
            /// *   **ECDHE-ECDSA-AES128-GCM-SHA256**
            /// *   **ECDHE-ECDSA-AES256-GCM-SHA384**
            /// *   **ECDHE-ECDSA-AES128-SHA256**
            /// *   **ECDHE-ECDSA-AES256-SHA384**
            /// *   **ECDHE-RSA-AES128-GCM-SHA256**
            /// *   **ECDHE-RSA-AES256-GCM-SHA384**
            /// *   **ECDHE-RSA-AES128-SHA256**
            /// *   **ECDHE-RSA-AES256-SHA384**
            /// *   **AES128-GCM-SHA256**
            /// *   **AES256-GCM-SHA384**
            /// *   **AES128-SHA256**
            /// *   **AES256-SHA256**
            /// 
            /// TLS 1.3 supports the following cipher suites:
            /// 
            /// *   **TLS_AES_128_GCM_SHA256**
            /// *   **TLS_AES_256_GCM_SHA384**
            /// *   **TLS_CHACHA20_POLY1305_SHA256**
            /// *   **TLS_AES_128_CCM_SHA256**
            /// *   **TLS_AES_128_CCM_8_SHA256**
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public string Ciphers { get; set; }

            /// <summary>
            /// The region ID of the NLB instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The listeners that are associated with the NLB instance.
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyResponseBodySecurityPoliciesRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyResponseBodySecurityPoliciesRelatedListeners : TeaModel {
                /// <summary>
                /// The listener ID.
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// The listener port.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                /// <summary>
                /// The listener protocol. Valid value: **TCPSSL**.
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// The NLB instance ID.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// The resource group ID.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The ID of the TLS security policy.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The name of the TLS security policy.
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// The status of the TLS security policy. Valid values:
            /// 
            /// *   **Configuring**
            /// *   **Available**
            /// </summary>
            [NameInMap("SecurityPolicyStatus")]
            [Validation(Required=false)]
            public string SecurityPolicyStatus { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyResponseBodySecurityPoliciesTags> Tags { get; set; }
            public class ListSecurityPolicyResponseBodySecurityPoliciesTags : TeaModel {
                /// <summary>
                /// The tag key. You can specify up to 10 tag keys.
                /// 
                /// The tag key can be up to 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value. You can specify up to 10 tag values.
                /// 
                /// The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The supported versions of the TLS protocol. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**.
            /// </summary>
            [NameInMap("TlsVersion")]
            [Validation(Required=false)]
            public string TlsVersion { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
