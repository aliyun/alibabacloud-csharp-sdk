// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the hosts on which you can create instances or those on which you cannot create instances. Valid values:
        /// 
        /// *   **0**: queries the hosts on which you cannot create instances
        /// *   **1**: queries the hosts on which you can create instances
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster. You can call the [DescribeDedicatedHostGroups](~~141946~~) operation to query the IDs of dedicated clusters.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The ID of the host.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The status of the hosts. Valid values:
        /// 
        /// *   **0**: queries the hosts that are being created
        /// *   **1**: queries the hosts that are running
        /// *   **2**: queries the hosts that are faulty
        /// *   **3**: queries the hosts that are being replaced
        /// *   **4**: queries the hosts that are deprecated
        /// *   **5**: queries the hosts that are being deleted
        /// *   **6**: queries the hosts that are restarting
        /// </summary>
        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        /// <summary>
        /// The type of storage media that is used for the hosts. Valid values:
        /// 
        /// *   **dhg_cloud_ssd**: enhanced solid-state drive (SSD)
        /// *   **dhg_local_ssd**: local SSD
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// The ID of the order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the hosts. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
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
        /// The zone ID of the hosts.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
