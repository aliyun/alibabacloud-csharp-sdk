// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true (default): Automatic payment is enabled.</para>
        /// </description></item>
        /// <item><description><para>false: An order is generated, but no payment is made.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If your account balance is insufficient, set the <c>autoPay</c> parameter to <c>false</c>. When an unpaid order is generated, log on to the Expenses and Costs console to pay for the order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("autoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para>false (default): Auto-renewal is disabled.</para>
        /// </description></item>
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
        /// <item><description><para>PrePaid: Subscription.</para>
        /// </description></item>
        /// <item><description><para>PostPaid: Pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is ignored for shared instances. Shared instances use defined specifications and the default billing method is pay-as-you-go..</para>
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
        /// <para>The cold storage capacity of the instance. Unit: GB.</para>
        /// <remarks>
        /// <para>This parameter is ignored for pay-as-you-go (PostPaid) instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("coldStorageSize")]
        [Validation(Required=false)]
        public long? ColdStorageSize { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>32 vCPUs and 128 GB of memory (2 compute nodes)</para>
        /// </description></item>
        /// <item><description><para>64 vCPUs and 256 GB of memory (4 compute nodes)</para>
        /// </description></item>
        /// <item><description><para>96 vCPUs and 384 GB of memory (6 compute nodes)</para>
        /// </description></item>
        /// <item><description><para>128 vCPUs and 512 GB of memory (8 compute nodes)</para>
        /// </description></item>
        /// <item><description><para>and so on.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Specify the number of vCPUs.</para>
        /// </description></item>
        /// <item><description><para>To purchase an instance with more than 1,024 vCPUs, submit a ticket.</para>
        /// </description></item>
        /// <item><description><para>You do not need to specify the instance type for a shared instance.</para>
        /// </description></item>
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
        /// <para>The subscription duration, such as two months.</para>
        /// <remarks>
        /// <para>Specify this parameter only for subscription instances.</para>
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
        /// <para>The number of gateways. Valid values: [2, 50].</para>
        /// <remarks>
        /// <para>You must specify this parameter only for virtual warehouse instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("gatewayCount")]
        [Validation(Required=false)]
        public long? GatewayCount { get; set; }

        /// <summary>
        /// <para>The initial database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot</para>
        /// </summary>
        [NameInMap("initialDatabases")]
        [Validation(Required=false)]
        public string InitialDatabases { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 64 characters in length. A letter is counted as one character.</para>
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
        /// <item><description><para>Standard: General-purpose instance.</para>
        /// </description></item>
        /// <item><description><para>Follower: Read-only secondary instance.</para>
        /// </description></item>
        /// <item><description><para>Warehouse: Virtual warehouse instance.</para>
        /// </description></item>
        /// <item><description><para>Shared: Shared instance.</para>
        /// </description></item>
        /// <item><description><para>Serverless: Serverless instance.</para>
        /// </description></item>
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
        /// <para>The ID of the primary instance. This parameter is required for secondary instances.</para>
        /// <remarks>
        /// <para>The primary and secondary instances must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description><para>The primary instance is in the Running state.</para>
        /// </description></item>
        /// <item><description><para>The primary and secondary instances are in the same region and zone.</para>
        /// </description></item>
        /// <item><description><para>They are in the same zone.</para>
        /// </description></item>
        /// <item><description><para>The primary instance has less than 10 secondary instances.</para>
        /// </description></item>
        /// <item><description><para>The primary and secondary instances belong to the same Alibaba Cloud account.</para>
        /// </description></item>
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
        /// <item><description><para>Month: The instance is billed on a monthly basis.</para>
        /// </description></item>
        /// <item><description><para>Hour: The instance is billed on an hourly basis.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Subscription instances support only <c>Month</c>.</para>
        /// </description></item>
        /// <item><description><para>Pay-as-you-go instances support only <c>Hour</c>.</para>
        /// </description></item>
        /// <item><description><para>For shared instances, the value is automatically set to <c>Hour</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("pricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region ID. For more information, see &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/hologres/developer-reference/api-hologram-2022-06-01-endpoint">Endpoints</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/zh/hologres/developer-reference/api-hologram-2022-06-01-endpoint">Endpoints</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group. If you leave this parameter empty, the default resource group for your account is used.</para>
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
        /// <para>This parameter is ignored for pay-as-you-go (PostPaid) instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>The storage class.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redundant</para>
        /// </summary>
        [NameInMap("storageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch. The vSwitch must be in the same zone as the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vccsiymtxxxxxx</para>
        /// </summary>
        [NameInMap("vSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). The VPC must be in the same region as the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-t4netc3y5xxxx</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
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
