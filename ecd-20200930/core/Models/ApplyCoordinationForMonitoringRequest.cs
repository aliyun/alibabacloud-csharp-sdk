// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringRequest : TeaModel {
        [NameInMap("CoordinatePolicyType")]
        [Validation(Required=false)]
        public string CoordinatePolicyType { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("InitiatorType")]
        [Validation(Required=false)]
        public string InitiatorType { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceCandidates")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringRequestResourceCandidates> ResourceCandidates { get; set; }
        public class ApplyCoordinationForMonitoringRequestResourceCandidates : TeaModel {
            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public long? OwnerAliUid { get; set; }

            [NameInMap("OwnerEndUserId")]
            [Validation(Required=false)]
            public string OwnerEndUserId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
