// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AssociateGlobalAccelerationInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the backend server.
        /// </summary>
        [NameInMap("BackendServerId")]
        [Validation(Required=false)]
        public string BackendServerId { get; set; }

        /// <summary>
        /// The region of the backend server. The region must belong to the service area of the GA instance.
        /// </summary>
        [NameInMap("BackendServerRegionId")]
        [Validation(Required=false)]
        public string BackendServerRegionId { get; set; }

        /// <summary>
        /// The backend server type. Valid values:
        /// 
        /// *   **EcsInstance** (default): ECS instance
        /// *   **SlbInstance**: SLB instance
        /// </summary>
        [NameInMap("BackendServerType")]
        [Validation(Required=false)]
        public string BackendServerType { get; set; }

        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("GlobalAccelerationInstanceId")]
        [Validation(Required=false)]
        public string GlobalAccelerationInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the GA instance. You can call the [DescribeRegions](~~36063~~) operation to query the most recent region list.
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
