// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the OceanBase cluster.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The information about the zone in which the cluster is deployed.</para>
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// <para>The product code of the OceanBase cluster.   </para>
            /// <list type="bullet">
            /// <item><description>oceanbase_oceanbasepre_public_cn: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in a China site.  </description></item>
            /// <item><description>oceanbase_oceanbasepost_public_cn: indicates an OceanBase cluster that is billed based on the pay-as-you-go plan and that is deployed in a China site.  </description></item>
            /// <item><description>oceanbase_obpre_public_intl: indicates an OceanBase cluster that is billed based on the subscription plan and that is deployed in an international site.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>oceanbase_oceanbasepost_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>The number of CPU cores of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public int? Cpu { get; set; }

            /// <summary>
            /// <para>The CPU architecture of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>X86_64, AARCH64</para>
            /// </summary>
            [NameInMap("CpuArchitecture")]
            [Validation(Required=false)]
            public string CpuArchitecture { get; set; }

            /// <summary>
            /// <para>The time in UTC when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-19T07:13:41Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies parameters for the automatic scaling of the data disk.</para>
            /// </summary>
            [NameInMap("DataDiskAutoScaleConfig")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig DataDiskAutoScaleConfig { get; set; }
            public class DescribeInstancesResponseBodyInstancesDataDiskAutoScaleConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable the automatic scaling of the data disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AutoScale")]
                [Validation(Required=false)]
                public bool? AutoScale { get; set; }

                /// <summary>
                /// <para>The maximum size of the disk, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80000</para>
                /// </summary>
                [NameInMap("MaxDiskSize")]
                [Validation(Required=false)]
                public long? MaxDiskSize { get; set; }

                /// <summary>
                /// <para>The size of scaling step during a major compaction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ScaleStepInMerge")]
                [Validation(Required=false)]
                public double? ScaleStepInMerge { get; set; }

                /// <summary>
                /// <para>The size of scaling step during daily use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("ScaleStepInNormal")]
                [Validation(Required=false)]
                public double? ScaleStepInNormal { get; set; }

                /// <summary>
                /// <para>The maximum usage of the data disk, in percentage, that triggers the scaling of the data disk for major compactions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("UpperMergeThreshold")]
                [Validation(Required=false)]
                public double? UpperMergeThreshold { get; set; }

                /// <summary>
                /// <para>The scale-out strategy. Valid values: RAW and PERCENTAGE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RAW</para>
                /// </summary>
                [NameInMap("UpperScaleStrategy")]
                [Validation(Required=false)]
                public string UpperScaleStrategy { get; set; }

                /// <summary>
                /// <para>The maximum usage of the data disk, in percentage, that triggers the scaling of the data disk for daily use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("UpperThreshold")]
                [Validation(Required=false)]
                public double? UpperThreshold { get; set; }

                /// <summary>
                /// <para>The maximum space, in GB, to which the data disk can be scaled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Upperbound")]
                [Validation(Required=false)]
                public double? Upperbound { get; set; }

            }

            /// <summary>
            /// <para>The data replica distribution mode of the cluster. The value is in the n-n-n format, where n is the number of OBServer nodes in each IDC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1-1-1</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The deployment type of the cluster. Valid values:   </para>
            /// <list type="bullet">
            /// <item><description>multiple: multi-IDC deployment  </description></item>
            /// <item><description>single: single-IDC deployment  </description></item>
            /// <item><description>dual: dual-IDC deployment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>multiple</para>
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The size of the storage space, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public long? DiskSize { get; set; }

            /// <summary>
            /// <para>The type of the storage disk where the cluster is deployed.<br>The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd_pl1</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>Indicates whether the cluster supports read-only replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("EnableReadOnlyReplicaManagement")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplicaManagement { get; set; }

            /// <summary>
            /// <para>Indicates whether new nodes can be added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableUpgradeNodes")]
            [Validation(Required=false)]
            public bool? EnableUpgradeNodes { get; set; }

            /// <summary>
            /// <para>The time elapsed since the expiration of the cluster, in seconds. </para>
            /// <remarks>
            /// <para>In subscription mode, if the cluster has not expired, this parameter indicates the remaining validity period of the cluster. If the cluster has expired, this parameter indicates the time elapsed since the expiration.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2606682</para>
            /// </summary>
            [NameInMap("ExpireSeconds")]
            [Validation(Required=false)]
            public int? ExpireSeconds { get; set; }

            /// <summary>
            /// <para>The time in UTC when the cluster expires. </para>
            /// <remarks>
            /// <para>This parameter is valid only for subscription instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-17T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to indicate the temporary status of the capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("InTempCapacityStatus")]
            [Validation(Required=false)]
            public bool? InTempCapacityStatus { get; set; }

            /// <summary>
            /// <para>The specifications of the cluster.  You can specify one of the following four plans:  </para>
            /// <list type="bullet">
            /// <item><description>8C32G: indicates 8 CPU cores and 32 GB of memory.  </description></item>
            /// <item><description>14C70G: indicates 14 CPU cores and 70 GB of memory.  </description></item>
            /// <item><description>30C180G: indicates 30 CPU cores and 180 GB of memory.  </description></item>
            /// <item><description>62C400G: indicates 62 CPU cores and 400 GB of memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>14C70G</para>
            /// </summary>
            [NameInMap("InstanceClass")]
            [Validation(Required=false)]
            public string InstanceClass { get; set; }

            /// <summary>
            /// <para>The ID of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob317v4uif****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the OceanBase cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob4test</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The role of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("InstanceRole")]
            [Validation(Required=false)]
            public string InstanceRole { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// <list type="bullet">
            /// <item><description>cluster: indicates a cluster instance.</description></item>
            /// <item><description>mtenant: indicates a tenant instance in MySQL mode.</description></item>
            /// <item><description>mtenant_serverless: indicates a serverless instance in MySQL mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLUSTER</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The time period in UTC for the daily routine maintenance of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-10-19T07:13:41Z</para>
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// <para>The memory size of the instance, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("Mem")]
            [Validation(Required=false)]
            public long? Mem { get; set; }

            [NameInMap("Migratable")]
            [Validation(Required=false)]
            public bool? Migratable { get; set; }

            [NameInMap("MigrationInfo")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesMigrationInfo MigrationInfo { get; set; }
            public class DescribeInstancesResponseBodyInstancesMigrationInfo : TeaModel {
                [NameInMap("CheckResult")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesMigrationInfoCheckResult CheckResult { get; set; }
                public class DescribeInstancesResponseBodyInstancesMigrationInfoCheckResult : TeaModel {
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    [NameInMap("CodeName")]
                    [Validation(Required=false)]
                    public string CodeName { get; set; }

                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                    [NameInMap("Module")]
                    [Validation(Required=false)]
                    public string Module { get; set; }

                    [NameInMap("ModuleName")]
                    [Validation(Required=false)]
                    public string ModuleName { get; set; }

                    [NameInMap("SubModule")]
                    [Validation(Required=false)]
                    public string SubModule { get; set; }

                    [NameInMap("SubModuleName")]
                    [Validation(Required=false)]
                    public string SubModuleName { get; set; }

                }

                [NameInMap("Migratable")]
                [Validation(Required=false)]
                public bool? Migratable { get; set; }

            }

            /// <summary>
            /// <para>The version of the OceanBase Database RedHat Package Managerment (RPM) package.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.2.1.7-107030032024062709</para>
            /// </summary>
            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            /// <summary>
            /// <para>The billing method for the OceanBase cluster. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description>PREPAY: the subscription billing method.  </description></item>
            /// <item><description>POSTPAY: the pay-as-you-go billing method.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PREPAY</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3F、2F1A</para>
            /// </summary>
            [NameInMap("ReplicaMode")]
            [Validation(Required=false)]
            public string ReplicaMode { get; set; }

            /// <summary>
            /// <para>The information about cluster resources.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResource Resource { get; set; }
            public class DescribeInstancesResponseBodyInstancesResource : TeaModel {
                /// <summary>
                /// <para>The information about capacity units.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCapacityUnit : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of capacity units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    /// <summary>
                    /// <para>The minimum number of capacity units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    /// <summary>
                    /// <para>The number of used capacity units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("UsedCapacityUnit")]
                    [Validation(Required=false)]
                    public int? UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// <para>The information about the CPU resources of the cluster.</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceCpu Cpu { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceCpu : TeaModel {
                    /// <summary>
                    /// <para>The number of original CPU cores in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public double? OriginalTotalCpu { get; set; }

                    /// <summary>
                    /// <para>The total number of CPU cores of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public double? TotalCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of each replica node in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public double? UnitCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores used in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public double? UsedCpu { get; set; }

                }

                /// <summary>
                /// <para>The information about the storage resources of the cluster.</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceDiskSize DiskSize { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The original size of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public double? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The total storage space of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public double? TotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The storage space of each replica node in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public double? UnitDiskSize { get; set; }

                    /// <summary>
                    /// <para>The size of used storage space of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public long? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The information about the memory resources of the cluster.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesResourceMemory Memory { get; set; }
                public class DescribeInstancesResponseBodyInstancesResourceMemory : TeaModel {
                    /// <summary>
                    /// <para>The original memory size of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public double? OriginalTotalMemory { get; set; }

                    /// <summary>
                    /// <para>The total memory size of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public double? TotalMemory { get; set; }

                    /// <summary>
                    /// <para>The memory size of each replica node in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public long? UnitMemory { get; set; }

                    /// <summary>
                    /// <para>The size of used memory in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public long? UsedMemory { get; set; }

                }

                /// <summary>
                /// <para>The number of resource units in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnitCount")]
                [Validation(Required=false)]
                public long? UnitCount { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>group1</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The series of the OceanBase cluster. Valid values:   </para>
            /// <list type="bullet">
            /// <item><description>NORMAL: the high availability edition.   </description></item>
            /// <item><description>BASIC: the basic edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <para>The specification type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dedicatedspec</para>
            /// </summary>
            [NameInMap("SpecType")]
            [Validation(Required=false)]
            public string SpecType { get; set; }

            /// <summary>
            /// <para>The status of the cluster. Valid values:   </para>
            /// <list type="bullet">
            /// <item><description>ONLINE: The cluster is running.  </description></item>
            /// <item><description>PENDING_CREATE: The cluster is being created.  </description></item>
            /// <item><description>ARREARS_CLOSED(&quot;arrears_closed&quot;): The cluster is suspended due to insufficient balance.</description></item>
            /// <item><description>PREPAID_EXPIRE_CLOSED(&quot;prepaid_expire_closed&quot;): The cluster is suspended because the subscription has expired.</description></item>
            /// <item><description>WHITE_LIST_MODIFYING(&quot;white_list_modifying&quot;): The allowlist of the cluster is being modified.</description></item>
            /// <item><description>SSL_MODIFYING(&quot;ssl_modifying&quot;): The Secure Sockets Layer (SSL) settings of the cluster are being modified.</description></item>
            /// <item><description>PARAMETER_MODIFYING(&quot;parameter_modifying&quot;): Parameters of the cluster are being modified.</description></item>
            /// <item><description>TENANT_CREATING(&quot;tenant_creating&quot;): A tenant is being created in the cluster.</description></item>
            /// <item><description>TENANT_SPEC_MODIFYING(&quot;tenant_spec_modifying&quot;): The specifications of a tenant in the cluster are being modified.</description></item>
            /// <item><description>EXPANDING(&quot;expanding&quot;): Nodes are being added to the cluster.</description></item>
            /// <item><description>REDUCING(&quot;reducing&quot;): Nodes are being removed from the cluster.</description></item>
            /// <item><description>ZONE_CHANGING(&quot;zone_changing&quot;): Zones of the cluster are being modified.</description></item>
            /// <item><description>SPEC_UPGRADING: The service plan is being upgraded.</description></item>
            /// <item><description>SPEC_DOWNGRADING(&quot;spec_downgrading&quot;): The plan specification is being downgraded.</description></item>
            /// <item><description>DISK_UPGRADING: The storage space is being expanded.</description></item>
            /// <item><description>UPGRADING(&quot;upgrading&quot;): The version of the cluster is being upgraded.</description></item>
            /// <item><description>PENDING_DELETE(&quot;pending_delete&quot;): The cluster is being deleted.</description></item>
            /// <item><description>DELETED(&quot;deleted&quot;): The cluster has been deleted.</description></item>
            /// <item><description>ABNORMAL(&quot;abnormal&quot;): The cluster is abnormal.</description></item>
            /// <item><description>OFFLINE(&quot;offline&quot;): The cluster is offline.</description></item>
            /// <item><description>STANDBY_CREATING(&quot;standby_creating&quot;): A standby cluster is being created for the cluster.</description></item>
            /// <item><description>STANDBY_DELETING(&quot;standby_deleting&quot;): A standby cluster of the cluster is being deleted.</description></item>
            /// <item><description>SWITCHOVER_SWITCHING(&quot;switchover_switching&quot;): The cluster is undergoing a primary/standby switchover.</description></item>
            /// <item><description>STANDBY_DISCONNECTING(&quot;standby_disconnecting&quot;): The cluster is being decoupled from its standby cluster.</description></item>
            /// <item><description>LOG_DISK_UPGRADING(&quot;log_disk_upgrading&quot;): The log disk of the cluster is being scaled out.</description></item>
            /// <item><description>ISOLATION_OPTIMIZATION_MODIFYING(&quot;isolation_optimization_modifying&quot;): The isolation optimization settings of the cluster are being modified.</description></item>
            /// <item><description>DISKTYPE_MODIFYING(&quot;disktype_modifying&quot;): The data disk type of the cluster is being modified.</description></item>
            /// <item><description>PROXY_SERVICE_CREATING(&quot;proxy_service_creating&quot;): The proxy service is being enabled for the cluster.</description></item>
            /// <item><description>PROXY_SERVICE_DELETING(&quot;proxy_service_deleting&quot;): The proxy service is being disabled for the cluster.</description></item>
            /// <item><description>PROXY_SERVICE_SPEC_MODIFYING(&quot;proxy_service_spec_modifying&quot;): The proxy service specification is being modified for the cluster.</description></item>
            /// <item><description>READONLY_ADD_NODE(&quot;readonly_add_node&quot;): A read-only node is being added to the cluster.</description></item>
            /// <item><description>READONLY_REDUCE_NODE(&quot;readonly_reduce_node&quot;): A read-only node is being removed from the cluster.</description></item>
            /// <item><description>READONLY_REDUCE_ZONE(&quot;readonly_reduce_zone&quot;): A read-only zone is being removed from the cluster.</description></item>
            /// <item><description>READONLY_ADD_ZONE(&quot;readonly_add_zone&quot;): A read-only zone is being added to the cluster.</description></item>
            /// <item><description>READONLY_UPGRADE_SPEC(&quot;readonly_upgrade_spec&quot;): The specification of read-only replicas is being upgraded.</description></item>
            /// <item><description>READONLY_UPGRADE_DISK(&quot;readonly_upgrade_disk&quot;): The disk space of read-only replicas is being scaled out.</description></item>
            /// <item><description>READONLY_DOWNGRADE_SPEC(&quot;readonly_downgrade_spec&quot;): The specification of read-only replicas is being downgraded.</description></item>
            /// <item><description>READONLY_DOWNGRADE_DISK(&quot;readonly_downgrade_disk&quot;): The disk space of read-only replicas is being scaled in.</description></item>
            /// <item><description>CREATING_TENANT_READONLY_REPLICA(&quot;creating_tenant_readonly_replica&quot;): A read-only replica is being created for a tenant in the cluster.</description></item>
            /// <item><description>DELETING_TENANT_READONLY_REPLICA(&quot;deleting_tenant_readonly_replica&quot;): A read-only replica is being deleted for a tenant in the cluster.</description></item>
            /// <item><description>DISK_DOWNGRADING(&quot;disk_downgrading&quot;): The disk space of the cluster is being scaled in.</description></item>
            /// <item><description>DEPLOY_MODE_MODIFYING(&quot;deploy_mode_modifying&quot;): The deployment mode of the cluster is being modified.<remarks>
            /// <para>Generally, the cluster is in the ONLINE state.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The size of used storage space of the cluster, in GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("UsedDiskSize")]
            [Validation(Required=false)]
            public long? UsedDiskSize { get; set; }

            /// <summary>
            /// <para>The OBServer version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.77</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>vpcId</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-8vb8qjrixzovjpy******</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of OceanBase clusters queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
