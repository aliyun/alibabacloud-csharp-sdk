// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateSecurityPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The cipher suites supported by the security policy. Valid values of this parameter vary based on the value of TlsVersions. You can specify up to 32 cipher suites.</para>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token. Ensure that the token is unique among different requests. Only ASCII characters are allowed.</para>
        /// <remarks>
        /// <para> If you do not set this parameter, the value of <b>RequestId</b> is used.**** The value of <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: validates the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the validation, the corresponding error message is returned. If the request passes the validation, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): validates the request and performs the operation. If the request passes the validation, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the region where the NLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the security policy belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the security policy.</para>
        /// <para>It must be 1 to 200 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSCipherPolicy</para>
        /// </summary>
        [NameInMap("SecurityPolicyName")]
        [Validation(Required=false)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSecurityPolicyRequestTag> Tag { get; set; }
        public class CreateSecurityPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. It must be 1 to 64 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>. It can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), minus signs (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags for the security policy in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. It must be 1 to 128 characters in length, cannot start with <c>acs:</c> or <c>aliyun</c>, and cannot contain <c>http://</c> or <c>https://</c>. It can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), minus signs (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags for the security policy in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Transport Layer Security (TLS) versions supported by the security policy. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TlsVersions")]
        [Validation(Required=false)]
        public List<string> TlsVersions { get; set; }

    }

}
