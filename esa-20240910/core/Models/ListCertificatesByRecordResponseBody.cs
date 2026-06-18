// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListCertificatesByRecordResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65C66B7B-671A-8297-9187-2R5477247B76</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>An array of record details.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<ListCertificatesByRecordResponseBodyResult> Result { get; set; }
        public class ListCertificatesByRecordResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The number of certificate requests in progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ApplylingCount")]
            [Validation(Required=false)]
            public long? ApplylingCount { get; set; }

            /// <summary>
            /// <para>A list of certificates matching the record.</para>
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListCertificatesByRecordResponseBodyResultCertificates> Certificates { get; set; }
            public class ListCertificatesByRecordResponseBodyResultCertificates : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30000137</para>
                /// </summary>
                [NameInMap("CasId")]
                [Validation(Required=false)]
                public string CasId { get; set; }

                /// <summary>
                /// <para>The common name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// <para>The time when the certificate was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

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
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>babab022c5e9b27bf9c64d7f4b1667f4</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The issuer of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GlobalSign nv-sa</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <para>The common name of the certificate issuer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GlobalSign Organization Validation CA - SHA256 - G3</para>
                /// </summary>
                [NameInMap("IssuerCN")]
                [Validation(Required=false)]
                public string IssuerCN { get; set; }

                /// <summary>
                /// <para>The Keyless server ID. This parameter is valid only when <c>Type</c> is set to <c>keyless</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baba39055622c008b90285a8838e****</para>
                /// </summary>
                [NameInMap("KeyServerId")]
                [Validation(Required=false)]
                public string KeyServerId { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourCertName</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The date and time when the certificate expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("NotAfter")]
                [Validation(Required=false)]
                public string NotAfter { get; set; }

                /// <summary>
                /// <para>The date and time when the certificate becomes valid.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("NotBefore")]
                [Validation(Required=false)]
                public string NotBefore { get; set; }

                /// <summary>
                /// <para>The public key algorithm of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RSA</para>
                /// </summary>
                [NameInMap("PubAlg")]
                [Validation(Required=false)]
                public string PubAlg { get; set; }

                /// <summary>
                /// <para>The region where the certificate is stored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The Subject Alternative Names (SANs) of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com,*.example.com">www.example.com,*.example.com</a></para>
                /// </summary>
                [NameInMap("SAN")]
                [Validation(Required=false)]
                public string SAN { get; set; }

                /// <summary>
                /// <para>The serial number of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>baba39055622c008b90285a8838ed09a</para>
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
                [NameInMap("SigAlg")]
                [Validation(Required=false)]
                public string SigAlg { get; set; }

                /// <summary>
                /// <para>The status of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the certificate. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>free</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The time when the certificate was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-02-28 06:17:11</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The number of certificates matching the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// <para>The record name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("RecordName")]
            [Validation(Required=false)]
            public string RecordName { get; set; }

            /// <summary>
            /// <para>The certificate configuration status for the record. Valid values:</para>
            /// 
            /// <b>Example:</b>
            /// <para>none</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
