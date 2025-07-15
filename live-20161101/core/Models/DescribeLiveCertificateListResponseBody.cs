// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeLiveCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeLiveCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// <para>The certificates.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeLiveCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeLiveCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeLiveCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeLiveCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123456</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cert-****</para>
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The Common Name (CN) attribute of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.net</para>
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// <para>The fingerprint of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <para>The certificate authority (CA) that issued the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <hr>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The time when the certificate was issued. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1512388659</para>
                    /// </summary>
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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
