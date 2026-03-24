// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDefaultHttpsRequest : TeaModel {
        /// <summary>
        /// <para>The certificate ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        /// <summary>
        /// <para>The type of the cipher suite. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: adds all cipher suites.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: adds strong cipher suites.</para>
        /// </description></item>
        /// <item><description><para><b>99</b>: adds custom cipher suites.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CipherSuite")]
        [Validation(Required=false)]
        public int? CipherSuite { get; set; }

        /// <summary>
        /// <para>The custom cipher suites that you want to add. This parameter is used only when <b>CipherSuite</b> is set to <b>99</b>.</para>
        /// </summary>
        [NameInMap("CustomCiphers")]
        [Validation(Required=false)]
        public List<string> CustomCiphers { get; set; }

        /// <summary>
        /// <para>Specifies whether to support TLS 1.3. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: supports TLS 1.3.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not support TLS 1.3.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to view the ID of the current WAF instance.</para>
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
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: regions outside the Chinese mainland.</para>
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
        /// <para>The version of the TLS protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>tlsv1</b></para>
        /// </description></item>
        /// <item><description><para><b>tlsv1.1</b></para>
        /// </description></item>
        /// <item><description><para><b>tlsv1.2</b></para>
        /// </description></item>
        /// </list>
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
