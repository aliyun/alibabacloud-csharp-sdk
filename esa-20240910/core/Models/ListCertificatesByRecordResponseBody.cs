// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCertificatesByRecordResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCertificatesByRecordResponseBodyResult> Result { get; set; }
        public class ListCertificatesByRecordResponseBodyResult : TeaModel {
            [NameInMap("ApplylingCount")]
            [Validation(Required=false)]
            public long? ApplylingCount { get; set; }

            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListCertificatesByRecordResponseBodyResultCertificates> Certificates { get; set; }
            public class ListCertificatesByRecordResponseBodyResultCertificates : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>30000137</para>
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
                /// <para>2023-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1dc5fc9af4eead2570c70d94b416130baeb6d4429b51fd3557379588456aca66</para>
                /// </summary>
                [NameInMap("FingerprintSha256")]
                [Validation(Required=false)]
                public string FingerprintSha256 { get; set; }

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

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("NotAfter")]
                [Validation(Required=false)]
                public string NotAfter { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-02-28 06:17:11</para>
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
                /// <para>baba39055622c008b90285a8838ed09a</para>
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
                /// <para>2023-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        [NameInMap("SiteName")]
        [Validation(Required=false)]
        public string SiteName { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
