// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>16-digit AliUid of the Alibaba Cloud primary account (main account).</para>
        /// 
        /// <b>Example:</b>
        /// <para>164901546557****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>Multi-AZ instance, coordinating Availability Zone virtual switch ID, which must be located in the Availability Zone corresponding to ArbiterZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, coordinating Availability Zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>The architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0</b>: The instance is deployed in a single zone.</description></item>
        /// <item><description><b>2.0</b>: The instance is deployed across multiple zones.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The Archive storage size of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0GB</para>
        /// </summary>
        [NameInMap("ArchiveStorage")]
        [Validation(Required=false)]
        public int? ArchiveStorage { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled, with the following returns:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. </description></item>
        /// <item><description><b>false</b>: Disabled.<remarks>
        /// <para>This parameter is returned when the instance\&quot;s payment type is prepaid.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The Capacity storage size of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0GB</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The disk type of the core nodes. This parameter is returned only for multi-zone instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: This instance uses the Standard type of storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: This instance uses the Performance type of storage.</description></item>
        /// <item><description><b>cloud_essd</b>: This instance uses ESSDs for storage.</description></item>
        /// <item><description><b>cloud_essd_pl0</b>: This instance uses PL0 ESSDs for storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("CoreDiskCategory")]
        [Validation(Required=false)]
        public string CoreDiskCategory { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, number of core nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoreNum")]
        [Validation(Required=false)]
        public int? CoreNum { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, core single-node disk capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, core node specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        /// <summary>
        /// <para>The timestamp in milliseconds between the instance creation time and 1970-01-01 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627290664000</para>
        /// </summary>
        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk of a single log node. This parameter is returned only for multi-zone instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-26 17:10:26</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled, returning:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: This instance uses the Standard type of storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: This instance uses the Performance type of storage.</description></item>
        /// <item><description><b>cloud_essd</b>: This instance uses ESSDs for storage.</description></item>
        /// <item><description><b>cloud_essd_pl0</b>: This instance uses PL0 ESSDs for storage.</description></item>
        /// <item><description><b>capacity_cloud_storage</b>: This instance uses the Capacity type of storage.</description></item>
        /// <item><description><b>local_ssd_pro</b>: This instance uses local SSDs for storage.</description></item>
        /// <item><description><b>local_hdd_pro</b>: This instance uses local HDDs for storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The threshold for disk space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80%</para>
        /// </summary>
        [NameInMap("DiskThreshold")]
        [Validation(Required=false)]
        public string DiskThreshold { get; set; }

        /// <summary>
        /// <para>Disk space usage rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0%</para>
        /// </summary>
        [NameInMap("DiskUsage")]
        [Validation(Required=false)]
        public string DiskUsage { get; set; }

        /// <summary>
        /// <para>Indicates whether LBlob is enabled for the instance. Valid values:</para>
        /// <para>true: LBlob is enabled for the instance. false: LBlob is not enabled for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBlob")]
        [Validation(Required=false)]
        public bool? EnableBlob { get; set; }

        /// <summary>
        /// <para>Indicates whether the data subscription feature for the instance is enabled. Returns:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. </description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCdc")]
        [Validation(Required=false)]
        public bool? EnableCdc { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance\&quot;s compute engine is enabled, returning:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. </description></item>
        /// <item><description><b>false</b>: Not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        /// <summary>
        /// <para>Indicates whether the Key Management Service (KMS) is enabled, returning:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableKms")]
        [Validation(Required=false)]
        public bool? EnableKms { get; set; }

        /// <summary>
        /// <para>Indicates whether LindormTable supports the Thrift and CQL protocols. If these protocols are not supported. You can call the SwitchLProxyService operation to enable or disable the support on these protocols for LindormTable.</para>
        /// <para>True: LindormTable supports the Thrift and CQL protocols.</para>
        /// <para>False: LindormTable does not support the Thrift and CQL protocols.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableLProxy")]
        [Validation(Required=false)]
        public bool? EnableLProxy { get; set; }

        /// <summary>
        /// <para>Indicates whether the LTS engine is activated for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The LTS engine is activated for the instance.</description></item>
        /// <item><description><b>false</b>: The LTS engine is not activated for the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLTS")]
        [Validation(Required=false)]
        public bool? EnableLTS { get; set; }

        /// <summary>
        /// <para>Indicates whether LindormTable of the instance supports LindormSQL V3 that is compatible with MySQL. By default, LindormTable of instances that are purchased after October 24, 2023 supports LindormSQL V3. If your instance is purchased before this date and want to enable LindormSQL V3, contact the technical support.</para>
        /// <list type="bullet">
        /// <item><description>True: LindormTable supports LindormSQL V3.</description></item>
        /// <item><description>False: LindormTable does not support LindormSQL V3.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableLsqlVersionV3")]
        [Validation(Required=false)]
        public bool? EnableLsqlVersionV3 { get; set; }

        /// <summary>
        /// <para>Indicates whether AI control nodes are enabled for the instance.</para>
        /// <list type="bullet">
        /// <item><description>True: AI control nodes are enabled for the instance.</description></item>
        /// <item><description>False: AI control nodes are not enabled for the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableMLCtrl")]
        [Validation(Required=false)]
        public bool? EnableMLCtrl { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL link encryption is enabled, returning:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. </description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>Whether to enable the Compute Engine History Server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableShs")]
        [Validation(Required=false)]
        public bool? EnableShs { get; set; }

        /// <summary>
        /// <para>Indicates whether the Transparent Data Encryption (TDE) is enabled, returning:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled. </description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableStoreTDE")]
        [Validation(Required=false)]
        public bool? EnableStoreTDE { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance has the stream engine enabled. Return values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Stream engine is enabled. </description></item>
        /// <item><description><b>false</b>: Stream engine is not enabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStream")]
        [Validation(Required=false)]
        public bool? EnableStream { get; set; }

        /// <summary>
        /// <para>The list of engines supported by the instance.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormInstanceResponseBodyEngineList : TeaModel {
            [NameInMap("ArbiterCoreCount")]
            [Validation(Required=false)]
            public string ArbiterCoreCount { get; set; }

            /// <summary>
            /// <para>The number of engine nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CoreCount")]
            [Validation(Required=false)]
            public string CoreCount { get; set; }

            /// <summary>
            /// <para>The number of CPU cores on the engine node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>lindorm</b>: LindormTable.</description></item>
            /// <item><description><b>tsdb</b>: LindormTSDB.</description></item>
            /// <item><description><b>solr</b>: LindormSearch.</description></item>
            /// <item><description><b>store</b>: LindormDFS.</description></item>
            /// <item><description><b>bds</b>: Lindorm Tunnel Service (LTS).</description></item>
            /// <item><description><b>compute</b>: Lindorm Distributed Processing System (LDPS).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>Indicates whether the version of the engine is the latest. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The version of the engine is the latest.</description></item>
            /// <item><description><b>false</b>: The version of the engine is not the latest.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsLastVersion")]
            [Validation(Required=false)]
            public bool? IsLastVersion { get; set; }

            /// <summary>
            /// <para>The latest version number of the engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.19.2</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The memory size of the engine nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8GB</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            [NameInMap("PrimaryCoreCount")]
            [Validation(Required=false)]
            public string PrimaryCoreCount { get; set; }

            /// <summary>
            /// <para>The specification of the engine node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm.g.2xlarge</para>
            /// </summary>
            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            [NameInMap("StandbyCoreCount")]
            [Validation(Required=false)]
            public string StandbyCoreCount { get; set; }

            /// <summary>
            /// <para>The version of the engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Supported engine types, the return value is obtained by performing addition operations on the values of the following engine types.</para>
        /// <list type="bullet">
        /// <item><description>1: Search Engine </description></item>
        /// <item><description>2: Time Series Engine</description></item>
        /// <item><description>4: Wide Table Engine</description></item>
        /// <item><description>8: File Engine<remarks>
        /// <para>For example: If EngineType is 15, where 15 = 8 + 4 + 2 + 1, it indicates that the instance supports Search Engine, Time Series Engine, Wide Table Engine, and File Engine. If EngineType is 6, where 6 = 4 + 2, it signifies that the instance supports Time Series Engine and Wide Table Engine.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public int? EngineType { get; set; }

        /// <summary>
        /// <para>Expiration time of the instance, format: <b>yyyy-MM-dd HH:mm:ss</b>.</para>
        /// <remarks>
        /// <para>This parameter is only returned when the payment type is pre-paid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-27 00:00:00</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The millisecond value between the instance expiration time and 1970-01-01 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629993600000</para>
        /// </summary>
        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        /// <summary>
        /// <para>Instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0726</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1o3y0yme2i2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
        /// <item><description><b>COLD_EXPANDING</b>: The Capacity storage of the instance is being scaled up.</description></item>
        /// <item><description><b>MINOR_VERSION_TRANSING</b>: The minor version of the instance is being updated.</description></item>
        /// <item><description><b>RESIZING</b>: The nodes in the instance are being scaled up.</description></item>
        /// <item><description><b>SHRINKING</b>: The nodes in the instance are being scaled down.</description></item>
        /// <item><description><b>CLASS_CHANGING</b>: The specification of the instance is being changed.</description></item>
        /// <item><description><b>SSL_SWITCHING: SSL</b>: The SSL configurations of the instance are being changed.</description></item>
        /// <item><description><b>CDC_OPENING</b>: Data subscription is being enabled for the instance.</description></item>
        /// <item><description><b>TRANSFER</b>: The data of the instance is being transferred.</description></item>
        /// <item><description><b>DATABASE_TRANSFER</b>: The data of the instance is being transferred to databases.</description></item>
        /// <item><description><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</description></item>
        /// <item><description><b>BACKUP_RECOVERING</b>: The data of the instance is being restored from a backup.</description></item>
        /// <item><description><b>DATABASE_IMPORTING</b>: Data is being imported to the instance.</description></item>
        /// <item><description><b>NET_MODIFYING</b>: The network configurations of the instance are being changed.</description></item>
        /// <item><description><b>NET_SWITCHING</b>: The network of the instance is being switched between a virtual private cloud (VPC) and the Internet.</description></item>
        /// <item><description><b>NET_CREATING</b>: The connection to the instance is being created.</description></item>
        /// <item><description><b>NET_DELETING</b>: The connection to the instance is being deleted.</description></item>
        /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
        /// <item><description><b>RESTARTING</b>: The instance is restarting.</description></item>
        /// <item><description><b>LOCKED</b>: The instance is locked because it expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>Instance\&quot;s storage capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, log node disk type, returns:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: Standard cloud storage. </description></item>
        /// <item><description><b>cloud_ssd</b>: Performance cloud storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, number of log nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk of a single log node. This parameter is returned only for multi-zone instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400GB</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, log node specification.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>Maintainable end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>Maintainable start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>Multi-zone combinations. For support details on zone combinations, please refer to the product page.</para>
        /// <list type="bullet">
        /// <item><description><b>ap-southeast-5abc-aliyun</b>: Indonesia (Jakarta) A+B+C. </description></item>
        /// <item><description><b>cn-hangzhou-ehi-aliyun</b>: East China 1 (Hangzhou) E+H+I.</description></item>
        /// <item><description><b>cn-beijing-acd-aliyun</b>: North China 2 (Beijing) A+C+D.</description></item>
        /// <item><description><b>ap-southeast-1-abc-aliyun</b>: Singapore A+B+C.</description></item>
        /// <item><description><b>cn-zhangjiakou-abc-aliyun</b>: North China 3 (Zhangjiakou) A+B+C.</description></item>
        /// <item><description><b>cn-shanghai-efg-aliyun</b>: East China 2 (Shanghai) E+F+G.</description></item>
        /// <item><description><b>cn-shanghai-abd-aliyun</b>: East China 2 (Shanghai) A+B+D.</description></item>
        /// <item><description><b>cn-hangzhou-bef-aliyun</b>: East China 1 (Hangzhou) B+E+F.</description></item>
        /// <item><description><b>cn-hangzhou-bce-aliyun</b>: East China 1 (Hangzhou) B+C+E.</description></item>
        /// <item><description><b>cn-beijing-fgh-aliyun</b>: North China 2 (Beijing) F+G+H.</description></item>
        /// <item><description><b>cn-shenzhen-abc-aliyun</b>: South China 1 (Shenzhen) A+B+C.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-efg-aliyun</para>
        /// </summary>
        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        /// <summary>
        /// <para>Instance\&quot;s network type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <para>PREPAY: subscription.
        /// POSTPAY: pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, the virtual switch ID of the primary availability zone, which must be in the availability zone corresponding to PrimaryZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, availability zone ID of the primary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>633F1BE4-C8DA-5744-8FDF-A3075C3FE37F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2wvd6oia****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Instance type, valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm</b>: represents a Lindorm single-zone instance.</description></item>
        /// <item><description><b>lindorm_multizone</b>: represents a Lindorm multi-zone instance.</description></item>
        /// <item><description><b>serverless_lindorm</b>: represents a Lindorm Serverless instance.</description></item>
        /// <item><description><b>lindorm_standalone</b>: represents a Lindorm standalone instance.</description></item>
        /// <item><description><b>lts</b>: represents the Lindorm Data Channel Service type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, the virtual switch ID of the backup availability zone, which must be in the availability zone corresponding to StandbyZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, backup availability zone\&quot;s availability zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The type of the log nodes. This parameter is returned only for multi-zone instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The number of the log nodes. This parameter is returned only for multi-zone instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vbjzmod9q3l9eo****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>Availability Zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
