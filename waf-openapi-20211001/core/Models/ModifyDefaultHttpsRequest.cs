// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefaultHttpsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The cipher suite type.</para>
        /// <remarks>
        /// <para>This parameter is required. You must specify this parameter when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CipherSuite")]
        [Validation(Required=false)]
        public int? CipherSuite { get; set; }

        /// <summary>
        /// <para>The custom cipher suites to add. This parameter is used only when <b>CipherSuite</b> is set to <b>99</b>.</para>
        /// </summary>
        [NameInMap("CustomCiphers")]
        [Validation(Required=false)]
        public List<string> CustomCiphers { get; set; }

        /// <summary>
        /// <para>Specifies whether TLS 1.3 is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: TLS 1.3 is supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: TLS 1.3 is not supported.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is used only when HttpsPorts is not empty, which indicates that the domain name uses the HTTPS protocol. If TLSVersion is set to tlsv1.3, this value must be true.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableTLSv3")]
        [Validation(Required=false)]
        public bool? EnableTLSv3 { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v2_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The TLS version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tlsv1</para>
        /// </summary>
        [NameInMap("TLSVersion")]
        [Validation(Required=false)]
        public string TLSVersion { get; set; }

    }

}
