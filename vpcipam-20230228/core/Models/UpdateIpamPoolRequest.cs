// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class UpdateIpamPoolRequest : TeaModel {
        [NameInMap("AllocationDefaultCidrMask")]
        [Validation(Required=false)]
        public int? AllocationDefaultCidrMask { get; set; }

        [NameInMap("AllocationMaxCidrMask")]
        [Validation(Required=false)]
        public int? AllocationMaxCidrMask { get; set; }

        [NameInMap("AllocationMinCidrMask")]
        [Validation(Required=false)]
        public int? AllocationMinCidrMask { get; set; }

        [NameInMap("AutoImport")]
        [Validation(Required=false)]
        public bool? AutoImport { get; set; }

        [NameInMap("ClearAllocationDefaultCidrMask")]
        [Validation(Required=false)]
        public bool? ClearAllocationDefaultCidrMask { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IpamPoolDescription")]
        [Validation(Required=false)]
        public string IpamPoolDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpamPoolId")]
        [Validation(Required=false)]
        public string IpamPoolId { get; set; }

        [NameInMap("IpamPoolName")]
        [Validation(Required=false)]
        public string IpamPoolName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
