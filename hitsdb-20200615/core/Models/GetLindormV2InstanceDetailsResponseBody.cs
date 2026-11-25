// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetLindormV2InstanceDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The 16-digit AliUid of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>164901546557****</para>
        /// </summary>
        [NameInMap("AliUid")]
        [Validation(Required=false)]
        public long? AliUid { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the arbitration zone for a multi-zone instance. The vSwitch must be in the zone specified by ArbiterZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the arbitration zone for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only when the billing method of the instance is subscription.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The cloud storage capacity, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public long? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The storage-optimized cloud storage capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The number of milliseconds between the instance creation time and 1970-01-01 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1627290664000</para>
        /// </summary>
        [NameInMap("CreateMilliseconds")]
        [Validation(Required=false)]
        public long? CreateMilliseconds { get; set; }

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
        /// <item><description><b>StandardStorage</b>: standard cloud storage.</description></item>
        /// <item><description><b>PerformanceStorage</b>: performance cloud storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
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
        /// <para>Indicates whether the compute engine is activated for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: activated.</description></item>
        /// <item><description><b>false</b>: not activated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableCompute")]
        [Validation(Required=false)]
        public bool? EnableCompute { get; set; }

        /// <summary>
        /// <para>Indicates whether the file engine is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableFs")]
        [Validation(Required=false)]
        public string EnableFs { get; set; }

        /// <summary>
        /// <para>Indicates whether storage TDE encryption is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableStoreTDE")]
        [Validation(Required=false)]
        public string EnableStoreTDE { get; set; }

        /// <summary>
        /// <para>The list of engine information.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceDetailsResponseBodyEngineList> EngineList { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyEngineList : TeaModel {
            /// <summary>
            /// <para>The list of engine connection addresses.</para>
            /// </summary>
            [NameInMap("ConnectAddressList")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList> ConnectAddressList { get; set; }
            public class GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList : TeaModel {
                /// <summary>
                /// <para>The connection address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ld-mxj9asg***-proxy-lindorm-vpc.lindorm.aliyuncs.com:33060</para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The port number of the database endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33060</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The connection address type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INTRANET: VPC private network address.</description></item>
                /// <item><description>INTERNET: public address.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INTRANET</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TABLE</b>: LindormTable.</description></item>
            /// <item><description><b>TSDB</b>: LindormTSDB.</description></item>
            /// <item><description><b>LSEARCH</b>: search index engine.</description></item>
            /// <item><description><b>LTS</b>: LTS timing engine.</description></item>
            /// <item><description><b>LVECTOR</b>: vector engine.</description></item>
            /// <item><description><b>LCOLUMN</b>: column store engine.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>Indicates whether the engine is running the latest version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: the latest version.</description></item>
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
            /// <para>The latest version number for the engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.19.2</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The list of engine node groups.</para>
            /// </summary>
            [NameInMap("NodeGroup")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceDetailsResponseBodyEngineListNodeGroup> NodeGroup { get; set; }
            public class GetLindormV2InstanceDetailsResponseBodyEngineListNodeGroup : TeaModel {
                /// <summary>
                /// <para>Deprecated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>caculated</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The number of vCPU cores on the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <para>Indicates whether a local cloud disk is attached to the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAttachLocalDisk")]
                [Validation(Required=false)]
                public bool? EnableAttachLocalDisk { get; set; }

                /// <summary>
                /// <para>The local cloud disk capacity, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LocalDiskCapacity")]
                [Validation(Required=false)]
                public long? LocalDiskCapacity { get; set; }

                /// <summary>
                /// <para>The local cloud disk type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>cloud_essd: performance cloud disk.</description></item>
                /// <item><description>cloud_efficiency: standard cloud disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("LocalDiskCategory")]
                [Validation(Required=false)]
                public string LocalDiskCategory { get; set; }

                /// <summary>
                /// <para>The memory size of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("MemorySizeGiB")]
                [Validation(Required=false)]
                public int? MemorySizeGiB { get; set; }

                /// <summary>
                /// <para>The node specifications.</para>
                /// <para>If you select performance cloud storage or standard cloud storage, valid values are:</para>
                /// <list type="bullet">
                /// <item><description>lindorm.c.2xlarge: 8 vCores and 16 GB memory.</description></item>
                /// <item><description>lindorm.g.2xlarge: 8 vCores and 32 GB memory.</description></item>
                /// <item><description>lindorm.c.4xlarge: 16 vCores and 32 GB memory.</description></item>
                /// <item><description>lindorm.g.4xlarge: 16 vCores and 64 GB memory.</description></item>
                /// <item><description>lindorm.c.8xlarge: 32 vCores and 64 GB memory.</description></item>
                /// <item><description>lindorm.g.8xlarge: 32 vCores and 128 GB memory.</description></item>
                /// <item><description>lindorm.r.2xlarge: 8 vCores and 64 GB memory.</description></item>
                /// <item><description>lindorm.r.4xlarge: 16 vCores and 128 GB memory.</description></item>
                /// <item><description>lindorm.r.8xlarge: 32 vCores and 256 GB memory.</description></item>
                /// </list>
                /// <para>If you select local SSD storage, valid values are:</para>
                /// <list type="bullet">
                /// <item><description>lindorm.i4.xlarge: 4 vCores and 32 GB memory (I4).</description></item>
                /// <item><description>lindorm.i4.2xlarge: 8 vCores and 64 GB memory (I4).</description></item>
                /// <item><description>lindorm.i4.4xlarge: 16 vCores and 128 GB memory (I4).</description></item>
                /// <item><description>lindorm.i4.8xlarge: 32 vCores and 256 GB memory (I4).</description></item>
                /// <item><description>lindorm.i3.xlarge: 4 vCores and 32 GB memory (I3).</description></item>
                /// <item><description>lindorm.i3.2xlarge: 8 vCores and 64 GB memory (I3).</description></item>
                /// <item><description>lindorm.i3.4xlarge: 16 vCores and 128 GB memory (I3).</description></item>
                /// <item><description>lindorm.i3.8xlarge: 32 vCores and 256 GB memory (I3).</description></item>
                /// <item><description>lindorm.i2.xlarge: 4 vCores and 32 GB memory (I2).</description></item>
                /// <item><description>lindorm.i2.2xlarge: 8 vCores and 64 GB memory (I2).</description></item>
                /// <item><description>lindorm.i2.4xlarge: 16 vCores and 128 GB memory (I2).</description></item>
                /// <item><description>lindorm.i2.8xlarge: 32 vCores and 256 GB memory (I2).</description></item>
                /// </list>
                /// <para>If you select big data instance type, valid values are:</para>
                /// <list type="bullet">
                /// <item><description>lindorm.sd3c.3xlarge: 14 vCores and 56 GB memory (D3C PRO).</description></item>
                /// <item><description>lindorm.sd3c.7xlarge: 28 vCores and 112 GB memory (D3C PRO).</description></item>
                /// <item><description>lindorm.sd3c.14xlarge: 56 vCores and 224 GB memory (D3C PRO).</description></item>
                /// <item><description>lindorm.d2c.6xlarge: 24 vCores and 88 GB memory (D2C).</description></item>
                /// <item><description>lindorm.d2c.12xlarge: 48 vCores and 176 GB memory (D2C).</description></item>
                /// <item><description>lindorm.d2c.24xlarge: 96 vCores and 352 GB memory (D2C).</description></item>
                /// <item><description>lindorm.d2s.5xlarge: 20 vCores and 88 GB memory (D2S).</description></item>
                /// <item><description>lindorm.d2s.10xlarge: 40 vCores and 176 GB memory (D2S).</description></item>
                /// <item><description>lindorm.d1.2xlarge: 8 vCores and 32 GB memory (D1NE).</description></item>
                /// <item><description>lindorm.d1.4xlarge: 16 vCores and 64 GB memory (D1NE).</description></item>
                /// <item><description>lindorm.d1.6xlarge: 24 vCores and 96 GB memory (D1NE).</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>lindorm.g.2xlarge</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                /// <summary>
                /// <para>The node group name. <b>Required.</b> Must match the name specified at creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_debug</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <para>The ID that uniquely corresponds to the delivery group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs.c6.large</para>
                /// </summary>
                [NameInMap("SpecId")]
                [Validation(Required=false)]
                public string SpecId { get; set; }

                /// <summary>
                /// <para>The node status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACTIVATION</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The version number of the engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The number of milliseconds between the instance expires time and 1970-01-01 00:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629993600000</para>
        /// </summary>
        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        /// <summary>
        /// <para>The initial default password.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("InitialRootPassword")]
        [Validation(Required=false)]
        public string InitialRootPassword { get; set; }

        /// <summary>
        /// <para>The instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm-test</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1mq0tdzbx1m****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CREATING</b>: the instance is being created.</description></item>
        /// <item><description><b>ACTIVATION</b>: the instance is running.</description></item>
        /// <item><description><b>COLD_EXPANDING</b>: the storage-optimized cloud storage is undergoing storage expansion.</description></item>
        /// <item><description><b>MINOR_VERSION_TRANSING</b>: a minor version upgrade is in progress.</description></item>
        /// <item><description><b>RESIZING</b>: nodes are being scaled out.</description></item>
        /// <item><description><b>SHRINKING</b>: nodes are being scaled in.</description></item>
        /// <item><description><b>CLASS_CHANGING</b>: instance specifications are being upgraded or the quota is being decreased.</description></item>
        /// <item><description><b>SSL_SWITCHING</b>: an SSL change is in progress.</description></item>
        /// <item><description><b>CDC_OPENING</b>: the Lindorm Tunnel Service feature is being activated.</description></item>
        /// <item><description><b>TRANSFER</b>: data migration is in progress.</description></item>
        /// <item><description><b>DATABASE_TRANSFER</b>: data is being migrated to a database.</description></item>
        /// <item><description><b>GUARD_CREATING</b>: a disaster recovery instance is being created.</description></item>
        /// <item><description><b>BACKUP_RECOVERING</b>: backup recovery is in progress.</description></item>
        /// <item><description><b>DATABASE_IMPORTING</b>: data import is in progress.</description></item>
        /// <item><description><b>NET_MODIFYING</b>: a network change is in progress.</description></item>
        /// <item><description><b>NET_SWITCHING</b>: the network is switching between the private network and the public network.</description></item>
        /// <item><description><b>NET_CREATING</b>: a network connection is being created.</description></item>
        /// <item><description><b>NET_DELETING</b>: a network connection is being deleted.</description></item>
        /// <item><description><b>DELETING</b>: the instance is being deleted.</description></item>
        /// <item><description><b>RESTARTING</b>: the instance is restarting.</description></item>
        /// <item><description><b>LOCKED</b>: the instance has expired and is locked.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVATION</para>
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// <para>The instance form factor. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>basic: production type.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The end time of the maintenance window, in HH:mmZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>20:00Z</para>
        /// </summary>
        [NameInMap("MaintainEndTime")]
        [Validation(Required=false)]
        public string MaintainEndTime { get; set; }

        /// <summary>
        /// <para>The start time of the maintenance window, in HH:mmZ format (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>00:00Z</para>
        /// </summary>
        [NameInMap("MaintainStartTime")]
        [Validation(Required=false)]
        public string MaintainStartTime { get; set; }

        /// <summary>
        /// <para>The network type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
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
        /// <para>The vSwitch ID of the primary zone for a multi-zone instance. The vSwitch must be in the zone specified by PrimaryZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone for a multi-zone instance.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1556DCB0-043A-4444-8BD9-CF4A68E7EE64</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2i6weeb4nfii</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm_v2</b>: Lindorm V2 single-zone instance.</description></item>
        /// <item><description><b>lindorm_v2_multizone</b>: Lindorm V2 multi-zone Basic Edition instance.</description></item>
        /// <item><description><b>lindorm_v2_multizone_ha</b>: Lindorm V2 multi-zone High Availability Edition instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm_v2</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the secondary zone for a multi-zone instance. The vSwitch must be in the zone specified by StandbyZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary zone for a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The instance storage usage level.</para>
        /// </summary>
        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetLindormV2InstanceDetailsResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyStorageUsage : TeaModel {
            /// <summary>
            /// <para>The instance storage usage level.</para>
            /// </summary>
            [NameInMap("CapacityByDiskCategory")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> CapacityByDiskCategory { get; set; }

            /// <summary>
            /// <para>The storage usage of each engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16</para>
            /// </summary>
            [NameInMap("EngineUsage")]
            [Validation(Required=false)]
            public Dictionary<string, object> EngineUsage { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// <para>The instance access whitelist.</para>
        /// </summary>
        [NameInMap("WhiteIpList")]
        [Validation(Required=false)]
        public List<GetLindormV2InstanceDetailsResponseBodyWhiteIpList> WhiteIpList { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyWhiteIpList : TeaModel {
            /// <summary>
            /// <para>The group name. Only letters, digits, and underscores are allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>swhy</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;10.2.0.0/18\&quot;, \&quot;10.0.0.0/24\&quot;, \&quot;119.23.188.139/32\&quot;]</para>
            /// </summary>
            [NameInMap("IpList")]
            [Validation(Required=false)]
            public string IpList { get; set; }

        }

        /// <summary>
        /// <para>The details of engine deployment by zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZoneEngineInfoMap</para>
        /// </summary>
        [NameInMap("ZoneEngineInfoMap")]
        [Validation(Required=false)]
        public Dictionary<string, object> ZoneEngineInfoMap { get; set; }

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
