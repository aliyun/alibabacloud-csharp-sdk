// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodCertificateListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about each certificate.</para>
        /// </summary>
        [NameInMap("CertificateListModel")]
        [Validation(Required=false)]
        public DescribeVodCertificateListResponseBodyCertificateListModel CertificateListModel { get; set; }
        public class DescribeVodCertificateListResponseBodyCertificateListModel : TeaModel {
            /// <summary>
            /// <para>The list of certificates.</para>
            /// </summary>
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeVodCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeVodCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeVodCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeVodCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    /// <summary>
                    /// <para>The algorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RSA</para>
                    /// </summary>
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>235437</para>
                    /// </summary>
                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    /// <summary>
                    /// <para>The ID of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14173772-cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("CertIdentifier")]
                    [Validation(Required=false)]
                    public string CertIdentifier { get; set; }

                    /// <summary>
                    /// <para>The name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>certificate</para>
                    /// </summary>
                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The common name of the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    /// <summary>
                    /// <para>The time when the certificate was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1725206400000</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>DomainMatchCert.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("DomainMatchCert")]
                    [Validation(Required=false)]
                    public bool? DomainMatchCert { get; set; }

                    /// <summary>
                    /// <para>The time when the certificate expired.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1759507200000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

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
                    /// <para>The ID of the instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cert-cn-cd806ae0fdfbfa60</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

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
                    /// <para>1512388610</para>
                    /// </summary>
                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

                    /// <summary>
                    /// <para>The signAlgorithm.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sha256withrsa</para>
                    /// </summary>
                    [NameInMap("SignAlgorithm")]
                    [Validation(Required=false)]
                    public string SignAlgorithm { get; set; }

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
        /// <para>FC0E34AC-0239-44A7-****-800DE522C8DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
