// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeServerCertificatesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The list of server certificates.
        /// </summary>
        [NameInMap("ServerCertificates")]
        [Validation(Required=false)]
        public DescribeServerCertificatesResponseBodyServerCertificates ServerCertificates { get; set; }
        public class DescribeServerCertificatesResponseBodyServerCertificates : TeaModel {
            [NameInMap("ServerCertificate")]
            [Validation(Required=false)]
            public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate> ServerCertificate { get; set; }
            public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificate : TeaModel {
                /// <summary>
                /// The ID of the server certificate from Alibaba Cloud Certificate Management Service.
                /// </summary>
                [NameInMap("AliCloudCertificateId")]
                [Validation(Required=false)]
                public string AliCloudCertificateId { get; set; }

                /// <summary>
                /// The name of the server certificate from Alibaba Cloud Certificate Management Service.
                /// </summary>
                [NameInMap("AliCloudCertificateName")]
                [Validation(Required=false)]
                public string AliCloudCertificateName { get; set; }

                /// <summary>
                /// The domain name of the certificate. The domain name is specified in the `CommonName` field.
                /// </summary>
                [NameInMap("CommonName")]
                [Validation(Required=false)]
                public string CommonName { get; set; }

                /// <summary>
                /// The time when the server certificate is uploaded.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The timestamp generated when the server certificate is uploaded.
                /// </summary>
                [NameInMap("CreateTimeStamp")]
                [Validation(Required=false)]
                public long? CreateTimeStamp { get; set; }

                /// <summary>
                /// The expiration time.
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// The timestamp that indicates when the certificate expires.
                /// </summary>
                [NameInMap("ExpireTimeStamp")]
                [Validation(Required=false)]
                public long? ExpireTimeStamp { get; set; }

                /// <summary>
                /// The fingerprint of the server certificate.
                /// </summary>
                [NameInMap("Fingerprint")]
                [Validation(Required=false)]
                public string Fingerprint { get; set; }

                /// <summary>
                /// Indicates whether the server certificate is from Alibaba Cloud Certificate Management Service. Valid values:
                /// 
                /// *   **1**: yes
                /// *   **0**: no
                /// </summary>
                [NameInMap("IsAliCloudCertificate")]
                [Validation(Required=false)]
                public int? IsAliCloudCertificate { get; set; }

                /// <summary>
                /// The ID of the region where the server certificate is created.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the server certificate.
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

                /// <summary>
                /// The name of the server certificate.
                /// </summary>
                [NameInMap("ServerCertificateName")]
                [Validation(Required=false)]
                public string ServerCertificateName { get; set; }

                /// <summary>
                /// The list of alternative domain names of the server certificate. The alternative domain names are specified in the `Subject Alternative Name` field of the server certificate.
                /// </summary>
                [NameInMap("SubjectAlternativeNames")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames SubjectAlternativeNames { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateSubjectAlternativeNames : TeaModel {
                    [NameInMap("SubjectAlternativeName")]
                    [Validation(Required=false)]
                    public List<string> SubjectAlternativeName { get; set; }

                }

                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags Tags { get; set; }
                public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag> Tag { get; set; }
                    public class DescribeServerCertificatesResponseBodyServerCertificatesServerCertificateTagsTag : TeaModel {
                        /// <summary>
                        /// The tag keys of the resource.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

    }

}
