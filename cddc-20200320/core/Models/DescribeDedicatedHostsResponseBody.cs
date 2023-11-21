// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// The dedicated cluster ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The queried hosts.
        /// </summary>
        [NameInMap("DedicatedHosts")]
        [Validation(Required=false)]
        public DescribeDedicatedHostsResponseBodyDedicatedHosts DedicatedHosts { get; set; }
        public class DescribeDedicatedHostsResponseBodyDedicatedHosts : TeaModel {
            [NameInMap("DedicatedHosts")]
            [Validation(Required=false)]
            public List<DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts> DedicatedHosts { get; set; }
            public class DescribeDedicatedHostsResponseBodyDedicatedHostsDedicatedHosts : TeaModel {
                /// <summary>
                /// The custom account name of the host.
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
                /// **Normal**: standard account.
                /// 
                /// **Admin**: administrator account.
                /// </summary>
                [NameInMap("AccountType")]
                [Validation(Required=false)]
                public string AccountType { get; set; }

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
                /// The ID of the bastion host with which the host is associated.
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// The CPU utilization of the host.
                /// </summary>
                [NameInMap("CPUAllocationRatio")]
                [Validation(Required=false)]
                public string CPUAllocationRatio { get; set; }

                /// <summary>
                /// The type of the dedicated cluster. Valid values:
                /// 
                /// *   **Pro**: Proprietary MyBase.
                /// *   **Standard**: Managed MyBase.
                /// 
                /// >  This parameter is returned only for the China site (aliyun.com).
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The billing method.
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// The number of used CPU cores.
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
                /// The disk usage of the host. Unit: %.
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public string DiskAllocationRatio { get; set; }

                /// <summary>
                /// The disk information of the ECS instance.
                /// 
                /// >  This parameter is returned only for the China site (aliyun.com) when the dedicated cluster is of the **Proprietary MyBase** type.
                /// </summary>
                [NameInMap("DiskInfo")]
                [Validation(Required=false)]
                public string DiskInfo { get; set; }

                /// <summary>
                /// The distribution symbol of the host.
                /// 
                /// >  This parameter is returned only when the host runs **Tair**.
                /// </summary>
                [NameInMap("DistributionSymbol")]
                [Validation(Required=false)]
                public string DistributionSymbol { get; set; }

                /// <summary>
                /// The distribution tag of the host.
                /// </summary>
                [NameInMap("DistributionTag")]
                [Validation(Required=false)]
                public string DistributionTag { get; set; }

                /// <summary>
                /// The instance type of the Elastic Compute Service (ECS) instance. For more information, see [Overview of instance families](~~25378~~).
                /// </summary>
                [NameInMap("EcsClassCode")]
                [Validation(Required=false)]
                public string EcsClassCode { get; set; }

                /// <summary>
                /// The ID of the ECS instance.
                /// 
                /// >  This parameter is returned only for the China site (aliyun.com) when the dedicated cluster is of the **Proprietary MyBase** type.
                /// </summary>
                [NameInMap("EcsId")]
                [Validation(Required=false)]
                public string EcsId { get; set; }

                /// <summary>
                /// The expiration time of the host. The time follows the ISO 8601 standard in the **yyyy-MM-ddTHH:mm:ssZ** format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The database engine of the host.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The number of CPU cores of the host.
                /// </summary>
                [NameInMap("HostCPU")]
                [Validation(Required=false)]
                public string HostCPU { get; set; }

                /// <summary>
                /// The instance type of the host.
                /// </summary>
                [NameInMap("HostClass")]
                [Validation(Required=false)]
                public string HostClass { get; set; }

                /// <summary>
                /// The memory size of the host. Unit: GB.
                /// </summary>
                [NameInMap("HostMem")]
                [Validation(Required=false)]
                public string HostMem { get; set; }

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
                /// >  When a host fails, the host is disabled. Before the host is disabled, the data of the instances that run on the host is migrated to another host.
                /// </summary>
                [NameInMap("HostStatus")]
                [Validation(Required=false)]
                public string HostStatus { get; set; }

                /// <summary>
                /// The total storage of the host. Unit: GB.
                /// </summary>
                [NameInMap("HostStorage")]
                [Validation(Required=false)]
                public string HostStorage { get; set; }

                /// <summary>
                /// The storage type of the host.
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
                /// The image type of the host.
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// The number of instances deployed on the host.
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public string InstanceNumber { get; set; }

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
                /// The versions supported by hosts in ApsaraDB MyBase for SQL Server.
                /// </summary>
                [NameInMap("MssqlSupportVersion")]
                [Validation(Required=false)]
                public string MssqlSupportVersion { get; set; }

                /// <summary>
                /// Indicates whether the host OS permissions are granted. Valid values:
                /// 
                /// *   **0**: no.
                /// *   **1** (default): yes.
                /// </summary>
                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                /// <summary>
                /// The amount of storage used by the host. Unit: GB.
                /// </summary>
                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public string StorageUsed { get; set; }

                /// <summary>
                /// The virtual private cloud (VPC) ID of the dedicated cluster in which the host is created.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch to which the host is connected.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the zone in which the host resides.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The maximum storage of local SSDs for auto scaling. Unit: GB.
        /// </summary>
        [NameInMap("MaxAutoScaleHostStorage")]
        [Validation(Required=false)]
        public long? MaxAutoScaleHostStorage { get; set; }

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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecords")]
        [Validation(Required=false)]
        public int? TotalRecords { get; set; }

    }

}
