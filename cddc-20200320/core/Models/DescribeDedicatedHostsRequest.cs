// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostsRequest : TeaModel {
        /// <summary>
        /// Specifies whether instances can be deployed on the host. Valid values:
        /// 
        /// *   **Allocatable**: Instances can be deployed on the host.
        /// *   **Suspended**: Instances cannot be deployed on the host.
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// The dedicated cluster ID. You can log on to the ApsaraDB for MyBase console and go to the **Dedicated Clusters** page to view the dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The ID of the host in the dedicated cluster. You can log on to the ApsaraDB for MyBase console and go to the **Hosts** page to view the host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The state of the host. Valid values:
        /// 
        /// *   **0**: The host is being created.
        /// *   **1**: The host is running.
        /// *   **2**: The host is faulty.
        /// *   **3**: The host is ready for disabling.
        /// *   **4**: The host is being maintained.
        /// *   **5**: The host is disabled.
        /// *   **6**: The host is restarting.
        /// *   **7**: The host is locked.
        /// 
        /// >  When a host fails, the host is disabled. Before the host is disabled, the data of the instances that run on the host is migrated to another host.
        /// </summary>
        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        /// <summary>
        /// The storage type of the host. Valid values:
        /// 
        /// *   **dhg_local_ssd**: local SSD.
        /// *   **dhg_cloud_ssd** or **dhg_cloud_essd**: enhanced SSD (ESSD).
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// The order ID. You can log on to the Billing Management console and go to the **Orders** page to view the order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumbers")]
        [Validation(Required=false)]
        public int? PageNumbers { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// [The region ID](~~198326~~).
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
        /// The tags that are added to the host. Each tag is a key-value pair that consists of TagKey and TagValue. You can specify a maximum of five tags in the following format for each request: {"key1":"value1","key2":"value2"...}.
        /// 
        /// >  If you want to filter hosts based on tags, do not specify the **DedicatedHostId** parameter. Otherwise, the **DedicatedHostId** parameter is used to filter hosts.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// The zone ID. You can call the [DescribeRegions](~~214103~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
