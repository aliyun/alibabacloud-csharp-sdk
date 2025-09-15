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
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("BuyInAliyun")]
        [Validation(Required=false)]
        public bool? BuyInAliyun { get; set; }

        /// <summary>
        /// <para>The content of the certificate if the certificate does not use an SM algorithm. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>---BEGIN CERTIFICATE----- MIIF...... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Cert")]
        [Validation(Required=false)]
        public string Cert { get; set; }

        /// <summary>
        /// <para>The certificate chain.</para>
        /// </summary>
        [NameInMap("CertChain")]
        [Validation(Required=false)]
        public List<GetUserCertificateDetailResponseBodyCertChain> CertChain { get; set; }
        public class GetUserCertificateDetailResponseBodyCertChain : TeaModel {
            /// <summary>
            /// <para>The common name of the certificate.</para>
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
            /// <para>The end of the validity period of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17322613180000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <para>The beginning of the validity period of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17302633180000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <para>The remaining days of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("RemainDay")]
            [Validation(Required=false)]
            public int? RemainDay { get; set; }

        }

        /// <summary>
        /// <para>The certificate identifier. The value is in the &quot;Certificate ID-cn-hangzhou&quot; format. For example, if the ID of the certificate is 123, the value of CertIdentifier is 123-cn-hangzhou.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10741304-cn-hangzhou</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The city of the company or organization to which the certificate purchaser belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The primary domain name that is bound to the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.com</para>
        /// </summary>
        [NameInMap("Common")]
        [Validation(Required=false)]
        public string Common { get; set; }

        /// <summary>
        /// <para>The country or region of the company or organization to which the certificate purchaser belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The content of the encryption certificate if the certificate uses an SM algorithm and is encoded in the PEM format. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
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
        /// <para>The private key of the encryption certificate if the certificate uses an SM algorithm and is encoded in the PEM format. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
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
        /// <para>The expiration date of the certificate.</para>
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
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The fingerprint of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D7801BBE772D5DE55CBF1F88AEB41A42402DA07</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>The instance ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cas-upload-50yf1q</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The certificate authority (CA) that issued the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Digicert</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The private key of the certificate if the certificate does not use an SM algorithm. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN RSA PRIVATE KEY----- MII.... -----END RSA PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The end of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17322613180000</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public long? NotAfter { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17312613180000</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public long? NotBefore { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
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
        /// <para>The province of the company or organization to which the certificate purchaser belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhejiang</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek****wia</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>All domain names that are bound to the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.com</para>
        /// </summary>
        [NameInMap("Sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// <para>The serial number of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>06ea4879591ddf84e6c8b6ba43607ccf</para>
        /// </summary>
        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// <para>The SHA-2 value of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>840707695D5EE41323102DDC2CB4924AA561012FBDC4E1A6324147119ED3C339</para>
        /// </summary>
        [NameInMap("Sha2")]
        [Validation(Required=false)]
        public string Sha2 { get; set; }

        /// <summary>
        /// <para>The content of the signing certificate if the certificate uses an SM algorithm and is encoded in the PEM format. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
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
        /// <para>The private key of the signing certificate if the certificate uses an SM algorithm and is encoded in the PEM format. If certFilter is set to false, this parameter is returned. Otherwise, this parameter is not returned.</para>
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
        /// <para>The issuance date of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2018-07-13</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetUserCertificateDetailResponseBodyTags> Tags { get; set; }
        public class GetUserCertificateDetailResponseBodyTags : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
