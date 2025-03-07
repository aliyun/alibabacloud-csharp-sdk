// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSMCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the certificate information.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnSMCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnSMCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// <para>A list of certificates.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public List<DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList> CertList { get; set; }
            public class DescribeDcdnSMCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourCertldentifier</para>
                /// </summary>
                [NameInMap("CertIdentifier")]
                [Validation(Required=false)]
                public string CertIdentifier { get; set; }

                /// <summary>
                /// <para>The name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourCertName</para>
                /// </summary>
                [NameInMap("CertName")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The common name of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourCertCommon</para>
                /// </summary>
                [NameInMap("Common")]
                [Validation(Required=false)]
                public string Common { get; set; }

                /// <summary>
                /// <para>The certificate authority (CA) that issued the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yourCertIssuer</para>
                /// </summary>
                [NameInMap("Issuer")]
                [Validation(Required=false)]
                public string Issuer { get; set; }

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
