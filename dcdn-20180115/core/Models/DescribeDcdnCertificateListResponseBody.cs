// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about certificates.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeDcdnCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeDcdnCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// <para>Details about each certificate.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeDcdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeDcdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Certificate 2</para>
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The Common Name (CN) attribute of the certificate. In most cases, the CN is a domain name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.com</para>
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// <para>The fingerprint of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0151xxxx</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <para>The certificate authority (CA) that issued the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DigiCert</para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1548065550</para>
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
            /// <para>123</para>
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
