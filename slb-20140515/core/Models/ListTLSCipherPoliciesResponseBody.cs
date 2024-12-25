// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class ListTLSCipherPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the current page is the last page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The current page is the last page.</description></item>
        /// <item><description><b>false</b>: The current page is not the last page.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If <b>NextToken</b> is not empty, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of TLS policies.</para>
        /// </summary>
        [NameInMap("TLSCipherPolicies")]
        [Validation(Required=false)]
        public List<ListTLSCipherPoliciesResponseBodyTLSCipherPolicies> TLSCipherPolicies { get; set; }
        public class ListTLSCipherPoliciesResponseBodyTLSCipherPolicies : TeaModel {
            /// <summary>
            /// <para>The cipher suites supported by the TLS version.</para>
            /// <para>TLS 1.0 and TLS 1.1 support the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description>ECDHE-ECDSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES256-SHA</description></item>
            /// <item><description>AES128-SHA AES256-SHA</description></item>
            /// <item><description>DES-CBC3-SHA</description></item>
            /// </list>
            /// <para>TLS 1.2 supports the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description>ECDHE-ECDSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-ECDSA-AES256-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES128-SHA</description></item>
            /// <item><description>ECDHE-RSA-AES256-SHA</description></item>
            /// <item><description>AES128-SHA AES256-SHA</description></item>
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
            /// <item><description>AES128-SHA256 AES256-SHA256</description></item>
            /// </list>
            /// <para>TLS 1.3 supports the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description>TLS_AES_128_GCM_SHA256</description></item>
            /// <item><description>TLS_AES_256_GCM_SHA384</description></item>
            /// <item><description>TLS_CHACHA20_POLY1305_SHA256</description></item>
            /// <item><description>TLS_AES_128_CCM_SHA256</description></item>
            /// <item><description>TLS_AES_128_CCM_8_SHA256</description></item>
            /// </list>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public List<string> Ciphers { get; set; }

            /// <summary>
            /// <para>The timestamp generated when the TLS policy is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1608273800000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the TLS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tls-bp17elso1h323r****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the TLS policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLSPolicy-test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of associated listeners.</para>
            /// </summary>
            [NameInMap("RelateListeners")]
            [Validation(Required=false)]
            public List<ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners> RelateListeners { get; set; }
            public class ListTLSCipherPoliciesResponseBodyTLSCipherPoliciesRelateListeners : TeaModel {
                /// <summary>
                /// <para>The ID of the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lb-bp1b6c719dfa08ex****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

                /// <summary>
                /// <para>The listening port. Valid values: <b>1</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The listening protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TCP</b></description></item>
                /// <item><description><b>UDP</b></description></item>
                /// <item><description><b>HTTP</b></description></item>
                /// <item><description><b>HTTPS</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <summary>
            /// <para>The status of the TLS policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>configuring</b>: The TLS policy is being configured.</description></item>
            /// <item><description><b>normal</b>: The TLS policy works as expected.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The version of the TLS protocol.</para>
            /// </summary>
            [NameInMap("TLSVersions")]
            [Validation(Required=false)]
            public List<string> TLSVersions { get; set; }

        }

        /// <summary>
        /// <para>The total number of TLS policies returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
