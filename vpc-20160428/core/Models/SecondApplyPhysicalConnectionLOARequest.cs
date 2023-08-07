// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class SecondApplyPhysicalConnectionLOARequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CompanyName")]
        [Validation(Required=false)]
        public string CompanyName { get; set; }

        [NameInMap("ConstructionTime")]
        [Validation(Required=false)]
        public string ConstructionTime { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("LineType")]
        [Validation(Required=false)]
        public string LineType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PMInfo")]
        [Validation(Required=false)]
        public List<SecondApplyPhysicalConnectionLOARequestPMInfo> PMInfo { get; set; }
        public class SecondApplyPhysicalConnectionLOARequestPMInfo : TeaModel {
            [NameInMap("PMCertificateNo")]
            [Validation(Required=false)]
            public string PMCertificateNo { get; set; }

            [NameInMap("PMCertificateType")]
            [Validation(Required=false)]
            public string PMCertificateType { get; set; }

            [NameInMap("PMContactInfo")]
            [Validation(Required=false)]
            public string PMContactInfo { get; set; }

            [NameInMap("PMGender")]
            [Validation(Required=false)]
            public string PMGender { get; set; }

            [NameInMap("PMName")]
            [Validation(Required=false)]
            public string PMName { get; set; }

        }

        [NameInMap("PeerLocation")]
        [Validation(Required=false)]
        public string PeerLocation { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("Si")]
        [Validation(Required=false)]
        public string Si { get; set; }

    }

}
