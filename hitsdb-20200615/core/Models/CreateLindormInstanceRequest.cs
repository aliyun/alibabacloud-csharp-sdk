// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The vSwitch ID of the arbiter zone for a multi-zone instance. The vSwitch must be in the zone specified by ArbiterZoneId. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the arbiter zone for a multi-zone instance. <b>To create a multi-zone instance, this parameter is required.</b></para>
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
        /// <para>If this parameter is not specified, the default value is 1.0. To create a multi-zone instance, set this parameter to 2.0. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0</para>
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months.</para>
        /// <para>Valid values: <b>1</b> to <b>12</b>.</para>
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
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b>: Auto-renewal is disabled.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>PayType</b> is set to <b>PREPAY</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The capacity cloud storage capacity of the instance. Unit: GB. If this parameter is not specified, capacity cloud storage is not enabled. Valid values: <b>800</b> to <b>1000000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The storage capacity per core node for a multi-zone instance. Valid values: 400 to 64000. Unit: GB. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The node specifications for local disk type of the instance.</para>
        /// <para>When the local storage type is local_ssd_pro, valid values are as follows. I3 instance types currently support only subscription:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.i4.xlarge</b>: 4 cores, 32 GB (I4).</description></item>
        /// <item><description><b>lindorm.i4.2xlarge</b>: 8 cores, 64 GB (I4).</description></item>
        /// <item><description><b>lindorm.i4.4xlarge</b>: 16 cores, 128 GB (I4).</description></item>
        /// <item><description><b>lindorm.i4.8xlarge</b>: 32 cores, 256 GB (I4).</description></item>
        /// <item><description><b>lindorm.i3.xlarge</b>: 4 cores, 32 GB (I3).</description></item>
        /// <item><description><b>lindorm.i3.2xlarge</b>: 8 cores, 64 GB (I3).</description></item>
        /// <item><description><b>lindorm.i3.4xlarge</b>: 16 cores, 128 GB (I3).</description></item>
        /// <item><description><b>lindorm.i3.8xlarge</b>: 32 cores, 256 GB (I3).</description></item>
        /// <item><description><b>lindorm.i2.xlarge</b>: 4 cores, 32 GB (I2).</description></item>
        /// <item><description><b>lindorm.i2.2xlarge</b>: 8 cores, 64 GB (I2).</description></item>
        /// <item><description><b>lindorm.i2.4xlarge</b>: 16 cores, 128 GB (I2).</description></item>
        /// <item><description><b>lindorm.i2.8xlarge</b>: 32 cores, 256 GB (I2).</description></item>
        /// </list>
        /// <para>When the local storage type is local_hdd_pro, valid values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.sd3c.3xlarge</b>: 14 cores, 56 GB (D3C PRO).</description></item>
        /// <item><description><b>lindorm.sd3c.7xlarge</b>: 28 cores, 112 GB (D3C PRO).</description></item>
        /// <item><description><b>lindorm.sd3c.14xlarge</b>: 56 cores, 224 GB (D3C PRO).</description></item>
        /// <item><description><b>lindorm.d2c.6xlarge</b>: 24 cores, 88 GB (D2C).</description></item>
        /// <item><description><b>lindorm.d2c.12xlarge</b>: 48 cores, 176 GB (D2C).</description></item>
        /// <item><description><b>lindorm.d2c.24xlarge</b>: 96 cores, 352 GB (D2C).</description></item>
        /// <item><description><b>lindorm.d2s.5xlarge</b>: 20 cores, 88 GB (D2S).</description></item>
        /// <item><description><b>lindorm.d2s.10xlarge</b>: 40 cores, 176 GB (D2S).</description></item>
        /// <item><description><b>lindorm.d1.2xlarge</b>: 8 cores, 32 GB (D1NE).</description></item>
        /// <item><description><b>lindorm.d1.4xlarge</b>: 16 cores, 64 GB (D1NE).</description></item>
        /// <item><description><b>lindorm.d1.6xlarge</b>: 24 cores, 96 GB (D1NE).</description></item>
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
        /// <item><description><b>cloud_efficiency</b>: standard cloud storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd</b>: enhanced performance cloud storage.</description></item>
        /// <item><description><b>cloud_essd_pl0</b>: performance cloud storage PL0.</description></item>
        /// <item><description><b>capacity_cloud_storage</b>: capacity cloud storage (not supported for multi-zone instances).</description></item>
        /// <item><description><b>local_ssd_pro</b>: local SSD (not supported for multi-zone instances).</description></item>
        /// <item><description><b>local_hdd_pro</b>: local HDD (not supported for multi-zone instances).</description></item>
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
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If PricingCycle is set to <b>Month</b>, valid values are <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If PricingCycle is set to <b>Year</b>, valid values are <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required when PayType is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The number of file engine nodes of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of the instance is <b>PREPAY</b>, valid values are <b>0</b> to <b>60</b>.</description></item>
        /// <item><description>If the billing method of the instance is <b>POSTPAY</b>, valid values are <b>0</b> to <b>8</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// <para>The file engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: 4 cores, 8 GB (standard).</description></item>
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
        /// <para>The storage capacity of the instance. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// <para>The number of LindormTable engine nodes of the instance.</para>
        /// <para>To create a single-zone instance, valid values are <b>0</b> to <b>90</b>.</para>
        /// <para><b>To create a multi-zone instance, this parameter is required.</b> For instances with non-local disk storage types, valid values are <b>4</b> to <b>400</b>. For instances with local disk storage types, valid values are <b>6</b> to <b>400</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// <para>The LindormTable engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.4xlarge</para>
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// <para>The disk type of log nodes for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: standard cloud storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: performance cloud storage.</description></item>
        /// </list>
        /// <para><b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of log nodes for a multi-zone instance. Valid values: 4 to 400. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The storage capacity per log node for a multi-zone instance. Valid values: 400 to 64000. Unit: GB. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The log node specifications for a multi-zone instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.sn1.large</b>: 4 cores, 8 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.sn1.2xlarge</b>: 8 cores, 16 GB (dedicated).</description></item>
        /// </list>
        /// <para><b>To create a multi-zone instance, this parameter is required and active.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The number of LTS engine nodes of the instance. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LtsNum")]
        [Validation(Required=false)]
        public string LtsNum { get; set; }

        /// <summary>
        /// <para>The LTS engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: 4 cores, 8 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("LtsSpec")]
        [Validation(Required=false)]
        public string LtsSpec { get; set; }

        /// <summary>
        /// <para>The multi-zone combination. You can check the supported zone combinations on the buy page.</para>
        /// <list type="bullet">
        /// <item><description><b>ap-southeast-5abc-aliyun</b>: Indonesia (Jakarta) A+B+C.</description></item>
        /// <item><description><b>cn-hangzhou-ehi-aliyun</b>: China (Hangzhou) E+H+I.</description></item>
        /// <item><description><b>cn-beijing-acd-aliyun</b>: China (Beijing) A+C+D.</description></item>
        /// <item><description><b>ap-southeast-1-abc-aliyun</b>: Singapore A+B+C.</description></item>
        /// <item><description><b>cn-zhangjiakou-abc-aliyun</b>: China (Zhangjiakou) A+B+C.</description></item>
        /// <item><description><b>cn-shanghai-efg-aliyun</b>: China (Shanghai) E+F+G.</description></item>
        /// <item><description><b>cn-shanghai-abd-aliyun</b>: China (Shanghai) A+B+D.</description></item>
        /// <item><description><b>cn-hangzhou-bef-aliyun</b>: China (Hangzhou) B+E+F.</description></item>
        /// <item><description><b>cn-hangzhou-bce-aliyun</b>: China (Hangzhou) B+C+E.</description></item>
        /// <item><description><b>cn-beijing-fgh-aliyun</b>: China (Beijing) F+G+H.</description></item>
        /// <item><description><b>cn-shenzhen-abc-aliyun</b>: China (Shenzhen) A+B+C.</description></item>
        /// </list>
        /// <para><b>To create a multi-zone instance, this parameter is required.</b></para>
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
        /// <item><description><b>PREPAY</b>: subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go.</description></item>
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
        /// <para>The billing cycle of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: monthly billing.</description></item>
        /// <item><description><b>Year</b>: yearly billing.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required when PayType is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the primary zone for a multi-zone instance. The vSwitch must be in the zone specified by PrimaryZoneId. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary zone for a multi-zone instance. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> to query available regions. Use this parameter to specify the region in which to create the instance.</para>
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
        /// <para>The number of search index engine nodes of the instance. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// <para>The search index engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the secondary zone for a multi-zone instance. The vSwitch must be in the zone specified by StandbyZoneId. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary zone for a multi-zone instance. <b>To create a multi-zone instance, this parameter is required.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The number of stream engine nodes of the instance. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// <para>The stream engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: 8 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: 16 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: 32 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLindormInstanceRequestTag> Tag { get; set; }
        public class CreateLindormInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>You can specify multiple tag keys. For example, the Key in the first pair specifies the first tag key, and the Key in the second pair specifies the second tag key.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para>You can specify multiple tag values. For example, the Value in the first pair specifies the first tag value, and the Value in the second pair specifies the second tag value.</para>
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
        /// <para>The number of LindormTSDB engine nodes of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the billing method of the instance is <b>PREPAY</b>, valid values are <b>0</b> to <b>24</b>.</description></item>
        /// <item><description>If the billing method of the instance is <b>POSTPAY</b>, valid values are <b>0</b> to <b>32</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// <para>The LindormTSDB engine node specifications of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: 4 cores, 16 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: 8 cores, 32 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: 16 cores, 64 GB (dedicated).</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: 32 cores, 128 GB (dedicated).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// <para>The VPC ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <para>This parameter is required.</para>
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
