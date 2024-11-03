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
            /// <summary>
            /// <para>The list of certificates.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeCdnCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeCdnCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeCdnCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Certificate1</para>
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
                    /// <para>2ED68FD33786C5B42950D40A6C50353575BB****</para>
                    /// </summary>
                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    /// <summary>
                    /// <para>The certificate authority (CA) that issued the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CO****</para>
                    /// </summary>
                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    /// <summary>
                    /// <para>The timestamp.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1512388610</para>
                    /// </summary>
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
