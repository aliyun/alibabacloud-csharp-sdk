// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeTenantResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE205C00-30E4-XXXX-XXXX-87E3A8A2AA0C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the tenant.</para>
        /// </summary>
        [NameInMap("Tenant")]
        [Validation(Required=false)]
        public DescribeTenantResponseBodyTenant Tenant { get; set; }
        public class DescribeTenantResponseBodyTenant : TeaModel {
            /// <summary>
            /// <para>The list of zones.</para>
            /// </summary>
            [NameInMap("AvailableZones")]
            [Validation(Required=false)]
            public List<string> AvailableZones { get; set; }

            /// <summary>
            /// <para>The character set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4</para>
            /// </summary>
            [NameInMap("Charset")]
            [Validation(Required=false)]
            public string Charset { get; set; }

            /// <summary>
            /// <para>The enabling status of the clog service.  </para>
            /// <list type="bullet">
            /// <item><description>CLOSED: The clog service is disabled.  </description></item>
            /// <item><description>ONLINE: The clog service is running.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CLOSED</para>
            /// </summary>
            [NameInMap("ClogServiceStatus")]
            [Validation(Required=false)]
            public string ClogServiceStatus { get; set; }

            /// <summary>
            /// <para>The collation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>utf8mb4_general_ci</para>
            /// </summary>
            [NameInMap("Collation")]
            [Validation(Required=false)]
            public string Collation { get; set; }

            /// <summary>
            /// <para>The time when the tenant was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-21 11:15:47.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The major compaction time of the tenant. This parameter is supported only in OceanBase Database V4.0.0 and later.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:36Z</para>
            /// </summary>
            [NameInMap("DataMergeTime")]
            [Validation(Required=false)]
            public string DataMergeTime { get; set; }

            /// <summary>
            /// <para>The data replica distribution mode of the tenant.    </para>
            /// <list type="bullet">
            /// <item><description>For the high availability version, N-N-N indicates the three-zone mode, and N-N indicates the dual-zone or single-zone mode.</description></item>
            /// <item><description>For the basic version, N indicates the single-zone mode.</description></item>
            /// </list>
            /// <remarks>
            /// <para><br>N represents the number of nodes in a single zone.</para>
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
            /// <para>The description of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>paycore database</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The type of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd_pl1</para>
            /// </summary>
            [NameInMap("DiskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>Indicates whether the binlog service is available for application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableBinlogService")]
            [Validation(Required=false)]
            public bool? EnableBinlogService { get; set; }

            /// <summary>
            /// <para>Indicates whether the clog service is available. To enable the clog service, submit a ticket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableClogService")]
            [Validation(Required=false)]
            public bool? EnableClogService { get; set; }

            /// <summary>
            /// <para>Indicates whether the Internet address can be enabled for the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableInternetAddressService")]
            [Validation(Required=false)]
            public bool? EnableInternetAddressService { get; set; }

            /// <summary>
            /// <para>Indicates whether parallel query can be enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableParallelQuery")]
            [Validation(Required=false)]
            public bool? EnableParallelQuery { get; set; }

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
            /// <para>Indicates whether to enable read/write splitting endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableReadWriteSplit")]
            [Validation(Required=false)]
            public bool? EnableReadWriteSplit { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KAFKA_PUBLIC</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>Indicates whether the table name is case-sensitive. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The table name is case-insensitive. </description></item>
            /// <item><description><b>0</b>: The table name is case-sensitive.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LowerCaseTableNames")]
            [Validation(Required=false)]
            public int? LowerCaseTableNames { get; set; }

            /// <summary>
            /// <para>The zone where the primary node is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("MasterIntranetAddressZone")]
            [Validation(Required=false)]
            public string MasterIntranetAddressZone { get; set; }

            /// <summary>
            /// <para>The maximum value of DOP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("MaxParallelQueryDegree")]
            [Validation(Required=false)]
            public long? MaxParallelQueryDegree { get; set; }

            /// <summary>
            /// <para>The ODP version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.3.1-xxxxxxxxx</para>
            /// </summary>
            [NameInMap("OdpVersion")]
            [Validation(Required=false)]
            public string OdpVersion { get; set; }

            /// <summary>
            /// <para>The parameter template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>express_oltp</para>
            /// </summary>
            [NameInMap("ParameterTemplate")]
            [Validation(Required=false)]
            public string ParameterTemplate { get; set; }

            /// <summary>
            /// <para>The type of the payment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>POSTPAY</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The primary zone of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The deployment type of the primary zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RANDOM</para>
            /// </summary>
            [NameInMap("PrimaryZoneDeployType")]
            [Validation(Required=false)]
            public string PrimaryZoneDeployType { get; set; }

            /// <summary>
            /// <para>The information about read-only resources.</para>
            /// </summary>
            [NameInMap("ReadOnlyResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantReadOnlyResource ReadOnlyResource { get; set; }
            public class DescribeTenantResponseBodyTenantReadOnlyResource : TeaModel {
                /// <summary>
                /// <para>The information about capacity units.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceCapacityUnit : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of capacity units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
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
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("UsedCapacit")]
                    [Validation(Required=false)]
                    public int? UsedCapacit { get; set; }

                }

                /// <summary>
                /// <para>The number of CPU cores of each replica node in the cluster.</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceCpu : TeaModel {
                    /// <summary>
                    /// <para>The total number of CPU cores of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores in each resource unit of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores used by the cluster.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                /// <summary>
                /// <para>The size of the data disk.</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The size of disk space used by the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The information about the log disk resources of the tenant.</para>
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceLogDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The total log disk size of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("TotalLogDisk")]
                    [Validation(Required=false)]
                    public int? TotalLogDisk { get; set; }

                    /// <summary>
                    /// <para>The log disk size of each resource unit of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("UnitLogDisk")]
                    [Validation(Required=false)]
                    public int? UnitLogDisk { get; set; }

                }

                /// <summary>
                /// <para>The information about the memory resources of the cluster.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantReadOnlyResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantReadOnlyResourceMemory : TeaModel {
                    /// <summary>
                    /// <para>The total memory size of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// <para>The memory size of each resource unit of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    /// <summary>
                    /// <para>The size of memory used by the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                /// <summary>
                /// <para>The number of resource units in the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            /// <summary>
            /// <para>The status of the recycle bin in the tenant. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>ON: The recycly bin is enabled. </description></item>
            /// <item><description>OFF: The recycle bin is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ON</para>
            /// </summary>
            [NameInMap("RecycleBinStatus")]
            [Validation(Required=false)]
            public string RecycleBinStatus { get; set; }

            /// <summary>
            /// <para>The series of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <para>The status of the tenant.</para>
            /// <list type="bullet">
            /// <item><description><para>ONLINE: The tenant is running.</para>
            /// </description></item>
            /// <item><description><para>PENDING_CREATE: The tenant is being created.</para>
            /// </description></item>
            /// <item><description><para>WAITING_ALLOCATE_MASTER_ADDRESS: The standby cluster is waiting for the primary address to be created.</para>
            /// </description></item>
            /// <item><description><para>ALLOCATING_MASTER_ADDRESS: The primary address is being created.</para>
            /// </description></item>
            /// <item><description><para>DELETING_MASTER_ADDRESS: The primary address is being deleted.</para>
            /// </description></item>
            /// <item><description><para>ALLOCATING_INTERNET_ADDRESS: The Internet address is being created.</para>
            /// </description></item>
            /// <item><description><para>PENDING_OFFLINE_INTERNET_ADDRESS: The Internet address is being deleted.</para>
            /// </description></item>
            /// <item><description><para>ALLOCATING_READONLY_ADDRESS: The read-only address is being created.</para>
            /// </description></item>
            /// <item><description><para>DELETING_READONLY_ADDRESS: The read-only address is being deleted.</para>
            /// </description></item>
            /// <item><description><para>ALLOCATING_READWRITE_ADDRESS: The read/write splitting address is being created.</para>
            /// </description></item>
            /// <item><description><para>DELETING_READWRITE_ADDRESS: The read/write splitting address is being deleted.</para>
            /// </description></item>
            /// <item><description><para>ALLOCATING_CLOGSERVICE_ADDRESS: The clog address is being created.</para>
            /// </description></item>
            /// <item><description><para>DELETING_CLOGSERVICE_ADDRESS: The clog address is being deleted.</para>
            /// </description></item>
            /// <item><description><para>MODIFYING_ADDRESS: The domain name of the address is being modified.</para>
            /// </description></item>
            /// <item><description><para>MODIFYING_PRIMARY_ZONE: The primary zone is being switched.</para>
            /// </description></item>
            /// <item><description><para>MODIFYING_READONLY_ADDRESS: The read-only address is being modified.</para>
            /// </description></item>
            /// <item><description><para>MODIFYING_READWRITE_ADDRESS: The read/write splitting address is being modified.</para>
            /// </description></item>
            /// <item><description><para>SPEC_MODIFYING: The specifications of the tenant are being modified.</para>
            /// </description></item>
            /// <item><description><para>WHITE_LIST_MODIFYING: The allowlist is being modified.</para>
            /// </description></item>
            /// <item><description><para>CREATING_BINLOG: Binlogs are being created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ONLINE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The connection information of the tenant.</para>
            /// </summary>
            [NameInMap("TenantConnections")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantConnections> TenantConnections { get; set; }
            public class DescribeTenantResponseBodyTenantTenantConnections : TeaModel {
                /// <summary>
                /// <para>The type of the address.</para>
                /// <list type="bullet">
                /// <item><description>MASTER: the primary address, which supports both data read and write.</description></item>
                /// <item><description>READONLY: a read-only address.</description></item>
                /// <item><description>READWRITE: a read/write splitting address.</description></item>
                /// <item><description>CLOGSERVICE: a clog service address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>READONLY</para>
                /// </summary>
                [NameInMap("AddressType")]
                [Validation(Required=false)]
                public string AddressType { get; set; }

                /// <summary>
                /// <para>The logical zones of the endpoints.</para>
                /// </summary>
                [NameInMap("ConnectionLogicalZones")]
                [Validation(Required=false)]
                public List<string> ConnectionLogicalZones { get; set; }

                /// <summary>
                /// <para>The type of the replica corresponding to the tenant connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FULL</para>
                /// </summary>
                [NameInMap("ConnectionReplicaType")]
                [Validation(Required=false)]
                public string ConnectionReplicaType { get; set; }

                /// <summary>
                /// <para>The list of zones corresponding to the tenant connection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;cn-hangzhou-i&quot;, &quot;cn-hangzhou-j&quot;]</para>
                /// </summary>
                [NameInMap("ConnectionZones")]
                [Validation(Required=false)]
                public List<string> ConnectionZones { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable transaction splitting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableTransactionSplit")]
                [Validation(Required=false)]
                public bool? EnableTransactionSplit { get; set; }

                /// <summary>
                /// <para>The Internet address for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t32a7ru5u****mo.oceanbase.aliyuncs.com</para>
                /// </summary>
                [NameInMap("InternetAddress")]
                [Validation(Required=false)]
                public string InternetAddress { get; set; }

                /// <summary>
                /// <para>The status of the Internet address for accessing the tenant. Valid values:   </para>
                /// <list type="bullet">
                /// <item><description>CLOSED: The address is disabled.   </description></item>
                /// <item><description>ALLOCATING_INTERNET_ADDRESS: An address is being applied for.   </description></item>
                /// <item><description>PENDING_OFFLINE_INTERNET_ADDRESS: The address is being disabled.   </description></item>
                /// <item><description>ONLINE: The address is in service.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CLOSED</para>
                /// </summary>
                [NameInMap("InternetAddressStatus")]
                [Validation(Required=false)]
                public string InternetAddressStatus { get; set; }

                /// <summary>
                /// <para>The upper limit of the maximum number of public connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4000</para>
                /// </summary>
                [NameInMap("InternetMaxConnectionLimit")]
                [Validation(Required=false)]
                public long? InternetMaxConnectionLimit { get; set; }

                /// <summary>
                /// <para>The current value set for the maximum number of public connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2500</para>
                /// </summary>
                [NameInMap("InternetMaxConnectionNum")]
                [Validation(Required=false)]
                public long? InternetMaxConnectionNum { get; set; }

                /// <summary>
                /// <para>The Internet port for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("InternetPort")]
                [Validation(Required=false)]
                public int? InternetPort { get; set; }

                /// <summary>
                /// <para>The port for direct loads of public connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3307</para>
                /// </summary>
                [NameInMap("InternetRpcPort")]
                [Validation(Required=false)]
                public int? InternetRpcPort { get; set; }

                /// <summary>
                /// <para>The intranet address for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t4nunwxr0****.oceanbase.aliyuncs.com</para>
                /// </summary>
                [NameInMap("IntranetAddress")]
                [Validation(Required=false)]
                public string IntranetAddress { get; set; }

                /// <summary>
                /// <para>The primary zone corresponding to the address for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
                [NameInMap("IntranetAddressMasterZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressMasterZoneId { get; set; }

                /// <summary>
                /// <para>The standby zone corresponding to the address for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("IntranetAddressSlaveZoneId")]
                [Validation(Required=false)]
                public string IntranetAddressSlaveZoneId { get; set; }

                /// <summary>
                /// <para>The status of the intranet address for accessing the tenant.<br>The value ONLINE indicates that the address is in service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("IntranetAddressStatus")]
                [Validation(Required=false)]
                public string IntranetAddressStatus { get; set; }

                /// <summary>
                /// <para>The intranet port for accessing the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2983</para>
                /// </summary>
                [NameInMap("IntranetPort")]
                [Validation(Required=false)]
                public int? IntranetPort { get; set; }

                /// <summary>
                /// <para>The port for direct loads of private connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3307</para>
                /// </summary>
                [NameInMap("IntranetRpcPort")]
                [Validation(Required=false)]
                public int? IntranetRpcPort { get; set; }

                /// <summary>
                /// <para>The port of private SQL connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3306</para>
                /// </summary>
                [NameInMap("IntranetSqlPort")]
                [Validation(Required=false)]
                public int? IntranetSqlPort { get; set; }

                /// <summary>
                /// <para>The current value set for the maximum number of private connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxConnectionLimit")]
                [Validation(Required=false)]
                public long? MaxConnectionLimit { get; set; }

                /// <summary>
                /// <para>The maximum number of connections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("MaxConnectionNum")]
                [Validation(Required=false)]
                public long? MaxConnectionNum { get; set; }

                /// <summary>
                /// <para>The ODP version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.3.1-xxxxxxxxx</para>
                /// </summary>
                [NameInMap("OdpVersion")]
                [Validation(Required=false)]
                public string OdpVersion { get; set; }

                /// <summary>
                /// <para>The degree of parallelism (DOP).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParallelQueryDegree")]
                [Validation(Required=false)]
                public long? ParallelQueryDegree { get; set; }

                /// <summary>
                /// <para>The ID of the OceanBase Database Proxy (ODP) cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>proxy-xxxxxxx</para>
                /// </summary>
                [NameInMap("ProxyClusterId")]
                [Validation(Required=false)]
                public string ProxyClusterId { get; set; }

                /// <summary>
                /// <para>The ID of the tenant endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>obe-4tw51gp7****</para>
                /// </summary>
                [NameInMap("TenantEndpointId")]
                [Validation(Required=false)]
                public string TenantEndpointId { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable transaction splitting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("TransactionSplit")]
                [Validation(Required=false)]
                public bool? TransactionSplit { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1i7b94u2et716yl****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1qiail1asmfe23t****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

            /// <summary>
            /// <para>The ID of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t4louaeei****</para>
            /// </summary>
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

            /// <summary>
            /// <para>The maximum number of connections allowed in the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600</para>
            /// </summary>
            [NameInMap("TenantMaxConnections")]
            [Validation(Required=false)]
            public string TenantMaxConnections { get; set; }

            /// <summary>
            /// <para>The mode of the tenant.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Oracle   </description></item>
            /// <item><description>MySQL</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("TenantMode")]
            [Validation(Required=false)]
            public string TenantMode { get; set; }

            /// <summary>
            /// <para>The name of the tenant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>forMySQLTenant</para>
            /// </summary>
            [NameInMap("TenantName")]
            [Validation(Required=false)]
            public string TenantName { get; set; }

            /// <summary>
            /// <para>The resource information of the tenant.</para>
            /// </summary>
            [NameInMap("TenantResource")]
            [Validation(Required=false)]
            public DescribeTenantResponseBodyTenantTenantResource TenantResource { get; set; }
            public class DescribeTenantResponseBodyTenantTenantResource : TeaModel {
                /// <summary>
                /// <para>The information about capacity units.</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCapacityUnit CapacityUnit { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCapacityUnit : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of capacity units.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
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
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("UsedCapacit")]
                    [Validation(Required=false)]
                    public int? UsedCapacit { get; set; }

                }

                /// <summary>
                /// <para>The information about the CPU resources of the tenant.</para>
                /// </summary>
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceCpu Cpu { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceCpu : TeaModel {
                    /// <summary>
                    /// <para>The total number of CPU cores of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TotalCpu")]
                    [Validation(Required=false)]
                    public float? TotalCpu { get; set; }

                    /// <summary>
                    /// <para>The number of CPU cores in each resource unit of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("UnitCpu")]
                    [Validation(Required=false)]
                    public float? UnitCpu { get; set; }

                    /// <summary>
                    /// <para>The number of used CPU cores of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("UsedCpu")]
                    [Validation(Required=false)]
                    public float? UsedCpu { get; set; }

                }

                /// <summary>
                /// <para>The information about the disk resources of the tenant.</para>
                /// </summary>
                [NameInMap("DiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceDiskSize DiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The size of used disk space of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>86</para>
                    /// </summary>
                    [NameInMap("UsedDiskSize")]
                    [Validation(Required=false)]
                    public float? UsedDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The information about the log disk resources of the tenant.</para>
                /// </summary>
                [NameInMap("LogDiskSize")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceLogDiskSize LogDiskSize { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceLogDiskSize : TeaModel {
                    /// <summary>
                    /// <para>The total size of log disk of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("TotalLogDisk")]
                    [Validation(Required=false)]
                    public int? TotalLogDisk { get; set; }

                    /// <summary>
                    /// <para>The log disk size of each resource unit of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8.0</para>
                    /// </summary>
                    [NameInMap("UnitLogDisk")]
                    [Validation(Required=false)]
                    public int? UnitLogDisk { get; set; }

                }

                /// <summary>
                /// <para>The information about the memory resources of the tenant.</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public DescribeTenantResponseBodyTenantTenantResourceMemory Memory { get; set; }
                public class DescribeTenantResponseBodyTenantTenantResourceMemory : TeaModel {
                    /// <summary>
                    /// <para>The total memory size of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("TotalMemory")]
                    [Validation(Required=false)]
                    public float? TotalMemory { get; set; }

                    /// <summary>
                    /// <para>The memory size of each resource unit of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("UnitMemory")]
                    [Validation(Required=false)]
                    public float? UnitMemory { get; set; }

                    /// <summary>
                    /// <para>The size of used memory of the tenant, in GB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("UsedMemory")]
                    [Validation(Required=false)]
                    public float? UsedMemory { get; set; }

                }

                /// <summary>
                /// <para>The number of resource units for the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UnitNum")]
                [Validation(Required=false)]
                public int? UnitNum { get; set; }

            }

            /// <summary>
            /// <para>The information about zones in the tenant.</para>
            /// </summary>
            [NameInMap("TenantZones")]
            [Validation(Required=false)]
            public List<DescribeTenantResponseBodyTenantTenantZones> TenantZones { get; set; }
            public class DescribeTenantResponseBodyTenantTenantZones : TeaModel {
                /// <summary>
                /// <para>The region where the zone of the tenant resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

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
                /// <para>The zone replicas of the tenant.</para>
                /// </summary>
                [NameInMap("TenantZoneReplicas")]
                [Validation(Required=false)]
                public List<DescribeTenantResponseBodyTenantTenantZonesTenantZoneReplicas> TenantZoneReplicas { get; set; }
                public class DescribeTenantResponseBodyTenantTenantZonesTenantZoneReplicas : TeaModel {
                    /// <summary>
                    /// <para>The ID of the full-featured replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("FullCopyId")]
                    [Validation(Required=false)]
                    public int? FullCopyId { get; set; }

                    /// <summary>
                    /// <para>The name of the logical zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai-f-z0</para>
                    /// </summary>
                    [NameInMap("LogicZoneName")]
                    [Validation(Required=false)]
                    public string LogicZoneName { get; set; }

                    /// <summary>
                    /// <para>The ID of the read-only replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("ReadOnlyCopyId")]
                    [Validation(Required=false)]
                    public string ReadOnlyCopyId { get; set; }

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
                    /// <para>The ID of the zone replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("ZoneCopyId")]
                    [Validation(Required=false)]
                    public int? ZoneCopyId { get; set; }

                    /// <summary>
                    /// <para>The number of nodes in the zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ZoneNodes")]
                    [Validation(Required=false)]
                    public long? ZoneNodes { get; set; }

                    /// <summary>
                    /// <para>The type of the zone replica.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>FULL</para>
                    /// </summary>
                    [NameInMap("ZoneReplicaType")]
                    [Validation(Required=false)]
                    public string ZoneReplicaType { get; set; }

                }

                /// <summary>
                /// <para>The role of the zone of the tenant.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ReadWrite</para>
                /// </summary>
                [NameInMap("TenantZoneRole")]
                [Validation(Required=false)]
                public string TenantZoneRole { get; set; }

            }

            /// <summary>
            /// <para>The time zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Asia/Shanghai</para>
            /// </summary>
            [NameInMap("TimeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }

            /// <summary>
            /// <para>The version information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4.2.1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The Virtual Private Cloud (VPC) ID of the tenant. If no suitable VPC is available, create a VPC as prompted. For more information, see &quot;What is a VPC&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1d2q3mhg9i23ofi****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
