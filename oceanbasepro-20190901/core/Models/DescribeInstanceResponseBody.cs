// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of the OceanBase cluster.</para>
        /// </summary>
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DescribeInstanceResponseBodyInstance Instance { get; set; }
        public class DescribeInstanceResponseBodyInstance : TeaModel {
            /// <summary>
            /// <para>Indicates whether the OceanBase Database Proxy (ODP) SQL firewall is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowCreateProxySqlFirewallRule")]
            [Validation(Required=false)]
            public bool? AllowCreateProxySqlFirewallRule { get; set; }

            /// <summary>
            /// <para>Indicates whether the maximum number of public connections can be modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowModifyInternetAddressConnectionLimit")]
            [Validation(Required=false)]
            public bool? AllowModifyInternetAddressConnectionLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic renewal is enabled. </para>
            /// <para>This parameter is valid only for clusters whose billing methods are set to PREPAY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoRenewal")]
            [Validation(Required=false)]
            public bool? AutoRenewal { get; set; }

            /// <summary>
            /// <para>Indicates whether automatic upgrade of the OBServer version is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoUpgradeObVersion")]
            [Validation(Required=false)]
            public bool? AutoUpgradeObVersion { get; set; }

            /// <summary>
            /// <para>The list of zones.</para>
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// <para>The CPU architecture of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>X86</para>
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
            /// <para>Specifies whether to enable automatic scaling of the data disk.</para>
            /// <remarks>
            /// <para><br>This parameter is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("DataDiskAutoScale")]
            [Validation(Required=false)]
            public bool? DataDiskAutoScale { get; set; }

            /// <summary>
            /// <para>Specifies parameters for the automatic scaling of the data disk.</para>
            /// </summary>
            [NameInMap("DataDiskAutoScaleConfig")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceDataDiskAutoScaleConfig DataDiskAutoScaleConfig { get; set; }
            public class DescribeInstanceResponseBodyInstanceDataDiskAutoScaleConfig : TeaModel {
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
                public long? ScaleStepInMerge { get; set; }

                /// <summary>
                /// <para>The size of scaling step during daily use.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("ScaleStepInNormal")]
                [Validation(Required=false)]
                public long? ScaleStepInNormal { get; set; }

                /// <summary>
                /// <para>The maximum usage of the data disk, in percentage, that triggers the scaling of the data disk for major compactions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("UpperMergeThreshold")]
                [Validation(Required=false)]
                public long? UpperMergeThreshold { get; set; }

                /// <summary>
                /// <para>The step size of the scale-out.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("UpperScaleStep")]
                [Validation(Required=false)]
                public string UpperScaleStep { get; set; }

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
                public long? UpperThreshold { get; set; }

                /// <summary>
                /// <para>The maximum space, in GB, to which the data disk can be scaled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("Upperbound")]
                [Validation(Required=false)]
                public long? Upperbound { get; set; }

            }

            /// <summary>
            /// <para>The time when the major compaction of cluster data is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00</para>
            /// </summary>
            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            /// <summary>
            /// <para>The data replica distribution mode of the cluster. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>n: indicates the single-IDC mode. </description></item>
            /// <item><description>n-n: indicates the dual-IDC mode. </description></item>
            /// <item><description>n-n-n: indicates the multi-IDC mode.</description></item>
            /// </list>
            /// <remarks>
            /// <para><br>The integer n represents the number of OBServer nodes in each IDC.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1-1-1</para>
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// <para>The deployment type of the cluster. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description>multiple: multi-IDC deployment   </description></item>
            /// <item><description>single: single-IDC deployment   </description></item>
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
            /// <para>The type of the storage disk where the cluster is deployed. </para>
            /// <para>The default value is cloud_essd_pl1, which indicates an ESSD cloud disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd_pl1</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable isolation optimization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableIsolationOptimization")]
            [Validation(Required=false)]
            public bool? EnableIsolationOptimization { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the proxy service.</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableProxyService")]
            [Validation(Required=false)]
            public bool? EnableProxyService { get; set; }

            /// <summary>
            /// <para>Indicates whether read-only replicas are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableReadOnlyReplica")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplica { get; set; }

            /// <summary>
            /// <para>Indicates whether read-only replicas can be purchased for the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableReadOnlyReplicaManagement")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplicaManagement { get; set; }

            /// <summary>
            /// <para>Indicates whether the log disk specifications can be upgraded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableUpgradeLogDisk")]
            [Validation(Required=false)]
            public bool? EnableUpgradeLogDisk { get; set; }

            /// <summary>
            /// <para>The maximum number of units of the proxy service in exclusive mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExclusiveUnitNumLimit")]
            [Validation(Required=false)]
            public int? ExclusiveUnitNumLimit { get; set; }

            /// <summary>
            /// <para>The time in UTC when the cluster expires.</para>
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
            /// <para>The specifications of the cluster.  You can specify one of the following four plans:    </para>
            /// <list type="bullet">
            /// <item><description>8C32G: indicates 8 CPU cores and 32 GB of memory. </description></item>
            /// <item><description>14C70G: indicates 14 CPU cores and 70 GB of memory. </description></item>
            /// <item><description>30C180G: indicates 30 CPU cores and 180 GB of memory. </description></item>
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
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("Iops")]
            [Validation(Required=false)]
            public int? Iops { get; set; }

            /// <summary>
            /// <para>Indicates whether the OBServer version is the latest.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsLatestObVersion")]
            [Validation(Required=false)]
            public bool? IsLatestObVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether trusted ECS instances are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTrustEcs")]
            [Validation(Required=false)]
            public bool? IsTrustEcs { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the control group feature.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsolationOptimization")]
            [Validation(Required=false)]
            public bool? IsolationOptimization { get; set; }

            /// <summary>
            /// <para>The period in UTC for the daily routine maintenance of the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>19:00Z-20:00Z</para>
            /// </summary>
            [NameInMap("MaintainTime")]
            [Validation(Required=false)]
            public string MaintainTime { get; set; }

            /// <summary>
            /// <para>The number of nodes in the cluster. If the cluster is deployed in n-n-n mode, the number of nodes in the cluster equals n × 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("NodeNum")]
            [Validation(Required=false)]
            public string NodeNum { get; set; }

            /// <summary>
            /// <para>The detailed information of the OBServer version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.77-20210526202046</para>
            /// </summary>
            [NameInMap("ObRpmVersion")]
            [Validation(Required=false)]
            public string ObRpmVersion { get; set; }

            /// <summary>
            /// <para>The billing method of the OceanBase cluster. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>PREPAY: the subscription billing method. </description></item>
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
            /// <para>The ID of the primary cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ob3h8ytroxxxxx</para>
            /// </summary>
            [NameInMap("PrimaryInstance")]
            [Validation(Required=false)]
            public string PrimaryInstance { get; set; }

            /// <summary>
            /// <para>The region of the primary cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("PrimaryRegion")]
            [Validation(Required=false)]
            public string PrimaryRegion { get; set; }

            /// <summary>
            /// <para>The ID of the proxy cluster.</para>
            /// <remarks>
            /// <para>This parameter returns a value only if you set the <b>EnableProxyService</b> parameter to true.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>proxy-56****a6tg2o</para>
            /// </summary>
            [NameInMap("ProxyClusterId")]
            [Validation(Required=false)]
            public string ProxyClusterId { get; set; }

            /// <summary>
            /// <para>The status of the proxy service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("ProxyServiceStatus")]
            [Validation(Required=false)]
            public string ProxyServiceStatus { get; set; }

            /// <summary>
            /// <para>The information about cluster resources.</para>
            /// </summary>
            [NameInMap("ReadOnlyResource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceReadOnlyResource ReadOnlyResource { get; set; }
            public class DescribeInstanceResponseBodyInstanceReadOnlyResource : TeaModel {
                /// <summary>
                /// <para>The information about capacity units.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceCapacityUnit : TeaModel {
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
                    public string UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// <para>The information about the CPU resources of the cluster.</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceCpu : TeaModel {
                    /// <summary>
                    /// <para>The number of original CPU cores in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

                    /// <summary>
                    /// <para>The total number of CPU cores of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of each replica node in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores used by the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                /// <summary>
                /// <para>The information about the storage resources of the cluster.</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The size of the data disk, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    /// <summary>
                    /// <para>The maximum disk size that can be created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80000</para>
                    /// </summary>
                    [NameInMap("MaxDiskSize")]
                    [Validation(Required=false)]
                    public double? MaxDiskSize { get; set; }

                    /// <summary>
                    /// <para>The maximum disk usage of the OBServer node.</para>
                    /// </summary>
                    [NameInMap("MaxDiskUsedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxDiskUsedObServer { get; set; }

                    /// <summary>
                    /// <para>The maximum disk usage, in percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.14</para>
                    /// </summary>
                    [NameInMap("MaxDiskUsedPercent")]
                    [Validation(Required=false)]
                    public double? MaxDiskUsedPercent { get; set; }

                    /// <summary>
                    /// <para>The original size of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The total storage space of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The storage space of each replica node in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

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
                /// <para>The information about the log disk space of the cluster.</para>
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceLogDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The allocated disk space for log storage, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("LogAssignedSize")]
                    [Validation(Required=false)]
                    public string LogAssignedSize { get; set; }

                    /// <summary>
                    /// <para>The maximum storage space allocated for.</para>
                    /// </summary>
                    [NameInMap("MaxLogAssignedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxLogAssignedObServer { get; set; }

                    /// <summary>
                    /// <para>The maximum percentage of space allocated for log storage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.68</para>
                    /// </summary>
                    [NameInMap("MaxLogAssignedPercent")]
                    [Validation(Required=false)]
                    public string MaxLogAssignedPercent { get; set; }

                    /// <summary>
                    /// <para>The information about the log disk space of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The log disk space of each replica node in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The information about the memory resources of the cluster.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceReadOnlyResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceReadOnlyResourceMemory : TeaModel {
                    /// <summary>
                    /// <para>The original memory size of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

                    /// <summary>
                    /// <para>The total memory size of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

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
                    /// <para>The size of memory used by the cluster, in GB.</para>
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
            /// <para>The number of full-featured replicas. Return value: 3 or 2.</para>
            /// <list type="bullet">
            /// <item><description>3: three full-featured replicas.</description></item>
            /// <item><description>2: two full-featured replicas.</description></item>
            /// </list>
            /// <para>An OceanBase cluster deployed in three-zone mode supports only three full-featured replicas. An OceanBase cluster deployed in two-zone mode supports only two full-featured replicas. An OceanBase cluster deployed in one single zone supports two or three full-featured replicas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2F1A</para>
            /// </summary>
            [NameInMap("ReplicaMode")]
            [Validation(Required=false)]
            public string ReplicaMode { get; set; }

            /// <summary>
            /// <para>The information about cluster resources.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceResource Resource { get; set; }
            public class DescribeInstanceResponseBodyInstanceResource : TeaModel {
                /// <summary>
                /// <para>The information about capacity units.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCapacityUnit : TeaModel {
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
                    public string UsedCapacityUnit { get; set; }

                }

                /// <summary>
                /// <para>The information about the CPU resources of the cluster.</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceCpu Cpu { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceCpu : TeaModel {
                    /// <summary>
                    /// <para>The number of original CPU cores in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("OriginalTotalCpu")]
                    [Validation(Required=false)]
                    public long? OriginalTotalCpu { get; set; }

                    /// <summary>
                    /// <para>The total number of CPU cores of the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14</para>
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public long? TotalCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores of each replica node in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public long? UnitCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores used in the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public long? UsedCpu { get; set; }

                }

                /// <summary>
                /// <para>The information about the storage resources of the cluster.</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceDiskSize DiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The size of the data disk, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("DataUsedSize")]
                    [Validation(Required=false)]
                    public double? DataUsedSize { get; set; }

                    /// <summary>
                    /// <para>The maximum disk size that can be created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80000</para>
                    /// </summary>
                    [NameInMap("MaxDiskSize")]
                    [Validation(Required=false)]
                    public double? MaxDiskSize { get; set; }

                    /// <summary>
                    /// <para>The maximum disk usage of the OBServer node.</para>
                    /// </summary>
                    [NameInMap("MaxDiskUsedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxDiskUsedObServer { get; set; }

                    /// <summary>
                    /// <para>The maximum disk usage, in percentage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.14</para>
                    /// </summary>
                    [NameInMap("MaxDiskUsedPercent")]
                    [Validation(Required=false)]
                    public double? MaxDiskUsedPercent { get; set; }

                    /// <summary>
                    /// <para>The original size of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public long? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The total storage space of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The storage space of each replica node in the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

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
                /// <para>The information about the log disk space of the cluster.</para>
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceLogDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The allocated disk space for log storage, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("LogAssignedSize")]
                    [Validation(Required=false)]
                    public string LogAssignedSize { get; set; }

                    /// <summary>
                    /// <para>The maximum storage space allocated for.</para>
                    /// </summary>
                    [NameInMap("MaxLogAssignedObServer")]
                    [Validation(Required=false)]
                    public List<string> MaxLogAssignedObServer { get; set; }

                    /// <summary>
                    /// <para>The maximum percentage of space allocated for log storage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.68</para>
                    /// </summary>
                    [NameInMap("MaxLogAssignedPercent")]
                    [Validation(Required=false)]
                    public string MaxLogAssignedPercent { get; set; }

                    /// <summary>
                    /// <para>The original size of the disk.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("OriginalTotalDiskSize")]
                    [Validation(Required=false)]
                    public int? OriginalTotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The total log disk space of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("TotalDiskSize")]
                    [Validation(Required=false)]
                    public long? TotalDiskSize { get; set; }

                    /// <summary>
                    /// <para>The log disk space of each replica node in the cluster. Unit: GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("UnitDiskSize")]
                    [Validation(Required=false)]
                    public long? UnitDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The information about the memory resources of the cluster.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeInstanceResponseBodyInstanceResourceMemory Memory { get; set; }
                public class DescribeInstanceResponseBodyInstanceResourceMemory : TeaModel {
                    /// <summary>
                    /// <para>The original memory size of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>72</para>
                    /// </summary>
                    [NameInMap("OriginalTotalMemory")]
                    [Validation(Required=false)]
                    public long? OriginalTotalMemory { get; set; }

                    /// <summary>
                    /// <para>The total memory size of the cluster, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>70</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public long? TotalMemory { get; set; }

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
            /// <para>The series of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>normal: Standard Cluster Edition (Cloud Disk). This is the default value.</para>
            /// </description></item>
            /// <item><description><para>normal_ssd: Standard Cluster Edition (Local Disk)</para>
            /// </description></item>
            /// <item><description><para>history: History Database Cluster Edition</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <para>The maximum number of units of the proxy service in shared mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("SharedUnitNumLimit")]
            [Validation(Required=false)]
            public int? SharedUnitNumLimit { get; set; }

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
            /// <para>The status of the cluster. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>PENDING_CREATE: The cluster is being created. </description></item>
            /// <item><description>ONLINE: The cluster is running. </description></item>
            /// <item><description>TENANT_CREATING: The tenant is being created. </description></item>
            /// <item><description>TENANT_SPEC_MODIFYING: The tenant specifications are being modified. </description></item>
            /// <item><description>EXPANDING: Nodes are being added to the cluster to increase its capacity. </description></item>
            /// <item><description>REDUCING: Nodes are being removed from the cluster to reduce its capacity. </description></item>
            /// <item><description>SPEC_UPGRADING: The service plan is being upgraded. </description></item>
            /// <item><description>DISK_UPGRADING: The storage space is being expanded. </description></item>
            /// <item><description>WHITE_LIST_MODIFYING: The whitelist is being modified. </description></item>
            /// <item><description>PARAMETER_MODIFYING: Parameters are being modified. </description></item>
            /// <item><description>SSL_MODIFYING: The SSL certificate is being changed. </description></item>
            /// <item><description>PREPAID_EXPIRE_CLOSED: The payment is overdue. This parameter is valid for a cluster whose billing method is set to PREPAY. </description></item>
            /// <item><description>ARREARS_CLOSED: The payment is overdue. This parameter is valid for a cluster whose billing method is set to POSTPAY. </description></item>
            /// <item><description>PENDING_DELETE: The cluster is being deleted.<br>Generally, the cluster is in the ONLINE state.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Specifies whether a tenant can be created.</para>
            /// </summary>
            [NameInMap("TenantCreatable")]
            [Validation(Required=false)]
            public DescribeInstanceResponseBodyInstanceTenantCreatable TenantCreatable { get; set; }
            public class DescribeInstanceResponseBodyInstanceTenantCreatable : TeaModel {
                /// <summary>
                /// <para>The reason why you cannot create a tenant in the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU_NOT_ENOUGH,  MEMORY_NOT_ENOUGH, TENANT_COUNT_EXCEEDS_LIMIT</para>
                /// </summary>
                [NameInMap("DisableCreateTenantReason")]
                [Validation(Required=false)]
                public string DisableCreateTenantReason { get; set; }

                /// <summary>
                /// <para>Specifies whether a tenant can be created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableCreateTenant")]
                [Validation(Required=false)]
                public bool? EnableCreateTenant { get; set; }

            }

            /// <summary>
            /// <para>The unit specification of the proxy service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2C4G</para>
            /// </summary>
            [NameInMap("UnitSpec")]
            [Validation(Required=false)]
            public string UnitSpec { get; set; }

            /// <summary>
            /// <para>The version of OceanBase Database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.77</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The ID of the zone to which the instance belongs.
            /// &lt;props=&quot;intl&quot;&gt;For more information about how to obtain the list of zones, see <a href="https://www.alibabacloud.com/help/en/apsaradb-for-oceanbase/latest/api-oceanbasepro-2019-09-01-describezones">DescribeZones</a>.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<string> Zones { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
