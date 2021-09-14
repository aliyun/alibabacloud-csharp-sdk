// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class ModifyScheduleMethodRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("InstanceDistribution")]
        [Validation(Required=false)]
        public string InstanceDistribution { get; set; }

        [NameInMap("ZoneDistribution")]
        [Validation(Required=false)]
        public string ZoneDistribution { get; set; }

        [NameInMap("CpuUtilityThreshold")]
        [Validation(Required=false)]
        public string CpuUtilityThreshold { get; set; }

        [NameInMap("MemoryUtilityThreshold")]
        [Validation(Required=false)]
        public string MemoryUtilityThreshold { get; set; }

        [NameInMap("LocalDiskUtilityThreshold")]
        [Validation(Required=false)]
        public string LocalDiskUtilityThreshold { get; set; }

        [NameInMap("ZonesOrder")]
        [Validation(Required=false)]
        public string ZonesOrder { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
