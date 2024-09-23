// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VpcIpam20230228.Models
{
    public class CreateIpamPoolRequest : TeaModel {
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

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("IpamPoolDescription")]
        [Validation(Required=false)]
        public string IpamPoolDescription { get; set; }

        [NameInMap("IpamPoolName")]
        [Validation(Required=false)]
        public string IpamPoolName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpamScopeId")]
        [Validation(Required=false)]
        public string IpamScopeId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("PoolRegionId")]
        [Validation(Required=false)]
        public string PoolRegionId { get; set; }

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

        [NameInMap("SourceIpamPoolId")]
        [Validation(Required=false)]
        public string SourceIpamPoolId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateIpamPoolRequestTag> Tag { get; set; }
        public class CreateIpamPoolRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
