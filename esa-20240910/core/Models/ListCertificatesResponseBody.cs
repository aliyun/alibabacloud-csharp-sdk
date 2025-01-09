// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCertificatesResponseBodyResult> Result { get; set; }
        public class ListCertificatesResponseBodyResult : TeaModel {
            [NameInMap("ApplyCode")]
            [Validation(Required=false)]
            public long? ApplyCode { get; set; }

            [NameInMap("ApplyMessage")]
            [Validation(Required=false)]
            public string ApplyMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30000569</para>
            /// </summary>
            [NameInMap("CasId")]
            [Validation(Required=false)]
            public string CasId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-06-24 07:48:51</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DCV")]
            [Validation(Required=false)]
            public List<ListCertificatesResponseBodyResultDCV> DCV { get; set; }
            public class ListCertificatesResponseBodyResultDCV : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1dc5fc9af4eead2570c70d94b416130baeb6d4429b51fd3557379588456a****</para>
            /// </summary>
            [NameInMap("FingerprintSha256")]
            [Validation(Required=false)]
            public string FingerprintSha256 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>baba39055622c008b90285a8838e****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GlobalSign nv-sa</para>
            /// </summary>
            [NameInMap("Issuer")]
            [Validation(Required=false)]
            public string Issuer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>GlobalSign Organization Validation CA - SHA256 - G3</para>
            /// </summary>
            [NameInMap("IssuerCN")]
            [Validation(Required=false)]
            public string IssuerCN { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>yourCertName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-03-31 02:08:00</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public string NotAfter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-03-31 02:08:00</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public string NotBefore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RSA</para>
            /// </summary>
            [NameInMap("PubAlg")]
            [Validation(Required=false)]
            public string PubAlg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com,*.example.com">www.example.com,*.example.com</a></para>
            /// </summary>
            [NameInMap("SAN")]
            [Validation(Required=false)]
            public string SAN { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>babab022c5e9b27bf9c64d7f4b16****</para>
            /// </summary>
            [NameInMap("SerialNumber")]
            [Validation(Required=false)]
            public string SerialNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SHA256-RSA</para>
            /// </summary>
            [NameInMap("SigAlg")]
            [Validation(Required=false)]
            public string SigAlg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>free</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-04-20 06:18:42</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
