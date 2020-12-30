// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadServerCertificateResponseBody : TeaModel {
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        [NameInMap("ExpireTimeStamp")]
        [Validation(Required=false)]
        public long? ExpireTimeStamp { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("SubjectAlternativeNames")]
        [Validation(Required=false)]
        public UploadServerCertificateResponseBodySubjectAlternativeNames SubjectAlternativeNames { get; set; }
        public class UploadServerCertificateResponseBodySubjectAlternativeNames : TeaModel {
            [NameInMap("SubjectAlternativeName")]
            [Validation(Required=false)]
            public List<string> SubjectAlternativeName { get; set; }
        };

        [NameInMap("AliCloudCertificateId")]
        [Validation(Required=false)]
        public string AliCloudCertificateId { get; set; }

        [NameInMap("AliCloudCertificateName")]
        [Validation(Required=false)]
        public string AliCloudCertificateName { get; set; }

        [NameInMap("IsAliCloudCertificate")]
        [Validation(Required=false)]
        public int? IsAliCloudCertificate { get; set; }

        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        [NameInMap("ServerCertificateName")]
        [Validation(Required=false)]
        public string ServerCertificateName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        [NameInMap("CommonName")]
        [Validation(Required=false)]
        public string CommonName { get; set; }

    }

}
