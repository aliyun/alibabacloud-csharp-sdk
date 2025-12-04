// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the vSwitch that is specified for the zone for the coordinate node of the instance. The vSwitch must be deployed in the zone specified by the ArbiterZoneId parameter. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6664pqjawb87k36****</para>
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone for the coordinate node of the instance. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
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
        /// <item><description><b>1.0</b>: The instance that you want to create is a single-zone instance.</description></item>
        /// <item><description><b>2.0</b>: The instance that you want to create is a multi-zone instance.</description></item>
        /// </list>
        /// <para>By default, the value of this parameter is 1.0. To create a multi-zone instance, set this parameter to 2.0. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
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
        /// <para> This parameter is available only when the <b>AutoRenewal</b> parameter is set to <b>true</b>.</para>
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
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b>: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// <remarks>
        /// <para> This parameter is available only when the <b>PayType</b> parameter is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// <para>The cold storage capacity of the instance. By default, if you leave this parameter unspecified, cold storage is not enabled for the instance. Unit: GB. Valid values: <b>800</b> to <b>1000000</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk of a single core node. Valid values: 400 to 64000. Unit: GB. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// <para>The specification of the nodes in the instance if you set DiskCategory to local_ssd_pro or local_hdd_pro.</para>
        /// <para>Valid values when DiskCategory is set to local_ssd_pro (i3 instance types support only subscription instances):</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.i4.xlarge</b>: Each node has 4 CPU cores and 32 GB of memory.</description></item>
        /// <item><description><b>lindorm.i4.2xlarge</b>: Each node has 8 CPU cores and 64 GB of memory.</description></item>
        /// <item><description><b>lindorm.i4.4xlarge</b>: Each node has 16 CPU cores and 128 GB of memory.</description></item>
        /// <item><description><b>lindorm.i4.8xlarge</b>: Each node has 32 CPU cores and 256 GB of memory.</description></item>
        /// <item><description><b>lindorm.i3.xlarge</b>: Each node has 4 CPU cores and 32 GB of memory.</description></item>
        /// <item><description><b>lindorm.i3.2xlarge</b>: Each node has 8 CPU cores and 64 GB of memory.</description></item>
        /// <item><description><b>lindorm.i3.4xlarge</b>: Each node has 16 CPU cores and 128 GB of memory.</description></item>
        /// <item><description><b>lindorm.i3.8xlarge</b>: Each node has 32 CPU cores and 256 GB of memory.</description></item>
        /// <item><description><b>lindorm.i2.xlarge</b>: Each node has 4 CPU cores and 32 GB of memory.</description></item>
        /// <item><description><b>lindorm.i2.2xlarge</b>: Each node has 8 CPU cores and 64 GB of memory.</description></item>
        /// <item><description><b>lindorm.i2.4xlarge</b>: Each node has 16 CPU cores and 128 GB of memory.</description></item>
        /// <item><description><b>lindorm.i2.8xlarge</b>: Each node has 32 CPU cores and 256 GB of memory.</description></item>
        /// </list>
        /// <para>Valid values when DiskCategory is set to local_hhd_pro:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.sd3c.3xlarge</b>: Each node has 14 CPU cores and 56 GB of memory.</description></item>
        /// <item><description><b>lindorm.sd3c.7xlarge</b>: Each node has 28 CPU cores and 112 GB of memory.</description></item>
        /// <item><description><b>lindorm.sd3c.14xlarge</b>: Each node has 56 CPU cores and 224 GB of memory.</description></item>
        /// <item><description><b>lindorm.d2c.6xlarge</b>: Each node has 24 CPU cores and 88 GB of memory.</description></item>
        /// <item><description><b>lindorm.d2c.12xlarge</b>: Each node has 48 CPU cores and 176 GB of memory.</description></item>
        /// <item><description><b>lindorm.d2c.24xlarge</b>: Each node has 96 CPU cores and 352 GB of memory.</description></item>
        /// <item><description><b>lindorm.d2s.5xlarge</b>: Each node has 20 CPU cores and 88 GB of memory.</description></item>
        /// <item><description><b>lindorm.d2s.10xlarge</b>: Each node has 40 CPU cores and 176 GB of memory.</description></item>
        /// <item><description><b>lindorm.d1.2xlarge</b>: Each node has 8 CPU cores and 32 GB of memory.</description></item>
        /// <item><description><b>lindorm.d1.4xlarge</b>: Each node has 16 CPU cores and 64 GB of memory.</description></item>
        /// <item><description><b>lindorm.d1.6xlarge</b>: Each node has 24 CPU cores and 96 GB of memory.</description></item>
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
        /// <item><description><b>cloud_efficiency</b>: This instance uses the Standard type of storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: This instance uses the Performance type of storage.</description></item>
        /// <item><description><b>capacity_cloud_storage</b>: This instance uses the Capacity type of storage.</description></item>
        /// <item><description><b>local_ssd_pro</b>: This instance uses local SSDs.</description></item>
        /// <item><description><b>local_hdd_pro</b>: This instance uses local HDDs.</description></item>
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
        /// <para>The subscription period of the instance. The valid values of this parameter depend on the value of the PricingCycle parameter.</para>
        /// <list type="bullet">
        /// <item><description>If PricingCycle is set to <b>Month</b>, set this parameter to an integer that ranges from <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If PricingCycle is set to <b>Year</b>, set this parameter to an integer that ranges from <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required when the PayType parameter is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The number of LindormDFS nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the PayType parameter is set to <b>PREPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>60</b>.</description></item>
        /// <item><description>If the PayType parameter is set to <b>POSTPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>8</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// <para>The specification of LindormDFS nodes in the instance. Set the value of this parameter to <b>lindorm.c.xlarge</b>, which indicates that each node has 4 dedicated CPU cores and 8 GB of dedicated memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// <para>The name of the instance that you want to create.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm_test</para>
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance you want to create. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>480</para>
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// <para>The number of LindormTable nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the PayType parameter is set to <b>PREPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>90</b>.</description></item>
        /// <item><description>If the PayType parameter is set to <b>POSTPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>400</b>.</description></item>
        /// </list>
        /// <para><b>This parameter is required if you want to create a multi-zone instance</b>.  The valid values of this parameter range from 4 to 400 if you want to create a multi-zone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// <para>The specification of LindormTable nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: Each node has 16 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: Each node has 32 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.c.xlarge</para>
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// <para>The disk type of the log nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud_efficiency</b>: This instance uses the Standard type of storage.</description></item>
        /// <item><description><b>cloud_ssd</b>: This instance uses the Performance type of storage.</description></item>
        /// </list>
        /// <para><b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// <para>The number of the log nodes. Valid values: 4 to 400. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// <para>The storage capacity of the disk of a single log node. Valid values: 400 to 64000. Unit: GB. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>400</para>
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// <para>The type of the log nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.sn1.xlarge</b>: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.sn1.2xlarge</b>: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// </list>
        /// <para><b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.sn1.large</para>
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// <para>The number of LTS nodes in the instance. Valid values: <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("LtsNum")]
        [Validation(Required=false)]
        public string LtsNum { get; set; }

        /// <summary>
        /// <para>The specification of LTS nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.c.xlarge</b>: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.xlarge</b>: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: Each node has 16 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: Each node has 32 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("LtsSpec")]
        [Validation(Required=false)]
        public string LtsSpec { get; set; }

        /// <summary>
        /// <para>The combinations of zones that are available for the multi-zone instance. You can go to the purchase page of Lindorm to view the supported zone combinations.</para>
        /// <list type="bullet">
        /// <item><description><b>ap-southeast-5abc-aliyun</b>: Zone A+B+C in the Indonesia (Jakarta) region.</description></item>
        /// <item><description><b>cn-hangzhou-ehi-aliyun</b>: Zone E+H+I in the China (Hangzhou) region.</description></item>
        /// <item><description><b>cn-beijing-acd-aliyun</b>: Zone A+C+D in the China (Beijing) region.</description></item>
        /// <item><description><b>ap-southeast-1-abc-aliyun</b>: Zone A+B+C in the Singapore region.</description></item>
        /// <item><description><b>cn-zhangjiakou-abc-aliyun</b>: Zone A+B+C in the China (Zhangjiakou) region.</description></item>
        /// <item><description><b>cn-shanghai-efg-aliyun</b>: Zone E+F+G in the China (Shanghai) region.</description></item>
        /// <item><description><b>cn-shanghai-abd-aliyun</b>: Zone A+B+D in the China (Shanghai) region.</description></item>
        /// <item><description><b>cn-hangzhou-bef-aliyun</b>: Zone B+E+F in the China (Hangzhou) region.</description></item>
        /// <item><description><b>cn-hangzhou-bce-aliyun</b>: Zone B+C+E in the China (Hangzhou) region.</description></item>
        /// <item><description><b>cn-beijing-fgh-aliyun</b>: Zone F+G+H in the China (Beijing) region.</description></item>
        /// <item><description><b>cn-shenzhen-abc-aliyun</b>: Zone A+B+C in the China (Shenzhen) region.</description></item>
        /// </list>
        /// <para><b>This parameter is required if you want to create a multi-zone instance</b>.</para>
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
        /// <para>The billing method of the instance you want to create. Valid values:</para>
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
        /// <para>The period based on which you are charged for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: You are charged for the instance on a monthly basis.</description></item>
        /// <item><description><b>Year</b>: You are charged for the instance on a yearly basis.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available and required when the PayType parameter is set to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is specified for the secondary zone of the instance. The vSwitch must be deployed in the zone specified by the StandbyZoneId parameter. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-uf6fdqa7c0pipnqzq****</para>
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// <para>Multi-zone instance, availability zone ID of the primary zone. <b>This parameter is required if you need to create a multi-zone instance.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-e</para>
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you want to create the instance. You can call the <a href="https://help.aliyun.com/document_detail/426062.html">DescribeRegions</a> operation to query the region in which you can create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the Lindorm instance belongs.</para>
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
        /// <para>The number of LindormSearch nodes in the instance. Valid values: integers from <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// <para>The specification of the LindormSearch nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.2xlarge</b>: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.4xlarge</b>: Each node has 16 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.c.8xlarge</b>: Each node has 32 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch that is specified for the secondary zone of the instance. The vSwitch must be deployed in the zone specified by the StandbyZoneId parameter. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2zec0kcn08cgdtr6****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone of the instance. <b>This parameter is required if you want to create a multi-zone instance</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai-f</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The number of LindormStream nodes in the instance. Valid values: integers from <b>0</b> to <b>60</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// <para>The specification of the LindormStream nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// <para>The tags that are added to instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLindormInstanceRequestTag> Tag { get; set; }
        public class CreateLindormInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20.</para>
            /// <remarks>
            /// <para> You can specify the keys of multiple tags. For example, you can specify the key of the first tag in the first key-value pair contained in the value of this parameter and specify the key of the second tag in the second key-value pair.</para>
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
            /// <para> You can specify the values of multiple tags. For example, you can specify the value of the first tag in the first key-value pair contained in the value of this parameter and specify the value of the second tag in the second key-value pair.</para>
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
        /// <para>The number of the LindormTSDB nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the PayType parameter is set to <b>PREPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>24</b>.</description></item>
        /// <item><description>If the PayType parameter is set to <b>POSTPAY</b>, set this parameter to an integer that ranges from <b>0</b> to <b>32</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// <para>The specification of the LindormTSDB nodes in the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lindorm.g.xlarge</b>: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.2xlarge</b>: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.4xlarge</b>: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.</description></item>
        /// <item><description><b>lindorm.g.8xlarge</b>: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lindorm.g.xlarge</para>
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// <para>The ID of the VPC in which you want to create the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1nme44gek34slfc****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which you want the instance to connect.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1e7clcw529l773d****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the zone in which you want to create the instance.</para>
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
