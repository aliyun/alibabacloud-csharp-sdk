// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The 16-character AliUid of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164901546557****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the arbiter zone for a multi-zone instance. The vSwitch must belong to the zone specified by ArbiterZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the arbiter zone for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>The deployment architecture. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1.0</b>: single-zone.</description></item>
        /// <item><description><b>2.0</b>: multi-zone.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The billable storage capacity of the archive storage type. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ArchiveStorage")]
        [Validation(Required=false)]
        public int? ArchiveStorage { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the billing method of the instance is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The backup instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-xxxx</para>
        /// </summary>
        [NameInMap("BackupInstance")]
        [Validation(Required=false)]
        public string BackupInstance { get; set; }

        /// <summary>
        /// <para>Storage capacity of storage capacity cloud storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The disk type of the core node for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: standard cloud storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd_pl0</b>: performance cloud storage PL0.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("CoreDiskCategory")]
        [Validation(Required=false)]
        public string CoreDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of core nodes for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoreNum")]
        [Validation(Required=false)]
        public int? CoreNum { get; set; }

        /// <summary>
        /// <para>The disk capacity of a single core node for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The core node specifications for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        /// <summary>
        /// <para>The creation time of the instance, represented as the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627290664000</para>
        /// </summary>
        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        /// <summary>
        /// <para>The time when the instance was created. The time is displayed in the <b>yyyy-MM-dd HH:mm:ss</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-26 17:10:26</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public string DeletionProtection { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: standard cloud storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd_pl0</b>: performance cloud storage PL0.</description></item>
        /// <item><description><b>capacity_cloud_storage</b>: capacity cloud storage.</description></item>
        /// <item><description><b>local_ssd_pro</b>: local SSD.</description></item>
        /// <item><description><b>local_hdd_pro</b>: local HDD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The disk space threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80%</para>
        /// </summary>
        [NameInMap("DiskThreshold")]
        [Validation(Required=false)]
        public string DiskThreshold { get; set; }

        /// <summary>
        /// <para>The disk space usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0%</para>
        /// </summary>
        [NameInMap("DiskUsage")]
        [Validation(Required=false)]
        public string DiskUsage { get; set; }

        /// <summary>
        /// <para>Indicates whether LBlob is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBlob")]
        [Validation(Required=false)]
        public bool? EnableBlob { get; set; }

        /// <summary>
        /// <para>Indicates whether the data subscription feature is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCdc")]
        [Validation(Required=false)]
        public bool? EnableCdc { get; set; }

        /// <summary>
        /// <para>Indicates whether the compute engine is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        /// <summary>
        /// <para>Indicates whether Key Management Service (KMS) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableKms")]
        [Validation(Required=false)]
        public bool? EnableKms { get; set; }

        /// <summary>
        /// <para>Indicates whether LindormTable supports the Thrift and CQL protocols. If not supported, you can call the SwitchLProxyService operation to enable or disable the support. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>True: supported.</para>
        /// </description></item>
        /// <item><description><para>False: not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableLProxy")]
        [Validation(Required=false)]
        public bool? EnableLProxy { get; set; }

        /// <summary>
        /// <para>Indicates whether Lindorm Tunnel Service is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLTS")]
        [Validation(Required=false)]
        public bool? EnableLTS { get; set; }

        /// <summary>
        /// <para>Indicates whether LindormTable supports LindormSQL-V3, which is compatible with the MySQL protocol. Instances purchased after October 24, 2023 support this feature by default. For existing instances, contact technical support for evaluation before enabling this feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>True: supported.</para>
        /// </description></item>
        /// <item><description><para>False: not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("EnableLsqlVersionV3")]
        [Validation(Required=false)]
        public bool? EnableLsqlVersionV3 { get; set; }

        /// <summary>
        /// <para>Indicates whether the AI control node is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>True: enabled.</para>
        /// </description></item>
        /// <item><description><para>False: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableMLCtrl")]
        [Validation(Required=false)]
        public bool? EnableMLCtrl { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL encryption is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>Indicates whether History Server for the compute engine is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableShs")]
        [Validation(Required=false)]
        public bool? EnableShs { get; set; }

        /// <summary>
        /// <para>Indicates whether storage encryption is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled.</para>
        /// </description></item>
        /// <item><description><para>false: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableStoreTDE")]
        [Validation(Required=false)]
        public bool? EnableStoreTDE { get; set; }

        /// <summary>
        /// <para>Indicates whether the streaming engine is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStream")]
        [Validation(Required=false)]
        public bool? EnableStream { get; set; }

        /// <summary>
        /// <para>The list of engine information.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormInstanceResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormInstanceResponseBodyEngineList : TeaModel {
            /// <summary>
            /// <para>The number of nodes in the arbiter zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
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
            /// <para>The number of CPUs for the engine node.</para>
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
            /// <item><description><b>solr</b>: search engine.</description></item>
            /// <item><description><b>store</b>: file engine.</description></item>
            /// <item><description><b>bds</b>: Lindorm Tunnel Service engine.</description></item>
            /// <item><description><b>compute</b>: compute engine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>Indicates whether the engine is of the latest version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: latest version.</description></item>
            /// <item><description><b>false</b>: not the latest version.</description></item>
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
            /// <para>The memory size of the engine node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8GB</para>
            /// </summary>
            [NameInMap("MemorySize")]
            [Validation(Required=false)]
            public string MemorySize { get; set; }

            /// <summary>
            /// <para>The number of nodes in the primary zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("PrimaryCoreCount")]
            [Validation(Required=false)]
            public string PrimaryCoreCount { get; set; }

            /// <summary>
            /// <para>The engine node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lindorm.g.2xlarge</para>
            /// </summary>
            [NameInMap("Specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <para>The number of nodes in the secondary zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StandbyCoreCount")]
            [Validation(Required=false)]
            public string StandbyCoreCount { get; set; }

            /// <summary>
            /// <para>The version number of the engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The supported engine types. The return value is the sum of the values of the following engine types:</para>
        /// <list type="bullet">
        /// <item><description>1: search engine</description></item>
        /// <item><description>2: LindormTSDB</description></item>
        /// <item><description>4: LindormTable</description></item>
        /// <item><description>8: file engine</description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, if the value of EngineType is 15 (15 = 8 + 4 + 2 + 1), the instance supports the search engine, LindormTSDB, LindormTable, and file engine. If the value of EngineType is 6 (6 = 4 + 2), the instance supports LindormTSDB and LindormTable.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public int? EngineType { get; set; }

        /// <summary>
        /// <para>The expiration time of the instance. The time is displayed in the <b>yyyy-MM-dd HH:mm:ss</b> format.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the billing method is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-27 00:00:00</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The time when the instance expires, represented as the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629993600000</para>
        /// </summary>
        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test0726</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1o3y0yme2i2****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: The instance is being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: The instance is running.</description></item>
        /// <item><description><b>COLD_EXPANDING</b>: Capacity cloud storage expansion in progress.</description></item>
        /// <item><description><b>MINOR_VERSION_TRANSING</b>: The minor version is being upgraded.</description></item>
        /// <item><description><b>RESIZING</b>: The nodes are being scaled up.</description></item>
        /// <item><description><b>SHRINKING</b>: The nodes are being scaled down.</description></item>
        /// <item><description><b>CLASS_CHANGING</b>: Instance specification upgrade or downgrade in progress.</description></item>
        /// <item><description><b>SSL_SWITCHING</b>: The SSL certificate is being changed.</description></item>
        /// <item><description><b>CDC_OPENING</b>: The data subscription feature is being enabled.</description></item>
        /// <item><description><b>TRANSFER</b>: Data migration in progress.</description></item>
        /// <item><description><b>DATABASE_TRANSFER</b>: Data is being migrated to the database.</description></item>
        /// <item><description><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</description></item>
        /// <item><description><b>BACKUP_RECOVERING</b>: The backup is being restored.</description></item>
        /// <item><description><b>DATABASE_IMPORTING</b>: Data import in progress.</description></item>
        /// <item><description><b>NET_MODIFYING</b>: The network is being modified.</description></item>
        /// <item><description><b>NET_SWITCHING</b>: The network is being switched between the internal network and the Internet.</description></item>
        /// <item><description><b>NET_CREATING</b>: A network connection is being created.</description></item>
        /// <item><description><b>NET_DELETING</b>: A network connection is being deleted.</description></item>
        /// <item><description><b>DELETING</b>: The instance is being deleted.</description></item>
        /// <item><description><b>RESTARTING</b>: The instance is being restarted.</description></item>
        /// <item><description><b>LOCKED</b>: The instance has expired and is locked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// <para>The disk type of the log node for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: standard cloud storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: performance cloud storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of log nodes for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The disk capacity of a single log node for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400GB</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The log node specifications for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window. The time is displayed in the HH:mmZ format. UTC time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window. The time is displayed in the HH:mmZ format. UTC time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The multi-zone combination. You can go to the buy page to view the supported zone combinations. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ap-southeast-5abc-aliyun</b>: Indonesia (Jakarta) Zones A, B, and C.</description></item>
        /// <item><description><b>cn-hangzhou-ehi-aliyun</b>: China (Hangzhou) Zones E, H, and I.</description></item>
        /// <item><description><b>cn-beijing-acd-aliyun</b>: China (Beijing) Zones A, C, and D.</description></item>
        /// <item><description><b>ap-southeast-1-abc-aliyun</b>: Singapore Zones A, B, and C.</description></item>
        /// <item><description><b>cn-zhangjiakou-abc-aliyun</b>: China (Zhangjiakou) Zones A, B, and C.</description></item>
        /// <item><description><b>cn-shanghai-efg-aliyun</b>: China (Shanghai) Zones E, F, and G.</description></item>
        /// <item><description><b>cn-shanghai-abd-aliyun</b>: China (Shanghai) Zones A, B, and D.</description></item>
        /// <item><description><b>cn-hangzhou-bef-aliyun</b>: China (Hangzhou) Zones B, E, and F.</description></item>
        /// <item><description><b>cn-hangzhou-bce-aliyun</b>: China (Hangzhou) Zones B, C, and E.</description></item>
        /// <item><description><b>cn-beijing-fgh-aliyun</b>: China (Beijing) Zones F, G, and H.</description></item>
        /// <item><description><b>cn-shenzhen-abc-aliyun</b>: China (Shenzhen) Zones A, B, and C.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-efg-aliyun</para>
        /// </summary>
        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        /// <summary>
        /// <para>The network type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the primary zone for a multi-zone instance. The vSwitch must belong to the zone specified by PrimaryZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>633F1BE4-C8DA-5744-8FDF-A3075C3FE37F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2wvd6oia****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm</b>: Lindorm single-zone instance.</description></item>
        /// <item><description><b>lindorm_multizone</b>: Lindorm multi-zone instance.</description></item>
        /// <item><description><b>serverless_lindorm</b>: Lindorm Serverless instance.</description></item>
        /// <item><description><b>lindorm_standalone</b>: Lindorm single-node instance.</description></item>
        /// <item><description><b>lts</b>: Lindorm Tunnel Service.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The risk alert information for the single-zone deployment.</para>
        /// </summary>
        [NameInMap("SingleZoneRiskAlert")]
        [Validation(Required=false)]
        public GetLindormInstanceResponseBodySingleZoneRiskAlert SingleZoneRiskAlert { get; set; }
        public class GetLindormInstanceResponseBodySingleZoneRiskAlert : TeaModel {
            /// <summary>
            /// <para>The confirmation date for risk handling. The date is displayed in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-24</para>
            /// </summary>
            [NameInMap("ConfirmDate")]
            [Validation(Required=false)]
            public string ConfirmDate { get; set; }

            /// <summary>
            /// <para>The risk handling type for the single-zone deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NO_SET</para>
            /// </summary>
            [NameInMap("DispositionType")]
            [Validation(Required=false)]
            public string DispositionType { get; set; }

            /// <summary>
            /// <para>Indicates whether a risk alert for the single-zone deployment is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedAlert")]
            [Validation(Required=false)]
            public bool? NeedAlert { get; set; }

            /// <summary>
            /// <para>The planned completion date for risk handling. The date is displayed in the yyyy-MM-dd format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-09-30</para>
            /// </summary>
            [NameInMap("PlannedCompletionDate")]
            [Validation(Required=false)]
            public string PlannedCompletionDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch in the secondary zone for a multi-zone instance. The vSwitch must belong to the zone specified by StandbyZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1n3i15v90el48nx****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1vbjzmod9q3l9eo****</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
