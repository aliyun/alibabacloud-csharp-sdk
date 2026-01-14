// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListSystemSecurityPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A9B4E54C-9CCD-4002-91A9-D38C6C209192</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of TLS security policies.</para>
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSystemSecurityPoliciesResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSystemSecurityPoliciesResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The supported cipher suites. The value of this parameter is determined by the value of <b>TLSVersions</b>.</para>
            /// <para>The specified cipher suites must be supported by at least one value of <b>TLSVersions</b>. For example, if you set TLSVersions to <b>TLSv1.3</b>, you must specify cipher suites that are supported by <b>TLSv1.3</b>.</para>
            /// <list type="bullet">
            /// <item><description><para>Valid values when TLSVersions is set to <b>TLSv1.0</b> or <b>TLSv1.1</b>:</para>
            /// <list type="bullet">
            /// <item><description>ECDHE-ECDSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES256-SHA</description></item>
            /// <item><description>AES128-SHA</description></item>
            /// <item><description>AES256-SHA</description></item>
            /// <item><description>DES-CBC3-SHA</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when TLSVersions is set to <b>TLSv1.2</b>:</para>
            /// <list type="bullet">
            /// <item><description>ECDHE-ECDSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES256-SHA</description></item>
            /// <item><description>AES128-SHA</description></item>
            /// <item><description>AES256-SHA</description></item>
            /// <item><description>DES-CBC3-SHA</description></item>
            /// <item><description>ECDHE-ECDSA-AES128-GCM-SHA256</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-GCM-SHA384</description></item>
            /// <item><description>ECDHE-ECDSA-AES128-SHA256</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-SHA384</description></item>
            /// <item><description>ECDHE-RSA-AES128-GCM-SHA256</description></item>
            /// <item><description>ECDHE-RSA-AES256-GCM-SHA384</description></item>
            /// <item><description>ECDHE-RSA-AES128-SHA256</description></item>
            /// <item><description>ECDHE-RSA-AES256-SHA384</description></item>
            /// <item><description>AES128-GCM-SHA256</description></item>
            /// <item><description>AES256-GCM-SHA384</description></item>
            /// <item><description>AES128-SHA256</description></item>
            /// <item><description>AES256-SHA256</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><para>Valid values when TLSVersions is set to <b>TLSv1.3</b>:</para>
            /// <list type="bullet">
            /// <item><description>TLS_AES_128_GCM_SHA256</description></item>
            /// <item><description>TLS_AES_256_GCM_SHA384</description></item>
            /// <item><description>TLS_CHACHA20_POLY1305_SHA256</description></item>
            /// <item><description>TLS_AES_128_CCM_SHA256</description></item>
            /// <item><description>TLS_AES_128_CCM_8_SHA256</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// <para>The ID of the TLS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tls_cipher_policy_1_1</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The supported TLS versions. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>.</para>
            /// </summary>
            [NameInMap("TlsVersions")]
            [Validation(Required=false)]
            public List<string> TlsVersions { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
