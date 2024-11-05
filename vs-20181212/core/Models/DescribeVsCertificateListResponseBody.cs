// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsCertificateListResponseBody : TeaModel {
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVsCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVsCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeVsCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeVsCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6338888</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public long? CertId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cert-5391062</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Common")]
                [Validation(Required=false)]
                public string Common { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3EB2585309AE5C8F369****7CDA6A8F5CEC8B2D4</para>
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xxxxCert Inc</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1632462708</para>
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6E310519-E035-51AB-80D4-C1CBECD39EB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
