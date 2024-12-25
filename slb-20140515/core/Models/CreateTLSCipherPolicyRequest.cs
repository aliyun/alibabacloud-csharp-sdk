// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateTLSCipherPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The supported cipher suites, which are determined by the TLS protocol version. You can specify at most 32 cipher suites.</para>
        /// <para>TLS 1.0 and TLS 1.1 support the following cipher suites:</para>
        /// <list type="bullet">
        /// <item><description><b>ECDHE-ECDSA-AES128-SHA</b></description></item>
        /// <item><description><b>ECDHE-ECDSA-AES256-SHA</b></description></item>
        /// <item><description><b>ECDHE-RSA-AES128-SHA</b></description></item>
        /// <item><description><b>ECDHE-RSA-AES256-SHA</b></description></item>
        /// <item><description><b>AES128-SHA</b></description></item>
        /// <item><description><b>AES256-SHA</b></description></item>
        /// <item><description><b>DES-CBC3-SHA</b></description></item>
        /// </list>
        /// <para>TLS 1.2 supports the following cipher suites:</para>
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
        /// <para>TLS 1.3 supports the following cipher suites:</para>
        /// <list type="bullet">
        /// <item><description><b>TLS_AES_128_GCM_SHA256</b></description></item>
        /// <item><description><b>TLS_AES_256_GCM_SHA384</b></description></item>
        /// <item><description><b>TLS_CHACHA20_POLY1305_SHA256</b></description></item>
        /// <item><description><b>TLS_AES_128_CCM_SHA256</b></description></item>
        /// <item><description><b>TLS_AES_128_CCM_8_SHA256</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AES256-SHA256</para>
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// <para>The name of the TLS policy. The name must be 1 to 200 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSPolicy-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Server Load Balancer (SLB) instance is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The version of the TLS protocol. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>. You can specify at most four TLS versions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TLSv1.0</para>
        /// </summary>
        [NameInMap("TLSVersions")]
        [Validation(Required=false)]
        public List<string> TLSVersions { get; set; }

    }

}
