// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class SslCertMetaInfo : TeaModel {
        /// <summary>
        /// <para>The algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RSA2048</para>
        /// </summary>
        [NameInMap("algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("certId")]
        [Validation(Required=false)]
        public long? CertId { get; set; }

        /// <summary>
        /// <para>The certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cert-123</para>
        /// </summary>
        [NameInMap("certIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The certificate name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("certName")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <para>The name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("commonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The certificate matching the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("domainMatchCert")]
        [Validation(Required=false)]
        public bool? DomainMatchCert { get; set; }

        /// <summary>
        /// <para>The certificate fingerprint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1:B2:C3:D4:E5:F6:78:90:AB:CD:EF:12:34:56:78:90</para>
        /// </summary>
        [NameInMap("fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp1234567890</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>isChainCompleted</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("isChainCompleted")]
        [Validation(Required=false)]
        public bool? IsChainCompleted { get; set; }

        /// <summary>
        /// <para>The certificate issuer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DigiCert Inc</para>
        /// </summary>
        [NameInMap("issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The key size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2048</para>
        /// </summary>
        [NameInMap("keySize")]
        [Validation(Required=false)]
        public string KeySize { get; set; }

        /// <summary>
        /// <para>The md5 value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4E5F67890ABCDEF1234567890</para>
        /// </summary>
        [NameInMap("md5")]
        [Validation(Required=false)]
        public string Md5 { get; set; }

        /// <summary>
        /// <para>The time when the certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("notAfterTimestamp")]
        [Validation(Required=false)]
        public long? NotAfterTimestamp { get; set; }

        /// <summary>
        /// <para>The time when the certificate starts to take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890000</para>
        /// </summary>
        [NameInMap("notBeforeTimestamp")]
        [Validation(Required=false)]
        public long? NotBeforeTimestamp { get; set; }

        /// <summary>
        /// <para>sans</para>
        /// 
        /// <b>Example:</b>
        /// <para>*.example.com,api.example.com,<a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("sans")]
        [Validation(Required=false)]
        public string Sans { get; set; }

        /// <summary>
        /// <para>The serial number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>03:A1:B2:C3:D4:E5:F6:78:90:AB:CD:EF:12:34:56:78:90</para>
        /// </summary>
        [NameInMap("serialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        /// <summary>
        /// <para>The sha2 value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4E5F67890ABCDEF1234567890ABCDEF1234567890ABCDEF1234567890</para>
        /// </summary>
        [NameInMap("sha2")]
        [Validation(Required=false)]
        public string Sha2 { get; set; }

        /// <summary>
        /// <para>The signature algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha256WithRSAEncryption</para>
        /// </summary>
        [NameInMap("signAlgorithm")]
        [Validation(Required=false)]
        public string SignAlgorithm { get; set; }

    }

}
