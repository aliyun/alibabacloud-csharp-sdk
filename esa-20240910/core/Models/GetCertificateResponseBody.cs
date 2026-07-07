// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCertificateResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The certificate information.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetCertificateResponseBodyResult Result { get; set; }
        public class GetCertificateResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The error code of the certificate application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ApplyCode")]
            [Validation(Required=false)]
            public long? ApplyCode { get; set; }

            /// <summary>
            /// <para>The error message of the certificate application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>canceled</para>
            /// </summary>
            [NameInMap("ApplyMessage")]
            [Validation(Required=false)]
            public string ApplyMessage { get; set; }

            /// <summary>
            /// <para>The cloud certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000478</para>
            /// </summary>
            [NameInMap("CasId")]
            [Validation(Required=false)]
            public string CasId { get; set; }

            /// <summary>
            /// <para>The Common Name (CN) field of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The creation time. The time is in the YYYY-MM-DD HH:MM:SS format in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01 07:25:23</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Domain Control Validation (DCV) information.</para>
            /// </summary>
            [NameInMap("DCV")]
            [Validation(Required=false)]
            public List<GetCertificateResponseBodyResultDCV> DCV { get; set; }
            public class GetCertificateResponseBodyResultDCV : TeaModel {
                /// <summary>
                /// <para>DCV ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>bababf7cdd1546a2ad04c0def1f4c980</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The DCV name. For the DNS type, this is the TXT record name. For the HTTP type, this is the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/.well-known/acme-challenge/pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow">http://www.example.com/.well-known/acme-challenge/pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow</a></para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The validation status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The DCV type. Valid values: DNS and HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The DCV content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow.KfzYo4LH3EgOt7a73G-RqZkbR0eYtLfEUmtmqGmr4FQ</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>babaded901474b9693acf530e0fb1d95</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>The certification authority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DigiCert Global Root CA</para>
            /// </summary>
            [NameInMap("IssuerCN")]
            [Validation(Required=false)]
            public string IssuerCN { get; set; }

            /// <summary>
            /// <para>The Keyless server ID. This parameter is valid only when Type is set to keyless.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baba39055622c008b90285a8838e****</para>
            /// </summary>
            [NameInMap("KeyServerId")]
            [Validation(Required=false)]
            public string KeyServerId { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourCertName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The end time of the certificate validity period. The time is in the YYYY-MM-DD HH:MM:SS format in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-29 06:26:46</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            /// <summary>
            /// <para>The start time of the certificate validity period. The time is in the YYYY-MM-DD HH:MM:SS format in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01 06:26:47</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            /// <summary>
            /// <para>The public key algorithm of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ECDSA</para>
            /// </summary>
            [NameInMap("PubAlg")]
            [Validation(Required=false)]
            public string PubAlg { get; set; }

            /// <summary>
            /// <para>The region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The Subject Alternative Name (SAN) of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com,*.example.com">www.example.com,*.example.com</a></para>
            /// </summary>
            [NameInMap("SAN")]
            [Validation(Required=false)]
            public string SAN { get; set; }

            /// <summary>
            /// <para>The certificate serial number.</para>
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
            /// <para>ECDSA-SHA1</para>
            /// </summary>
            [NameInMap("SigAlg")]
            [Validation(Required=false)]
            public string SigAlg { get; set; }

            /// <summary>
            /// <para>The certificate status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The certificate type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The update time. The time is in the YYYY-MM-DD HH:MM:SS format in the UTC/GMT time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-07-01 07:25:23</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>The certificate status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
