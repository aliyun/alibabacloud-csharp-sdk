// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal. If you select this value, you must manually renew the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set AutoRenew to true. Default value: 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2c5d1274axxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("EncryptedInstance")]
        [Validation(Required=false)]
        public bool? EncryptedInstance { get; set; }

        /// <summary>
        /// <para>The instance name. We recommend that you specify a name that does not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>professional: Professional Edition</description></item>
        /// <item><description>enterprise: Enterprise Edition</description></item>
        /// <item><description>vip: Enterprise Platinum Edition</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum number of connections that can be established to the instance. Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// <para>The maximum number of EIP-based TPS on the instance. Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("MaxEipTps")]
        [Validation(Required=false)]
        public long? MaxEipTps { get; set; }

        /// <summary>
        /// <para>The maximum number of virtual private cloud (VPC)-based transactions per second (TPS) on the instance. Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxPrivateTps")]
        [Validation(Required=false)]
        public long? MaxPrivateTps { get; set; }

        /// <summary>
        /// <para>The billing method. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Subscription</description></item>
        /// </list>
        /// <remarks>
        /// <para> API operations provided by ApsaraMQ for RabbitMQ are supported only by subscription instances. You can set this parameter only to Subscription.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Subscription</para>
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The subscription period. The unit of the subscription period is specified by periodCycle.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set PaymentType to Subscription. Default value: 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you set PaymentType to Subscription. Default value: Month.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodCycle")]
        [Validation(Required=false)]
        public string PeriodCycle { get; set; }

        /// <summary>
        /// <para>The number of queues. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Professional Edition: 50 to 1000. The number of queues must increase in increments of 5.</description></item>
        /// <item><description>Enterprise Edition: 200 to 6000. The number of queues must increase in increments of 100.</description></item>
        /// <item><description>Enterprise Platinum Edition: 10000 to 80000. The number of queues must increase in increments of 100.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("QueueCapacity")]
        [Validation(Required=false)]
        public int? QueueCapacity { get; set; }

        /// <summary>
        /// <para>The renewal status. This parameter is the same as AutoRenew. You can configure one of these parameters. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>AutoRenewal</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you configure both this parameter and AutoRenew, the value of this parameter is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Month</description></item>
        /// <item><description>Year</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("RenewalDurationUnit")]
        [Validation(Required=false)]
        public string RenewalDurationUnit { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The billing method of the pay-as-you-go instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>onDemand: You are charged based on your actual usage</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onDemand</para>
        /// </summary>
        [NameInMap("ServerlessChargeType")]
        [Validation(Required=false)]
        public string ServerlessChargeType { get; set; }

        /// <summary>
        /// <para>The storage capacity. Unit: GB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Professional Edition and Enterprise Edition instances: Set this parameter to 0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value 0 specifies that storage space is available for Professional Edition and Enterprise Edition instances, but no storage fees are generated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Platinum Edition instances: Set the value to m × 100, where m ranges from 7 to 28.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether elastic IP addresses (EIPs) are supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>True</description></item>
        /// <item><description>False</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportEip")]
        [Validation(Required=false)]
        public bool? SupportEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the message trace feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Enterprise Platinum Edition instances allow you to retain message traces for 15 days free of charge. If you use an Enterprise Platinum Edition instance, you can set this parameter only to true and TracingStorageTime only to 15.</para>
        /// </description></item>
        /// <item><description><para>For instances of other editions, you can set this parameter to true or false.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportTracing")]
        [Validation(Required=false)]
        public bool? SupportTracing { get; set; }

        /// <summary>
        /// <para>The retention period of messages. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3</description></item>
        /// <item><description>7</description></item>
        /// <item><description>15</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you set SupportTracing to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TracingStorageTime")]
        [Validation(Required=false)]
        public int? TracingStorageTime { get; set; }

    }

}
