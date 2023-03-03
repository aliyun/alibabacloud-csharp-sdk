// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// The information of the OceanBase cluster.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// Indicates whether automatic renewal is enabled. 
            /// 
            /// This parameter is valid only for clusters whose billing methods are set to PREPAY.
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// Indicates whether automatic upgrade of the OBServer version is enabled.
            /// </summary>
            [NameInMap("AutoUpgradeObVersion")]
            [Validation(Required=false)]
            public bool? AutoUpgradeObVersion { get; set; }

            /// <summary>
            /// The list of zones.
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// The time in UTC when the cluster was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The time when the major compaction of cluster data is performed.
            /// </summary>
            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            /// <summary>
            /// The data replica distribution mode of the cluster. Valid values: 
            /// - n: indicates the single-IDC mode. 
            /// - n-n: indicates the dual-IDC mode. 
            /// - n-n-n: indicates the multi-IDC mode. 
            /// 
            /// > <br>The integer n represents the number of OBServer nodes in each IDC.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// The deployment type of the cluster. Valid values:  
            /// - multiple: multi-IDC deployment   
            /// - single: single-IDC deployment   
            /// - dual: dual-IDC deployment
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The type of the storage disk where the cluster is deployed. 
            /// 
            /// The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// Indicates whether the log disk specifications can be upgraded.
            /// </summary>
            [NameInMap("EnableUpgradeLogDisk")]
            [Validation(Required=false)]
            public bool? EnableUpgradeLogDisk { get; set; }

            /// <summary>
            /// The time in UTC when the cluster expires.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// The specifications of the cluster.  You can specify one of the following four plans:    
            /// - 8C32G: indicates 8 CPU cores and 32 GB of memory. 
            /// - 14C70G: indicates 14 CPU cores and 70 GB of memory. 
            /// - 30C180G: indicates 30 CPU cores and 180 GB of memory. 
            /// - 62C400G: indicates 62 CPU cores and 400 GB of memory.
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the OceanBase cluster.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// Indicates whether the OBServer version is the latest.
            /// </summary>
            [NameInMap("IsLatestObVersion")]
            [Validation(Required=false)]
            public bool? IsLatestObVersion { get; set; }

            /// <summary>
            /// Indicates whether trusted ECS instances are used.
            /// </summary>
            [NameInMap("IsTrustEcs")]
            [Validation(Required=false)]
            public bool? IsTrustEcs { get; set; }

            /// <summary>
            /// The time period in UTC for the daily routine maintenance of the cluster.
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

            /// <summary>
            /// The detailed information of the OBServer version.
            /// </summary>
            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            /// <summary>
            /// The billing method of the OceanBase cluster. Valid values: 
            /// - PREPAY: the subscription billing method. 
            /// - POSTPAY: the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The information about cluster resources.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceResource Resource { get; set; }
            public class DescribeInstanceResponseBodyInstanceResource : TeaModel {
                /// <summary>
                /// The information about the CPU resources of the cluster.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCpu : TeaModel {
                    /// <summary>
                    /// The total number of CPU cores of the cluster.
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    /// <summary>
                    /// The number of CPU cores of each replica node in the cluster.
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    /// <summary>
                    /// The number of CPU cores used in the cluster.
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                /// <summary>
                /// The information about the storage resources of the cluster.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceDiskSize : TeaModel {
                    /// <summary>
                    /// The size of the data disk, in GB.
                    /// </summary>
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    /// <summary>
                    /// The server with the highest disk usage.
                    /// </summary>
                    [NameInMap("MaxDiskUsedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxDiskUsedObServer { get; set; }

                    /// <summary>
                    /// The maximum disk usage, in percentage.
                    /// </summary>
                    [NameInMap("MaxDiskUsedPercent")]
                    [Validation(Required=false)]
                    public double? MaxDiskUsedPercent { get; set; }

                    /// <summary>
                    /// The total storage space of the cluster, in GB.
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// The storage space of each replica node in the cluster, in GB.
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                    /// <summary>
                    /// The size of used storage space of the cluster, in GB.
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// The information about the log disk space of the cluster.
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceLogDiskSize : TeaModel {
                    /// <summary>
                    /// The total log disk space of the cluster, in GB.
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// The log disk space of each replica node in the cluster. Unit: GB.
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                /// <summary>
                /// The information about the memory resources of the cluster.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceMemory : TeaModel {
                    /// <summary>
                    /// The total memory size of the cluster, in GB.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                    /// <summary>
                    /// The memory size of each replica node in the cluster, in GB.
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public long? UnitMemory { get; set; }

                    /// <summary>
                    /// The size of used memory in the cluster, in GB.
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public long? UsedMemory { get; set; }

                }

                /// <summary>
                /// The number of resource units in the cluster.
                /// </summary>
                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            /// <summary>
            /// The series of the OceanBase cluster. Valid values:   
            /// - NORMAL: the high availability edition.   
            /// - BASIC: the basic edition.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// The status of the cluster. Valid values: 
            ///  - PENDING_CREATE: The cluster is being created. 
            ///  - ONLINE: The cluster is running. 
            ///  - TENANT_CREATING: The tenant is being created. 
            /// - TENANT_SPEC_MODIFYING: The tenant specifications are being modified. 
            /// - EXPANDING: Nodes are being added to the cluster to increase its capacity. 
            /// - REDUCING: Nodes are being removed from the cluster to reduce its capacity. 
            /// - SPEC_UPGRADING: The service plan is being upgraded. 
            /// - DISK_UPGRADING: The storage space is being expanded. 
            /// - WHITE_LIST_MODIFYING: The whitelist is being modified. 
            /// - PARAMETER_MODIFYING: Parameters are being modified. 
            /// - SSL_MODIFYING: The SSL certificate is being changed. 
            /// - PREPAID_EXPIRE_CLOSED: The payment is overdue. This parameter is valid for a cluster whose billing method is set to PREPAY. 
            /// - ARREARS_CLOSED: The payment is overdue. This parameter is valid for a cluster whose billing method is set to POSTPAY. 
            /// - PENDING_DELETE: The cluster is being deleted.    
            /// Generally, the cluster is in the ONLINE state.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The OBServer version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
