// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsRequest : TeaModel {
        /// <summary>
        /// Specifies whether instances can be deployed on the host. Valid values:
        /// 
        /// *   **0**: Instances cannot be deployed on the host.
        /// *   **1**: Instances can be deployed on the host.
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// The dedicated cluster ID. You can call the DescribeDedicatedHostGroups operation to query the dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The ID of the host in the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The status of the host. Valid values:
        /// 
        /// *   **0**: creating
        /// *   **1**: running
        /// *   **2**: faulty
        /// *   **3**: being replaced
        /// *   **4**: deprecated
        /// *   **5**: deleting
        /// *   **6**: restarting
        /// </summary>
        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        /// <summary>
        /// The storage type of the host. Valid values:
        /// 
        /// *   **dhg_cloud_ssd**: enhanced SSD (ESSD)
        /// *   **dhg_local_ssd**: local SSD
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// The order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the DescribeRegions operation to query the most recent region list.
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

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
