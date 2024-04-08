// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The information of the OceanBase cluster.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The information about the zone in which the cluster is deployed.
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// The product code of the OceanBase cluster.   
            /// - oceanbase_oceanbasepre_public_cn: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in a China site.  
            /// - oceanbase_oceanbasepost_public_cn: indicates an OceanBase cluster that is billed based on the pay-as-you-go plan and that is deployed in a China site.  
            /// - oceanbase_obpre_public_intl: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in an international site.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The number of CPU cores of the cluster.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// The CPU architecture of the cluster.
            /// </summary>
            [NameInMap("CpuArchitecture")]
            [Validation(Required=false)]
            public string CpuArchitecture { get; set; }

            /// <summary>
            /// The time in UTC when the cluster was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Specifies parameters for the automatic scaling of the data disk.
            /// </summary>
            [NameInMap("DataDiskAutoScaleConfig")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig DataDiskAutoScaleConfig { get; set; }
            public class DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig : TeaModel {
                /// <summary>
                /// Specifies whether to enable the automatic scaling of the data disk.
                /// </summary>
                [NameInMap("AutoScale")]
                [Validation(Required=false)]
                public bool? AutoScale { get; set; }

                /// <summary>
                /// The maximum size of the disk, in GB.
                /// </summary>
                [NameInMap("MaxDiskSize")]
                [Validation(Required=false)]
                public long? MaxDiskSize { get; set; }

                /// <summary>
                /// The size of scaling step during a major compaction.
                /// </summary>
                [NameInMap("ScaleStepInMerge")]
                [Validation(Required=false)]
                public long? ScaleStepInMerge { get; set; }

                /// <summary>
                /// The size of scaling step during daily use.
                /// </summary>
                [NameInMap("ScaleStepInNormal")]
                [Validation(Required=false)]
                public long? ScaleStepInNormal { get; set; }

                /// <summary>
                /// The maximum usage of the data disk, in percentage, that triggers the scaling of the data disk for major compactions.
                /// </summary>
                [NameInMap("UpperMergeThreshold")]
                [Validation(Required=false)]
                public long? UpperMergeThreshold { get; set; }

                /// <summary>
                /// The scale-out strategy. Valid values: RAW and PERCENTAGE.
                /// </summary>
                [NameInMap("UpperScaleStrategy")]
                [Validation(Required=false)]
                public string UpperScaleStrategy { get; set; }

                /// <summary>
                /// The maximum usage of the data disk, in percentage, that triggers the scaling of the data disk for daily use.
                /// </summary>
                [NameInMap("UpperThreshold")]
                [Validation(Required=false)]
                public long? UpperThreshold { get; set; }

                /// <summary>
                /// The maximum space, in GB, to which the data disk can be scaled.
                /// </summary>
                [NameInMap("Upperbound")]
                [Validation(Required=false)]
                public long? Upperbound { get; set; }

            }

            /// <summary>
            /// The data replica distribution mode of the cluster. The value is in the n-n-n format, where n is the number of OBServer nodes in each IDC.
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
            /// The size of the storage space, in GB.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public string DiskSize { get; set; }

            /// <summary>
            /// The type of the storage disk where the cluster is deployed.   
            /// The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// Indicates whether the cluster supports read-only replicas.
            /// </summary>
            [NameInMap("EnableReadOnlyReplicaManagement")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplicaManagement { get; set; }

            /// <summary>
            /// Indicates whether new nodes can be added.
            /// </summary>
            [NameInMap("EnableUpgradeNodes")]
            [Validation(Required=false)]
            public bool? EnableUpgradeNodes { get; set; }

            /// <summary>
            /// The time elapsed since the expiration of the cluster, in seconds. 
            /// > In subscription mode, if the cluster has not expired, this parameter indicates the remaining validity period of the cluster. If the cluster has expired, this parameter indicates the time elapsed since the expiration.
            /// </summary>
            [NameInMap("ExpireSeconds")]
            [Validation(Required=false)]
            public int? ExpireSeconds { get; set; }

            /// <summary>
            /// The time in UTC when the cluster expires. 
            /// > This parameter is valid only for subscription instances.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// Specifies whether to indicate the temporary status of the capacity.
            /// </summary>
            [NameInMap("InTempCapacityStatus")]
            [Validation(Required=false)]
            public bool? InTempCapacityStatus { get; set; }

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

            /// <summary>
            /// The role of the instance.
            /// </summary>
            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// The instance type.
            /// - cluster: indicates a cluster instance.
            /// - mtenant: indicates a tenant instance in MySQL mode.
            /// - mtenant_serverless: indicates a serverless instance in MySQL mode.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The time period in UTC for the daily routine maintenance of the cluster.
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// The memory size of the instance, in GB.
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            /// <summary>
            /// The billing method for the OceanBase cluster. Valid values:  
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
            public DescribeInstancesResponseBodyInstancesResource Resource { get; set; }
            public class DescribeInstancesResponseBodyInstancesResource : TeaModel {
                /// <summary>
                /// The information about capacity units.
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCapacityUnit : TeaModel {
                    /// <summary>
                    /// The maximum number of capacity units.
                    /// </summary>
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    /// <summary>
                    /// The minimum number of capacity units.
                    /// </summary>
                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    /// <summary>
                    /// The number of used capacity units.
                    /// </summary>
                    [NameInMap("UsedCapacityUnit")]
                    [Validation(Required=false)]
                    public int? UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// The information about the CPU resources of the cluster.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCpu Cpu { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCpu : TeaModel {
                    /// <summary>
                    /// The number of original CPU cores in the cluster.
                    /// </summary>
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

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
                public DescribeInstancesResponseBodyInstancesResourceDiskSize DiskSize { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceDiskSize : TeaModel {
                    /// <summary>
                    /// The original size of the disk.
                    /// </summary>
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

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
                /// The information about the memory resources of the cluster.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceMemory Memory { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceMemory : TeaModel {
                    /// <summary>
                    /// The original memory size of the cluster, in GB.
                    /// </summary>
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

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
            /// The ID of the resource group.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

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
            /// - ONLINE: The cluster is running.  
            /// - PENDING_CREATE: The cluster is being created.  
            /// - ARREARS_CLOSED("arrears_closed"): The cluster is suspended due to insufficient balance.
            /// - PREPAID_EXPIRE_CLOSED("prepaid_expire_closed"): The cluster is suspended because the subscription has expired.
            /// - WHITE_LIST_MODIFYING("white_list_modifying"): The allowlist of the cluster is being modified.
            /// - SSL_MODIFYING("ssl_modifying"): The Secure Sockets Layer (SSL) settings of the cluster are being modified.
            /// - PARAMETER_MODIFYING("parameter_modifying"): Parameters of the cluster are being modified.
            /// - TENANT_CREATING("tenant_creating"): A tenant is being created in the cluster.
            /// - TENANT_SPEC_MODIFYING("tenant_spec_modifying"): The specifications of a tenant in the cluster are being modified.
            /// - EXPANDING("expanding"): Nodes are being added to the cluster.
            /// - REDUCING("reducing"): Nodes are being removed from the cluster.
            /// - ZONE_CHANGING("zone_changing"): Zones of the cluster are being modified.
            /// - SPEC_UPGRADING: The service plan is being upgraded.
            /// - SPEC_DOWNGRADING("spec_downgrading"): The plan specification is being downgraded.
            /// - DISK_UPGRADING: The storage space is being expanded.
            /// - UPGRADING("upgrading"): The version of the cluster is being upgraded.
            /// - PENDING_DELETE("pending_delete"): The cluster is being deleted.
            /// - DELETED("deleted"): The cluster has been deleted.
            /// - ABNORMAL("abnormal"): The cluster is abnormal.
            /// - OFFLINE("offline"): The cluster is offline.
            /// - STANDBY_CREATING("standby_creating"): A standby cluster is being created for the cluster.
            /// - STANDBY_DELETING("standby_deleting"): A standby cluster of the cluster is being deleted.
            /// - SWITCHOVER_SWITCHING("switchover_switching"): The cluster is undergoing a primary/standby switchover.
            /// - STANDBY_DISCONNECTING("standby_disconnecting"): The cluster is being decoupled from its standby cluster.
            /// - LOG_DISK_UPGRADING("log_disk_upgrading"): The log disk of the cluster is being scaled out.
            /// - ISOLATION_OPTIMIZATION_MODIFYING("isolation_optimization_modifying"): The isolation optimization settings of the cluster are being modified.
            /// - DISKTYPE_MODIFYING("disktype_modifying"): The data disk type of the cluster is being modified.
            /// - PROXY_SERVICE_CREATING("proxy_service_creating"): The proxy service is being enabled for the cluster.
            /// - PROXY_SERVICE_DELETING("proxy_service_deleting"): The proxy service is being disabled for the cluster.
            /// - PROXY_SERVICE_SPEC_MODIFYING("proxy_service_spec_modifying"): The proxy service specification is being modified for the cluster.
            /// - READONLY_ADD_NODE("readonly_add_node"): A read-only node is being added to the cluster.
            /// - READONLY_REDUCE_NODE("readonly_reduce_node"): A read-only node is being removed from the cluster.
            /// - READONLY_REDUCE_ZONE("readonly_reduce_zone"): A read-only zone is being removed from the cluster.
            /// - READONLY_ADD_ZONE("readonly_add_zone"): A read-only zone is being added to the cluster.
            /// - READONLY_UPGRADE_SPEC("readonly_upgrade_spec"): The specification of read-only replicas is being upgraded.
            /// - READONLY_UPGRADE_DISK("readonly_upgrade_disk"): The disk space of read-only replicas is being scaled out.
            /// - READONLY_DOWNGRADE_SPEC("readonly_downgrade_spec"): The specification of read-only replicas is being downgraded.
            /// - READONLY_DOWNGRADE_DISK("readonly_downgrade_disk"): The disk space of read-only replicas is being scaled in.
            /// - CREATING_TENANT_READONLY_REPLICA("creating_tenant_readonly_replica"): A read-only replica is being created for a tenant in the cluster.
            /// - DELETING_TENANT_READONLY_REPLICA("deleting_tenant_readonly_replica"): A read-only replica is being deleted for a tenant in the cluster.
            /// - DISK_DOWNGRADING("disk_downgrading"): The disk space of the cluster is being scaled in.
            /// - DEPLOY_MODE_MODIFYING("deploy_mode_modifying"): The deployment mode of the cluster is being modified.
            /// > Generally, the cluster is in the ONLINE state.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The size of used storage space of the cluster, in GB.
            /// </summary>
            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public long? UsedDiskSize { get; set; }

            /// <summary>
            /// The OBServer version.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// vpcId
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of OceanBase clusters queried.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
