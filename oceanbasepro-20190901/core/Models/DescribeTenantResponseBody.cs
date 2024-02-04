// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantResponseBody : TeaModel {
        /// <summary>
        /// The zone information of the tenant.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the zone.
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public DescribeTenantResponseBodyTenant Tenant { get; set; }
        public class DescribeTenantResponseBodyTenant : TeaModel {
            /// <summary>
            /// DescribeTenant
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// The number of CPU cores in each resource unit of the tenant.
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// 地址类型
            /// </summary>
            [NameInMap("ClogServiceStatus")]
            [Validation(Required=false)]
            public string ClogServiceStatus { get; set; }

            /// <summary>
            /// The request ID.
            /// </summary>
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// You can call this operation to create a single tenant in a specific cluster.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            /// <summary>
            /// The list of zones.
            /// </summary>
            [NameInMap("DeployMode")]
            [Validation(Required=false)]
            public string DeployMode { get; set; }

            /// <summary>
            /// The series of the instance.
            /// </summary>
            [NameInMap("DeployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// Indicates whether to enable read/write splitting endpoint.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// You can call this operation to query the information of a specific tenant in a specific cluster.
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// 是否可以申请Binlog服务
            /// </summary>
            [NameInMap("EnableBinlogService")]
            [Validation(Required=false)]
            public bool? EnableBinlogService { get; set; }

            /// <summary>
            /// The intranet address for accessing the tenant.
            /// </summary>
            [NameInMap("EnableClogService")]
            [Validation(Required=false)]
            public bool? EnableClogService { get; set; }

            /// <summary>
            /// The deployment type of the primary zone.
            /// </summary>
            [NameInMap("EnableInternetAddressService")]
            [Validation(Required=false)]
            public bool? EnableInternetAddressService { get; set; }

            [NameInMap("EnableParallelQuery")]
            [Validation(Required=false)]
            public bool? EnableParallelQuery { get; set; }

            [NameInMap("EnableReadOnlyReplica")]
            [Validation(Required=false)]
            public bool? EnableReadOnlyReplica { get; set; }

            [NameInMap("EnableReadWriteSplit")]
            [Validation(Required=false)]
            public bool? EnableReadWriteSplit { get; set; }

            /// <summary>
            /// {
            ///     "RequestId": "EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C",
            ///     "Tenant": {
            ///         "TenantId": "t33h8y08k****",
            ///         "TenantName": "pay_online",
            ///         "TenantMode": "Oracle",
            ///         "VpcId": "vpc-bp1d2q3mhg9i23ofi****",
            ///         "Status": "ONLINE",
            ///         "PrimaryZone": "cn-hangzhou-i",
            ///         "DeployType": "multiple",
            ///         "DeployMode": "1-1-1",
            ///         "Description": "PayCore business database",
            ///         "CreateTime": "2021-09-17 15:52:17",
            ///         "TenantResource": {
            ///             "UnitNum": 1,
            ///             "Cpu": {
            ///                 "UsedCpu": 8,
            ///                 "TotalCpu": 10,
            ///                 "UnitCpu": 8
            ///             },
            ///             "Memory": {
            ///                 "UsedMemory": 30,
            ///                 "TotalMemory": 64,
            ///                 "UnitMemory": 32
            ///             },
            ///             "DiskSize": {
            ///                 "UsedDiskSize": 86
            ///             }
            ///         },
            ///         "TenantConnections": [
            ///             {
            ///                 "ConnectionRole": "ReadWrite",
            ///                 "IntranetAddress": "t32a7ru5u****.oceanbase.aliyuncs.com",
            ///                 "IntranetPort": 3306,
            ///                 "InternetAddress": "t32a7ru5u****mo.oceanbase.aliyuncs.com",
            ///                 "InternetPort": 3306,
            ///                 "VpcId": "vpc-bp1qiail1asmfe23t****",
            ///                 "VSwitchId": "vsw-bp11k1aypnzu1l3whi****",
            ///                 "IntranetAddressMasterZoneId": "cn-hangzhou-i",
            ///                 "IntranetAddressSlaveZoneId": "cn-hangzhou-j",
            ///                 "IntranetAddressStatus": "ONLINE",
            ///                 "ConnectionZones": [
            ///                     "cn-hangzhou-i"
            ///                 ],
            ///                 "InternetAddressStatus": "CLOSED"
            ///             }
            ///         ],
            ///         "TenantZones": [
            ///             {
            ///                 "TenantZoneId": "cn-hangzhou-i",
            ///                 "Region": "cn-hangzhou",
            ///                 "TenantZoneRole": "ReadOnly"
            ///             }
            ///         ],
            ///         "ClogServiceStatus": "CLOSED"
            ///     }
            /// }
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// ```
            /// http(s)://[Endpoint]/?Action=DescribeTenant
            /// &InstanceId=ob317v4uif****
            /// &TenantId=ob2mr3oae0****
            /// &Common request parameters
            /// ```
            /// </summary>
            [NameInMap("MasterIntranetAddressZone")]
            [Validation(Required=false)]
            public string MasterIntranetAddressZone { get; set; }

            [NameInMap("MaxParallelQueryDegree")]
            [Validation(Required=false)]
            public long? MaxParallelQueryDegree { get; set; }

            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// The type of the payment.
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// Example 1
            /// </summary>
            [NameInMap("PrimaryZoneDeployType")]
            [Validation(Required=false)]
            public string PrimaryZoneDeployType { get; set; }

            [NameInMap("ReadOnlyResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantReadOnlyResource ReadOnlyResource { get; set; }
            public class DescribeTenantResponseBodyTenantReadOnlyResource : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceCapacityUnit : TeaModel {
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    [NameInMap("UsedCapacit")]
                    [Validation(Required=false)]
                    public int? UsedCapacit { get; set; }

                }

                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceCpu : TeaModel {
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceDiskSize : TeaModel {
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceLogDiskSize : TeaModel {
                    [NameInMap("TotalLogDisk")]
                    [Validation(Required=false)]
                    public int? TotalLogDisk { get; set; }

                    [NameInMap("UnitLogDisk")]
                    [Validation(Required=false)]
                    public int? UnitLogDisk { get; set; }

                }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceMemory : TeaModel {
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            /// <summary>
            /// <DescribeTenantResponse>
            ///     <RequestId>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</RequestId>
            ///     <Tenant>
            ///         <TenantId>t33h8y08k****</TenantId>
            ///         <TenantName>pay_online</TenantName>
            ///         <TenantMode>Oracle</TenantMode>
            ///         <VpcId>vpc-bp1d2q3mhg9i23ofi****</VpcId>
            ///         <Status>ONLINE</Status>
            ///         <PrimaryZone>cn-hangzhou-i</PrimaryZone>
            ///         <DeployType>multiple</DeployType>
            ///         <DeployMode>1-1-1</DeployMode>
            ///         <Description>PayCore business database</Description>
            ///         <CreateTime>2021-09-17 15:52:17</CreateTime>
            ///         <TenantResource>
            ///             <UnitNum>1</UnitNum>
            ///             <Cpu>
            ///                 <UsedCpu>8</UsedCpu>
            ///                 <TotalCpu>10</TotalCpu>
            ///                 <UnitCpu>8</UnitCpu>
            ///             </Cpu>
            ///             <Memory>
            ///                 <UsedMemory>30</UsedMemory>
            ///                 <TotalMemory>64</TotalMemory>
            ///                 <UnitMemory>32</UnitMemory>
            ///             </Memory>
            ///             <DiskSize>
            ///                 <UsedDiskSize>86</UsedDiskSize>
            ///             </DiskSize>
            ///         </TenantResource>
            ///         <TenantConnections>
            ///             <ConnectionRole>ReadWrite</ConnectionRole>
            ///             <IntranetAddress>t32a7ru5u****.oceanbase.aliyuncs.com</IntranetAddress>
            ///             <IntranetPort>3306</IntranetPort>
            ///             <InternetAddress>t32a7ru5u****mo.oceanbase.aliyuncs.com</InternetAddress>
            ///             <InternetPort>3306</InternetPort>
            ///             <VpcId>vpc-bp1qiail1asmfe23t****</VpcId>
            ///             <VSwitchId>vsw-bp11k1aypnzu1l3whi****</VSwitchId>
            ///             <IntranetAddressMasterZoneId>cn-hangzhou-i</IntranetAddressMasterZoneId>
            ///             <IntranetAddressSlaveZoneId>cn-hangzhou-j</IntranetAddressSlaveZoneId>
            ///             <IntranetAddressStatus>ONLINE</IntranetAddressStatus>
            ///             <ConnectionZones>cn-hangzhou-i</ConnectionZones>
            ///             <InternetAddressStatus>CLOSED</InternetAddressStatus>
            ///         </TenantConnections>
            ///         <TenantZones>
            ///             <TenantZoneId>cn-hangzhou-i</TenantZoneId>
            ///             <Region>cn-hangzhou</Region>
            ///             <TenantZoneRole>ReadOnly</TenantZoneRole>
            ///         </TenantZones>
            ///         <ClogServiceStatus>CLOSED</ClogServiceStatus>
            ///     </Tenant>
            /// </DescribeTenantResponse>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// The character set.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
            [NameInMap("TenantConnections")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantConnections> TenantConnections { get; set; }
            public class DescribeTenantResponseBodyTenantTenantConnections : TeaModel {
                /// <summary>
                /// The primary zone of the tenant.
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                [NameInMap("ConnectionReplicaType")]
                [Validation(Required=false)]
                public string ConnectionReplicaType { get; set; }

                /// <summary>
                /// The Internet address for accessing the tenant.
                /// </summary>
                [NameInMap("ConnectionZones")]
                [Validation(Required=false)]
                public List<string> ConnectionZones { get; set; }

                [NameInMap("EnableTransactionSplit")]
                [Validation(Required=false)]
                public bool? EnableTransactionSplit { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("InternetAddress")]
                [Validation(Required=false)]
                public string InternetAddress { get; set; }

                /// <summary>
                /// 实例系列
                /// </summary>
                [NameInMap("InternetAddressStatus")]
                [Validation(Required=false)]
                public string InternetAddressStatus { get; set; }

                /// <summary>
                /// 实例类型
                /// </summary>
                [NameInMap("InternetPort")]
                [Validation(Required=false)]
                public int? InternetPort { get; set; }

                /// <summary>
                /// The deployment type of the cluster. Valid values:  
                /// - multiple: multi-IDC deployment   
                /// - single: single-IDC deployment   
                /// - dual: dual-IDC deployment
                /// </summary>
                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                /// <summary>
                /// PayCore business database
                /// </summary>
                [NameInMap("IntranetAddressMasterZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressMasterZoneId { get; set; }

                /// <summary>
                /// The total number of CPU cores of the tenant.
                /// </summary>
                [NameInMap("IntranetAddressSlaveZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressSlaveZoneId { get; set; }

                /// <summary>
                /// 付费类型
                /// </summary>
                [NameInMap("IntranetAddressStatus")]
                [Validation(Required=false)]
                public string IntranetAddressStatus { get; set; }

                /// <summary>
                /// The ID of the tenant.
                /// </summary>
                [NameInMap("IntranetPort")]
                [Validation(Required=false)]
                public int? IntranetPort { get; set; }

                [NameInMap("MaxConnectionNum")]
                [Validation(Required=false)]
                public long? MaxConnectionNum { get; set; }

                [NameInMap("ParallelQueryDegree")]
                [Validation(Required=false)]
                public long? ParallelQueryDegree { get; set; }

                [NameInMap("TenantEndpointId")]
                [Validation(Required=false)]
                public string TenantEndpointId { get; set; }

                /// <summary>
                /// The primary zone corresponding to the address for accessing the tenant.
                /// </summary>
                [NameInMap("TransactionSplit")]
                [Validation(Required=false)]
                public bool? TransactionSplit { get; set; }

                /// <summary>
                /// The connection access information of the tenant.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The service mode of the connection address. Valid values:  
                /// ReadWrite: provides strong-consistency read and write services.   
                /// ReadOnly: provides the read-only service to ensure ultimate consistency of data.   
                /// Clog: provides transaction log services.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// The region where the zone of the tenant resides.
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// The enabling status of the clog service.  
            /// - CLOSED: The clog service is disabled.  
            /// - ONLINE: The clog service is running.
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// The request type of the zone of the tenant.  ReadWrite: The zone supports data reads and writes. ReadOnly: The zone supports only data reads. For a high availability cluster with multiple IDCs, the primary zone provides ReadWrite services, and the standby zone provides ReadOnly services. For a high availability cluster with a single IDC, all zones provide ReadWrite services.
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// It is an online CLI tool that allows you to quickly retrieve and debug APIs. It can dynamically generate executable SDK code samples.
            /// </summary>
            [NameInMap("TenantResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantTenantResource TenantResource { get; set; }
            public class DescribeTenantResponseBodyTenantTenantResource : TeaModel {
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCapacityUnit : TeaModel {
                    [NameInMap("MaxCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MaxCapacityUnit { get; set; }

                    [NameInMap("MinCapacityUnit")]
                    [Validation(Required=false)]
                    public int? MinCapacityUnit { get; set; }

                    [NameInMap("UsedCapacit")]
                    [Validation(Required=false)]
                    public int? UsedCapacit { get; set; }

                }

                /// <summary>
                /// The enabling status of the Clog service.  
                /// CLOSED: The Clog service is disabled.  
                /// - ONLINE: The Clog service is running.
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCpu : TeaModel {
                    /// <summary>
                    /// The data replica distribution mode of the tenant.    
                    /// 
                    /// - For the high availability version, N-N-N indicates the three-zone mode, and N-N indicates the dual-zone or single-zone mode.
                    /// - For the basic version, N indicates the single-zone mode. 
                    /// 
                    /// > <br>N represents the number of nodes in a single zone.
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    /// <summary>
                    /// The zone corresponding to the tenant connection.
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    /// <summary>
                    /// The tenant mode.   
                    /// Valid values: 
                    /// Oracle   
                    /// MySQL
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                /// <summary>
                /// The status of the intranet address for accessing the tenant.  
                /// The value ONLINE indicates that the address is in service.
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceDiskSize : TeaModel {
                    /// <summary>
                    /// The total memory size of the tenant, in GB.
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceLogDiskSize : TeaModel {
                    [NameInMap("TotalLogDisk")]
                    [Validation(Required=false)]
                    public int? TotalLogDisk { get; set; }

                    [NameInMap("UnitLogDisk")]
                    [Validation(Required=false)]
                    public int? UnitLogDisk { get; set; }

                }

                /// <summary>
                /// The description of the tenant.
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceMemory : TeaModel {
                    /// <summary>
                    /// The information about the memory resources of the tenant.
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// The time when the tenant was created.
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    /// <summary>
                    /// The status of the Internet address for accessing the tenant. Valid values:   
                    /// Closed: The address is disabled.   
                    /// - ALLOCATING_INTERNET_ADDRESS: An address is being applied for.   
                    /// - PENDING_OFFLINE_INTERNET_ADDRESS: The address is being disabled.   
                    /// - ONLINE: The address is in service.
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                /// <summary>
                /// Alibaba Cloud CLI
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            /// <summary>
            /// The standby zone corresponding to the address for accessing the tenant.
            /// </summary>
            [NameInMap("TenantZones")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantZones> TenantZones { get; set; }
            public class DescribeTenantResponseBodyTenantTenantZones : TeaModel {
                /// <summary>
                /// 是否允许开启读写分离地址
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// The intranet port for accessing the tenant.
                /// </summary>
                [NameInMap("TenantZoneId")]
                [Validation(Required=false)]
                public string TenantZoneId { get; set; }

                [NameInMap("TenantZoneReplicas")]
                [Validation(Required=false)]
                public List<DescribeTenantResponseBodyTenantTenantZonesTenantZoneReplicas> TenantZoneReplicas { get; set; }
                public class DescribeTenantResponseBodyTenantTenantZonesTenantZoneReplicas : TeaModel {
                    [NameInMap("FullCopyId")]
                    [Validation(Required=false)]
                    public int? FullCopyId { get; set; }

                    [NameInMap("LogicZoneName")]
                    [Validation(Required=false)]
                    public string LogicZoneName { get; set; }

                    [NameInMap("ReadOnlyCopyId")]
                    [Validation(Required=false)]
                    public string ReadOnlyCopyId { get; set; }

                    [NameInMap("ZoneCopyId")]
                    [Validation(Required=false)]
                    public int? ZoneCopyId { get; set; }

                    [NameInMap("ZoneNodes")]
                    [Validation(Required=false)]
                    public string ZoneNodes { get; set; }

                    [NameInMap("ZoneReplicaType")]
                    [Validation(Required=false)]
                    public string ZoneReplicaType { get; set; }

                }

                /// <summary>
                /// The character set.
                /// </summary>
                [NameInMap("TenantZoneRole")]
                [Validation(Required=false)]
                public string TenantZoneRole { get; set; }

            }

            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            /// <summary>
            /// Indicates whether the clog service is available. To enable the clog service, submit a ticket.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
