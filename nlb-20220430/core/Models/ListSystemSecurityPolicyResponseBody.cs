// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListSystemSecurityPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C057647-284B-5C67-A07E-4B8F3DABA9F9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of TLS security policies.</para>
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPolicyResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPolicyResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The cipher suite.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECDHE-ECDSA-AES128-GCM-SHA256,ECDHE-ECDSA-AES256-GCM-SHA384,ECDHE-ECDSA-AES128-SHA256,ECDHE-ECDSA-AES256-SHA384,ECDHE-RSA-AES128-GCM-SHA256,ECDHE-RSA-AES256-GCM-SHA384,ECDHE-RSA-AES128-SHA256,ECDHE-RSA-AES256-SHA384,AES128-GCM-SHA256,AES256-GCM-SHA384,AES128-SHA256,AES256-SHA256,ECDHE-ECDSA-AES128-SHA,ECDHE-ECDSA-AES256-SHA,ECDHE-RSA-AES128-SHA,ECDHE-RSA-AES256-SHA,AES128-SHA,AES256-SHA,DES-CBC3-SHA</para>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public string Ciphers { get; set; }

            /// <summary>
            /// <para>The ID of the TLS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sp-3fdab6dkkke10s****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the TLS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// <para>The TLS version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLSv1.0</para>
            /// </summary>
            [NameInMap("TlsVersion")]
            [Validation(Required=false)]
            public string TlsVersion { get; set; }

        }

    }

}
