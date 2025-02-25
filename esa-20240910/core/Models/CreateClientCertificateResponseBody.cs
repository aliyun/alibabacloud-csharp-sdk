// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateClientCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>babaded901474b9693acf530e0fb1dbb</para>
        /// </summary>
        [NameInMap("CACertificateId")]
        [Validation(Required=false)]
        public string CACertificateId { get; set; }

        /// <summary>
        /// <para>The certificate content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("Certificate")]
        [Validation(Required=false)]
        public string Certificate { get; set; }

        /// <summary>
        /// <para>The Common Name of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com">www.example.com</a></para>
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// <para>The SHA-256 fingerprint of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dc5fc9af4eead2570c70d94b416130baeb6d4429b51fd3557379588456aca66</para>
        /// </summary>
        [NameInMap("FingerprintSha256")]
        [Validation(Required=false)]
        public string FingerprintSha256 { get; set; }

        /// <summary>
        /// <para>The certificate ID on ESA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>babaded901474b9693acf530e0fb1d95</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The CA that issued the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DCDN CA</para>
        /// </summary>
        [NameInMap("Issuer")]
        [Validation(Required=false)]
        public string Issuer { get; set; }

        /// <summary>
        /// <para>The time when the certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-12-01T02:12:49Z</para>
        /// </summary>
        [NameInMap("NotAfter")]
        [Validation(Required=false)]
        public string NotAfter { get; set; }

        /// <summary>
        /// <para>The time when the certificate takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-01T02:12:49Z</para>
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        /// <summary>
        /// <para>The private key of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PRIVATE KEY-----</para>
        /// </summary>
        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The serial number of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>babaded901474b9693acf530e0fb1daa</para>
        /// </summary>
        [NameInMap("SerialNumber")]
        [Validation(Required=false)]
        public string SerialNumber { get; set; }

        /// <summary>
        /// <para>The signature algorithm of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SHA256-RSA</para>
        /// </summary>
        [NameInMap("SignatureAlgorithm")]
        [Validation(Required=false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// <para>The status of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The validity period of the certificate. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("ValidityDays")]
        [Validation(Required=false)]
        public string ValidityDays { get; set; }

    }

}
