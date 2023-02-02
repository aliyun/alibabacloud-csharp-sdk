// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the tenant.
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public DescribeTenantResponseBodyTenant Tenant { get; set; }
        public class DescribeTenantResponseBodyTenant : TeaModel {
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// The enabling status of the Clog service.  
            /// CLOSED: The Clog service is disabled.   
            /// - ONLINE: The Clog service is running.
            /// </summary>
            [NameInMap("ClogServiceStatus")]
            [Validation(Required=false)]
            public string ClogServiceStatus { get; set; }

            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// The time when the tenant was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The data replica distribution mode of the tenant.    
            /// 
            /// - For the high availability version, N-N-N indicates the three-zone mode, and N-N indicates the dual-zone or single-zone mode.
            /// - For the basic version, N indicates the single-zone mode. 
            /// 
            /// > <br>N represents the number of nodes in a single zone.
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
            /// The description of the tenant.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// Indicates whether the Clog service is available. To enable the Clog service, submit a ticket.
            /// </summary>
            [NameInMap("EnableClogService")]
            [Validation(Required=false)]
            public bool? EnableClogService { get; set; }

            /// <summary>
            /// Indicates whether the Internet address can be enabled for the tenant.
            /// </summary>
            [NameInMap("EnableInternetAddressService")]
            [Validation(Required=false)]
            public bool? EnableInternetAddressService { get; set; }

            [NameInMap("EnableReadWriteSplit")]
            [Validation(Required=false)]
            public bool? EnableReadWriteSplit { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("MasterIntranetAddressZone")]
            [Validation(Required=false)]
            public string MasterIntranetAddressZone { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The primary zone of the tenant.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("PrimaryZoneDeployType")]
            [Validation(Required=false)]
            public string PrimaryZoneDeployType { get; set; }

            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The connection access information of the tenant.
            /// </summary>
            [NameInMap("TenantConnections")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantConnections> TenantConnections { get; set; }
            public class DescribeTenantResponseBodyTenantTenantConnections : TeaModel {
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// The service mode of the connection address. Valid values:  
                /// ReadWrite: provides strong-consistency read and write services.   
                /// ReadOnly: provides the read-only service to ensure ultimate consistency of data.   
                /// Clog: provides transaction log services.
                /// </summary>
                [NameInMap("ConnectionRole")]
                [Validation(Required=false)]
                public string ConnectionRole { get; set; }

                /// <summary>
                /// The list of zones corresponding to the tenant connection.
                /// </summary>
                [NameInMap("ConnectionZones")]
                [Validation(Required=false)]
                public List<string> ConnectionZones { get; set; }

                /// <summary>
                /// The Internet address for accessing the tenant.
                /// </summary>
                [NameInMap("InternetAddress")]
                [Validation(Required=false)]
                public string InternetAddress { get; set; }

                /// <summary>
                /// The status of the Internet address for accessing the tenant. Valid values:   
                /// Closed: The address is disabled.   
                /// - ALLOCATING_INTERNET_ADDRESS: An address is being applied for.   
                /// - PENDING_OFFLINE_INTERNET_ADDRESS: The address is being disabled.   
                /// - ONLINE: The address is in service.
                /// </summary>
                [NameInMap("InternetAddressStatus")]
                [Validation(Required=false)]
                public string InternetAddressStatus { get; set; }

                /// <summary>
                /// The Internet port for accessing the tenant.
                /// </summary>
                [NameInMap("InternetPort")]
                [Validation(Required=false)]
                public int? InternetPort { get; set; }

                /// <summary>
                /// The intranet address for accessing the tenant.
                /// </summary>
                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                /// <summary>
                /// The primary zone corresponding to the address for accessing the tenant.
                /// </summary>
                [NameInMap("IntranetAddressMasterZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressMasterZoneId { get; set; }

                /// <summary>
                /// The standby zone corresponding to the address for accessing the tenant.
                /// </summary>
                [NameInMap("IntranetAddressSlaveZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressSlaveZoneId { get; set; }

                /// <summary>
                /// The status of the intranet address for accessing the tenant.  
                /// The value ONLINE indicates that the address is in service.
                /// </summary>
                [NameInMap("IntranetAddressStatus")]
                [Validation(Required=false)]
                public string IntranetAddressStatus { get; set; }

                /// <summary>
                /// The intranet port for accessing the tenant.
                /// </summary>
                [NameInMap("IntranetPort")]
                [Validation(Required=false)]
                public int? IntranetPort { get; set; }

                [NameInMap("TransactionSplit")]
                [Validation(Required=false)]
                public bool? TransactionSplit { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The tenant mode.   
            /// Valid values: 
            /// Oracle   
            /// MySQL
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
            /// The resource information of the tenant.
            /// </summary>
            [NameInMap("TenantResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantTenantResource TenantResource { get; set; }
            public class DescribeTenantResponseBodyTenantTenantResource : TeaModel {
                /// <summary>
                /// The information about the CPU resources of the tenant.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCpu : TeaModel {
                    /// <summary>
                    /// The total number of CPU cores of the tenant.
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    /// <summary>
                    /// The number of CPU cores in each resource unit of the tenant.
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    /// <summary>
                    /// The number of used CPU cores of the tenant.
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                /// <summary>
                /// The information about the disk resources of the tenant.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceDiskSize : TeaModel {
                    /// <summary>
                    /// The size of used disk space of the tenant, in GB.
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// The information about the memory resources of the tenant.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceMemory : TeaModel {
                    /// <summary>
                    /// The total memory size of the tenant, in GB.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// The memory size of each resource unit of the tenant, in GB.
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    /// <summary>
                    /// The size of used memory of the tenant, in GB.
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                /// <summary>
                /// The number of resource units in the tenant.
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            /// <summary>
            /// The zone information of the tenant.
            /// </summary>
            [NameInMap("TenantZones")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantZones> TenantZones { get; set; }
            public class DescribeTenantResponseBodyTenantTenantZones : TeaModel {
                /// <summary>
                /// The region where the zone of the tenant resides.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The ID of the zone.
                /// </summary>
                [NameInMap("TenantZoneId")]
                [Validation(Required=false)]
                public string TenantZoneId { get; set; }

                /// <summary>
                /// The role of the zone of the tenant.
                /// </summary>
                [NameInMap("TenantZoneRole")]
                [Validation(Required=false)]
                public string TenantZoneRole { get; set; }

            }

            /// <summary>
            /// The ID of the VPC.    
            /// If no suitable VPC is available, create a VPC as prompted. For more information, see "What is a VPC".
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
