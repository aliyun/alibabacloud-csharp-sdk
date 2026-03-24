// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnSMCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the certificate information.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeCdnSMCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeCdnSMCertificateListResponseBodyCertificateListModel : TeaModel {
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnSMCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnSMCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnSMCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnSMCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("CertIdentifier")]
                    [Validation(Required=false)]
                    public string CertIdentifier { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

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
        /// <para>DC0E34AC-0239-44A7-AB0E-800DE522C8DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
