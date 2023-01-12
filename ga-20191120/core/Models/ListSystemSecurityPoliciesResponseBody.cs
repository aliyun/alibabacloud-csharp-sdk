// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSystemSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The security policies.
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// The supported cipher suites, which depend on the **TLSVersions** value.
            /// 
            /// The specified cipher suites must be supported by at least one **TLS protocol version** that you select. For example, if you set the TLSVersions.N parameter to **TLSv1.3**, you can specify only cipher suites that are supported by **TLSv1.3**.
            /// 
            /// *   **TLSv1.0** and **TLSv1.1** support the following cipher suites:
            /// 
            ///     *   **ECDHE-ECDSA-AES128-SHA**
            ///     *   **ECDHE-ECDSA-AES256-SHA**
            ///     *   **ECDHE-RSA-AES128-SHA**
            ///     *   **ECDHE-RSA-AES256-SHA**
            ///     *   **AES128-SHA**
            ///     *   **AES256-SHA**
            ///     *   **DES-CBC3-SHA**
            /// 
            /// *   **TLS 1.2** supports the following cipher suites:
            /// 
            ///     *   **ECDHE-ECDSA-AES128-SHA**
            ///     *   **ECDHE-ECDSA-AES256-SHA**
            ///     *   **ECDHE-RSA-AES128-SHA**
            ///     *   **ECDHE-RSA-AES256-SHA**
            ///     *   **AES128-SHA**
            ///     *   **AES256-SHA**
            ///     *   **DES-CBC3-SHA**
            ///     *   **ECDHE-ECDSA-AES128-GCM-SHA256**
            ///     *   **ECDHE-ECDSA-AES256-GCM-SHA384**
            ///     *   **ECDHE-ECDSA-AES128-SHA256**
            ///     *   **ECDHE-ECDSA-AES256-SHA384**
            ///     *   **ECDHE-RSA-AES128-GCM-SHA256**
            ///     *   **ECDHE-RSA-AES256-GCM-SHA384**
            ///     *   **ECDHE-RSA-AES128-SHA256**
            ///     *   **ECDHE-RSA-AES256-SHA384**
            ///     *   **AES128-GCM-SHA256**
            ///     *   **AES256-GCM-SHA384**
            ///     *   **AES128-SHA256**
            ///     *   **AES256-SHA256**
            /// 
            /// *   **TLSv1.3** supports the following cipher suites:
            /// 
            ///     *   **TLS_AES\_128\_GCM_SHA256**
            ///     *   **TLS_AES\_256\_GCM_SHA384**
            ///     *   **TLS_CHACHA20\_POLY1305\_SHA256**
            ///     *   **TLS_AES\_128\_CCM_SHA256**
            ///     *   **TLS_AES\_128\_CCM\_8\_SHA256**
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// The ID of the security policy.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The supported TLS protocol versions. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**.
            /// </summary>
            [NameInMap("TlsVersions")]
            [Validation(Required=false)]
            public List<string> TlsVersions { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
