// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        /// <summary>
        /// The topology of the cluster.
        /// </summary>
        [NameInMap("InstanceTopology")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyInstanceTopology InstanceTopology { get; set; }
        public class DescribeInstanceTopologyResponseBodyInstanceTopology : TeaModel {
            /// <summary>
            /// The information of the tenant.
            /// </summary>
            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenants> Tenants { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenants : TeaModel {
                /// <summary>
                /// The primary zone deployment mode.
                /// </summary>
                [NameInMap("PrimaryZoneDeployType")]
                [Validation(Required=false)]
                public string PrimaryZoneDeployType { get; set; }

                /// <summary>
                /// The number of CPU cores of the tenant.
                /// </summary>
                [NameInMap("TenantCpu")]
                [Validation(Required=false)]
                public float? TenantCpu { get; set; }

                /// <summary>
                /// The deployment type of the tenant.   
                /// - multiple: multi-IDC deployment   
                /// - single: single-IDC deployment   
                /// - dual: dual-IDC deployment
                /// </summary>
                [NameInMap("TenantDeployType")]
                [Validation(Required=false)]
                public string TenantDeployType { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// The memory size of the tenant, in GB.
                /// </summary>
                [NameInMap("TenantMemory")]
                [Validation(Required=false)]
                public float? TenantMemory { get; set; }

                /// <summary>
                /// The tenant mode. Valid values:   
                /// - Oracle   
                /// - MySQL
                /// </summary>
                [NameInMap("TenantMode")]
                [Validation(Required=false)]
                public string TenantMode { get; set; }

                /// <summary>
                /// The name of the tenant.
                /// </summary>
                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                /// <summary>
                /// The status of the tenant.   
                /// - PENDING_CREATE: The tenant is being created.   
                /// - RESTORE: The tenant is being recovered.   
                /// - ONLINE: The tenant is running.   
                /// - SPEC_MODIFYING: The specification of the tenant is being modified.   
                /// - ALLOCATING_INTERNET_ADDRESS: An Internet address is being allocated.   
                /// - PENDING_OFFLINE_INTERNET_ADDRESS: The Internet address is being disabled.   
                /// - PRIMARY_ZONE_MODIFYING: The tenant is switching to a new primary zone.   
                /// - PARAMETER_MODIFYING: Parameters are being modified.   
                /// - WHITE_LIST_MODIFYING: The whitelist is being modified.
                /// </summary>
                [NameInMap("TenantStatus")]
                [Validation(Required=false)]
                public string TenantStatus { get; set; }

                /// <summary>
                /// The number of resource units in the tenant.
                /// </summary>
                [NameInMap("TenantUnitNum")]
                [Validation(Required=false)]
                public int? TenantUnitNum { get; set; }

                /// <summary>
                /// The zone information of the tenant.
                /// </summary>
                [NameInMap("TenantZones")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones> TenantZones { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones : TeaModel {
                    /// <summary>
                    /// Indicates whether the zone is the primary zone.
                    /// </summary>
                    [NameInMap("IsPrimaryTenantZone")]
                    [Validation(Required=false)]
                    public string IsPrimaryTenantZone { get; set; }

                    /// <summary>
                    /// The ID of the zone.
                    /// </summary>
                    [NameInMap("TenantZoneId")]
                    [Validation(Required=false)]
                    public string TenantZoneId { get; set; }

                    /// <summary>
                    /// The role to access the zone. Valid values:   
                    ///  - ReadWrite: a role that has the read and write privileges.
                    ///  - ReadOnly: a role that has only the read-only privilege.
                    /// </summary>
                    [NameInMap("TenantZoneRole")]
                    [Validation(Required=false)]
                    public string TenantZoneRole { get; set; }

                    /// <summary>
                    /// The information about resource units.
                    /// </summary>
                    [NameInMap("Units")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits> Units { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits : TeaModel {
                        /// <summary>
                        /// Indicates whether the migration can be canceled.   
                        /// This field is valid only for units that are being manually immigrated or emigrated.
                        /// </summary>
                        [NameInMap("EnableCancelMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableCancelMigrateUnit { get; set; }

                        /// <summary>
                        /// Indicates whether migration can be performed.
                        /// </summary>
                        [NameInMap("EnableMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableMigrateUnit { get; set; }

                        /// <summary>
                        /// Indicates whether the migration is manually performed.
                        /// </summary>
                        [NameInMap("ManualMigrate")]
                        [Validation(Required=false)]
                        public bool? ManualMigrate { get; set; }

                        /// <summary>
                        /// The ID of the OBServer where the resource unit resides.
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// The number of CPU cores of the resource unit.
                        /// </summary>
                        [NameInMap("UnitCpu")]
                        [Validation(Required=false)]
                        public float? UnitCpu { get; set; }

                        /// <summary>
                        /// The data size of the unit.
                        /// </summary>
                        [NameInMap("UnitDataSize")]
                        [Validation(Required=false)]
                        public long? UnitDataSize { get; set; }

                        /// <summary>
                        /// The ID of the resource unit.
                        /// </summary>
                        [NameInMap("UnitId")]
                        [Validation(Required=false)]
                        public string UnitId { get; set; }

                        /// <summary>
                        /// The memory size of the resource unit, in GB.
                        /// </summary>
                        [NameInMap("UnitMemory")]
                        [Validation(Required=false)]
                        public float? UnitMemory { get; set; }

                        /// <summary>
                        /// The status of the resource unit. Valid values:    
                        /// 
                        /// - ONLINE: The resource unit is running.
                        /// - IMMIGRATING: The resource unit is being immigrated.
                        /// - EMIGRATING: The resource unit is being emigrated.
                        /// - CANCEL_EMIGRATING: Resource node immigration is being canceled.
                        /// - CANCEL_EMIGRATING: Resource node emigration is being canceled.
                        /// - DELETING: The resource unit is being deleted.
                        /// </summary>
                        [NameInMap("UnitStatus")]
                        [Validation(Required=false)]
                        public string UnitStatus { get; set; }

                    }

                }

            }

            /// <summary>
            /// The zone information of the cluster.
            /// </summary>
            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZones> Zones { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyZones : TeaModel {
                /// <summary>
                /// The information of the nodes.
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes> Nodes { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes : TeaModel {
                    /// <summary>
                    /// The ID of the replica node.
                    /// </summary>
                    [NameInMap("NodeCopyId")]
                    [Validation(Required=false)]
                    public long? NodeCopyId { get; set; }

                    /// <summary>
                    /// The ID of the node.
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// The information of node resources.
                    /// </summary>
                    [NameInMap("NodeResource")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource> NodeResource { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource : TeaModel {
                        /// <summary>
                        /// The information about the CPU resources of the node.
                        /// </summary>
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu Cpu { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu : TeaModel {
                            /// <summary>
                            /// The total number of CPU cores for the node.
                            /// </summary>
                            [NameInMap("TotalCpu")]
                            [Validation(Required=false)]
                            public int? TotalCpu { get; set; }

                            /// <summary>
                            /// The number of CPU cores used by the node.
                            /// </summary>
                            [NameInMap("UsedCpu")]
                            [Validation(Required=false)]
                            public float? UsedCpu { get; set; }

                        }

                        /// <summary>
                        /// The information about the storage resources of the node.
                        /// </summary>
                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize DiskSize { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize : TeaModel {
                            /// <summary>
                            /// The total storage space of the node, in GB.
                            /// </summary>
                            [NameInMap("TotalDiskSize")]
                            [Validation(Required=false)]
                            public double? TotalDiskSize { get; set; }

                            /// <summary>
                            /// The size of used storage space of the node, in GB.
                            /// </summary>
                            [NameInMap("UsedDiskSize")]
                            [Validation(Required=false)]
                            public double? UsedDiskSize { get; set; }

                        }

                        /// <summary>
                        /// The information about the memory resources of the node.
                        /// </summary>
                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory Memory { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory : TeaModel {
                            /// <summary>
                            /// The total memory size of the node, in GB.
                            /// </summary>
                            [NameInMap("TotalMemory")]
                            [Validation(Required=false)]
                            public long? TotalMemory { get; set; }

                            /// <summary>
                            /// The size of used memory of the node, in GB.
                            /// </summary>
                            [NameInMap("UsedMemory")]
                            [Validation(Required=false)]
                            public float? UsedMemory { get; set; }

                        }

                    }

                    /// <summary>
                    /// The status of the node.
                    /// </summary>
                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public string NodeStatus { get; set; }

                }

                /// <summary>
                /// The ID of the region.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The storage capacity of the zone.
                /// </summary>
                [NameInMap("ZoneDisk")]
                [Validation(Required=false)]
                public string ZoneDisk { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// The information of zones.
                /// </summary>
                [NameInMap("ZoneResource")]
                [Validation(Required=false)]
                public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource ZoneResource { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource : TeaModel {
                    /// <summary>
                    /// The information about the storage resources of the node.
                    /// </summary>
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize DiskSize { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize : TeaModel {
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

                    }

                }

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
