// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeServerCertificatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ServerCertificates")]
        [Validation(Required=false)]
        public DescribeServerCertificatesResponseBodyServerCertificates ServerCertificates { get; set; }
        public class DescribeServerCertificatesResponseBodyServerCertificates : TeaModel {
            [NameInMap("ServerCertificate")]
            [Validation(Required=false)]
            public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate> ServerCertificate { get; set; }
            public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate : TeaModel {
                [NameInMap("AliCloudCertificateId")]
                [Validation(Required=false)]
                public string AliCloudCertificateId { get; set; }

                [NameInMap("AliCloudCertificateName")]
                [Validation(Required=false)]
                public string AliCloudCertificateName { get; set; }

                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                [NameInMap("IsAliCloudCertificate")]
                [Validation(Required=false)]
                public int? IsAliCloudCertificate { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

                [NameInMap("ServerCertificateName")]
                [Validation(Required=false)]
                public string ServerCertificateName { get; set; }

                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames SubjectAlternativeNames { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames : TeaModel {
                    [NameInMap("SubjectAlternativeName")]
                    [Validation(Required=false)]
                    public List<string> SubjectAlternativeName { get; set; }

                }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags Tags { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag> Tag { get; set; }
                    public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

    }

}
