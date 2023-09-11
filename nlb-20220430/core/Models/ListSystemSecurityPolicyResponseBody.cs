// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListSystemSecurityPolicyResponseBody : TeaModel {
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
        public List<ListSystemSecurityPolicyResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPolicyResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// The cipher suites.
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public string Ciphers { get; set; }

            /// <summary>
            /// The TLS policy ID.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The TLS policy name.
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// The version of the TLS protocol.
            /// </summary>
            [NameInMap("TlsVersion")]
            [Validation(Required=false)]
            public string TlsVersion { get; set; }

        }

    }

}
