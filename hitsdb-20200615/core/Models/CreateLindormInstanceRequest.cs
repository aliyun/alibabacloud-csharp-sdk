// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class CreateLindormInstanceRequest : TeaModel {
        /// <summary>
        /// The ID of the vSwitch that is specified for the zone for the coordinate node of the instance. The vSwitch must be deployed in the zone specified by the ArbiterZoneId parameter. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("ArbiterVSwitchId")]
        [Validation(Required=false)]
        public string ArbiterVSwitchId { get; set; }

        /// <summary>
        /// The ID of the zone for the coordinate node of the instance. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("ArbiterZoneId")]
        [Validation(Required=false)]
        public string ArbiterZoneId { get; set; }

        /// <summary>
        /// The architecture of the instance. Valid values:
        /// 
        /// *   **1.0**: The instance that you want to create is a single-zone instance.
        /// *   **2.0**: The instance that you want to create is a multi-zone instance.
        /// 
        /// By default, the value of this parameter is 1.0. To create a multi-zone instance, set this parameter to 2.0. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("ArchVersion")]
        [Validation(Required=false)]
        public string ArchVersion { get; set; }

        /// <summary>
        /// The cold storage capacity of the instance. By default, if you leave this parameter unspecified, cold storage is not enabled for the instance. Unit: GB. Valid values: **800** to **1000000**.
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public int? ColdStorage { get; set; }

        /// <summary>
        /// The storage capacity of the disk of a single core node. Valid values: 400 to 64000. Unit: GB. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("CoreSingleStorage")]
        [Validation(Required=false)]
        public int? CoreSingleStorage { get; set; }

        /// <summary>
        /// The specification of the nodes in the instance if you set DiskCategory to local_ssd_pro or local_hdd_pro.
        /// 
        /// When DiskCategory is set to local_ssd_pro, you can set this parameter to the following values:
        /// 
        /// *   **lindorm.i2.xlarge**: Each node has 4 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.i2.2xlarge**: Each node has 8 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.i2.4xlarge**: Each node has 16 dedicated CPU cores and 128 GB of dedicated memory.
        /// *   **lindorm.i2.8xlarge**: Each node has 32 dedicated CPU cores and 256 GB of dedicated memory.
        /// 
        /// When DiskCategory is set to local_hdd_pro, you can set this parameter to the following values:
        /// 
        /// *   **lindorm.d1.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.d1.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.d1.6xlarge**: Each node has 24 dedicated CPU cores and 96 GB of dedicated memory.
        /// </summary>
        [NameInMap("CoreSpec")]
        [Validation(Required=false)]
        public string CoreSpec { get; set; }

        /// <summary>
        /// The storage type of the instance. Valid values:
        /// 
        /// *   **cloud_efficiency**: This instance uses the Standard type of storage.
        /// *   **cloud_ssd**: This instance uses the Performance type of storage.
        /// *   **capacity_cloud_storage**: This instance uses the Capacity type of storage.
        /// *   **local_ssd_pro**: This instance uses local SSDs.
        /// *   **local_hdd_pro**: This instance uses local HDDs.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The subscription period of the instance. The valid values of this parameter depend on the value of the PricingCycle parameter.
        /// 
        /// *   If PricingCycle is set to **Month**, set this parameter to an integer that ranges from **1** to **9**.
        /// *   If PricingCycle is set to **Year**, set this parameter to an integer that ranges from **1** to **3**.
        /// 
        /// > This parameter is available and required when the PayType parameter is set to **PREPAY**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// The number of LindormDFS nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.
        /// 
        /// *   If the PayType parameter is set to **PREPAY**, set this parameter to an integer that ranges from **0** to **60**.
        /// *   If the PayType parameter is set to **POSTPAY**, set this parameter to an integer that ranges from **0** to **8**.
        /// </summary>
        [NameInMap("FilestoreNum")]
        [Validation(Required=false)]
        public int? FilestoreNum { get; set; }

        /// <summary>
        /// The specification of LindormDFS nodes in the instance. Set the value of this parameter to **lindorm.c.xlarge**, which indicates that each node has 4 dedicated CPU cores and 8 GB of dedicated memory.
        /// </summary>
        [NameInMap("FilestoreSpec")]
        [Validation(Required=false)]
        public string FilestoreSpec { get; set; }

        /// <summary>
        /// The name of the instance that you want to create.
        /// </summary>
        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        /// <summary>
        /// The storage capacity of the instance you want to create. Unit: GB.
        /// </summary>
        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        /// <summary>
        /// The number of LindormTable nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.
        /// 
        /// *   If the PayType parameter is set to **PREPAY**, set this parameter to an integer that ranges from **0** to **90**.
        /// *   If the PayType parameter is set to **POSTPAY**, set this parameter to an integer that ranges from **0** to **400**.
        /// 
        /// **This parameter is required if you want to create a multi-zone instance**.  The valid values of this parameter range from 4 to 400 if you want to create a multi-zone instance.
        /// </summary>
        [NameInMap("LindormNum")]
        [Validation(Required=false)]
        public int? LindormNum { get; set; }

        /// <summary>
        /// The specification of LindormTable nodes in the instance. Valid values:
        /// 
        /// *   **lindorm.c.xlarge**: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.
        /// *   **lindorm.c.2xlarge**: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.c.4xlarge**: Each node has 16 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.c.8xlarge**: Each node has 32 dedicated CPU cores and 64 GB of dedicated memory.
        /// </summary>
        [NameInMap("LindormSpec")]
        [Validation(Required=false)]
        public string LindormSpec { get; set; }

        /// <summary>
        /// The disk type of the log nodes. Valid values:
        /// 
        /// *   **cloud_efficiency**: This instance uses the Standard type of storage.
        /// *   **cloud_ssd**: This instance uses the Performance type of storage.
        /// 
        /// **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("LogDiskCategory")]
        [Validation(Required=false)]
        public string LogDiskCategory { get; set; }

        /// <summary>
        /// The number of the log nodes. Valid values: 4 to 400. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("LogNum")]
        [Validation(Required=false)]
        public int? LogNum { get; set; }

        /// <summary>
        /// The storage capacity of the disk of a single log node. Valid values: 400 to 64000. Unit: GB. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("LogSingleStorage")]
        [Validation(Required=false)]
        public int? LogSingleStorage { get; set; }

        /// <summary>
        /// The type of the log nodes. Valid values:
        /// 
        /// *   **lindorm.sn1.xlarge**: Each node has 4 dedicated CPU cores and 8 GB of dedicated memory.
        /// *   **lindorm.sn1.2xlarge**: Each node has 8 dedicated CPU cores and 16 GB of dedicated memory.
        /// 
        /// **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("LogSpec")]
        [Validation(Required=false)]
        public string LogSpec { get; set; }

        /// <summary>
        /// The combinations of zones that are available for the multi-zone instance. You can go to the purchase page of Lindorm to view the supported zone combinations.
        /// 
        /// *   **ap-southeast-5abc-aliyun**: Zone A+B+C in the Indonesia (Jakarta) region.
        /// *   **cn-hangzhou-ehi-aliyun**: Zone E+H+I in the China (Hangzhou) region.
        /// *   **cn-beijing-acd-aliyun**: Zone A+C+D in the China (Beijing) region.
        /// *   **ap-southeast-1-abc-aliyun**: Zone A+B+C in the Singapore region.
        /// *   **cn-zhangjiakou-abc-aliyun**: Zone A+B+C in the China (Zhangjiakou) region.
        /// *   **cn-shanghai-efg-aliyun**: Zone E+F+G in the China (Shanghai) region.
        /// *   **cn-shanghai-abd-aliyun**: Zone A+B+D in the China (Shanghai) region.
        /// *   **cn-hangzhou-bef-aliyun**: Zone B+E+F in the China (Hangzhou) region.
        /// *   **cn-hangzhou-bce-aliyun**: Zone B+C+E in the China (Hangzhou) region.
        /// *   **cn-beijing-fgh-aliyun**: Zone F+G+H in the China (Beijing) region.
        /// *   **cn-shenzhen-abc-aliyun**: Zone A+B+C in the China (Shenzhen) region.
        /// 
        /// **This parameter is required if you want to create a multi-zone instance**.
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
        /// The billing method of the instance you want to create. Valid values:
        /// 
        /// *   **PREPAY**: subscription.
        /// *   **POSTPAY**: pay-as-you-go.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The period based on which you are charged for the instance. Valid values:
        /// 
        /// *   **Month**: You are charged for the instance on a monthly basis.
        /// *   **Year**: You are charged for the instance on a yearly basis.
        /// 
        /// > This parameter is available and required when the PayType parameter is set to **PREPAY**.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The ID of the vSwitch that is specified for the secondary zone of the instance. The vSwitch must be deployed in the zone specified by the StandbyZoneId parameter. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("PrimaryVSwitchId")]
        [Validation(Required=false)]
        public string PrimaryVSwitchId { get; set; }

        /// <summary>
        /// 多可用区实例，主可用区的可用区ID。**如果需要创建多可用区实例，该参数必填。**
        /// </summary>
        [NameInMap("PrimaryZoneId")]
        [Validation(Required=false)]
        public string PrimaryZoneId { get; set; }

        /// <summary>
        /// The ID of the region in which you want to create the instance. You can call the [DescribeRegions](~~426062~~) operation to query the region in which you can create the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the Lindorm instance belongs.
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
        /// The number of LindormSearch nodes in the instance. Valid values: integers from **0** to **60**.
        /// </summary>
        [NameInMap("SolrNum")]
        [Validation(Required=false)]
        public int? SolrNum { get; set; }

        /// <summary>
        /// The specification of the LindormSearch nodes in the instance. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("SolrSpec")]
        [Validation(Required=false)]
        public string SolrSpec { get; set; }

        /// <summary>
        /// The ID of the vSwitch that is specified for the secondary zone of the instance. The vSwitch must be deployed in the zone specified by the StandbyZoneId parameter. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// The ID of the secondary zone of the instance. **This parameter is required if you want to create a multi-zone instance**.
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// The number of LindormStream nodes in the instance. Valid values: integers from **0** to **60**.
        /// </summary>
        [NameInMap("StreamNum")]
        [Validation(Required=false)]
        public int? StreamNum { get; set; }

        /// <summary>
        /// The specification of the LindormStream nodes in the instance. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("StreamSpec")]
        [Validation(Required=false)]
        public string StreamSpec { get; set; }

        /// <summary>
        /// The number of the LindormTSDB nodes in the instance. The valid values of this parameter depend on the value of the PayType parameter.
        /// 
        /// *   If the PayType parameter is set to **PREPAY**, set this parameter to an integer that ranges from **0** to **24**.
        /// *   If the PayType parameter is set to **POSTPAY**, set this parameter to an integer that ranges from **0** to **32**.
        /// </summary>
        [NameInMap("TsdbNum")]
        [Validation(Required=false)]
        public int? TsdbNum { get; set; }

        /// <summary>
        /// The specification of the LindormTSDB nodes in the instance. Valid values:
        /// 
        /// *   **lindorm.g.xlarge**: Each node has 4 dedicated CPU cores and 16 GB of dedicated memory.
        /// *   **lindorm.g.2xlarge**: Each node has 8 dedicated CPU cores and 32 GB of dedicated memory.
        /// *   **lindorm.g.4xlarge**: Each node has 16 dedicated CPU cores and 64 GB of dedicated memory.
        /// *   **lindorm.g.8xlarge**: Each node has 32 dedicated CPU cores and 128 GB of dedicated memory.
        /// </summary>
        [NameInMap("TsdbSpec")]
        [Validation(Required=false)]
        public string TsdbSpec { get; set; }

        /// <summary>
        /// The ID of the VPC in which you want to create the instance.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of the vSwitch to which you want the instance to connect.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the zone in which you want to create the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
