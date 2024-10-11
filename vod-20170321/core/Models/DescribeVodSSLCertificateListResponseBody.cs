// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodSSLCertificateListResponseBody : TeaModel {
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVodSSLCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVodSSLCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeVodSSLCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeVodSSLCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeVodSSLCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeVodSSLCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>235437</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>video-ssl</para>
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("CertRegion")]
                    [Validation(Required=false)]
                    public string CertRegion { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1512388610</para>
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
