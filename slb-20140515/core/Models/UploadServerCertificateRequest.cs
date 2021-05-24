// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class UploadServerCertificateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("AliCloudCertificateId")]
        [Validation(Required=false)]
        public string AliCloudCertificateId { get; set; }

        [NameInMap("AliCloudCertificateName")]
        [Validation(Required=false)]
        public string AliCloudCertificateName { get; set; }

        [NameInMap("AliCloudCertificateRegionId")]
        [Validation(Required=false)]
        public string AliCloudCertificateRegionId { get; set; }

        [NameInMap("ServerCertificate")]
        [Validation(Required=false)]
        public string ServerCertificate { get; set; }

        [NameInMap("PrivateKey")]
        [Validation(Required=false)]
        public string PrivateKey { get; set; }

        [NameInMap("ServerCertificateName")]
        [Validation(Required=false)]
        public string ServerCertificateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
