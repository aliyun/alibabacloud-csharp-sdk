// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSystemSecurityPoliciesResponseBody : TeaModel {
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of TLS security policies.
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// The supported cipher suites. The value of this parameter is determined by the value of **TLSVersions**.
            /// 
            /// The specified cipher suites must be supported by at least one value of **TLSVersions**. For example, if you set TLSVersions to **TLSv1.3**, you must specify cipher suites that are supported by **TLSv1.3**.
            /// 
            /// *   Valid values when TLSVersions is set to **TLSv1.0** or **TLSv1.1**:
            /// 
            ///     *   ECDHE-ECDSA-AES128-SHA
            ///     *   ECDHE-ECDSA-AES256-SHA
            ///     *   ECDHE-RSA-AES128-SHA
            ///     *   ECDHE-RSA-AES256-SHA
            ///     *   AES128-SHA
            ///     *   AES256-SHA
            ///     *   DES-CBC3-SHA
            /// 
            /// *   Valid values when TLSVersions is set to **TLSv1.2**:
            /// 
            ///     *   ECDHE-ECDSA-AES128-SHA
            ///     *   ECDHE-ECDSA-AES256-SHA
            ///     *   ECDHE-RSA-AES128-SHA
            ///     *   ECDHE-RSA-AES256-SHA
            ///     *   AES128-SHA
            ///     *   AES256-SHA
            ///     *   DES-CBC3-SHA
            ///     *   ECDHE-ECDSA-AES128-GCM-SHA256
            ///     *   ECDHE-ECDSA-AES256-GCM-SHA384
            ///     *   ECDHE-ECDSA-AES128-SHA256
            ///     *   ECDHE-ECDSA-AES256-SHA384
            ///     *   ECDHE-RSA-AES128-GCM-SHA256
            ///     *   ECDHE-RSA-AES256-GCM-SHA384
            ///     *   ECDHE-RSA-AES128-SHA256
            ///     *   ECDHE-RSA-AES256-SHA384
            ///     *   AES128-GCM-SHA256
            ///     *   AES256-GCM-SHA384
            ///     *   AES128-SHA256
            ///     *   AES256-SHA256
            /// 
            /// *   Valid values when TLSVersions is set to **TLSv1.3**:
            /// 
            ///     *   TLS_AES_128_GCM_SHA256
            ///     *   TLS_AES_256_GCM_SHA384
            ///     *   TLS_CHACHA20_POLY1305_SHA256
            ///     *   TLS_AES_128_CCM_SHA256
            ///     *   TLS_AES_128_CCM_8_SHA256
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// The ID of the TLS security policy.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The supported TLS versions. Valid values: **TLSv1.0**, **TLSv1.1**, **TLSv1.2**, and **TLSv1.3**.
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
