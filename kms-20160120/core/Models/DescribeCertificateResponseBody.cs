// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:kms:cn-hangzhou:159498693826****:certificate/9a28de48-8d8b-484d-a766-dec4****&quot;</para>
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public string Arn { get; set; }

        /// <summary>
        /// <para>The ID of the certificate. The ID must be globally unique in Certificates Manager.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9a28de48-8d8b-484d-a766-dec4****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The time when the certificate was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13T03:05:03Z</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>Indicates whether the private key of the certificate can be exported for use. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The private key of the certificate can be exported for use. This is the default value.</description></item>
        /// <item><description>false: The private key of the certificate cannot be exported for use.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ExportablePrivateKey")]
        [Validation(Required=false)]
        public bool? ExportablePrivateKey { get; set; }

        /// <summary>
        /// <para>The certificate issuer in the distinguished name (DN) format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN=testCA,OU=kms,O=aliyun,C=CN</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The type of the key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA_2048</para>
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// <para>The end of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-13T03:09:00Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The beginning of the validity period of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-10-13T03:09:00Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>edb671a3-c5a1-4ebe-a1de-d748b640bdf2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("Serial")]
        [Validation(Required=false)]
        public string Serial { get; set; }

        /// <summary>
        /// <para>The signature algorithm of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RSA2048-SHA256</description></item>
        /// <item><description>ECDSA-SHA256</description></item>
        /// <item><description>SM2-SM3</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ECDSA-SHA256</para>
        /// </summary>
        [NameInMap("SignatureAlgorithm")]
        [Validation(Required=false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// <para>The status of the certificate. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PENDING: The certificate is to be imported.</description></item>
        /// <item><description>ACTIVE: The certificate is enabled.</description></item>
        /// <item><description>INACTIVE: The certificate is disabled.</description></item>
        /// <item><description>REVOKED: The certificate is revoked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The subject of the certificate, which is in the DN format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CN=userName,OU=aliyun,O=aliyun,C=CN</para>
        /// </summary>
        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        /// <summary>
        /// <para>The alias of the certificate subject.</para>
        /// <para>A domain name list is supported. A maximum of 10 domain names are supported.</para>
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public List<string> SubjectAlternativeNames { get; set; }

        /// <summary>
        /// <para>The public key identifier of the certificate subject.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79 36 26 DE 9F F5 15 E3 56 DC ****</para>
        /// </summary>
        [NameInMap("SubjectKeyIdentifier")]
        [Validation(Required=false)]
        public string SubjectKeyIdentifier { get; set; }

        /// <summary>
        /// <para>The public key of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PUBLIC KEY----- MIIBIjA -----END PUBLIC KEY-----</para>
        /// </summary>
        [NameInMap("SubjectPublicKey")]
        [Validation(Required=false)]
        public string SubjectPublicKey { get; set; }

        /// <summary>
        /// <para>The tag of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;TagKey\&quot;:\&quot;S1key1\&quot;,\&quot;TagValue\&quot;:\&quot;S1val1\&quot;},{\&quot;TagKey\&quot;:\&quot;S1key2\&quot;,\&quot;TagValue\&quot;:\&quot;S2val2\&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        /// <summary>
        /// <para>The time when the certificate was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-23T06:10:13Z</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

    }

}
