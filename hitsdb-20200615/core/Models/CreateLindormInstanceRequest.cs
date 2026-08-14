// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the VSwitch for the arbiter zone of the multi-zone instance. The VSwitch must be in the zone specified by <c>ArbiterZoneId</c>. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the arbiter zone for the multi-zone instance. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-g</para>
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// <para>The deployment architecture of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1.0</b>: Single-zone deployment.</para>
        /// </description></item>
        /// <item><description><para><b>2.0</b>: Multi-zone deployment.</para>
        /// </description></item>
        /// </list>
        /// <para>The default value is 1.0. To create a multi-zone instance, set this parameter to 2.0. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration, in months.</para>
        /// <para>The value of this parameter ranges from <b>1</b> to <b>12</b>.</para>
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
        /// <para>Specifies whether to enable auto-renewal for the Subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Auto-renewal is disabled.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>PayType</b> parameter is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The cold storage capacity of the instance, in GB. The value of this parameter ranges from <b>800</b> to <b>1,000,000</b>. If you do not specify this parameter, cold storage is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The storage capacity of a single core node in the multi-zone instance. Unit: GB. The value of this parameter ranges from 400 to 64,000. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The node specification for an instance that uses local disks.</para>
        /// <para>If the storage type is <b>local_ssd_pro</b>, valid values include the following: Note that I3-family specifications are available only for Subscription instances.</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.i4.xlarge</b>: 4 cores, 32 GB memory (I4).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i4.2xlarge</b>: 8 cores, 64 GB memory (I4).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i4.4xlarge</b>: 16 cores, 128 GB memory (I4).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i4.8xlarge</b>: 32 cores, 256 GB memory (I4).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i3.xlarge</b>: 4 cores, 32 GB memory (I3).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i3.2xlarge</b>: 8 cores, 64 GB memory (I3).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i3.4xlarge</b>: 16 cores, 128 GB memory (I3).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i3.8xlarge</b>: 32 cores, 256 GB memory (I3).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i2.xlarge</b>: 4 cores, 32 GB memory (I2).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i2.2xlarge</b>: 8 cores, 64 GB memory (I2).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i2.4xlarge</b>: 16 cores, 128 GB memory (I2).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.i2.8xlarge</b>: 32 cores, 256 GB memory (I2).</para>
        /// </description></item>
        /// </list>
        /// <para>If the storage type is <b>local_hdd_pro</b>, valid values include:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.sd3c.3xlarge</b>: 14 cores, 56 GB memory (D3C PRO).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.sd3c.7xlarge</b>: 28 cores, 112 GB memory (D3C PRO).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.sd3c.14xlarge</b>: 56 cores, 224 GB memory (D3C PRO).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d2c.6xlarge</b>: 24 cores, 88 GB memory (D2C).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d2c.12xlarge</b>: 48 cores, 176 GB memory (D2C).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d2c.24xlarge</b>: 96 cores, 352 GB memory (D2C).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d2s.5xlarge</b>: 20 cores, 88 GB memory (D2S).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d2s.10xlarge</b>: 40 cores, 176 GB memory (D2S).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d1.2xlarge</b>: 8 cores, 32 GB memory (D1NE).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d1.4xlarge</b>: 16 cores, 64 GB memory (D1NE).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.d1.6xlarge</b>: 24 cores, 96 GB memory (D1NE).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.i2.xlarge</para>
        /// </summary>
        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_efficiency</b>: Efficiency cloud disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_ssd</b>: Performance cloud disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd</b>: Enhanced SSD (ESSD).</para>
        /// </description></item>
        /// <item><description><para><b>cloud_essd_pl0</b>: ESSD PL0.</para>
        /// </description></item>
        /// <item><description><para><b>capacity_cloud_storage</b>: Capacity-optimized cloud storage. (Not available for multi-zone instances.)</para>
        /// </description></item>
        /// <item><description><para><b>local_ssd_pro</b>: Local SSD. (Not available for multi-zone instances.)</para>
        /// </description></item>
        /// <item><description><para><b>local_hdd_pro</b>: Local HDD. (Not available for multi-zone instances.)</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// <para>The subscription duration for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Month</b>, the value can range from <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Year</b>, the value can range from <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you set <b>PayType</b> to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The number of nodes in the file engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>For a Subscription instance, the value of this parameter ranges from <b>0</b> to <b>60</b>.</para>
        /// </description></item>
        /// <item><description><para>For a Pay-As-You-Go instance, the value of this parameter ranges from <b>0</b> to <b>8</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// <para>The specification of the file engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: 4 cores, 8 GB memory (standard).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm_test</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// <para>The number of nodes in the wide table engine.</para>
        /// <para>For a single-zone instance, the value of this parameter ranges from <b>0</b> to <b>90</b>.</para>
        /// <para><b>This parameter is required for multi-zone instances.</b> For an instance that uses cloud disks, the value ranges from <b>4</b> to <b>400</b>. For an instance that uses local disks, the value ranges from <b>6</b> to <b>400</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// <para>The specification of the wide table engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// <para>The storage type of the log nodes for the multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cloud_efficiency</b>: Efficiency cloud disk.</para>
        /// </description></item>
        /// <item><description><para><b>cloud_ssd</b>: Performance cloud disk.</para>
        /// </description></item>
        /// </list>
        /// <para><b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of log nodes for the multi-zone instance. The value of this parameter ranges from 4 to 400. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The storage capacity of a single log node in the multi-zone instance. Unit: GB. The value of this parameter ranges from 400 to 64,000. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The specification of the log nodes for the multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.sn1.large</b>: 4 cores, 8 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.sn1.2xlarge</b>: 8 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// <para><b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The number of nodes in the LTS engine. The value of this parameter ranges from <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LtsNum")]
        [Validation(Required=false)]
        public string LtsNum { get; set; }

        /// <summary>
        /// <para>The specification of the LTS engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.c.xlarge</b>: 4 cores, 8 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("LtsSpec")]
        [Validation(Required=false)]
        public string LtsSpec { get; set; }

        /// <summary>
        /// <para>The combination of zones for the multi-zone instance. For a list of supported combinations, refer to the instance purchase page.</para>
        /// <list type="bullet">
        /// <item><description><para><b>ap-southeast-5abc-aliyun</b>: Indonesia (Jakarta) A+B+C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-ehi-aliyun</b>: China (Hangzhou) E+H+I.</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing-acd-aliyun</b>: China (Beijing) A+C+D.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1-abc-aliyun</b>: Singapore A+B+C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-zhangjiakou-abc-aliyun</b>: China (Zhangjiakou) A+B+C.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-efg-aliyun</b>: China (Shanghai) E+F+G.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shanghai-abd-aliyun</b>: China (Shanghai) A+B+D.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-bef-aliyun</b>: China (Hangzhou) B+E+F.</para>
        /// </description></item>
        /// <item><description><para><b>cn-hangzhou-bce-aliyun</b>: China (Hangzhou) B+C+E.</para>
        /// </description></item>
        /// <item><description><para><b>cn-beijing-fgh-aliyun</b>: China (Beijing) F+G+H.</para>
        /// </description></item>
        /// <item><description><para><b>cn-shenzhen-abc-aliyun</b>: China (Shenzhen) A+B+C.</para>
        /// </description></item>
        /// </list>
        /// <para><b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-efg-aliyun</para>
        /// </summary>
        [NameInMap("MultiZoneCombination")]
        [Validation(Required=false)]
        public string MultiZoneCombination { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PREPAY</b>: Subscription.</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: Pay-As-You-Go.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle for the Subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you set <b>PayType</b> to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch for the primary zone of the multi-zone instance. The VSwitch must be in the zone specified by <c>PrimaryZoneId</c>. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone for the multi-zone instance. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the latest region list.</para>
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
        /// <para>The number of search engine nodes. The value of this parameter ranges from <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// <para>The specification of the search engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch for the standby zone of the multi-zone instance. The VSwitch must be in the zone specified by <c>StandbyZoneId</c>. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the standby zone for the multi-zone instance. <b>This parameter is required for multi-zone instances.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The number of nodes in the stream engine. The value of this parameter ranges from <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// <para>The specification of the stream engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// <para>The tags to add to the instance. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLindormInstanceRequestTag> Tag { get; set; }
        public class CreateLindormInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of a tag.</para>
            /// <remarks>
            /// <para>You can specify the keys of multiple tags. For example, <c>Tag.1.Key</c> specifies the key of the first tag and <c>Tag.2.Key</c> specifies the key of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of a tag.</para>
            /// <remarks>
            /// <para>You can specify the values of multiple tags. For example, <c>Tag.1.Value</c> specifies the value of the first tag and <c>Tag.2.Value</c> specifies the value of the second tag.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of nodes in the time series engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>For a Subscription instance, the value of this parameter ranges from <b>0</b> to <b>24</b>.</para>
        /// </description></item>
        /// <item><description><para>For a Pay-As-You-Go instance, the value of this parameter ranges from <b>0</b> to <b>32</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// <para>The specification of the time series engine nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lindorm.g.xlarge</b>: 4 cores, 16 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB memory (dedicated).</para>
        /// </description></item>
        /// <item><description><para><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB memory (dedicated).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// <para>The ID of the VPC where you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the VSwitch.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone where you want to create the instance.</para>
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
