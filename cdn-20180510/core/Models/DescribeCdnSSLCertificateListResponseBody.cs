// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSSLCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of certificates.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnSSLCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnSSLCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnSSLCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnSSLCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnSSLCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnSSLCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("CertRegion")]
                    [Validation(Required=false)]
                    public string CertRegion { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of certificates.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number. Pages start from page 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Valid values: an integer from 1 to 1000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9D3257A-1B7C-414C-90C1-8D07AC47BCAC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
