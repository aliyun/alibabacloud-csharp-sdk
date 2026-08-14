// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The UID of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164901546557****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the arbiter zone for the multi-zone instance. The vSwitch must be deployed in the zone that is specified by <c>ArbiterZoneId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The arbiter zone ID of the multi-zone instance.</para>
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
        /// <item><description><para><b>1.0</b>: single-zone deployment.</para>
        /// </description></item>
        /// <item><description><para><b>2.0</b>: multi-zone deployment.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The billable storage capacity of the archive storage. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0GB</para>
        /// </summary>
        [NameInMap("ArchiveStorage")]
        [Validation(Required=false)]
        public int? ArchiveStorage { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The ID of the backup instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-xxxx</para>
        /// </summary>
        [NameInMap("BackupInstance")]
        [Validation(Required=false)]
        public string BackupInstance { get; set; }

        /// <summary>
        /// <para>The capacity of the cold storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0GB</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The disk type of the core nodes in a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_efficiency</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_ssd</b>: Performance.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd</b>: ESSD.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl0</b>: ESSD PL0.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("CoreDiskCategory")]
        [Validation(Required=false)]
        public string CoreDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of core nodes in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoreNum")]
        [Validation(Required=false)]
        public int? CoreNum { get; set; }

        /// <summary>
        /// <para>The storage capacity of a single core node in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The specification of the core nodes in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        /// <summary>
        /// <para>The time at which the instance was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627290664000</para>
        /// </summary>
        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

        /// <summary>
        /// <para>The time at which the instance was created. The time is displayed in the <b>yyyy-MM-dd HH:mm:ss</b> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-07-26 17:10:26</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Indicates whether release protection is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
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
        /// <item><description><para><b>cloud_efficiency</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_ssd</b>: Performance.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd</b>: Enhanced SSD (ESSD).</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl0</b>: ESSD PL0.</para>
        /// </description></item>
        /// <item><description><para><b>capacity_cloud_storage</b>: Capacity.</para>
        /// </description></item>
        /// <item><description><para><b>local_ssd_pro</b>: local SSD.</para>
        /// </description></item>
        /// <item><description><para><b>local_hdd_pro</b>: local HDD.</para>
        /// </description></item>
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
        /// <para>The disk usage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0%</para>
        /// </summary>
        [NameInMap("DiskUsage")]
        [Validation(Required=false)]
        public string DiskUsage { get; set; }

        /// <summary>
        /// <para>Indicates whether LBlob is enabled. Valid values:</para>
        /// <para>true: Enabled. false: Disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBlob")]
        [Validation(Required=false)]
        public bool? EnableBlob { get; set; }

        /// <summary>
        /// <para>Indicates whether Change Data Capture (CDC) is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableKms")]
        [Validation(Required=false)]
        public bool? EnableKms { get; set; }

        /// <summary>
        /// <para>Specifies whether the wide table engine supports the Thrift and CQL protocols. If this feature is disabled, you can call the SwitchLProxyService operation to enable it.</para>
        /// <para>true: Supported.</para>
        /// <para>false: Not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("EnableLProxy")]
        [Validation(Required=false)]
        public bool? EnableLProxy { get; set; }

        /// <summary>
        /// <para>Indicates whether the LTS engine is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableLTS")]
        [Validation(Required=false)]
        public bool? EnableLTS { get; set; }

        /// <summary>
        /// <para>Indicates whether LindormSQL V3.0, which is compatible with the MySQL protocol, is supported by the wide table engine.
        /// This feature is supported by default on instances created after October 24, 2023. For existing instances, contact technical support to enable this feature.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Supported.</para>
        /// </description></item>
        /// <item><description><para>false: Not supported.</para>
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
        /// <para>Indicates whether the ML node is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
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
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>Indicates whether the History Server is enabled for the compute engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableShs")]
        [Validation(Required=false)]
        public bool? EnableShs { get; set; }

        /// <summary>
        /// <para>Indicates whether Transparent Data Encryption (TDE) is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Enabled.</para>
        /// </description></item>
        /// <item><description><para>false: Disabled.</para>
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
        /// <para>Indicates whether the stream engine is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableStream")]
        [Validation(Required=false)]
        public bool? EnableStream { get; set; }

        /// <summary>
        /// <para>The information about the engines.</para>
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
            /// <para>The number of vCPUs for the engine node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("CpuCount")]
            [Validation(Required=false)]
            public string CpuCount { get; set; }

            /// <summary>
            /// <para>The type of the engine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>lindorm</b>: the wide table engine.</para>
            /// </description></item>
            /// <item><description><para><b>tsdb</b>: the time series engine.</para>
            /// </description></item>
            /// <item><description><para><b>solr</b>: the search engine.</para>
            /// </description></item>
            /// <item><description><para><b>store</b>: the file engine.</para>
            /// </description></item>
            /// <item><description><para><b>bds</b>: the LTS engine.</para>
            /// </description></item>
            /// <item><description><para><b>compute</b>: the compute engine.</para>
            /// </description></item>
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
            /// <item><description><para><b>true</b>: The engine is of the latest version.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The engine is not of the latest version.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsLastVersion")]
            [Validation(Required=false)]
            public bool? IsLastVersion { get; set; }

            /// <summary>
            /// <para>The latest version of the engine.</para>
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
            /// <para>The specification of the engine nodes.</para>
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
        /// <para>The types of the engines that are supported by the instance. The value of this parameter is the sum of the values of all supported engine types.</para>
        /// <list type="bullet">
        /// <item><description><para>1: search engine</para>
        /// </description></item>
        /// <item><description><para>2: time series engine</para>
        /// </description></item>
        /// <item><description><para>4: wide table engine</para>
        /// </description></item>
        /// <item><description><para>8: file engine</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>For example, if the value of this parameter is 15, it indicates that the instance supports the search, time series, wide table, and file engines because 1 + 2 + 4 + 8 = 15. If the value of this parameter is 6, it indicates that the instance supports the time series and wide table engines because 2 + 4 = 6.</para>
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
        /// <para>This parameter is returned only for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-08-27 00:00:00</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the instance. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
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
        /// <para>The ID of the instance.</para>
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
        /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVATION</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>COLD_EXPANDING</b>: The capacity of the cold storage is being expanded.</para>
        /// </description></item>
        /// <item><description><para><b>MINOR_VERSION_TRANSITIONING</b>: The minor version of the instance is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>RESIZING</b>: The number of nodes is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>SHRINKING</b>: The number of nodes is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>CLASS_CHANGING</b>: The specification of the instance is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>SSL_SWITCHING</b>: SSL is being enabled or disabled.</para>
        /// </description></item>
        /// <item><description><para><b>CDC_OPENING</b>: The CDC feature is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>TRANSFER</b>: Data is being migrated.</para>
        /// </description></item>
        /// <item><description><para><b>DATABASE_TRANSFER</b>: Data is being migrated.</para>
        /// </description></item>
        /// <item><description><para><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>BACKUP_RECOVERING</b>: Data is being restored from a backup.</para>
        /// </description></item>
        /// <item><description><para><b>DATABASE_IMPORTING</b>: Data is being imported.</para>
        /// </description></item>
        /// <item><description><para><b>NET_MODIFYING</b>: The network type is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>NET_SWITCHING</b>: The network is being switched.</para>
        /// </description></item>
        /// <item><description><para><b>NET_CREATING</b>: A network connection is being created.</para>
        /// </description></item>
        /// <item><description><para><b>NET_DELETING</b>: A network connection is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>DELETING</b>: The instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>RESTARTING</b>: The instance is being restarted.</para>
        /// </description></item>
        /// <item><description><para><b>LOCKED</b>: The instance is locked.</para>
        /// </description></item>
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
        /// <para>The disk type of the log nodes in the multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_efficiency</b>: Standard.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_ssd</b>: Performance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of log nodes in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The storage capacity of a single log node in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400GB</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The specification of the log nodes in the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The combination of zones. For more information about the supported zone combinations, see the instance buy page.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ap-southeast-5abc-aliyun</b>: Indonesia (Jakarta) Zone A, B, and C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-ehi-aliyun</b>: China (Hangzhou) Zone E, H, and I.</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing-acd-aliyun</b>: China (Beijing) Zone A, C, and D.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1-abc-aliyun</b>: Singapore Zone A, B, and C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou-abc-aliyun</b>: China (Zhangjiakou) Zone A, B, and C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-efg-aliyun</b>: China (Shanghai) Zone E, F, and G.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-abd-aliyun</b>: China (Shanghai) Zone A, B, and D.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-bef-aliyun</b>: China (Hangzhou) Zone B, E, and F.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-bce-aliyun</b>: China (Hangzhou) Zone B, C, and E.</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing-fgh-aliyun</b>: China (Beijing) Zone F, G, and H.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen-abc-aliyun</b>: China (Shenzhen) Zone A, B, and C.</para>
        /// </description></item>
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
        /// <item><description><para><b>PREPAY</b>: subscription</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: pay-as-you-go</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the primary zone for the multi-zone instance. The vSwitch must be deployed in the zone that is specified by <c>PrimaryZoneId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The primary zone ID of the multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
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
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm</b>: a single-zone instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_multizone</b>: a multi-zone instance.</para>
        /// </description></item>
        /// <item><description><para><b>serverless_lindorm</b>: a serverless instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_standalone</b>: a single-node instance.</para>
        /// </description></item>
        /// <item><description><para><b>lts</b>: a Lindorm Tunnel Service (LTS) instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        [NameInMap("SingleZoneRiskAlert")]
        [Validation(Required=false)]
        public GetLindormInstanceResponseBodySingleZoneRiskAlert SingleZoneRiskAlert { get; set; }
        public class GetLindormInstanceResponseBodySingleZoneRiskAlert : TeaModel {
            [NameInMap("ConfirmDate")]
            [Validation(Required=false)]
            public string ConfirmDate { get; set; }

            [NameInMap("DispositionType")]
            [Validation(Required=false)]
            public string DispositionType { get; set; }

            [NameInMap("NeedAlert")]
            [Validation(Required=false)]
            public bool? NeedAlert { get; set; }

            [NameInMap("PlannedCompletionDate")]
            [Validation(Required=false)]
            public string PlannedCompletionDate { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch in the secondary zone for the multi-zone instance. The vSwitch must be deployed in the zone that is specified by <c>StandbyZoneId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The secondary zone ID of the multi-zone instance.</para>
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
        /// <para>The ID of the zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
