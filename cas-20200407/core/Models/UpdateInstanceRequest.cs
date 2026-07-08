// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Whether to enable automatic management.</para>
        /// <list type="bullet">
        /// <item><description><para>enable: enabled</para>
        /// </description></item>
        /// <item><description><para>disable: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AutoReissue")]
        [Validation(Required=false)]
        public string AutoReissue { get; set; }

        /// <summary>
        /// <para>The name of the instance. When issuing a certificate, this value serves as the default certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// <para>The city where the company or organization of the certificate requester is located. Required when generating a CSR for a DV certificate. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The company information ID. Required for OV and EV certificates. Otherwise, you cannot call ApplyCertificate to request a certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44211</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>The list of contact IDs. You must specify at least one contact. Otherwise, you cannot call ApplyCertificate to request a certificate.</para>
        /// </summary>
        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public List<long?> ContactIdList { get; set; }

        /// <summary>
        /// <para>The country or region code of the certificate organization. For example, CN represents China, and US represents the United States. Required when generating a CSR for a DV certificate. Default value: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The CSR content. You can generate a CSR using OpenSSL or Keytool. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How to create a CSR file</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The domain name to bind to the certificate. Requirements are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Supports single domain names or wildcard domain names (for example, <c>*.aliyundoc.com</c>).</para>
        /// </description></item>
        /// <item><description><para>Supports multiple domain names. Separate multiple domain names with commas (,). The first domain determines whether a free domain is included.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>If you bind multiple domain names to the certificate, this parameter is required. This parameter and the <b>Csr</b> parameter cannot both be empty. If you set both parameters, the system uses the <b>CN</b> field value from the <b>Csr</b> as the domain name for the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The CSR generation method. Default value: online.</para>
        /// <list type="bullet">
        /// <item><description><para>online: The system generates the CSR. The Csr field is ignored.</para>
        /// </description></item>
        /// <item><description><para>upload: You upload the CSR. The Csr field is required.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("GenerateCsrMethod")]
        [Validation(Required=false)]
        public string GenerateCsrMethod { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-cn-68n1mm16****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The certificate algorithm. Default value: RSA_2048.</para>
        /// <list type="bullet">
        /// <item><description><para><b>RSA_2048</b></para>
        /// </description></item>
        /// <item><description><para><b>RSA_3072</b></para>
        /// </description></item>
        /// <item><description><para><b>RSA_4096</b></para>
        /// </description></item>
        /// <item><description><para><b>ECC_256</b></para>
        /// </description></item>
        /// <item><description><para><b>SM2</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// <para>The province or region where the company is located. Required when generating a CSR for a DV certificate. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>A list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestTags> Tags { get; set; }
        public class UpdateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values for N: <b>1</b> to <b>20</b>. If you specify this value, it cannot be an empty string.</para>
            /// <para>It can contain up to 64 characters. It cannot start with <c>aliyun</c> or <c>acs:</c>, and it cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values for N: <b>1</b> to <b>20</b>. If you specify this value, it can be an empty string.</para>
            /// <para>It can contain up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c>, and it cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The certificate validation method.</para>
        /// <list type="bullet">
        /// <item><description><para>DNS: DNS validation using TXT or CNAME records.</para>
        /// </description></item>
        /// <item><description><para>HTTP: File-based validation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DNS</para>
        /// </summary>
        [NameInMap("ValidationMethod")]
        [Validation(Required=false)]
        public string ValidationMethod { get; set; }

    }

}
