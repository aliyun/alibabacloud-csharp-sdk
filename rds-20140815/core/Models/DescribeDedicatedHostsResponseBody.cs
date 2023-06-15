// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the dedicated cluster.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// An array that consists of hosts returned.
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
                /// The account of the host. You can call the [CreateDedicatedHostAccount](~~196877~~) operation to create a host account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// Indicates whether the system allows you to create instances on the host. Valid values:
                /// 
                /// *   **0**: The system does not allow you to create instances on the host.
                /// *   **1**: The system allows you to create instances on the host.
                /// </summary>
                [NameInMap("AllocationStatus")]
                [Validation(Required=false)]
                public string AllocationStatus { get; set; }

                /// <summary>
                /// The ID of the bastion host.
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// The core overcommitment ratio of the dedicated cluster. Unit: %. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](~~182328~~).
                /// </summary>
                [NameInMap("CPUAllocationRatio")]
                [Validation(Required=false)]
                public string CPUAllocationRatio { get; set; }

                /// <summary>
                /// The number of used cores on the host.
                /// </summary>
                [NameInMap("CpuUsed")]
                [Validation(Required=false)]
                public string CpuUsed { get; set; }

                /// <summary>
                /// The time when the host was created.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// The ID of the dedicated cluster.
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
                /// The disk overcommitment ratio of the dedicated cluster. Unit: %. For more information about the disk overcommitment ratio, see [Manage a dedicated cluster](~~182328~~).
                /// </summary>
                [NameInMap("DiskAllocationRatio")]
                [Validation(Required=false)]
                public string DiskAllocationRatio { get; set; }

                /// <summary>
                /// The time when the host expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The database engine of instances that are created on the host.
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// The total number of cores that are configured for the host.
                /// </summary>
                [NameInMap("HostCPU")]
                [Validation(Required=false)]
                public string HostCPU { get; set; }

                /// <summary>
                /// The specifications of the host.
                /// </summary>
                [NameInMap("HostClass")]
                [Validation(Required=false)]
                public string HostClass { get; set; }

                /// <summary>
                /// The total memory space of the host. Unit: MB.
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
                /// The status of the host. Valid values:
                /// 
                /// *   **0**: The host is being created.
                /// *   **1**: The host is running.
                /// *   **2**: The host is faulty.
                /// *   **3**: The host is being replaced.
                /// *   **4**: The host is deprecated.
                /// *   **5**: The host is being deleted.
                /// *   **6**: The host is restarting.
                /// </summary>
                [NameInMap("HostStatus")]
                [Validation(Required=false)]
                public string HostStatus { get; set; }

                /// <summary>
                /// The storage capacity of the host. Unit: MB.
                /// </summary>
                [NameInMap("HostStorage")]
                [Validation(Required=false)]
                public string HostStorage { get; set; }

                /// <summary>
                /// The type of storage media that is used for the host. Valid values:
                /// 
                /// *   **dhg_cloud_ssd**: enhanced SSD
                /// *   **dhg_local_ssd**: local SSD
                /// </summary>
                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                /// <summary>
                /// The internal IP address of the host.
                /// </summary>
                [NameInMap("IPAddress")]
                [Validation(Required=false)]
                public string IPAddress { get; set; }

                /// <summary>
                /// The image of the host. This parameter is returned only when the **Engine** parameter is set to **mssql**. Valid values:
                /// 
                /// *   **WindowsWithMssqlStdLicense**: a Windows image, which contains the licenses of the SQL Server Standard Edition
                /// *   **WindowsWithMssqlEntLisence**: a Windows image, which contains the licenses of the SQL Server Enterprise Edition
                /// *   **WindowsWithMssqlWebLisence**: a Windows image, which contains the licenses of the SQL Server Web Edition
                /// </summary>
                [NameInMap("ImageCategory")]
                [Validation(Required=false)]
                public string ImageCategory { get; set; }

                /// <summary>
                /// The total number of instances that are created on the host.
                /// </summary>
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public string InstanceNumber { get; set; }

                /// <summary>
                /// The maximum memory usage per host in the dedicated cluster.
                /// </summary>
                [NameInMap("MemAllocationRatio")]
                [Validation(Required=false)]
                public string MemAllocationRatio { get; set; }

                /// <summary>
                /// The amount of used memory space on the host. Unit: MB.
                /// </summary>
                [NameInMap("MemoryUsed")]
                [Validation(Required=false)]
                public string MemoryUsed { get; set; }

                /// <summary>
                /// Indicates whether the operating system permissions of the host can be granted. Valid values:
                /// 
                /// *   **0** or **null**: The permissions cannot be granted.
                /// *   **1**: The permissions can be granted.
                /// *   **3**: The permissions have been granted.
                /// </summary>
                [NameInMap("OpenPermission")]
                [Validation(Required=false)]
                public string OpenPermission { get; set; }

                /// <summary>
                /// The amount of used storage space on the host.
                /// </summary>
                [NameInMap("StorageUsed")]
                [Validation(Required=false)]
                public string StorageUsed { get; set; }

                /// <summary>
                /// The ID of the virtual private cloud (VPC) to which the host belongs.
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// The ID of the vSwitch associated with the specified VPC.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The zone ID of the host.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
