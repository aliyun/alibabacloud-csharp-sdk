// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadServerCertificateResponseBody : TeaModel {
        /// <summary>
        /// The AliCloud certificate ID.
        /// </summary>
        [NameInMap("AliCloudCertificateId")]
        [Validation(Required=false)]
        public string AliCloudCertificateId { get; set; }

        /// <summary>
        /// The AliCloud certificate name.
        /// </summary>
        [NameInMap("AliCloudCertificateName")]
        [Validation(Required=false)]
        public string AliCloudCertificateName { get; set; }

        /// <summary>
        /// The domain name of the CA certificate.
        /// </summary>
        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// The time when the CA certificate is uploaded.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp generated when the CA certificate is uploaded.
        /// </summary>
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// The time when the CA certificate expires.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// The timestamp generated when the CA certificate expires.
        /// </summary>
        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public long? ExpireTimeStamp { get; set; }

        /// <summary>
        /// The fingerprint of the CA certificate.
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Indicates whether the certificate is provided by Alibaba Cloud Certificate Management Service. Valid values:
        /// - **0**: The certificate is not provided by Alibaba Cloud Certificate Management Service.
        /// - **1**: The certificate is provided by Alibaba Cloud Certificate Management Service.
        /// </summary>
        [NameInMap("IsAliCloudCertificate")]
        [Validation(Required=false)]
        public int? IsAliCloudCertificate { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](~~27584~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
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
        /// 
        /// The name must be 1 to 80 characters in length. It must start with an English letter. It can contain letters, numbers, periods (.), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ServerCertificateName")]
        [Validation(Required=false)]
        public string ServerCertificateName { get; set; }

        /// <summary>
        /// The subject alternative names.
        /// 
        /// A domain name list is supported. A maximum of 10 domain names are supported.
        /// </summary>
        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public UploadServerCertificateResponseBodySubjectAlternativeNames SubjectAlternativeNames { get; set; }
        public class UploadServerCertificateResponseBodySubjectAlternativeNames : TeaModel {
            [NameInMap("SubjectAlternativeName")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeName { get; set; }

        }

    }

}
