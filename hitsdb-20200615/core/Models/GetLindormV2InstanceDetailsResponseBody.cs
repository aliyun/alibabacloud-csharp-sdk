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
        /// <para>For a multi-zone instance, this is the ID of the virtual switch in the arbiter zone. The vSwitch must be in the zone specified by ArbiterZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>For a multi-zone instance, this is the ID of the arbiter zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is returned only for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The cloud storage capacity in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public long? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The capacity of the storage-optimized cloud storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The number of milliseconds between the instance creation time and 00:00:00 on January 1, 1970.</para>
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
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>The storage class. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>StandardStorage</b>: Standard cloud storage.</para>
        /// </description></item>
        /// <item><description><para><b>PerformanceStorage</b>: Performance cloud storage.</para>
        /// </description></item>
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
        /// <para>Indicates whether the compute engine is enabled for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
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
        /// <para>Indicates whether the file engine is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableFs")]
        [Validation(Required=false)]
        public string EnableFs { get; set; }

        /// <summary>
        /// <para>Indicates whether transparent data encryption (TDE) is enabled for storage.</para>
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
            /// <para>A list of engine endpoints.</para>
            /// </summary>
            [NameInMap("ConnectAddressList")]
            [Validation(Required=false)]
            public List<GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList> ConnectAddressList { get; set; }
            public class GetLindormV2InstanceDetailsResponseBodyEngineListConnectAddressList : TeaModel {
                /// <summary>
                /// <para>The endpoint.</para>
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
                /// <para>The endpoint type.</para>
                /// <list type="bullet">
                /// <item><description><para>INTRANET: VPC private endpoint.</para>
                /// </description></item>
                /// <item><description><para>INTERNET: Public endpoint.</para>
                /// </description></item>
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
            /// <item><description><para><b>TABLE</b>: LindormTable.</para>
            /// </description></item>
            /// <item><description><para><b>TSDB</b>: LindormTSDB.</para>
            /// </description></item>
            /// <item><description><para><b>LSEARCH</b>: Search engine.</para>
            /// </description></item>
            /// <item><description><para><b>LTS</b>: LTS engine.</para>
            /// </description></item>
            /// <item><description><para><b>LVECTOR</b>: Vector engine.</para>
            /// </description></item>
            /// <item><description><para><b>LCOLUMN</b>: Column store.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>Indicates whether the engine is the latest version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The engine is the latest version.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The engine is not the latest version.</para>
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
            /// <para>The latest version number for the engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.2.19.2</para>
            /// </summary>
            [NameInMap("LatestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>A list of engine node groups.</para>
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
                /// <para>The number of vCPUs for the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("CpuCoreCount")]
                [Validation(Required=false)]
                public int? CpuCoreCount { get; set; }

                /// <summary>
                /// <para>Indicates whether a local disk is attached to the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("EnableAttachLocalDisk")]
                [Validation(Required=false)]
                public bool? EnableAttachLocalDisk { get; set; }

                /// <summary>
                /// <para>The capacity of the local disk in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LocalDiskCapacity")]
                [Validation(Required=false)]
                public long? LocalDiskCapacity { get; set; }

                /// <summary>
                /// <para>The type of the local cloud disk.</para>
                /// <list type="bullet">
                /// <item><description><para>cloud_essd: performance cloud disk</para>
                /// </description></item>
                /// <item><description><para>cloud_efficiency: standard cloud disk</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("LocalDiskCategory")]
                [Validation(Required=false)]
                public string LocalDiskCategory { get; set; }

                /// <summary>
                /// <para>The memory size of the node in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64</para>
                /// </summary>
                [NameInMap("MemorySizeGiB")]
                [Validation(Required=false)]
                public int? MemorySizeGiB { get; set; }

                /// <summary>
                /// <para>The node specifications.</para>
                /// <para>If you select Performance cloud storage or Standard cloud storage, this parameter can be set to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para>lindorm.c.2xlarge: 8 vCPUs, 16 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.g.2xlarge: 8 vCPUs, 32 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.c.4xlarge: 16 vCPUs, 32 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.g.4xlarge: 16 vCPUs, 64 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.c.8xlarge: 32 vCPUs, 64 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.g.8xlarge: 32 vCPUs, 128 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.r.2xlarge: 8 vCPUs, 64 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.r.4xlarge: 16 vCPUs, 128 GB memory.</para>
                /// </description></item>
                /// <item><description><para>lindorm.r.8xlarge: 32 vCPUs, 256 GB memory.</para>
                /// </description></item>
                /// </list>
                /// <para>If you select Local SSD, this parameter can be set to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para>lindorm.i4.xlarge: 4 vCPUs, 32 GB memory (I4).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i4.2xlarge: 8 vCPUs, 64 GB memory (I4).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i4.4xlarge: 16 vCPUs, 128 GB memory (I4).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i4.8xlarge: 32 vCPUs, 256 GB memory (I4).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i3.xlarge: 4 vCPUs, 32 GB memory (I3).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i3.2xlarge: 8 vCPUs, 64 GB memory (I3).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i3.4xlarge: 16 vCPUs, 128 GB memory (I3).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i3.8xlarge: 32 vCPUs, 256 GB memory (I3).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i2.xlarge: 4 vCPUs, 32 GB memory (I2).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i2.2xlarge: 8 vCPUs, 64 GB memory (I2).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i2.4xlarge: 16 vCPUs, 128 GB memory (I2).</para>
                /// </description></item>
                /// <item><description><para>lindorm.i2.8xlarge: 32 vCPUs, 256 GB memory (I2).</para>
                /// </description></item>
                /// </list>
                /// <para>If you select Big Data, this parameter can be set to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para>lindorm.sd3c.3xlarge: 14 vCPUs, 56 GB memory (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para>lindorm.sd3c.7xlarge: 28 vCPUs, 112 GB memory (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para>lindorm.sd3c.14xlarge: 56 vCPUs, 224 GB memory (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d2c.6xlarge: 24 vCPUs, 88 GB memory (D2C).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d2c.12xlarge: 48 vCPUs, 176 GB memory (D2C).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d2c.24xlarge: 96 vCPUs, 352 GB memory (D2C).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d2s.5xlarge: 20 vCPUs, 88 GB memory (D2S).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d2s.10xlarge: 40 vCPUs, 176 GB memory (D2S).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d1.2xlarge: 8 vCPUs, 32 GB memory (D1NE).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d1.4xlarge: 16 vCPUs, 64 GB memory (D1NE).</para>
                /// </description></item>
                /// <item><description><para>lindorm.d1.6xlarge: 24 vCPUs, 96 GB memory (D1NE).</para>
                /// </description></item>
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
                /// <para>The name of the node group. <b>Required</b>. This must be the same as the name used during creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job_debug</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

                /// <summary>
                /// <para>The unique ID that corresponds to the delivery group ID.</para>
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
        /// <para>The number of milliseconds between the instance expiration time and 00:00:00 on January 1, 1970.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1629993600000</para>
        /// </summary>
        [NameInMap("ExpiredMilliseconds")]
        [Validation(Required=false)]
        public long? ExpiredMilliseconds { get; set; }

        /// <summary>
        /// <para>The default initial password.</para>
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
        /// <para>The ID of the instance.</para>
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
        /// <item><description><para><b>CREATING</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>ACTIVATION</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>COLD_EXPANDING</b>: The storage-optimized cloud storage is being scaled out.</para>
        /// </description></item>
        /// <item><description><para><b>MINOR_VERSION_TRANSING</b>: The minor version is being upgraded.</para>
        /// </description></item>
        /// <item><description><para><b>RESIZING</b>: The nodes are being scaled out.</para>
        /// </description></item>
        /// <item><description><para><b>SHRINKING</b>: The nodes are being scaled in.</para>
        /// </description></item>
        /// <item><description><para><b>CLASS_CHANGING</b>: The instance specifications are being upgraded or downgraded.</para>
        /// </description></item>
        /// <item><description><para><b>SSL_SWITCHING</b>: The SSL certificate is being changed.</para>
        /// </description></item>
        /// <item><description><para><b>CDC_OPENING</b>: The data subscription feature is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>TRANSFER</b>: Data is being migrated.</para>
        /// </description></item>
        /// <item><description><para><b>DATABASE_TRANSFER</b>: Data is being migrated to the database.</para>
        /// </description></item>
        /// <item><description><para><b>GUARD_CREATING</b>: A disaster recovery instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>BACKUP_RECOVERING</b>: Data is being restored from a backup.</para>
        /// </description></item>
        /// <item><description><para><b>DATABASE_IMPORTING</b>: Data is being imported.</para>
        /// </description></item>
        /// <item><description><para><b>NET_MODIFYING</b>: The network is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>NET_SWITCHING</b>: The network is being switched between the private network and the public network.</para>
        /// </description></item>
        /// <item><description><para><b>NET_CREATING</b>: A network connection is being created.</para>
        /// </description></item>
        /// <item><description><para><b>NET_DELETING</b>: A network connection is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>DELETING</b>: The instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>RESTARTING</b>: The instance is being restarted.</para>
        /// </description></item>
        /// <item><description><para><b>LOCKED</b>: The instance has expired and is locked.</para>
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
        /// <para>The instance type. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>basic: Production.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

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
        /// <item><description><para><b>PREPAY</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
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
        /// <para>For a multi-zone instance, this is the ID of the virtual switch in the primary zone. The vSwitch must be in the zone specified by PrimaryZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>For a multi-zone instance, this is the ID of the primary zone.</para>
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
        /// <item><description><para><b>lindorm_v2</b>: Lindorm V2 single-zone instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_v2_multizone</b>: Lindorm V2 Multi-zone Deployment (Basic) instance.</para>
        /// </description></item>
        /// <item><description><para><b>lindorm_v2_multizone_ha</b>: Lindorm V2 multi-zone High-availability Edition instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm_v2</para>
        /// </summary>
        [NameInMap("ServiceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// <para>For a multi-zone instance, this is the ID of the virtual switch in the secondary zone. The vSwitch must be in the zone specified by StandbyZoneId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>For a multi-zone instance, this is the ID of the secondary zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The instance storage usage.</para>
        /// </summary>
        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public GetLindormV2InstanceDetailsResponseBodyStorageUsage StorageUsage { get; set; }
        public class GetLindormV2InstanceDetailsResponseBodyStorageUsage : TeaModel {
            /// <summary>
            /// <para>The instance storage usage.</para>
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
        /// <para>The ID of the virtual private cloud (VPC) where the instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1xxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual switch.</para>
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
            /// <para>The group name. The name can contain only letters, digits, and underscores (_).</para>
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
        /// <para>The deployment details of the engine in the zone.</para>
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
