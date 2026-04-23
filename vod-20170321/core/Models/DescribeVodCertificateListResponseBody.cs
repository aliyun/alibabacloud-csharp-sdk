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
            [NameInMap("CertList")]
            [Validation(Required=false)]
            public DescribeVodCertificateListResponseBodyCertificateListModelCertList CertList { get; set; }
            public class DescribeVodCertificateListResponseBodyCertificateListModelCertList : TeaModel {
                [NameInMap("Cert")]
                [Validation(Required=false)]
                public List<DescribeVodCertificateListResponseBodyCertificateListModelCertListCert> Cert { get; set; }
                public class DescribeVodCertificateListResponseBodyCertificateListModelCertListCert : TeaModel {
                    [NameInMap("Algorithm")]
                    [Validation(Required=false)]
                    public string Algorithm { get; set; }

                    [NameInMap("CertId")]
                    [Validation(Required=false)]
                    public long? CertId { get; set; }

                    [NameInMap("CertIdentifier")]
                    [Validation(Required=false)]
                    public string CertIdentifier { get; set; }

                    [NameInMap("CertName")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("Common")]
                    [Validation(Required=false)]
                    public string Common { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    [NameInMap("DomainMatchCert")]
                    [Validation(Required=false)]
                    public bool? DomainMatchCert { get; set; }

                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    [NameInMap("Fingerprint")]
                    [Validation(Required=false)]
                    public string Fingerprint { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Issuer")]
                    [Validation(Required=false)]
                    public string Issuer { get; set; }

                    [NameInMap("LastTime")]
                    [Validation(Required=false)]
                    public long? LastTime { get; set; }

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
