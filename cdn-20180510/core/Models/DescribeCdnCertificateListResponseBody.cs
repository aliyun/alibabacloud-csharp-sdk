// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about certificates.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

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
            /// <para>The number of certificates that are returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC0E34AC-0239-44A7-AB0E-800DE522C8DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
