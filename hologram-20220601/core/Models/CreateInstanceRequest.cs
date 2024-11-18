// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-payment. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If the balance of your account is insufficient, you can set this parameter to false. In this case, an unpaid order is generated. You can log on to the User Center to pay for the order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable monthly auto-renewal. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: subscription</description></item>
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is invalid for shared instances. Shared instances have fixed specifications and are pay-as-you-go instances.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The infrequent access (IA) storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is invalid for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The instance specifications. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>8-core 32 GB (number of compute nodes: 1)</description></item>
        /// <item><description>16-core 64 GB (number of compute nodes: 1)</description></item>
        /// <item><description>32-core 128 GB (number of compute nodes: 2)</description></item>
        /// <item><description>64-core 256 GB (number of compute nodes: 4)</description></item>
        /// <item><description>96-core 384 GB (number of compute nodes: 6)</description></item>
        /// <item><description>128-core 512 GB (number of compute nodes: 8)</description></item>
        /// <item><description>Others</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Set this parameter to the number of cores.</para>
        /// </description></item>
        /// <item><description><para>If you want to set this parameter to specifications with more than 1,024 compute units (CUs), you must submit a ticket.</para>
        /// </description></item>
        /// <item><description><para>If you want to purchase a shared instance, you do not need to configure this parameter.</para>
        /// </description></item>
        /// <item><description><para>The specifications of 8-core 32 GB (number of compute nodes: 1) are for trial use only and cannot be used for production.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The validity period of the instance that you want to purchase. For example, you can specify a validity period of two months.</para>
        /// <remarks>
        /// <para>You do not need to configure this parameter for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// <para>The number of gateways. Valid values: 2 to 50.</para>
        /// <remarks>
        /// <para>This parameter is required only for virtual warehouse instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        [NameInMap("initialDatabases")]
        [Validation(Required=false)]
        public string InitialDatabases { get; set; }

        /// <summary>
        /// <para>The name of the Hologres instance that you want to purchase. The name must be 2 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_holo</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: general-purpose instance</description></item>
        /// <item><description>Follower: read-only secondary instance</description></item>
        /// <item><description>Warehouse: virtual warehouse instance</description></item>
        /// <item><description>Shared: shared instance</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("instanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the primary instance. This parameter is required for read-only secondary instances.</para>
        /// <remarks>
        /// <para>The primary instance and secondary instances must meet the following requirements:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The primary instance is in the Running state.</para>
        /// </description></item>
        /// <item><description><para>The primary instance and secondary instances are deployed in the same region.</para>
        /// </description></item>
        /// <item><description><para>The primary instance and secondary instances are deployed in the same zone.</para>
        /// </description></item>
        /// <item><description><para>Less than 10 secondary instances are associated with the primary instance.</para>
        /// </description></item>
        /// <item><description><para>The primary and secondary instances belong to the same Alibaba Cloud account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hgpostcn-cn-lbj3aworq112</para>
        /// </summary>
        [NameInMap("leaderInstanceId")]
        [Validation(Required=false)]
        public string LeaderInstanceId { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Hour</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter can only be set to Month for subscription instances.</para>
        /// </description></item>
        /// <item><description><para>This parameter can only be set to Hour for pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>By default, this parameter is set to Hour for shared instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The ID of the region. You can go to the <a href="https://api.aliyun.com/product/Hologram">OpenAPI Explorer</a> or the Usage notes section to view the ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group. If you do not specify this parameter, the default resource group of the account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The standard storage space of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is invalid for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. The zone in which the vSwitch resides must be the same as the zone in which the instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vccsiymtxxxxxx</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). The region in which the VPC resides must be the same as the region in which the Hologres instance resides.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4netc3y5xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The ID of the zone. For more information about how to obtain the ID of the zone, see the Usage notes section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-h</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
