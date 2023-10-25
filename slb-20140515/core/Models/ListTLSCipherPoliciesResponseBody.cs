// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ListTLSCipherPoliciesResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the current page is the last page. Valid values:
        /// 
        /// *   **true**: The current page is the last page.
        /// *   **false**: The current page is not the last page.
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** is empty, it indicates that no next query is to be sent.
        /// *   If **NextToken** is not empty, the value indicates the token that is used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of TLS policies.
        /// </summary>
        [NameInMap("TLSCipherPolicies")]
        [Validation(Required=false)]
        public List<ListTLSCipherPoliciesResponseBodyTLSCipherPolicies> TLSCipherPolicies { get; set; }
        public class ListTLSCipherPoliciesResponseBodyTLSCipherPolicies : TeaModel {
            /// <summary>
            /// The cipher suites supported by the TLS version.
            /// 
            /// TLS 1.0 and TLS 1.1 support the following cipher suites:
            /// 
            /// *   ECDHE-ECDSA-AES128-SHA
            /// *   ECDHE-ECDSA-AES256-SHA
            /// *   ECDHE-RSA-AES128-SHA
            /// *   ECDHE-RSA-AES256-SHA
            /// *   AES128-SHA AES256-SHA
            /// *   DES-CBC3-SHA
            /// 
            /// TLS 1.2 supports the following cipher suites:
            /// 
            /// *   ECDHE-ECDSA-AES128-SHA
            /// *   ECDHE-ECDSA-AES256-SHA
            /// *   ECDHE-RSA-AES128-SHA
            /// *   ECDHE-RSA-AES256-SHA
            /// *   AES128-SHA AES256-SHA
            /// *   DES-CBC3-SHA
            /// *   ECDHE-ECDSA-AES128-GCM-SHA256
            /// *   ECDHE-ECDSA-AES256-GCM-SHA384
            /// *   ECDHE-ECDSA-AES128-SHA256
            /// *   ECDHE-ECDSA-AES256-SHA384
            /// *   ECDHE-RSA-AES128-GCM-SHA256
            /// *   ECDHE-RSA-AES256-GCM-SHA384
            /// *   ECDHE-RSA-AES128-SHA256
            /// *   ECDHE-RSA-AES256-SHA384
            /// *   AES128-GCM-SHA256
            /// *   AES256-GCM-SHA384
            /// *   AES128-SHA256 AES256-SHA256
            /// 
            /// TLS 1.3 supports the following cipher suites:
            /// 
            /// *   TLS_AES\_128\_GCM_SHA256
            /// *   TLS_AES\_256\_GCM_SHA384
            /// *   TLS_CHACHA20\_POLY1305\_SHA256
            /// *   TLS_AES\_128\_CCM_SHA256
            /// *   TLS_AES\_128\_CCM\_8\_SHA256
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// The timestamp generated when the TLS policy is created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The ID of the TLS policy.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the TLS policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The list of associated listeners.
            /// </summary>
            [NameInMap("RelateListeners")]
            [Validation(Required=false)]
            public List<ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners> RelateListeners { get; set; }
            public class ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners : TeaModel {
                /// <summary>
                /// The ID of the CLB instance.
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// The listening port. Valid values: **1** to **65535**.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The listening protocol. Valid values:
                /// 
                /// *   **TCP**
                /// *   **UDP**
                /// *   **HTTP**
                /// *   **HTTPS**
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// The status of the TLS policy. Valid values:
            /// 
            /// *   **configuring**: The TLS policy is being configured.
            /// *   **normal**: The TLS policy works as expected.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The version of the TLS protocol.
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

        }

        /// <summary>
        /// The total number of TLS policies returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
