// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceTopologyResponseBody : TeaModel {
        [NameInMap("InstanceTopology")]
        [Validation(Required=false)]
        public DescribeInstanceTopologyResponseBodyInstanceTopology InstanceTopology { get; set; }
        public class DescribeInstanceTopologyResponseBodyInstanceTopology : TeaModel {
            [NameInMap("Tenants")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenants> Tenants { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenants : TeaModel {
                [NameInMap("PrimaryZoneDeployType")]
                [Validation(Required=false)]
                public string PrimaryZoneDeployType { get; set; }

                [NameInMap("TenantCpu")]
                [Validation(Required=false)]
                public float? TenantCpu { get; set; }

                [NameInMap("TenantDeployType")]
                [Validation(Required=false)]
                public string TenantDeployType { get; set; }

                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                [NameInMap("TenantMemory")]
                [Validation(Required=false)]
                public float? TenantMemory { get; set; }

                [NameInMap("TenantMode")]
                [Validation(Required=false)]
                public string TenantMode { get; set; }

                [NameInMap("TenantName")]
                [Validation(Required=false)]
                public string TenantName { get; set; }

                [NameInMap("TenantStatus")]
                [Validation(Required=false)]
                public string TenantStatus { get; set; }

                [NameInMap("TenantUnitNum")]
                [Validation(Required=false)]
                public int? TenantUnitNum { get; set; }

                [NameInMap("TenantZones")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones> TenantZones { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZones : TeaModel {
                    [NameInMap("IsPrimaryTenantZone")]
                    [Validation(Required=false)]
                    public string IsPrimaryTenantZone { get; set; }

                    [NameInMap("TenantZoneId")]
                    [Validation(Required=false)]
                    public string TenantZoneId { get; set; }

                    [NameInMap("TenantZoneRole")]
                    [Validation(Required=false)]
                    public string TenantZoneRole { get; set; }

                    [NameInMap("Units")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits> Units { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyTenantsTenantZonesUnits : TeaModel {
                        [NameInMap("EnableCancelMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableCancelMigrateUnit { get; set; }

                        [NameInMap("EnableMigrateUnit")]
                        [Validation(Required=false)]
                        public bool? EnableMigrateUnit { get; set; }

                        [NameInMap("ManualMigrate")]
                        [Validation(Required=false)]
                        public bool? ManualMigrate { get; set; }

                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        [NameInMap("UnitCpu")]
                        [Validation(Required=false)]
                        public float? UnitCpu { get; set; }

                        [NameInMap("UnitDataSize")]
                        [Validation(Required=false)]
                        public long? UnitDataSize { get; set; }

                        [NameInMap("UnitId")]
                        [Validation(Required=false)]
                        public string UnitId { get; set; }

                        [NameInMap("UnitMemory")]
                        [Validation(Required=false)]
                        public float? UnitMemory { get; set; }

                        [NameInMap("UnitStatus")]
                        [Validation(Required=false)]
                        public string UnitStatus { get; set; }

                    }

                }

            }

            [NameInMap("Zones")]
            [Validation(Required=false)]
            public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZones> Zones { get; set; }
            public class DescribeInstanceTopologyResponseBodyInstanceTopologyZones : TeaModel {
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes> Nodes { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodes : TeaModel {
                    [NameInMap("NodeCopyId")]
                    [Validation(Required=false)]
                    public long? NodeCopyId { get; set; }

                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    [NameInMap("NodeResource")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource> NodeResource { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResource : TeaModel {
                        [NameInMap("Cpu")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu Cpu { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceCpu : TeaModel {
                            [NameInMap("TotalCpu")]
                            [Validation(Required=false)]
                            public int? TotalCpu { get; set; }

                            [NameInMap("UsedCpu")]
                            [Validation(Required=false)]
                            public float? UsedCpu { get; set; }

                        }

                        [NameInMap("DiskSize")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize DiskSize { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceDiskSize : TeaModel {
                            [NameInMap("TotalDiskSize")]
                            [Validation(Required=false)]
                            public double? TotalDiskSize { get; set; }

                            [NameInMap("UsedDiskSize")]
                            [Validation(Required=false)]
                            public double? UsedDiskSize { get; set; }

                        }

                        [NameInMap("Memory")]
                        [Validation(Required=false)]
                        public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory Memory { get; set; }
                        public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesNodesNodeResourceMemory : TeaModel {
                            [NameInMap("TotalMemory")]
                            [Validation(Required=false)]
                            public long? TotalMemory { get; set; }

                            [NameInMap("UsedMemory")]
                            [Validation(Required=false)]
                            public float? UsedMemory { get; set; }

                        }

                    }

                    [NameInMap("NodeStatus")]
                    [Validation(Required=false)]
                    public string NodeStatus { get; set; }

                }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ZoneDisk")]
                [Validation(Required=false)]
                public string ZoneDisk { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                [NameInMap("ZoneResource")]
                [Validation(Required=false)]
                public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource ZoneResource { get; set; }
                public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResource : TeaModel {
                    [NameInMap("DiskSize")]
                    [Validation(Required=false)]
                    public DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize DiskSize { get; set; }
                    public class DescribeInstanceTopologyResponseBodyInstanceTopologyZonesZoneResourceDiskSize : TeaModel {
                        [NameInMap("MaxDiskUsedObServer")]
                        [Validation(Required=false)]
                        public List<string> MaxDiskUsedObServer { get; set; }

                        [NameInMap("MaxDiskUsedPercent")]
                        [Validation(Required=false)]
                        public double? MaxDiskUsedPercent { get; set; }

                    }

                }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
