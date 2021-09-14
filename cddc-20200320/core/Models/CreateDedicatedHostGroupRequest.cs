// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateDedicatedHostGroupRequest : TeaModel {
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

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("CpuAllocationRatio")]
        [Validation(Required=false)]
        public int? CpuAllocationRatio { get; set; }

        [NameInMap("MemAllocationRatio")]
        [Validation(Required=false)]
        public int? MemAllocationRatio { get; set; }

        [NameInMap("DiskAllocationRatio")]
        [Validation(Required=false)]
        public int? DiskAllocationRatio { get; set; }

        [NameInMap("AllocationPolicy")]
        [Validation(Required=false)]
        public string AllocationPolicy { get; set; }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("HostReplacePolicy")]
        [Validation(Required=false)]
        public string HostReplacePolicy { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OpenPermission")]
        [Validation(Required=false)]
        public int? OpenPermission { get; set; }

        [NameInMap("DedicatedHostGroupDesc")]
        [Validation(Required=false)]
        public string DedicatedHostGroupDesc { get; set; }

    }

}
