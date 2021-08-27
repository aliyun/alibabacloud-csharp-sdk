// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskReplicaPairRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        [NameInMap("DestinationDiskId")]
        [Validation(Required=false)]
        public string DestinationDiskId { get; set; }

        [NameInMap("PairName")]
        [Validation(Required=false)]
        public string PairName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("AsyncCycle")]
        [Validation(Required=false)]
        public int? AsyncCycle { get; set; }

    }

}
