// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateInstanceShrinkRequest : TeaModel {
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
        /// <para>The auto-renewal period. The unit of the auto-renewal period is specified by RenewalDurationUnit. Default value: Month.</para>
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

        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable storage encryption for the instance. This parameter is available only for exclusive instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptedInstance")]
        [Validation(Required=false)]
        public bool? EncryptedInstance { get; set; }

        /// <summary>
        /// <para>The name of the instance. We recommend that you specify a name that does not exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values if you create a subscription instance:</para>
        /// <list type="bullet">
        /// <item><description>professional: Professional Edition.</description></item>
        /// <item><description>enterprise: Enterprise Edition</description></item>
        /// <item><description>vip: Enterprise Platinum Edition</description></item>
        /// </list>
        /// <para>If you create a serverless instance, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The ID of the Key Management Service (KMS)-managed key used for storage encryption. This parameter is available only for exclusive instances and required only if you set EncryptedInstance to true. The key must meet the following conditions:</para>
        /// <list type="bullet">
        /// <item><description>The key cannot be a service key.</description></item>
        /// <item><description>The key must be in the Enabled state.</description></item>
        /// <item><description>The key must be a symmetric key.</description></item>
        /// <item><description>The key must be used for encryption and decryption.</description></item>
        /// <item><description>After the key is expired or deleted, you cannot read or write data and exceptions can occur in the ApsaraMQ for RabbitMQ instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum number of connections that can be established to the instance.</para>
        /// <para>Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// <para>The maximum number of Internet-based TPS on the instance.</para>
        /// <para>Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("MaxEipTps")]
        [Validation(Required=false)]
        public long? MaxEipTps { get; set; }

        /// <summary>
        /// <para>The maximum number of virtual private cloud (VPC)-based transactions per second (TPS) on the instance.</para>
        /// <para>Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxPrivateTps")]
        [Validation(Required=false)]
        public long? MaxPrivateTps { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Subscription: subscription instance</description></item>
        /// <item><description>PayAsYouGo: serverless instance</description></item>
        /// </list>
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
        /// <para>This parameter is valid only if you set PaymentType to Subscription. Default value: Month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodCycle")]
        [Validation(Required=false)]
        public string PeriodCycle { get; set; }

        [NameInMap("ProvisionedCapacity")]
        [Validation(Required=false)]
        public int? ProvisionedCapacity { get; set; }

        /// <summary>
        /// <para>The number of queues on the instance.</para>
        /// <para>Configure this parameter based on the values provided on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RocketMQ buy page</a>.</para>
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
        /// <para> If you configure both this parameter and AutoRenew, the value of this parameter is used.</para>
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

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmvvajg5qkxhi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The billing method of the serverless instance. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>onDemand: You are charged based on your actual usage.</description></item>
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
        /// <item><description>Professional Edition and Enterprise Edition instances: Set the value to 0.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The value 0 specifies that storage space is available for Professional Edition and Enterprise Edition instances, but no storage fees are generated.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Enterprise Platinum Edition instances: Set the value to m × 100, where m is an integer that ranges from 7 to 28.</description></item>
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
        /// <item><description><para>Enterprise Platinum Edition instances allow you to retain message traces for 15 days free of charge. If you create an Enterprise Platinum Edition instance, you can set this parameter only to true and TracingStorageTime only to 15.</para>
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

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The retention period of messages. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3</description></item>
        /// <item><description>7</description></item>
        /// <item><description>15</description></item>
        /// </list>
        /// <para>This parameter is valid only if you set SupportTracing to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TracingStorageTime")]
        [Validation(Required=false)]
        public int? TracingStorageTime { get; set; }

    }

}
