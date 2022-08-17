// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateDiskReplicaGroupRequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        [NameInMap("DestinationZoneId")]
        [Validation(Required=false)]
        public string DestinationZoneId { get; set; }

        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SourceZoneId")]
        [Validation(Required=false)]
        public string SourceZoneId { get; set; }

    }

}
