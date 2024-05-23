// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeDedicatedHostsResponseBody : TeaModel {
        /// <summary>
        /// The host group ID.
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// The host information.
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
                /// The host account. You can call the [CreateDedicatedHostAccount](https://help.aliyun.com/document_detail/196877.html) operation to create a host account.
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

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
                /// The bastion host ID.
                /// </summary>
                [NameInMap("BastionInstanceId")]
                [Validation(Required=false)]
                public string BastionInstanceId { get; set; }

                /// <summary>
                /// The core overcommitment ratio of the dedicated cluster. Unit: percentage. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](https://help.aliyun.com/document_detail/182328.html).
                /// </summary>
                [NameInMap("CPUAllocationRatio")]
                [Validation(Required=false)]
                public string CPUAllocationRatio { get; set; }

                /// <summary>
                /// The number of used CPU cores on the host. Unit: cores.
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
                /// The dedicated cluster ID.
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
                /// The disk overcommitment ratio of the dedicated cluster. Unit: percentage. For more information about the core overcommitment ratio, see [Manage a dedicated cluster](https://help.aliyun.com/document_detail/182328.html).
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
                /// The total number of CPU cores that are configured for the host. Unit: cores.
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
                /// The total memory space of the host. Unit: MB.
                /// </summary>
                [NameInMap("HostMem")]
                [Validation(Required=false)]
                public string HostMem { get; set; }

                /// <summary>
                /// The host name.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

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
                /// The storage capacity of the host. Unit: MB.
                /// </summary>
                [NameInMap("HostStorage")]
                [Validation(Required=false)]
                public string HostStorage { get; set; }

                /// <summary>
                /// The storage type of the host. Valid values:
                /// 
                /// *   **dhg_cloud_ssd**: ESSD
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
                /// The host image. This parameter is returned only when the **Engine** parameter is set to **mssql**. Valid values:
                /// 
                /// *   **WindowsWithMssqlStdLicense**: a Windows image that contains the licenses of SQL Server Standard Edition
                /// *   **WindowsWithMssqlEntLisence**: a Windows image that contains the licenses of SQL Server Enterprise Edition
                /// *   **WindowsWithMssqlWebLisence**: a Windows image that contains the licenses of SQL Server Web Edition
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
                /// The size of the used memory. Unit: MB.
                /// </summary>
                [NameInMap("MemoryUsed")]
                [Validation(Required=false)]
                public string MemoryUsed { get; set; }

                /// <summary>
                /// Indicates whether the feature that allows you to have the OS permissions on the host is enabled. Valid values:
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
