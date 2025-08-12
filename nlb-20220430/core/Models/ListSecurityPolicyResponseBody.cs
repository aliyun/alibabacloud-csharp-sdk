// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListSecurityPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If NextToken is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for NextToken, specify the value in the next request to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7A8875F-373A-5F48-8484-25B07A61F2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The TLS security policies.</para>
        /// </summary>
        [NameInMap("SecurityPolicies")]
        [Validation(Required=false)]
        public List<ListSecurityPolicyResponseBodySecurityPolicies> SecurityPolicies { get; set; }
        public class ListSecurityPolicyResponseBodySecurityPolicies : TeaModel {
            /// <summary>
            /// <para>The cipher suites supported by the security policy. Valid values of this parameter vary based on the value of TlsVersions. A security policy supports up to 32 cipher suites.</para>
            /// <para>TLSv1.0 and TLSv1.1 support the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description><b>ECDHE-ECDSA-AES128-SHA</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES256-SHA</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES128-SHA</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES256-SHA</b></description></item>
            /// <item><description><b>AES128-SHA</b></description></item>
            /// <item><description><b>AES256-SHA</b></description></item>
            /// <item><description><b>DES-CBC3-SHA</b></description></item>
            /// </list>
            /// <para>TLSv1.2 supports the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description><b>ECDHE-ECDSA-AES128-SHA</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES256-SHA</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES128-SHA</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES256-SHA</b></description></item>
            /// <item><description><b>AES128-SHA</b></description></item>
            /// <item><description><b>AES256-SHA</b></description></item>
            /// <item><description><b>DES-CBC3-SHA</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES128-GCM-SHA256</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES256-GCM-SHA384</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES128-SHA256</b></description></item>
            /// <item><description><b>ECDHE-ECDSA-AES256-SHA384</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES128-GCM-SHA256</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES256-GCM-SHA384</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES128-SHA256</b></description></item>
            /// <item><description><b>ECDHE-RSA-AES256-SHA384</b></description></item>
            /// <item><description><b>AES128-GCM-SHA256</b></description></item>
            /// <item><description><b>AES256-GCM-SHA384</b></description></item>
            /// <item><description><b>AES128-SHA256</b></description></item>
            /// <item><description><b>AES256-SHA256</b></description></item>
            /// </list>
            /// <para>TLSv1.3 supports the following cipher suites:</para>
            /// <list type="bullet">
            /// <item><description><b>TLS_AES_128_GCM_SHA256</b></description></item>
            /// <item><description><b>TLS_AES_256_GCM_SHA384</b></description></item>
            /// <item><description><b>TLS_CHACHA20_POLY1305_SHA256</b></description></item>
            /// <item><description><b>TLS_AES_128_CCM_SHA256</b></description></item>
            /// <item><description><b>TLS_AES_128_CCM_8_SHA256</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECDHE-ECDSA-AES128-SHA</para>
            /// </summary>
            [NameInMap("Ciphers")]
            [Validation(Required=false)]
            public string Ciphers { get; set; }

            /// <summary>
            /// <para>The region ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The listeners that are associated with the NLB instance.</para>
            /// </summary>
            [NameInMap("RelatedListeners")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyResponseBodySecurityPoliciesRelatedListeners> RelatedListeners { get; set; }
            public class ListSecurityPolicyResponseBodySecurityPoliciesRelatedListeners : TeaModel {
                /// <summary>
                /// <para>The listener ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lsn-bp1bpn0kn908w4nbw****@443</para>
                /// </summary>
                [NameInMap("ListenerId")]
                [Validation(Required=false)]
                public string ListenerId { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public long? ListenerPort { get; set; }

                /// <summary>
                /// <para>The listener protocol. Valid value: <b>TCPSSL</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCPSSL</para>
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

                /// <summary>
                /// <para>The NLB instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>nlb-83ckzc8d4xlp8o****</para>
                /// </summary>
                [NameInMap("LoadBalancerId")]
                [Validation(Required=false)]
                public string LoadBalancerId { get; set; }

            }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-atstuj3rtop****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the TLS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tls-bp14bb1e7dll4f****</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The name of the TLS security policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLSCipherPolicy</para>
            /// </summary>
            [NameInMap("SecurityPolicyName")]
            [Validation(Required=false)]
            public string SecurityPolicyName { get; set; }

            /// <summary>
            /// <para>The status of the TLS security policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Configuring</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("SecurityPolicyStatus")]
            [Validation(Required=false)]
            public string SecurityPolicyStatus { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListSecurityPolicyResponseBodySecurityPoliciesTags> Tags { get; set; }
            public class ListSecurityPolicyResponseBodySecurityPoliciesTags : TeaModel {
                /// <summary>
                /// <para>The tag key. You can specify up to 10 tag keys.</para>
                /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. You can specify up to 10 tag values.</para>
                /// <para>The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The supported versions of the TLS protocol. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TLSv1.0</para>
            /// </summary>
            [NameInMap("TlsVersion")]
            [Validation(Required=false)]
            public string TlsVersion { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
