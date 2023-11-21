// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class ModifyDedicatedHostGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The policy that is used to allocate resources in the dedicated cluster. Valid values:
        /// 
        /// *   **Evenly**: The system preferentially deploys database instances on the hosts where no resources or fewer resources are allocated. This maximizes system stability.
        /// *   **Intensively**: The system preferentially deploys database instances on the hosts that are created earlier and have more allocated resources. This maximizes resource utilization.
        /// </summary>
        [NameInMap("AllocationPolicy")]
        [Validation(Required=false)]
        public string AllocationPolicy { get; set; }

        /// <summary>
        /// The CPU overcommit ratio of the dedicated cluster. Valid values: **100** to **300**.
        /// 
        /// >  If you change the CPU overcommit ratio to **300%**, the total CPU resources of all instances are three times the actual CPU resources. This maximizes the use of CPU resources.
        /// </summary>
        [NameInMap("CpuAllocationRatio")]
        [Validation(Required=false)]
        public int? CpuAllocationRatio { get; set; }

        /// <summary>
        /// The name of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupDesc")]
        [Validation(Required=false)]
        public string DedicatedHostGroupDesc { get; set; }

        /// <summary>
        /// The dedicated cluster ID.
        /// 
        /// >  You can log on to the ApsaraDB for MyBase console and go to the Dedicated Clusters page to view the dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The storage overcommit ratio of the dedicated cluster. Valid values: **100** to **200**.
        /// </summary>
        [NameInMap("DiskAllocationRatio")]
        [Validation(Required=false)]
        public int? DiskAllocationRatio { get; set; }

        /// <summary>
        /// The policy that is used to handle host failures. Valid values:
        /// 
        /// *   **Auto**: The system automatically replaces faulty hosts.
        /// *   **Manual**: You must manually replace faulty hosts.
        /// 
        /// >  You can select a policy based on your business requirements only for dedicated clusters that run **MySQL**. For dedicated clusters that run other database engines, the default value Auto is used.
        /// </summary>
        [NameInMap("HostReplacePolicy")]
        [Validation(Required=false)]
        public string HostReplacePolicy { get; set; }

        /// <summary>
        /// The maximum memory usage of each host in the dedicated cluster. Valid values: **0** to **100**.
        /// </summary>
        [NameInMap("MemAllocationRatio")]
        [Validation(Required=false)]
        public int? MemAllocationRatio { get; set; }

        /// <summary>
        /// Specifies whether to grant the host OS permissions. Valid values:
        /// 
        /// *   **0**: no.
        /// *   **1**: yes.
        /// 
        /// >  You can grant the host OS permissions based on your business requirements only when you create dedicated clusters that run **MySQL, SQL Server, or PostgreSQL**. For dedicated clusters that run other database engines, the default value 0 is used.
        /// </summary>
        [NameInMap("OpenPermission")]
        [Validation(Required=false)]
        public string OpenPermission { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the dedicated cluster. For more information, see [Region IDs](~~198326~~).
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
