// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListSystemSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>593B0448-D13E-4C56-AC0D-FDF0FDE0E9A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security policies.</para>
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The supported cipher suite.</para>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// <para>The ID of the security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>spy-n0kn923****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The supported TLS protocol versions.</para>
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

        }

    }

}
