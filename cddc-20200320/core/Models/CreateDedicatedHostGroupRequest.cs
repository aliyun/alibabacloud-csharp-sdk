// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateDedicatedHostGroupRequest : TeaModel {
        /// <summary>
        /// The policy that is used to allocate resources in the dedicated cluster. Valid values:
        /// 
        /// *   **Evenly** (default): The system preferentially deploys database instances on the hosts where no resources or fewer resources are allocated. This maximizes system stability.
        /// *   **Intensively**: The system preferentially deploys database instances on the hosts that are created earlier and have more allocated resources. This maximizes resource utilization.
        /// </summary>
        [NameInMap("AllocationPolicy")]
        [Validation(Required=false)]
        public string AllocationPolicy { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The CPU overcommit ratio of the dedicated cluster.
        /// 
        /// >  Unit: %. Valid values: **100** to **300**. Default value: **200**, which specifies that the total amount of CPU resources allocated to all instances is twice the amount of actual CPU resources. This helps you maximize CPU utilization.
        /// </summary>
        [NameInMap("CpuAllocationRatio")]
        [Validation(Required=false)]
        public int? CpuAllocationRatio { get; set; }

        /// <summary>
        /// The name of the dedicated cluster. The name must be 1 to 64 characters in length and can contain letters, digits, underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("DedicatedHostGroupDesc")]
        [Validation(Required=false)]
        public string DedicatedHostGroupDesc { get; set; }

        /// <summary>
        /// The storage overcommit ratio of the dedicated cluster.
        /// 
        /// >  Unit: %. Valid values: **100** to **300**. Default value: **200**, which specifies that the total amount of storage resources allocated to all instances is twice the amount of actual storage resources. This helps you maximize storage usage. This parameter does not take effect for dedicated clusters that run SQL Server.
        /// </summary>
        [NameInMap("DiskAllocationRatio")]
        [Validation(Required=false)]
        public int? DiskAllocationRatio { get; set; }

        /// <summary>
        /// The database engine of the dedicated cluster. Valid values:
        /// 
        /// *   **MySQL**
        /// *   **SQL Server**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The policy that is used to handle host failures. Valid values:
        /// 
        /// *   **Auto** (default): The system automatically replaces faulty hosts.
        /// *   **Manual**: You must manually replace faulty hosts.
        /// 
        /// >  When you create a dedicated cluster that runs **MySQL**, you can select a policy based on your business requirements. For dedicated clusters that run other database engines, the default value **Auto** is used.
        /// </summary>
        [NameInMap("HostReplacePolicy")]
        [Validation(Required=false)]
        public string HostReplacePolicy { get; set; }

        /// <summary>
        /// The maximum memory usage of each host in the dedicated cluster.
        /// 
        /// >  Unit: %. Valid values: **0** to **100**. Default value: **100**.
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
        /// >  When you create a dedicated cluster that runs **MySQL or SQL Server**, you can grant the host OS permissions based on your business requirements. For dedicated clusters that run other database engines, the default value **0** is used. When you create an ApsaraDB MyBase for SQL Server dedicated cluster, you must set this parameter to 1.
        /// </summary>
        [NameInMap("OpenPermission")]
        [Validation(Required=false)]
        public int? OpenPermission { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. For more information, see [Region IDs](~~198326~~).
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
        /// The ID of the virtual private cloud (VPC) where you want to create the dedicated cluster. You can log on to the VPC console and click **VPCs** in the left-side navigation pane to view the VPC ID.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

    }

}
