// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// <para>The topology of the cluster.</para>
        /// </summary>
        [NameInMap("InstanceTopology")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyInstanceTopology InstanceTopology { get; set; }
        public class DescribeInstanceTopologyResponseBodyInstanceTopology : TeaModel {
            /// <summary>
            /// <para>The information about replicas.</para>
            /// </summary>
            [NameInMap("Replicas")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyReplicas> Replicas { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyReplicas : TeaModel {
                /// <summary>
                /// <para>The ID of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h-z0</para>
                /// </summary>
                [NameInMap("LogicalZone")]
                [Validation(Required=false)]
                public string LogicalZone { get; set; }

                /// <summary>
                /// <para>The number of nodes of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NodeNum")]
                [Validation(Required=false)]
                public int? NodeNum { get; set; }

                [NameInMap("OnlineNodeNum")]
                [Validation(Required=false)]
                public long? OnlineNodeNum { get; set; }

                /// <summary>
                /// <para>The type of the read-only replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ROW_STORE</para>
                /// </summary>
                [NameInMap("ReadOnlyReplicaType")]
                [Validation(Required=false)]
                public string ReadOnlyReplicaType { get; set; }

                /// <summary>
                /// <para>The information about the replica resources.</para>
                /// </summary>
                [NameInMap("ReplicaResource")]
                [Validation(Required=false)]
                public DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResource ReplicaResource { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResource : TeaModel {
                    /// <summary>
                    /// <para>The information about the CPU resources of the replica.</para>
                    /// </summary>
                    [NameInMap("Cpu")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceCpu Cpu { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceCpu : TeaModel {
                        /// <summary>
                        /// <para>The total number of CPU cores of the replica.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16</para>
                        /// </summary>
                        [NameInMap("TotalCpu")]
                        [Validation(Required=false)]
                        public int? TotalCpu { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores used by the replica.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8</para>
                        /// </summary>
                        [NameInMap("UsedCpu")]
                        [Validation(Required=false)]
                        public int? UsedCpu { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the data disk of the replica.</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceDiskSize DiskSize { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceDiskSize : TeaModel {
                        /// <summary>
                        /// <para>The total disk space of the replica, in GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("TotalDiskSize")]
                        [Validation(Required=false)]
                        public long? TotalDiskSize { get; set; }

                        /// <summary>
                        /// <para>The disk space used by the replica, in GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>50</para>
                        /// </summary>
                        [NameInMap("UsedDiskSize")]
                        [Validation(Required=false)]
                        public float? UsedDiskSize { get; set; }

                    }

                    /// <summary>
                    /// <para>The information about the memory resources of the replica.</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceMemory Memory { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyReplicasReplicaResourceMemory : TeaModel {
                        /// <summary>
                        /// <para>The total memory size of the replica, in GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32</para>
                        /// </summary>
                        [NameInMap("TotalMemory")]
                        [Validation(Required=false)]
                        public long? TotalMemory { get; set; }

                        /// <summary>
                        /// <para>The size of memory used by the replica, in GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>16</para>
                        /// </summary>
                        [NameInMap("UsedMemory")]
                        [Validation(Required=false)]
                        public long? UsedMemory { get; set; }

                    }

                }

                /// <summary>
                /// <para>The type of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FULL</para>
                /// </summary>
                [NameInMap("ReplicaType")]
                [Validation(Required=false)]
                public string ReplicaType { get; set; }

                /// <summary>
                /// <para>The status of the replica. Valid values: ACTIVE, INACTIVE, and UNKNOWN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The serial number of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ZoneLogicalId")]
                [Validation(Required=false)]
                public int? ZoneLogicalId { get; set; }

                /// <summary>
                /// <para>The region of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneLogicalName")]
                [Validation(Required=false)]
                public string ZoneLogicalName { get; set; }

                /// <summary>
                /// <para>The zone of the replica.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("ZoneRegionName")]
                [Validation(Required=false)]
                public string ZoneRegionName { get; set; }

            }

            /// <summary>
            /// <para>The information about the tenants.</para>
            /// </summary>
            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenants> Tenants { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenants : TeaModel {
                /// <summary>
                /// <para>The deployment mode of the primary zone. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>RANDOM. </description></item>
                /// <item><description>STATIC.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RANDOM</para>
                /// </summary>
                [NameInMap("PrimaryZoneDeployType")]
                [Validation(Required=false)]
                public string PrimaryZoneDeployType { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TenantCpu")]
                [Validation(Required=false)]
                public float? TenantCpu { get; set; }

                /// <summary>
                /// <para>The deployment type of the tenant. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>multiple: multi-IDC deployment. </description></item>
                /// <item><description>single: single-IDC deployment. </description></item>
                /// <item><description>dual: dual-IDC deployment.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>multiple</para>
                /// </summary>
                [NameInMap("TenantDeployType")]
                [Validation(Required=false)]
                public string TenantDeployType { get; set; }

                /// <summary>
                /// <para>The disk space of the tenant, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TenantDiskSize")]
                [Validation(Required=false)]
                public float? TenantDiskSize { get; set; }

                /// <summary>
                /// <para>The ID of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t33h8y08k****</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The memory size of the tenant, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("TenantMemory")]
                [Validation(Required=false)]
                public float? TenantMemory { get; set; }

                /// <summary>
                /// <para>The mode of the tenant. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>Oracle  </description></item>
                /// <item><description>MySQL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Oracle</para>
                /// </summary>
                [NameInMap("TenantMode")]
                [Validation(Required=false)]
                public string TenantMode { get; set; }

                /// <summary>
                /// <para>The name of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pay_online</para>
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                /// <summary>
                /// <para>The status of the tenant. Valid values: </para>
                /// <list type="bullet">
                /// <item><description>PENDING_CREATE: The tenant is being created. </description></item>
                /// <item><description>RESTORE: The tenant is being restored. </description></item>
                /// <item><description>ONLINE: The tenant is running. </description></item>
                /// <item><description>SPEC_MODIFYING: The specification of the tenant is being modified. </description></item>
                /// <item><description>ALLOCATING_INTERNET_ADDRESS: A public IP address is being allocated to the tenant. </description></item>
                /// <item><description>PENDING_OFFLINE_INTERNET_ADDRESS: The public IP address is being disabled. </description></item>
                /// <item><description>PRIMARY_ZONE_MODIFYING: The tenant is being switched to a new primary zone. </description></item>
                /// <item><description>PARAMETER_MODIFYING: Parameters are being modified. </description></item>
                /// <item><description>WHITE_LIST_MODIFYING: The allowlist is being modified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("TenantStatus")]
                [Validation(Required=false)]
                public string TenantStatus { get; set; }

                /// <summary>
                /// <para>The number of CPU cores of a single node in the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TenantUnitCpu")]
                [Validation(Required=false)]
                public float? TenantUnitCpu { get; set; }

                /// <summary>
                /// <para>The memory size of a single node in the tenant, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("TenantUnitMemory")]
                [Validation(Required=false)]
                public float? TenantUnitMemory { get; set; }

                /// <summary>
                /// <para>The number of resource units in the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TenantUnitNum")]
                [Validation(Required=false)]
                public int? TenantUnitNum { get; set; }

                /// <summary>
                /// <para>The information about the zones.</para>
                /// </summary>
                [NameInMap("TenantZones")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones> TenantZones { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the zone is the primary zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsPrimaryTenantZone")]
                    [Validation(Required=false)]
                    public bool? IsPrimaryTenantZone { get; set; }

                    /// <summary>
                    /// <para>The ID of the replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h-z0</para>
                    /// </summary>
                    [NameInMap("LogicalZone")]
                    [Validation(Required=false)]
                    public string LogicalZone { get; set; }

                    /// <summary>
                    /// <para>The type of the read-only replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROW_STORE</para>
                    /// </summary>
                    [NameInMap("ReadOnlyReplicaType")]
                    [Validation(Required=false)]
                    public string ReadOnlyReplicaType { get; set; }

                    /// <summary>
                    /// <para>The replica type of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FULL</para>
                    /// </summary>
                    [NameInMap("ReplicaType")]
                    [Validation(Required=false)]
                    public string ReplicaType { get; set; }

                    /// <summary>
                    /// <para>The ID of the zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h</para>
                    /// </summary>
                    [NameInMap("TenantZoneId")]
                    [Validation(Required=false)]
                    public string TenantZoneId { get; set; }

                    /// <summary>
                    /// <para>The role to access the zone. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>ReadWrite: a role that has the read and write privileges. </description></item>
                    /// <item><description>ReadOnly: a role that has only the read-only privilege.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ReadWrite</para>
                    /// </summary>
                    [NameInMap("TenantZoneRole")]
                    [Validation(Required=false)]
                    public string TenantZoneRole { get; set; }

                    /// <summary>
                    /// <para>The information about the resource units.</para>
                    /// </summary>
                    [NameInMap("Units")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits> Units { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the migration can be canceled. This parameter is valid only for resource units that are being manually immigrated or emigrated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableCancelMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableCancelMigrateUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the resource unit can be migrated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("EnableMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableMigrateUnit { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the resource unit is manually migrated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("ManualMigrate")]
                        [Validation(Required=false)]
                        public bool? ManualMigrate { get; set; }

                        /// <summary>
                        /// <para>The ID of the OBServer node in which the resource unit resides.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>i-bp16niirq4zdmgvm****</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The type of the replica. Node filtering conditions are configured based on the replica type when you query the monitoring data of the OceanBase cluster. </para>
                        /// <list type="bullet">
                        /// <item><description>By default, the replica type is not specified when you query the monitoring data of OceanBase clusters or the access proxy. If you do not specify the replica type when you query the monitoring data of an OceanBase cluster, the monitoring data of all nodes is queried. </description></item>
                        /// <item><description>If you set the replica type to FULL when you query the monitoring data of an OceanBase cluster, the monitoring data of only the full-featured replica nodes is queried. </description></item>
                        /// <item><description>If you set the replica type to READONLY when you query the monitoring data of an OceanBase cluster, the monitoring data of only the read-only replica nodes is queried.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>FULL</para>
                        /// </summary>
                        [NameInMap("ReplicaType")]
                        [Validation(Required=false)]
                        public string ReplicaType { get; set; }

                        /// <summary>
                        /// <para>The number of CPU cores of the resource unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("UnitCpu")]
                        [Validation(Required=false)]
                        public float? UnitCpu { get; set; }

                        /// <summary>
                        /// <para>The data size of the resource unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("UnitDataSize")]
                        [Validation(Required=false)]
                        public long? UnitDataSize { get; set; }

                        /// <summary>
                        /// <para>The ID of the resource unit.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1002</para>
                        /// </summary>
                        [NameInMap("UnitId")]
                        [Validation(Required=false)]
                        public string UnitId { get; set; }

                        /// <summary>
                        /// <para>The memory size of the resource unit, in GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("UnitMemory")]
                        [Validation(Required=false)]
                        public float? UnitMemory { get; set; }

                        /// <summary>
                        /// <para>The status of the resource unit. Valid values: </para>
                        /// <list type="bullet">
                        /// <item><description>ONLINE: The resource unit is running. </description></item>
                        /// <item><description>IMMIGRATING: The resource unit is being immigrated. </description></item>
                        /// <item><description>EMIGRATING: The resource unit is being emigrated. </description></item>
                        /// <item><description>CANCEL_EMIGRATING: The immigration of the resource unit is being canceled. </description></item>
                        /// <item><description>CANCEL_EMIGRATING: The emigration of the resource unit is being canceled. </description></item>
                        /// <item><description>DELETING: The resource unit is being deleted.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ONLINE</para>
                        /// </summary>
                        [NameInMap("UnitStatus")]
                        [Validation(Required=false)]
                        public string UnitStatus { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The information about the zones in which the cluster is deployed.</para>
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZones> Zones { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyZones : TeaModel {
                /// <summary>
                /// <para>The information about the nodes.</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes> Nodes { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes : TeaModel {
                    /// <summary>
                    /// <para>The ID of the full-featured replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("FullCopyId")]
                    [Validation(Required=false)]
                    public long? FullCopyId { get; set; }

                    /// <summary>
                    /// <para>The ID of the replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-h-z0</para>
                    /// </summary>
                    [NameInMap("LogicalZone")]
                    [Validation(Required=false)]
                    public string LogicalZone { get; set; }

                    /// <summary>
                    /// <para>The ID of the replica node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("NodeCopyId")]
                    [Validation(Required=false)]
                    public long? NodeCopyId { get; set; }

                    /// <summary>
                    /// <para>The ID of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp16niirq4zdmgvm****</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The information about node resources.</para>
                    /// </summary>
                    [NameInMap("NodeResource")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource NodeResource { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource : TeaModel {
                        /// <summary>
                        /// <para>The information about the CPU resources of the node.</para>
                        /// </summary>
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu Cpu { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu : TeaModel {
                            /// <summary>
                            /// <para>The total number of CPU cores of the node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>14</para>
                            /// </summary>
                            [NameInMap("TotalCpu")]
                            [Validation(Required=false)]
                            public int? TotalCpu { get; set; }

                            /// <summary>
                            /// <para>The number of CPU cores used by the node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>4</para>
                            /// </summary>
                            [NameInMap("UsedCpu")]
                            [Validation(Required=false)]
                            public float? UsedCpu { get; set; }

                        }

                        /// <summary>
                        /// <para>The information about the storage resources of the node.</para>
                        /// </summary>
                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize DiskSize { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize : TeaModel {
                            /// <summary>
                            /// <para>The total storage space of the node, in GB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("TotalDiskSize")]
                            [Validation(Required=false)]
                            public double? TotalDiskSize { get; set; }

                            /// <summary>
                            /// <para>The size of storage space used by the node, in GB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>50</para>
                            /// </summary>
                            [NameInMap("UsedDiskSize")]
                            [Validation(Required=false)]
                            public double? UsedDiskSize { get; set; }

                        }

                        /// <summary>
                        /// <para>The information about the memory resources of the node.</para>
                        /// </summary>
                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory Memory { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory : TeaModel {
                            /// <summary>
                            /// <para>The total memory size of the node, in GB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>70</para>
                            /// </summary>
                            [NameInMap("TotalMemory")]
                            [Validation(Required=false)]
                            public long? TotalMemory { get; set; }

                            /// <summary>
                            /// <para>The size of memory used by the node, in GB.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("UsedMemory")]
                            [Validation(Required=false)]
                            public float? UsedMemory { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The status of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ONLINE</para>
                    /// </summary>
                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public string NodeStatus { get; set; }

                    /// <summary>
                    /// <para>The ID of the read-only replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReadOnlyCopyId")]
                    [Validation(Required=false)]
                    public long? ReadOnlyCopyId { get; set; }

                    /// <summary>
                    /// <para>The type of the read-only replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROW_STORE</para>
                    /// </summary>
                    [NameInMap("ReadOnlyReplicaType")]
                    [Validation(Required=false)]
                    public string ReadOnlyReplicaType { get; set; }

                    /// <summary>
                    /// <para>The type of the replica. Valid values: </para>
                    /// <list type="bullet">
                    /// <item><description>FULL. </description></item>
                    /// <item><description>READONLY.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FULL</para>
                    /// </summary>
                    [NameInMap("ReplicaType")]
                    [Validation(Required=false)]
                    public string ReplicaType { get; set; }

                }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The storage capacity of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200 GB</para>
                /// </summary>
                [NameInMap("ZoneDisk")]
                [Validation(Required=false)]
                public string ZoneDisk { get; set; }

                /// <summary>
                /// <para>The ID of the zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The information about zones.</para>
                /// </summary>
                [NameInMap("ZoneResource")]
                [Validation(Required=false)]
                public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource ZoneResource { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource : TeaModel {
                    /// <summary>
                    /// <para>The information about the storage resources of the node.</para>
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize DiskSize { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize : TeaModel {
                        /// <summary>
                        /// <para>The IDs of OBServer nodes that use the maximum disk space.</para>
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

                    }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-<b><b>-</b></b>-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
