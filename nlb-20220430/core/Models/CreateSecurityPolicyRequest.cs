// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateSecurityPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The supported cipher suites, which depend on the TLSVersion value. You can add up to 32 cipher suites.</para>
        /// <para>Supported by TLSv1.0 and TLSv1.1:</para>
        /// <list type="bullet">
        /// <item><description><b>ECDHE-ECDSA-AES128-SHA</b></description></item>
        /// <item><description><b>ECDHE-ECDSA-AES256-SHA</b></description></item>
        /// <item><description><b>ECDHE-RSA-AES128-SHA</b></description></item>
        /// <item><description><b>ECDHE-RSA-AES256-SHA</b></description></item>
        /// <item><description><b>AES128-SHA</b></description></item>
        /// <item><description><b>AES256-SHA</b></description></item>
        /// <item><description><b>DES-CBC3-SHA</b></description></item>
        /// </list>
        /// <para>Supported by TLSv1.2:</para>
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
        /// <item><description><b>ECDHE-ECDSA-CHACHA20-POLY1305</b></description></item>
        /// <item><description><b>ECDHE-RSA-CHACHA20-POLY1305</b></description></item>
        /// </list>
        /// <para>Supported by TLSv1.3:</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the custom security policy. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, an error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The region ID of the Network Load Balancer (NLB) instance. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Policy Name of the security policy.</para>
        /// <para>Policy Name must be 1 to 200 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSCipherPolicy</para>
        /// </summary>
        [NameInMap("SecurityPolicyName")]
        [Validation(Required=false)]
        public string SecurityPolicyName { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSecurityPolicyRequestTag> Tag { get; set; }
        public class CreateSecurityPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. Supported characters include letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. Supported characters include letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ValueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The supported TLS versions. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TlsVersions")]
        [Validation(Required=false)]
        public List<string> TlsVersions { get; set; }

    }

}
