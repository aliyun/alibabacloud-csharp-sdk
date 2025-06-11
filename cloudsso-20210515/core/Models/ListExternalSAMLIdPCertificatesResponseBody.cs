// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListExternalSAMLIdPCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400979BC-92EC-58B9-B47C-6913BD56A6FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The SAML signing certificates.</para>
        /// </summary>
        [NameInMap("SAMLIdPCertificates")]
        [Validation(Required=false)]
        public List<ListExternalSAMLIdPCertificatesResponseBodySAMLIdPCertificates> SAMLIdPCertificates { get; set; }
        public class ListExternalSAMLIdPCertificatesResponseBodySAMLIdPCertificates : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-c-00dt9gnl7fmjaw9c****</para>
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// <para>The issuer of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.840.113549.1.9.1=#160d696e666f406f6b74612e63****,CN=dev-xxxxxx,OU=SSOProvider,O=Okta,L=San Francisco,ST=California,C=US</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The time when the certificate expires.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2030-06-23T07:04:37Z</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            /// <summary>
            /// <para>The time when the certificate was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-06-23T07:03:37Z</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            /// <summary>
            /// <para>The public key of the certificate. The value of this parameter is in the PEM format and is Base64-encoded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MIIBIjANBgkqhkiG****</para>
            /// </summary>
            [NameInMap("PublicKey")]
            [Validation(Required=false)]
            public string PublicKey { get; set; }

            /// <summary>
            /// <para>The serial number of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>159289587****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>The signature algorithm of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256withRSA</para>
            /// </summary>
            [NameInMap("SignatureAlgorithm")]
            [Validation(Required=false)]
            public string SignatureAlgorithm { get; set; }

            /// <summary>
            /// <para>The subject of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.2.840.113549.1.9.1=#160d696e666f406f6b74612e63****,CN=dev-xxxxxx,OU=SSOProvider,O=Okta,L=San Francisco,ST=California,C=US</para>
            /// </summary>
            [NameInMap("Subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

            /// <summary>
            /// <para>The version of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The X.509 certificate in the PEM format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MIIDpDCCAoygAwIBAgIG****</para>
            /// </summary>
            [NameInMap("X509Certificate")]
            [Validation(Required=false)]
            public string X509Certificate { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
