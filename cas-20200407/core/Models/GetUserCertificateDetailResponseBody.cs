// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class GetUserCertificateDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>Indicates whether the certificate was purchased from Alibaba Cloud. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuyInAliyun")]
        [Validation(Required=false)]
        public bool? BuyInAliyun { get; set; }

        /// <summary>
        /// <para>The certificate content that uses a non-Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>---BEGIN CERTIFICATE----- MIIF...... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The certificate chain information.</para>
        /// </summary>
        [NameInMap("CertChain")]
        [Validation(Required=false)]
        public List<GetUserCertificateDetailResponseBodyCertChain> CertChain { get; set; }
        public class GetUserCertificateDetailResponseBodyCertChain : TeaModel {
            /// <summary>
            /// <para>The common name in the certificate chain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The common name of the issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Encryption Everywhere DV TLS CA - G2</para>
            /// </summary>
            [NameInMap("IssuerCommonName")]
            [Validation(Required=false)]
            public string IssuerCommonName { get; set; }

            /// <summary>
            /// <para>The end time of the certificate chain validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17352613180000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The start time of the certificate chain validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17322633180000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <para>The remaining days of the certificate chain validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }

        }

        /// <summary>
        /// <para>The certificate ID appended with &quot;-cn-hangzhou&quot;. For example, if the certificate ID is 123, the CertIdentifier is &quot;123-cn-hangzhou&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13781326-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E696C2DB574DF99467A90BEF62B341294A9B0C731D228A0BD38265E1467D8EF0</para>
        /// </summary>
        [NameInMap("CertSha2")]
        [Validation(Required=false)]
        public string CertSha2 { get; set; }

        /// <summary>
        /// <para>The city where the company or organization of the certificate purchaser is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The primary domain name bound to the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.com</para>
        /// </summary>
        [NameInMap("Common")]
        [Validation(Required=false)]
        public string Common { get; set; }

        /// <summary>
        /// <para>The country where the company or organization of the certificate purchaser is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The encryption certificate content in PEM format that uses a Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICDzCCA***
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("EncryptCert")]
        [Validation(Required=false)]
        public string EncryptCert { get; set; }

        /// <summary>
        /// <para>The private key of the encryption certificate in PEM format that uses a Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN EC PRIVATE KEY-----
        /// MHcCAQEEI****
        /// -----END EC PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("EncryptPrivateKey")]
        [Validation(Required=false)]
        public string EncryptPrivateKey { get; set; }

        /// <summary>
        /// <para>The certificate expiration date, in the format of YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-25</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Indicates whether the certificate has expired. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The certificate has expired.</description></item>
        /// <item><description><b>false</b>: The certificate has not expired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The certificate fingerprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D7801BBE772D5DE55CBF1F88AEB41A42402DA07</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The resource instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-ivauto-hqito6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The certification authority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The private key that uses a non-Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- MII.... -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The end time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17326613180000</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public long? NotAfter { get; set; }

        /// <summary>
        /// <para>The start time of the certificate validity period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17321613180000</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public long? NotBefore { get; set; }

        /// <summary>
        /// <para>The ID of the certificate application order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// <para>The name of the company or organization to which the certificate purchaser belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba</para>
        /// </summary>
        [NameInMap("OrgName")]
        [Validation(Required=false)]
        public string OrgName { get; set; }

        /// <summary>
        /// <para>The province where the company or organization of the certificate purchaser is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhejiang</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>All domain names bound to the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.com</para>
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// <para>The certificate serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>033cd852608689ef5e368fde89e0961769e8</para>
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// <para>The SHA-2 value of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>573415B23243066AD345AE5A57BD0FAE94F598BDD06D906278B5FF318F090FC8</para>
        /// </summary>
        [NameInMap("Sha2")]
        [Validation(Required=false)]
        public string Sha2 { get; set; }

        /// <summary>
        /// <para>The signing certificate content in PEM format that uses a Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----
        /// MIICDzCCAbagAw****
        /// -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SignCert")]
        [Validation(Required=false)]
        public string SignCert { get; set; }

        /// <summary>
        /// <para>The private key of the signing certificate in PEM format that uses a Chinese cryptographic algorithm. This field is returned when the CertFilter request parameter is set to false, and is not returned when set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN EC PRIVATE KEY-----
        /// MHcCAQEEILR****
        /// -----END EC PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("SignPrivateKey")]
        [Validation(Required=false)]
        public string SignPrivateKey { get; set; }

        /// <summary>
        /// <para>The certificate issuance date, in the format of YYYY-MM-DD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-13</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetUserCertificateDetailResponseBodyTags> Tags { get; set; }
        public class GetUserCertificateDetailResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
