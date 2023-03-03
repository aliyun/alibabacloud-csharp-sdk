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
            /// The time in UTC when the cluster was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The data replica distribution mode of the cluster. Valid values:    
            /// 
            /// - n: indicates the single-IDC mode.  
            /// - n-n: indicates the dual-IDC mode.  
            /// - n-n-n: indicates the multi-IDC mode. The integer n represents the number of OBServer nodes in each IDC.
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
            /// Indicates whether new nodes can be added.
            /// </summary>
            [NameInMap("EnableUpgradeNodes")]
            [Validation(Required=false)]
            public bool? EnableUpgradeNodes { get; set; }

            /// <summary>
            /// The time elapsed since the expiration of the cluster, in seconds.
            /// </summary>
            [NameInMap("ExpireSeconds")]
            [Validation(Required=false)]
            public int? ExpireSeconds { get; set; }

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
            /// The instance type.
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
                /// The information about the CPU resources of the cluster.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCpu Cpu { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCpu : TeaModel {
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
            /// The whitelist information of the cluster.
            /// </summary>
            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public List<string> SecurityIps { get; set; }

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
            /// - PENDING_CREATE: The cluster is being created.  
            /// - ONLINE: The cluster is running.  
            /// - TENANT_CREATING: The tenant is being created.  
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
