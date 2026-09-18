// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic hosting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>enable: Enabled.</description></item>
        /// <item><description>disable: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("AutoReissue")]
        [Validation(Required=false)]
        public string AutoReissue { get; set; }

        /// <summary>
        /// <para>The name of the instance. When a certificate is issued, this name is used as the default name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("CertificateName")]
        [Validation(Required=false)]
        public string CertificateName { get; set; }

        /// <summary>
        /// <para>The city where the company or organization of the certificate purchaser is located. This field is required when generating a CSR for a DV certificate. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The company information ID. This parameter is required for OV and EV certificates. Otherwise, you cannot call the ApplyCertificate operation to apply for a certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44211</para>
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <para>The list of contact IDs. If a contact already exists, you do not need to specify this parameter. If no contact has been configured, specify at least one contact ID. Otherwise, you cannot call the ApplyCertificate operation to apply for a certificate.</para>
        /// </summary>
        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public List<long?> ContactIdList { get; set; }

        /// <summary>
        /// <para>The country or region code of the certificate organization. For example, CN indicates China and US indicates the United States. This field is required when generating a CSR for a DV certificate. Default value: CN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("CountryCode")]
        [Validation(Required=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// <para>The CSR content. You can use OpenSSL or Keytool to generate a CSR. For more information, see <a href="https://help.aliyun.com/document_detail/42218.html">How do I create a CSR file?</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE REQUEST----- ...... -----END CERTIFICATE REQUEST-----</para>
        /// </summary>
        [NameInMap("Csr")]
        [Validation(Required=false)]
        public string Csr { get; set; }

        /// <summary>
        /// <para>The domain name to which the certificate is bound. Requirements:</para>
        /// <list type="bullet">
        /// <item><description>You can specify a single domain name or a wildcard domain name (for example, <c>*.aliyundoc.com</c>).</description></item>
        /// <item><description>You can specify multiple domain names. Separate multiple domain names with commas (,). Whether a free domain name is included is determined based on the first domain name.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice:  </para>
        /// </remarks>
        /// <para>When the certificate is bound to multiple domain names, this parameter is required. This parameter and the <b>Csr</b> parameter cannot both be empty. If you specify both this parameter and the <b>Csr</b> parameter, the <b>CN</b> field value in the <b>Csr</b> parameter is used as the domain name to which the certificate is bound.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The method used to generate the certificate signing request (CSR). Default value: online. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>online: The system generates the CSR. The Csr parameter is ignored.</description></item>
        /// <item><description>upload: You upload the CSR. The Csr parameter is required.</description></item>
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
        /// <para>The certificate algorithm. Default value: RSA_2048. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RSA_2048</b></description></item>
        /// <item><description><b>RSA_3072</b></description></item>
        /// <item><description><b>RSA_4096</b></description></item>
        /// <item><description><b>ECC_256</b></description></item>
        /// <item><description><b>SM2</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeyAlgorithm")]
        [Validation(Required=false)]
        public string KeyAlgorithm { get; set; }

        /// <summary>
        /// <para>The province or region where the company is located. This field is required when generating a CSR for a DV certificate. Default value: Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ae******4wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<UpdateInstanceRequestTags> Tags { get; set; }
        public class UpdateInstanceRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>. If you specify this parameter, the value cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. Valid values of N: <b>1</b> to <b>20</b>. If you specify this parameter, the value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        /// <summary>
        /// <para>The validation method for the certificate application. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DNS: DNS validation, which uses TXT or CNAME records.</description></item>
        /// <item><description>HTTP: File validation.</description></item>
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
