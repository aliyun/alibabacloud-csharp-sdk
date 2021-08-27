// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeSpotAdviceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("InstanceTypes")]
        [Validation(Required=false)]
        public List<string> InstanceTypes { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Cores")]
        [Validation(Required=false)]
        public int? Cores { get; set; }

        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        [NameInMap("MinCores")]
        [Validation(Required=false)]
        public int? MinCores { get; set; }

        [NameInMap("MinMemory")]
        [Validation(Required=false)]
        public float? MinMemory { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("InstanceTypeFamily")]
        [Validation(Required=false)]
        public string InstanceTypeFamily { get; set; }

        [NameInMap("InstanceFamilyLevel")]
        [Validation(Required=false)]
        public string InstanceFamilyLevel { get; set; }

        [NameInMap("GpuSpec")]
        [Validation(Required=false)]
        public string GpuSpec { get; set; }

        [NameInMap("GpuAmount")]
        [Validation(Required=false)]
        public int? GpuAmount { get; set; }

    }

}
