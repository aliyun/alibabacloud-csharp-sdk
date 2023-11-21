// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostAttributeResponseBody : TeaModel {
        /// <summary>
        /// The account name of the host.
        /// 
        /// *   The name can contain lowercase letters, digits, and underscores (\_).
        /// *   The name must start with a lowercase letter and end with a lowercase letter or a digit.
        /// *   The name must be 2 to 16 characters in length.
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The account type of the host. Valid values:
        /// 
        /// *   **Normal**: standard account.
        /// *   **Admin**: administrator account.
        /// </summary>
        [NameInMap("AccountType")]
        [Validation(Required=false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Indicates whether instances can be deployed on the host. Valid values:
        /// 
        /// *   **Allocatable**: yes.
        /// *   **Suspended**: no.
        /// </summary>
        [NameInMap("AllocationStatus")]
        [Validation(Required=false)]
        public string AllocationStatus { get; set; }

        /// <summary>
        /// Indicates whether auto-renewal is enabled on the host. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// The CPU overcommit ratio of the dedicated cluster. Unit: %. The value is accurate to the tens digit.
        /// </summary>
        [NameInMap("CPUAllocationRatio")]
        [Validation(Required=false)]
        public string CPUAllocationRatio { get; set; }

        /// <summary>
        /// The number of CPU cores used by the host.
        /// </summary>
        [NameInMap("CpuUsed")]
        [Validation(Required=false)]
        public string CpuUsed { get; set; }

        /// <summary>
        /// The time when the host was created. The time follows the ISO 8601 standard in the **yyyy-MM-ddTHH:mm:ssZ** format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        /// <summary>
        /// The ID of the dedicated cluster in which the host is created.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The host ID.
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The storage overcommit ratio of the dedicated cluster.
        /// </summary>
        [NameInMap("DiskAllocationRatio")]
        [Validation(Required=false)]
        public string DiskAllocationRatio { get; set; }

        /// <summary>
        /// The distribution tag of the host.
        /// </summary>
        [NameInMap("DistributionTag")]
        [Validation(Required=false)]
        public string DistributionTag { get; set; }

        /// <summary>
        /// The instance type of the Elastic Compute Service (ECS) instance.
        /// </summary>
        [NameInMap("EcsClassCode")]
        [Validation(Required=false)]
        public string EcsClassCode { get; set; }

        /// <summary>
        /// The expiration time of the host. The time follows the ISO 8601 standard in the **yyyy-MM-ddTHH:mm:ssZ** format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// The number of CPU cores of the host.
        /// </summary>
        [NameInMap("HostCPU")]
        [Validation(Required=false)]
        public int? HostCPU { get; set; }

        /// <summary>
        /// The instance type of the host.
        /// </summary>
        [NameInMap("HostClass")]
        [Validation(Required=false)]
        public string HostClass { get; set; }

        /// <summary>
        /// The memory size of the host. Unit: MB.
        /// </summary>
        [NameInMap("HostMem")]
        [Validation(Required=false)]
        public int? HostMem { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

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
        /// >  When a host fails, the host is disabled. Before the host is disabled, the data of the instances that run on the host is migrated to another host. This ensures data integrity.
        /// </summary>
        [NameInMap("HostStatus")]
        [Validation(Required=false)]
        public string HostStatus { get; set; }

        /// <summary>
        /// The total storage of the host. Unit: GB.
        /// </summary>
        [NameInMap("HostStorage")]
        [Validation(Required=false)]
        public int? HostStorage { get; set; }

        /// <summary>
        /// The storage type of the host. Valid values:
        /// 
        /// *   **dhg_cloud_ssd** or **dhg_cloud_essd**: enhanced SSD (ESSD).
        /// *   **dhg_local_ssd**: local SSD.
        /// </summary>
        [NameInMap("HostType")]
        [Validation(Required=false)]
        public string HostType { get; set; }

        /// <summary>
        /// The IP address of the host.
        /// </summary>
        [NameInMap("IPAddress")]
        [Validation(Required=false)]
        public string IPAddress { get; set; }

        /// <summary>
        /// The image of the host. This parameter is returned only when the database engine is **SQL Server**. Valid values:
        /// 
        /// *   **WindowsWithMssqlEntAlwaysonLicense**: SQL Server Cluster Edition (AlwaysOn).
        /// *   **WindowsWithMssqlStdLicense**: SQL Server Standard Edition.
        /// *   **WindowsWithMssqlEntLicense**: SQL Server Enterprise Edition.
        /// *   **WindowsWithMssqlWebLicense**: SQL Server Web Edition.
        /// </summary>
        [NameInMap("ImageCategory")]
        [Validation(Required=false)]
        public string ImageCategory { get; set; }

        /// <summary>
        /// The number of instances deployed on the host.
        /// </summary>
        [NameInMap("InstanceNumber")]
        [Validation(Required=false)]
        public int? InstanceNumber { get; set; }

        /// <summary>
        /// The number of primary instances deployed on the host.
        /// </summary>
        [NameInMap("InstanceNumberMaster")]
        [Validation(Required=false)]
        public int? InstanceNumberMaster { get; set; }

        /// <summary>
        /// The number of primary instances of the read-only instance deployed on the host.
        /// </summary>
        [NameInMap("InstanceNumberROMaster")]
        [Validation(Required=false)]
        public int? InstanceNumberROMaster { get; set; }

        /// <summary>
        /// The number of secondary instances of the read-only instance deployed on the host.
        /// </summary>
        [NameInMap("InstanceNumberROSlave")]
        [Validation(Required=false)]
        public int? InstanceNumberROSlave { get; set; }

        /// <summary>
        /// The number of secondary instances deployed on the host.
        /// </summary>
        [NameInMap("InstanceNumberSlave")]
        [Validation(Required=false)]
        public int? InstanceNumberSlave { get; set; }

        /// <summary>
        /// The memory usage of the host. Unit: %.
        /// </summary>
        [NameInMap("MemAllocationRatio")]
        [Validation(Required=false)]
        public string MemAllocationRatio { get; set; }

        /// <summary>
        /// The amount of memory used by the host. Unit: GB.
        /// </summary>
        [NameInMap("MemoryUsed")]
        [Validation(Required=false)]
        public string MemoryUsed { get; set; }

        /// <summary>
        /// Indicates whether the host OS permissions are grated. Valid values:
        /// 
        /// *   **0**: no.
        /// *   **1**: yes.
        /// </summary>
        [NameInMap("OpenPermission")]
        [Validation(Required=false)]
        public string OpenPermission { get; set; }

        /// <summary>
        /// [The region ID](~~198326~~).
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The storage usage of the host. Unit: GB.
        /// </summary>
        [NameInMap("StorageUsed")]
        [Validation(Required=false)]
        public string StorageUsed { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The vSwitch ID.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
