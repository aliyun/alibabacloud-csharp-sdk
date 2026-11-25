// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormV2InstanceRequest : TeaModel {
        /// <summary>
        /// <para>The vSwitch ID of the arbiter zone for a multi-zone instance. The vSwitch must be deployed in the zone specified by <b>ArbiterZoneId</b>. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the arbiter zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
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
        /// <item><description><b>1.0</b>: Single-zone.</description></item>
        /// <item><description><b>2.0</b>: Multi-zone Basic Edition.</description></item>
        /// <item><description><b>3.0</b>: Multi-zone High-availability Edition.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months. Valid values: <b>1</b> to <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>AutoRenewal</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public string AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: Disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>PayType</b> is set to <b>PREPAY</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The size of the capacity storage. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("CapacityStorageSize")]
        [Validation(Required=false)]
        public int? CapacityStorageSize { get; set; }

        /// <summary>
        /// <para>The size of the cloud storage space. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>320</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The storage type. If you select the <b>big data</b> or <b>local SSD</b> type, you can leave this parameter empty. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PerformanceStorage</b>: Performance cloud storage.</description></item>
        /// <item><description><b>StandardStorage</b>: Standard cloud storage.</description></item>
        /// <item><description><b>CapacityStorage</b>: Capacity cloud storage.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        /// <summary>
        /// <para>The instance mode. This parameter is optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BASIC</b>: General mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The cluster pattern. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>basic</b>: Production.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("ClusterPattern")]
        [Validation(Required=false)]
        public string ClusterPattern { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>PricingCycle</b> is set to <b>Month</b>, the value ranges from <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If <b>PricingCycle</b> is set to <b>Year</b>, the value ranges from <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>PayType</b> is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable capacity storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableCapacityStorage")]
        [Validation(Required=false)]
        public bool? EnableCapacityStorage { get; set; }

        /// <summary>
        /// <para>The list of engine information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EngineList")]
        [Validation(Required=false)]
        public List<CreateLindormV2InstanceRequestEngineList> EngineList { get; set; }
        public class CreateLindormV2InstanceRequestEngineList : TeaModel {
            /// <summary>
            /// <para>The engine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TABLE</b>: LindormTable.</description></item>
            /// <item><description><b>TSDB</b>: LindormTSDB.</description></item>
            /// <item><description><b>LSEARCH</b>: Search engine.</description></item>
            /// <item><description><b>LTS</b>: Lindorm Tunnel Service.</description></item>
            /// <item><description><b>LVECTOR</b>: Vector engine.</description></item>
            /// <item><description><b>LCOLUMN</b>: Column store engine.</description></item>
            /// <item><description><b>LAI</b>: AI engine.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TABLE</para>
            /// </summary>
            [NameInMap("EngineType")]
            [Validation(Required=false)]
            public string EngineType { get; set; }

            /// <summary>
            /// <para>The list of engine nodes.</para>
            /// </summary>
            [NameInMap("NodeGroupList")]
            [Validation(Required=false)]
            public List<CreateLindormV2InstanceRequestEngineListNodeGroupList> NodeGroupList { get; set; }
            public class CreateLindormV2InstanceRequestEngineListNodeGroupList : TeaModel {
                /// <summary>
                /// <para>The number of nodes in the cluster.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("NodeCount")]
                [Validation(Required=false)]
                public int? NodeCount { get; set; }

                /// <summary>
                /// <para>The disk size per node. Default unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                /// <summary>
                /// <para>The cloud disk type of the node. This parameter is optional. <b>This parameter is used in special scenarios and is available only to whitelisted users.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>The node specifications. If you select performance cloud storage or standard cloud storage, valid values are:</para>
                /// <list type="bullet">
                /// <item><description><b>lindorm.c.2xlarge</b>: 8 vCPUs and 16 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.2xlarge</b>: 8 vCPUs and 32 GB of memory.</description></item>
                /// <item><description><b>lindorm.c.4xlarge</b>: 16 vCPUs and 32 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.4xlarge</b>: 16 vCPUs and 64 GB of memory.</description></item>
                /// <item><description><b>lindorm.c.8xlarge</b>: 32 vCPUs and 64 GB of memory.</description></item>
                /// <item><description><b>lindorm.g.8xlarge</b>: 32 vCPUs and 128 GB of memory.</description></item>
                /// <item><description><b>lindorm.r.2xlarge</b>: 8 vCPUs and 64 GB of memory.</description></item>
                /// <item><description><b>lindorm.r.4xlarge</b>: 16 vCPUs and 128 GB of memory.</description></item>
                /// <item><description><b>lindorm.r.8xlarge</b>: 32 vCPUs and 256 GB of memory.</description></item>
                /// </list>
                /// <para>If you select the local SSD type, valid values are:</para>
                /// <list type="bullet">
                /// <item><description><b>lindorm.i4.xlarge</b>: 4 vCPUs and 32 GB of memory (I4).</description></item>
                /// <item><description><b>lindorm.i4.2xlarge</b>: 8 vCPUs and 64 GB of memory (I4).</description></item>
                /// <item><description><b>lindorm.i4.4xlarge</b>: 16 vCPUs and 128 GB of memory (I4).</description></item>
                /// <item><description><b>lindorm.i4.8xlarge</b>: 32 vCPUs and 256 GB of memory (I4).</description></item>
                /// <item><description><b>lindorm.i3.xlarge</b>: 4 vCPUs and 32 GB of memory (I3).</description></item>
                /// <item><description><b>lindorm.i3.2xlarge</b>: 8 vCPUs and 64 GB of memory (I3).</description></item>
                /// <item><description><b>lindorm.i3.4xlarge</b>: 16 vCPUs and 128 GB of memory (I3).</description></item>
                /// <item><description><b>lindorm.i3.8xlarge</b>: 32 vCPUs and 256 GB of memory (I3).</description></item>
                /// <item><description><b>lindorm.i2.xlarge</b>: 4 vCPUs and 32 GB of memory (I2).</description></item>
                /// <item><description><b>lindorm.i2.2xlarge</b>: 8 vCPUs and 64 GB of memory (I2).</description></item>
                /// <item><description><b>lindorm.i2.4xlarge</b>: 16 vCPUs and 128 GB of memory (I2).</description></item>
                /// <item><description><b>lindorm.i2.8xlarge</b>: 32 vCPUs and 256 GB of memory (I2).</description></item>
                /// </list>
                /// <para>If you select the big data type, valid values are:</para>
                /// <list type="bullet">
                /// <item><description><b>lindorm.sd3c.3xlarge</b>: 14 vCPUs and 56 GB of memory (D3C PRO).</description></item>
                /// <item><description><b>lindorm.sd3c.7xlarge</b>: 28 vCPUs and 112 GB of memory (D3C PRO).</description></item>
                /// <item><description><b>lindorm.sd3c.14xlarge</b>: 56 vCPUs and 224 GB of memory (D3C PRO).</description></item>
                /// <item><description><b>lindorm.d2c.6xlarge</b>: 24 vCPUs and 88 GB of memory (D2C).</description></item>
                /// <item><description><b>lindorm.d2c.12xlarge</b>: 48 vCPUs and 176 GB of memory (D2C).</description></item>
                /// <item><description><b>lindorm.d2c.24xlarge</b>: 96 vCPUs and 352 GB of memory (D2C).</description></item>
                /// <item><description><b>lindorm.d2s.5xlarge</b>: 20 vCPUs and 88 GB of memory (D2S).</description></item>
                /// <item><description><b>lindorm.d2s.10xlarge</b>: 40 vCPUs and 176 GB of memory (D2S).</description></item>
                /// <item><description><b>lindorm.d1.2xlarge</b>: 8 vCPUs and 32 GB of memory (D1NE).</description></item>
                /// <item><description><b>lindorm.d1.4xlarge</b>: 16 vCPUs and 64 GB of memory (D1NE).</description></item>
                /// <item><description><b>lindorm.d1.6xlarge</b>: 24 vCPUs and 96 GB of memory (D1NE).</description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lindorm.g.2xlarge</para>
                /// </summary>
                [NameInMap("NodeSpec")]
                [Validation(Required=false)]
                public string NodeSpec { get; set; }

                /// <summary>
                /// <para>The name of the node group. This parameter is optional.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group_name_01</para>
                /// </summary>
                [NameInMap("ResourceGroupName")]
                [Validation(Required=false)]
                public string ResourceGroupName { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm-test</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: Subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: Pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: Month.</description></item>
        /// <item><description><b>Year</b>: Year.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required only when <b>PayType</b> is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the primary zone for a multi-zone instance. The vSwitch must be deployed in the zone specified by <b>PrimaryZoneId</b>. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the most recent region list. Use this parameter to specify the region where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2i6weeb4nfii</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the secondary zone for a multi-zone instance. The vSwitch must be deployed in the zone specified by <b>StandbyZoneId</b>. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The VPC ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9ydz3vg93s1ozsd****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
