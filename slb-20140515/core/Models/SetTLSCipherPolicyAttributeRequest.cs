// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetTLSCipherPolicyAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The cipher suites supported by the TLS version.</para>
        /// <para>The specified cipher suites must be supported by at least one TLS protocol version that you specify. For example, if you set the TLSVersions parameter to TLSv1.3, you must specify cipher suites that are supported by this protocol version.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DES-CBC3-SHA</para>
        /// </summary>
        [NameInMap("Ciphers")]
        [Validation(Required=false)]
        public List<string> Ciphers { get; set; }

        /// <summary>
        /// <para>The name of the TLS policy. The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls-policy*****-test</para>
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
        /// <para>The ID of the region where the Server Load Balancer (SLB) instance is deployed.</para>
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
        /// <para>The ID of the TLS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tls-bp1lp2076qx4e******bridp</para>
        /// </summary>
        [NameInMap("TLSCipherPolicyId")]
        [Validation(Required=false)]
        public string TLSCipherPolicyId { get; set; }

        /// <summary>
        /// <para>The version of the TLS protocol. Valid values: <b>TLSv1.0</b>, <b>TLSv1.1</b>, <b>TLSv1.2</b>, and <b>TLSv1.3</b>.</para>
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
