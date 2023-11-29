// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// The total storage space of the cluster, in GB.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// The time in UTC when the cluster expires.
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// The storage space of each replica node in the cluster, in GB.
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// The product code of the OceanBase cluster.   
            /// - oceanbase_oceanbasepre_public_cn: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in a China site.  
            /// - oceanbase_oceanbasepost_public_cn: indicates an OceanBase cluster that is billed based on the pay-as-you-go plan and that is deployed in a China site.  
            /// - oceanbase_obpre_public_intl: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in an international site.
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            [NameInMap("CpuArchitecture")]
            [Validation(Required=false)]
            public string CpuArchitecture { get; set; }

            /// <summary>
            /// The number of OceanBase clusters queried.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataDiskAutoScaleConfig")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig DataDiskAutoScaleConfig { get; set; }
            public class DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig : TeaModel {
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
            /// The request ID.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// Alibaba Cloud provides SDKs in different languages to help you quickly integrate Alibaba Cloud products and services by using APIs. We recommend that you use an SDK to call APIs. In this way, you do not need to sign for verification.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// The information about the memory resources of the cluster.
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public string DiskSize { get; set; }

            /// <summary>
            /// The number of CPU cores used in the cluster.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// The ID of the OceanBase cluster.
            /// </summary>
            [NameInMap("EnableUpgradeNodes")]
            [Validation(Required=false)]
            public bool? EnableUpgradeNodes { get; set; }

            /// <summary>
            /// The whitelist information of the cluster.
            /// </summary>
            [NameInMap("ExpireSeconds")]
            [Validation(Required=false)]
            public int? ExpireSeconds { get; set; }

            /// <summary>
            /// The information about the storage resources of the cluster.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("InTempCapacityStatus")]
            [Validation(Required=false)]
            public bool? InTempCapacityStatus { get; set; }

            /// <summary>
            /// The instance type.
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// The total storage space of the cluster, in GB.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// You can call this operation to obtain the list of OceanBase clusters.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The return result of the request.
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// The information about the CPU resources of the cluster.
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            /// <summary>
            /// It is an Alibaba Cloud asset management and configuration tool, with which you can manage multiple Alibaba Cloud products and services by using commands. It is easy to use and a good helper in migration to cloud.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The type of the storage disk where the cluster is deployed.   
            /// The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResource Resource { get; set; }
            public class DescribeInstancesResponseBodyInstancesResource : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCapacityUnit : TeaModel {
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    [NameInMap("UsedCapacityUnit")]
                    [Validation(Required=false)]
                    public int? UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// Indicates whether new nodes can be added.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCpu Cpu { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCpu : TeaModel {
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

                    /// <summary>
                    /// The name of the OceanBase cluster.    
                    /// It must be 1 to 20 characters in length.   
                    /// If this parameter is not specified, the value is the instance ID of the cluster by default.
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    /// <summary>
                    /// The data replica distribution mode of the cluster. Valid values:    
                    /// 
                    /// - n: indicates the single-IDC mode.  
                    /// - n-n: indicates the dual-IDC mode.  
                    /// - n-n-n: indicates the multi-IDC mode. The integer n represents the number of OBServer nodes in each IDC.
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    /// <summary>
                    /// The search keyword.
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                /// <summary>
                /// The time elapsed since the expiration of the cluster, in seconds.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceDiskSize DiskSize { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceDiskSize : TeaModel {
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// The request ID.
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// Example 1
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                    /// <summary>
                    /// $.parameters[7].schema.example
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

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
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceMemory Memory { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceMemory : TeaModel {
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

                    /// <summary>
                    /// The number of CPU cores of the cluster.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

                    /// <summary>
                    /// The size of used storage space of the cluster, in GB.
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

                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            /// <summary>
            /// The number of OceanBase clusters queried.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The billing method for the OceanBase cluster. Valid values:  
            /// - PREPAY: the subscription billing method.  
            /// - POSTPAY: the pay-as-you-go billing method.
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// The number of resource units in the cluster.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The number of resource units in the cluster.
            /// </summary>
            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public long? UsedDiskSize { get; set; }

            /// <summary>
            /// The total number of CPU cores of the cluster.
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

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
