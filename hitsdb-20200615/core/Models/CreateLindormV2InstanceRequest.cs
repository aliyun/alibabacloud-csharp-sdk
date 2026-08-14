// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormV2InstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the vSwitch in the arbiter zone for a multi-zone instance. The vSwitch must be in the zone specified by ArbiterZoneId. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the arbiter zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
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
        /// <item><description><para><b>1.0</b>: single zone.</para>
        /// </description></item>
        /// <item><description><para><b>2.0</b>: multi-zone Basic Edition.</para>
        /// </description></item>
        /// <item><description><para><b>3.0</b>: multi-zone High-availability Edition.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: month.</para>
        /// <para>Valid values: <b>1</b> to <b>12</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you set <b>AutoRenewal</b> to <b>true</b>.</para>
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
        /// <item><description><para><b>true</b>: Enable auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is false.</para>
        /// <remarks>
        /// <para>This parameter is valid only when you set <b>PayType</b> to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The size of the storage-optimized storage. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("CapacityStorageSize")]
        [Validation(Required=false)]
        public int? CapacityStorageSize { get; set; }

        /// <summary>
        /// <para>The size of the cloud storage. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>320</para>
        /// </summary>
        [NameInMap("CloudStorageSize")]
        [Validation(Required=false)]
        public int? CloudStorageSize { get; set; }

        /// <summary>
        /// <para>The storage class. This parameter is not required if you select <b>Big Data</b> or <b>Local SSD</b>.</para>
        /// <list type="bullet">
        /// <item><description><para><b>PerformanceStorage</b>: performance cloud storage</para>
        /// </description></item>
        /// <item><description><para><b>StandardStorage</b>: standard cloud storage</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PerformanceStorage</para>
        /// </summary>
        [NameInMap("CloudStorageType")]
        [Validation(Required=false)]
        public string CloudStorageType { get; set; }

        /// <summary>
        /// <para>The instance mode. This parameter is not required.</para>
        /// <list type="bullet">
        /// <item><description><b>BASIC</b>: general-purpose mode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BASIC</para>
        /// </summary>
        [NameInMap("ClusterMode")]
        [Validation(Required=false)]
        public string ClusterMode { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>basic</b>: production</description></item>
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
        /// <item><description><para>If you set PricingCycle to <b>Month</b>, the valid values are <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If you set PricingCycle to <b>Year</b>, the valid values are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when you set PayType to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable storage-optimized storage.</para>
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
            /// <item><description><para><b>TABLE</b>: LindormTable.</para>
            /// </description></item>
            /// <item><description><para><b>TSDB</b>: LindormTSDB.</para>
            /// </description></item>
            /// <item><description><para><b>LSEARCH</b>: search engine.</para>
            /// </description></item>
            /// <item><description><para><b>LTS</b>: LTS engine.</para>
            /// </description></item>
            /// <item><description><para><b>LVECTOR</b>: vector engine.</para>
            /// </description></item>
            /// <item><description><para><b>LCOLUMN</b>: column store engine.</para>
            /// </description></item>
            /// <item><description><para><b>LAI</b>: AI engine.</para>
            /// </description></item>
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
                /// <para>The disk size of a single node. The default unit is GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("NodeDiskSize")]
                [Validation(Required=false)]
                public int? NodeDiskSize { get; set; }

                /// <summary>
                /// <para>The disk type of the node. This parameter is not required. <b>This parameter is available only for specific scenarios. To use this parameter, you must be added to the whitelist.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("NodeDiskType")]
                [Validation(Required=false)]
                public string NodeDiskType { get; set; }

                /// <summary>
                /// <para>The node specifications.</para>
                /// <para>If you select performance cloud storage or standard cloud storage, set this parameter to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.r.2xlarge</b>: 8 cores, 64 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.r.4xlarge</b>: 16 cores, 128 GB.</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.r.8xlarge</b>: 32 cores, 256 GB.</para>
                /// </description></item>
                /// </list>
                /// <para>If you select the local SSD type, set this parameter to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>lindorm.i4.xlarge</b>: 4 cores, 32 GB (I4).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i4.2xlarge</b>: 8 cores, 64 GB (I4).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i4.4xlarge</b>: 16 cores, 128 GB (I4).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i4.8xlarge</b>: 32 cores, 256 GB (I4).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i3.xlarge</b>: 4 cores, 32 GB (I3).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i3.2xlarge</b>: 8 cores, 64 GB (I3).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i3.4xlarge</b>: 16 cores, 128 GB (I3).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i3.8xlarge</b>: 32 cores, 256 GB (I3).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i2.xlarge</b>: 4 cores, 32 GB (I2).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i2.2xlarge</b>: 8 cores, 64 GB (I2).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i2.4xlarge</b>: 16 cores, 128 GB (I2).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.i2.8xlarge</b>: 32 cores, 256 GB (I2).</para>
                /// </description></item>
                /// </list>
                /// <para>If you select the big data type, set this parameter to one of the following values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>lindorm.sd3c.3xlarge</b>: 14 cores, 56 GB (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.sd3c.7xlarge</b>: 28 cores, 112 GB (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.sd3c.14xlarge</b>: 56 cores, 224 GB (D3C PRO).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d2c.6xlarge</b>: 24 cores, 88 GB (D2C).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d2c.12xlarge</b>: 48 cores, 176 GB (D2C).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d2c.24xlarge</b>: 96 cores, 352 GB (D2C).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d2s.5xlarge</b>: 20 cores, 88 GB (D2S).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d2s.10xlarge</b>: 40 cores, 176 GB (D2S).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d1.2xlarge</b>: 8 cores, 32 GB (D1NE).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d1.4xlarge</b>: 16 cores, 64 GB (D1NE).</para>
                /// </description></item>
                /// <item><description><para><b>lindorm.d1.6xlarge</b>: 24 cores, 96 GB (D1NE).</para>
                /// </description></item>
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
                /// <para>The name of the node group. <b>This parameter is required.</b></para>
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
        /// <item><description><para><b>PREPAY</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
        /// </description></item>
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
        /// <para>The subscription period of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: The unit is month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: The unit is year.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when you set PayType to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the primary zone for a multi-zone instance. The vSwitch must be in the zone specified by PrimaryZoneId. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the region where you want to create the instance. To query the available regions, call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
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
        /// <para>The ID of the vSwitch in the secondary zone for a multi-zone instance. The vSwitch must be in the zone specified by StandbyZoneId. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone for a multi-zone instance. <b>This parameter is required if you want to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) for the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-wz9ydz3vg93s1ozsd****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone for the instance.</para>
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
