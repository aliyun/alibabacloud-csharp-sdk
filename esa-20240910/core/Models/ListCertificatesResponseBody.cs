// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>Number of records per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result array.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCertificatesResponseBodyResult> Result { get; set; }
        public class ListCertificatesResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Certificate application error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ApplyCode")]
            [Validation(Required=false)]
            public long? ApplyCode { get; set; }

            /// <summary>
            /// <para>Certificate application error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>canceled</para>
            /// </summary>
            [NameInMap("ApplyMessage")]
            [Validation(Required=false)]
            public string ApplyMessage { get; set; }

            /// <summary>
            /// <para>Cloud certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30000569</para>
            /// </summary>
            [NameInMap("CasId")]
            [Validation(Required=false)]
            public string CasId { get; set; }

            /// <summary>
            /// <para>Common name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-06-24 07:48:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>DCV information.</para>
            /// </summary>
            [NameInMap("DCV")]
            [Validation(Required=false)]
            public List<ListCertificatesResponseBodyResultDCV> DCV { get; set; }
            public class ListCertificatesResponseBodyResultDCV : TeaModel {
                /// <summary>
                /// <para>DCV ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bababf7cdd1546a2ad04c0def1f4****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>DCV name. For DNS type, it is the TXT record name; for HTTP type, it is the URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com/.well-known/acme-challenge/pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow">http://www.example.com/.well-known/acme-challenge/pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow</a></para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>Verification status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pending</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>DCV type. Possible values: DNS; HTTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>DCV content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pH20CqwS5L3ZnvkhI436DCzadKFuG7QcUcvB_4KsAow.KfzYo4LH3EgOt7a73G-RqZkbR0eYtLfEUmtmqGmr4FQ</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Certificate SHA256 fingerprint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1dc5fc9af4eead2570c70d94b416130baeb6d4429b51fd3557379588456a****</para>
            /// </summary>
            [NameInMap("FingerprintSha256")]
            [Validation(Required=false)]
            public string FingerprintSha256 { get; set; }

            /// <summary>
            /// <para>Certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baba39055622c008b90285a8838e****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GlobalSign nv-sa</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <para>Common name of the certificate issuer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GlobalSign Organization Validation CA - SHA256 - G3</para>
            /// </summary>
            [NameInMap("IssuerCN")]
            [Validation(Required=false)]
            public string IssuerCN { get; set; }

            /// <summary>
            /// <para>Certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourCertName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>End date of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-31 02:08:00</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            /// <summary>
            /// <para>Start date of the certificate validity period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-31 02:08:00</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            /// <summary>
            /// <para>Certificate public key algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("PubAlg")]
            [Validation(Required=false)]
            public string PubAlg { get; set; }

            /// <summary>
            /// <para>Region information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Subject Alternative Name of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com,*.example.com">www.example.com,*.example.com</a></para>
            /// </summary>
            [NameInMap("SAN")]
            [Validation(Required=false)]
            public string SAN { get; set; }

            /// <summary>
            /// <para>Certificate serial number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>babab022c5e9b27bf9c64d7f4b16****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <para>Certificate signature algorithm.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SHA256-RSA</para>
            /// </summary>
            [NameInMap("SigAlg")]
            [Validation(Required=false)]
            public string SigAlg { get; set; }

            /// <summary>
            /// <para>Certificate status.</para>
            /// <list type="bullet">
            /// <item><description>OK: Normal.</description></item>
            /// <item><description>Expired: The certificate has expired.</description></item>
            /// <item><description>Expiring: The certificate is about to expire (within 30 days).</description></item>
            /// <item><description>Issued: Free certificate - issued.</description></item>
            /// <item><description>Applying: Free certificate - applying.</description></item>
            /// <item><description>ApplyFailed: Free certificate - application failed.</description></item>
            /// <item><description>Canceled: Free certificate - canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Certificate type.</para>
            /// <list type="bullet">
            /// <item><description>cas: Cloud Shield certificate.</description></item>
            /// <item><description>upload: Custom uploaded certificate.</description></item>
            /// <item><description>free: Free certificate.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>Update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-20 06:18:42</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>Site name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <para>Total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
