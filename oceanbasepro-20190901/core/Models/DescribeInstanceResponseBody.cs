// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// The log disk space of each replica node in the cluster. Unit: GB.
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// The operation that you want to perform. <br>Set the value to **DescribeInstance**.
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("AutoUpgradeObVersion")]
            [Validation(Required=false)]
            public bool? AutoUpgradeObVersion { get; set; }

            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            [NameInMap("CpuArchitecture")]
            [Validation(Required=false)]
            public string CpuArchitecture { get; set; }

            /// <summary>
            /// Indicates whether the log disk specifications can be upgraded.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataDiskAutoScale")]
            [Validation(Required=false)]
            public bool? DataDiskAutoScale { get; set; }

            [NameInMap("DataDiskAutoScaleConfig")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceDataDiskAutoScaleConfig DataDiskAutoScaleConfig { get; set; }
            public class DescribeInstanceResponseBodyInstanceDataDiskAutoScaleConfig : TeaModel {
                [NameInMap("AutoScale")]
                [Validation(Required=false)]
                public bool? AutoScale { get; set; }

                [NameInMap("MaxDiskSize")]
                [Validation(Required=false)]
                public long? MaxDiskSize { get; set; }

                [NameInMap("ScaleStepInMerge")]
                [Validation(Required=false)]
                public long? ScaleStepInMerge { get; set; }

                [NameInMap("ScaleStepInNormal")]
                [Validation(Required=false)]
                public long? ScaleStepInNormal { get; set; }

                [NameInMap("UpperMergeThreshold")]
                [Validation(Required=false)]
                public long? UpperMergeThreshold { get; set; }

                [NameInMap("UpperThreshold")]
                [Validation(Required=false)]
                public long? UpperThreshold { get; set; }

                [NameInMap("Upperbound")]
                [Validation(Required=false)]
                public long? Upperbound { get; set; }

            }

            /// <summary>
            /// The total number of CPU cores of the cluster.
            /// </summary>
            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            /// <summary>
            /// Alibaba Cloud CLI
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// It is an online CLI tool that allows you to quickly retrieve and debug APIs. It can dynamically generate executable SDK code samples.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The total storage space of the cluster, in GB.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            [NameInMap("EnableIsolationOptimization")]
            [Validation(Required=false)]
            public bool? EnableIsolationOptimization { get; set; }

            [NameInMap("EnableProxyService")]
            [Validation(Required=false)]
            public bool? EnableProxyService { get; set; }

            [NameInMap("EnableUpgradeLogDisk")]
            [Validation(Required=false)]
            public bool? EnableUpgradeLogDisk { get; set; }

            /// <summary>
            /// The information of the OceanBase cluster.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("InTempCapacityStatus")]
            [Validation(Required=false)]
            public bool? InTempCapacityStatus { get; set; }

            /// <summary>
            /// The detailed information of the OBServer version.
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// The information about the log disk space of the cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether automatic upgrade of the OBServer version is enabled.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            [NameInMap("IsLatestObVersion")]
            [Validation(Required=false)]
            public bool? IsLatestObVersion { get; set; }

            /// <summary>
            /// The information about the CPU resources of the cluster.
            /// </summary>
            [NameInMap("IsTrustEcs")]
            [Validation(Required=false)]
            public bool? IsTrustEcs { get; set; }

            [NameInMap("IsolationOptimization")]
            [Validation(Required=false)]
            public bool? IsolationOptimization { get; set; }

            /// <summary>
            /// The time when the major compaction of cluster data is performed.
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            /// <summary>
            /// The list of zones.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("ProxyClusterId")]
            [Validation(Required=false)]
            public string ProxyClusterId { get; set; }

            [NameInMap("ProxyServiceStatus")]
            [Validation(Required=false)]
            public string ProxyServiceStatus { get; set; }

            [NameInMap("ReadOnlyResource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceReadOnlyResource ReadOnlyResource { get; set; }
            public class DescribeInstanceResponseBodyInstanceReadOnlyResource : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceCapacityUnit : TeaModel {
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    [NameInMap("UsedCapacityUnit")]
                    [Validation(Required=false)]
                    public string UsedCapacityUnit { get; set; }

                }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceCpu : TeaModel {
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceDiskSize : TeaModel {
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    [NameInMap("MaxDiskSize")]
                    [Validation(Required=false)]
                    public double? MaxDiskSize { get; set; }

                    [NameInMap("MaxDiskUsedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxDiskUsedObServer { get; set; }

                    [NameInMap("MaxDiskUsedPercent")]
                    [Validation(Required=false)]
                    public double? MaxDiskUsedPercent { get; set; }

                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceLogDiskSize : TeaModel {
                    [NameInMap("LogAssignedSize")]
                    [Validation(Required=false)]
                    public string LogAssignedSize { get; set; }

                    [NameInMap("MaxLogAssignedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxLogAssignedObServer { get; set; }

                    [NameInMap("MaxLogAssignedPercent")]
                    [Validation(Required=false)]
                    public string MaxLogAssignedPercent { get; set; }

                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceMemory : TeaModel {
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public long? UnitMemory { get; set; }

                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public long? UsedMemory { get; set; }

                }

                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            [NameInMap("ReplicaMode")]
            [Validation(Required=false)]
            public string ReplicaMode { get; set; }

            /// <summary>
            /// The size of used memory in the cluster, in GB.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceResource Resource { get; set; }
            public class DescribeInstanceResponseBodyInstanceResource : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCapacityUnit : TeaModel {
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    [NameInMap("UsedCapacityUnit")]
                    [Validation(Required=false)]
                    public string UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// The information of the OceanBase cluster.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCpu : TeaModel {
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

                    /// <summary>
                    /// The series of the OceanBase cluster. Valid values:   
                    /// - NORMAL: the high availability edition.   
                    /// - BASIC: the basic edition.
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    /// <summary>
                    /// The type of the storage disk where the cluster is deployed. 
                    /// 
                    /// The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    /// <summary>
                    /// Indicates whether automatic upgrade of the OBServer version is enabled.
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                /// <summary>
                /// The number of the page to return. 
                /// - Start value: 1  
                /// - Default value: 1
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceDiskSize : TeaModel {
                    /// <summary>
                    /// The ID of the OceanBase cluster.
                    /// </summary>
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    [NameInMap("MaxDiskSize")]
                    [Validation(Required=false)]
                    public double? MaxDiskSize { get; set; }

                    /// <summary>
                    /// The time in UTC when the cluster expires.
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

                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// The data replica distribution mode of the cluster. Valid values: 
                    /// - n: indicates the single-IDC mode. 
                    /// - n-n: indicates the dual-IDC mode. 
                    /// - n-n-n: indicates the multi-IDC mode. 
                    /// 
                    /// > <br>The integer n represents the number of OBServer nodes in each IDC.
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// The list of zones.
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                    /// <summary>
                    /// The specifications of the cluster.  You can specify one of the following four plans:    
                    /// - 8C32G: indicates 8 CPU cores and 32 GB of memory. 
                    /// - 14C70G: indicates 14 CPU cores and 70 GB of memory. 
                    /// - 30C180G: indicates 30 CPU cores and 180 GB of memory. 
                    /// - 62C400G: indicates 62 CPU cores and 400 GB of memory.
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// The server with the highest disk usage.
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceLogDiskSize : TeaModel {
                    [NameInMap("LogAssignedSize")]
                    [Validation(Required=false)]
                    public string LogAssignedSize { get; set; }

                    [NameInMap("MaxLogAssignedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxLogAssignedObServer { get; set; }

                    [NameInMap("MaxLogAssignedPercent")]
                    [Validation(Required=false)]
                    public string MaxLogAssignedPercent { get; set; }

                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public int? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// The ID of the region.
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// The request ID.
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                /// <summary>
                /// The name of the OceanBase cluster.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceMemory : TeaModel {
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

                    /// <summary>
                    /// Indicates whether trusted ECS instances are used.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                    /// <summary>
                    /// The log disk space of each replica node in the cluster. Unit: GB.
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public long? UnitMemory { get; set; }

                    /// <summary>
                    /// The time in UTC when the cluster was created.
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public long? UsedMemory { get; set; }

                }

                /// <summary>
                /// The number of CPU cores used in the cluster.
                /// </summary>
                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            /// <summary>
            /// Indicates whether the OBServer version is the latest.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// The information about cluster resources.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TenantCreatable")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceTenantCreatable TenantCreatable { get; set; }
            public class DescribeInstanceResponseBodyInstanceTenantCreatable : TeaModel {
                [NameInMap("DisableCreateTenantReason")]
                [Validation(Required=false)]
                public string DisableCreateTenantReason { get; set; }

                [NameInMap("EnableCreateTenant")]
                [Validation(Required=false)]
                public bool? EnableCreateTenant { get; set; }

            }

            /// <summary>
            /// You can call this operation to query the detailed information of an OceanBase cluster.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// The total log disk space of the cluster, in GB.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
