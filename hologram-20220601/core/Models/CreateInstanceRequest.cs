// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Automatic payment is enabled.</description></item>
        /// <item><description>false: Only an order is generated, and no payment is made.<remarks>
        /// <para>Default value: true. If your payment method has insufficient balance, you can set the AutoPay parameter to false. In this case, an unpaid order is generated, and you can log on to the Expenses and Costs console to complete the payment.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
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
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("autoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid: Subscription.</description></item>
        /// <item><description>PostPaid: Pay-as-you-go.<remarks>
        /// <para>This parameter is ignored for Shared instances. Shared is a defined specifications type, and its billing method defaults to PostPaid.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The low-frequency storage capacity of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go instances.</para>
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
        /// <item><description>32 cores, 128 GB (Number of compute nodes: 2)</description></item>
        /// <item><description>64 cores, 256 GB (Number of compute nodes: 4)</description></item>
        /// <item><description>96 cores, 384 GB (Number of compute nodes: 6)</description></item>
        /// <item><description>128 cores, 512 GB (Number of compute nodes: 8)</description></item>
        /// <item><description>Other specifications</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Specify the number of cores.</description></item>
        /// <item><description>To purchase an instance with more than 1,024 cores, submit a ticket.</description></item>
        /// <item><description>You do not need to specify the specifications for a Shared instance.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public long? Cpu { get; set; }

        /// <summary>
        /// <para>The subscription duration. For example, set this parameter to 2 for a two-month subscription.</para>
        /// <remarks>
        /// <para>This parameter is not required if the billing method is PostPaid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Serverless Computing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableServerlessComputing")]
        [Validation(Required=false)]
        public bool? EnableServerlessComputing { get; set; }

        /// <summary>
        /// <para>The number of gateways. Valid values: 2 to 50.</para>
        /// <remarks>
        /// <para>This parameter is required only for Warehouse instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// <para>The initial databases.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot</para>
        /// </summary>
        [NameInMap("initialDatabases")]
        [Validation(Required=false)]
        public string InitialDatabases { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 64 characters in length. Each Chinese character or letter counts as one character.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my_holo</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Standard: General-purpose.</description></item>
        /// <item><description>Follower: Read-only secondary instance.</description></item>
        /// <item><description>Warehouse: Compute group.</description></item>
        /// <item><description>Shared: Shared.</description></item>
        /// <item><description>Severless: Serverless.</description></item>
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
        /// <para>The ID of the primary instance. This parameter is required for Follower instances.</para>
        /// <remarks>
        /// <para>The primary and secondary instances must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>The primary instance is in the Running state.</description></item>
        /// <item><description>The primary and secondary instances are in the same region.</description></item>
        /// <item><description>The primary and secondary instances are in the same zone.</description></item>
        /// <item><description>The primary instance is associated with fewer than 10 secondary instances.</description></item>
        /// <item><description>The primary and secondary instances belong to the same Alibaba Cloud account.</description></item>
        /// </list>
        /// </remarks>
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
        /// <item><description>Month: Monthly billing.</description></item>
        /// <item><description>Hour: Hourly billing.<remarks>
        /// <list type="bullet">
        /// <item><description>PrePaid supports only Month.</description></item>
        /// <item><description>PostPaid supports only Hour.</description></item>
        /// <item><description>For Shared instances, this parameter is automatically set to Hour and does not need to be specified.</description></item>
        /// </list>
        /// </remarks>
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
        /// <para>The region ID. You can go to &lt;props=&quot;china&quot;&gt;<a href="https://www.alibabacloud.com/help/en/hologres/developer-reference/api-hologram-2022-06-01-endpoint">service registration endpoints</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/hologres/developer-reference/api-hologram-2022-06-01-endpoint">service registration endpoints</a> to view the supported regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If this parameter is left empty, the default resource group of the account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The standard storage capacity of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The storage type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redundant</para>
        /// </summary>
        [NameInMap("storageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. The zone ID of the vSwitch must be the same as that of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vccsiymtxxxxxx</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). The region ID of the VPC must be the same as that of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4netc3y5xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID. Refer to the usage notes.</para>
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
