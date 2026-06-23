// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ram openSource</para>
        /// </summary>
        [NameInMap("AuthModel")]
        [Validation(Required=false)]
        public string AuthModel { get; set; }

        /// <summary>
        /// <para>The renewal method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables auto-renewal.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables auto-renewal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. The <c>RenewalDurationUnit</c> parameter specifies the unit, which defaults to month.</para>
        /// <remarks>
        /// <para>This parameter is required if you set <c>AutoRenew</c> to <c>true</c>. The default value is 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// <para>The client token used to ensure request idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2c5d1274axxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment architecture for the serverless instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>shared</c>: The shared architecture, which is applicable to reserved and elastic (shared) instances and pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para><c>dedicated</c>: The dedicated architecture, which is applicable to reserved and elastic (dedicated) instances.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>shared</para>
        /// </summary>
        [NameInMap("Edition")]
        [Validation(Required=false)]
        public string Edition { get; set; }

        /// <summary>
        /// <para>This parameter is applicable only to dedicated instances. Specifies whether to enable data-at-rest encryption for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptedInstance")]
        [Validation(Required=false)]
        public bool? EncryptedInstance { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name can be up to 64 characters long.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-xxxxx</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The instance type.
        /// This parameter is required for subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>professional</c>: Professional Edition</para>
        /// </description></item>
        /// <item><description><para><c>enterprise</c>: Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para><c>vip</c>: Platinum Edition</para>
        /// </description></item>
        /// </list>
        /// <para>You do not need to specify this parameter for serverless instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>This parameter applies only to dedicated instances and is required if <c>EncryptedInstance</c> is set to <c>true</c>. It specifies the ID of the KMS key used for data-at-rest encryption. The key must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The key cannot be a service key.</para>
        /// </description></item>
        /// <item><description><para>The key must be in the Enabled state.</para>
        /// </description></item>
        /// <item><description><para>The key must be a symmetric key, not an asymmetric key.</para>
        /// </description></item>
        /// <item><description><para>The key usage must be for encryption and decryption.</para>
        /// </description></item>
        /// <item><description><para>If the KMS key expires or is deleted, data reads and writes will become unavailable, and the ApsaraMQ for RabbitMQ instance may become inoperable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>key-xxx</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable only the TLS-encrypted port. This parameter applies only to reserved and elastic (dedicated) instances, and Platinum Edition instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp_and_ssl</para>
        /// </summary>
        [NameInMap("ListenerMode")]
        [Validation(Required=false)]
        public string ListenerMode { get; set; }

        /// <summary>
        /// <para>The maximum number of connections.</para>
        /// <para>For information about the valid values, see the instance specifications on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ</a> product page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50000</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// <para>The peak transactions per second (TPS) of the instance over the public network.</para>
        /// <para>For information about the valid values, see the instance specifications on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ</a> product page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("MaxEipTps")]
        [Validation(Required=false)]
        public long? MaxEipTps { get; set; }

        /// <summary>
        /// <para>The peak transactions per second (TPS) of the instance over a private network.</para>
        /// <para>For information about the valid values, see the instance specifications on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ</a> product page.</para>
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
        /// <item><description><para><c>Subscription</c>: The subscription-based billing method.</para>
        /// </description></item>
        /// <item><description><para><c>PayAsYouGo</c>: The pay-as-you-go method for serverless instances.</para>
        /// </description></item>
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
        /// <para>The subscription duration. The <c>PeriodCycle</c> parameter specifies the unit.</para>
        /// <remarks>
        /// <para>This parameter is required if you set <c>PaymentType</c> to <c>Subscription</c>. The default value is 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Month</c>: month</para>
        /// </description></item>
        /// <item><description><para><c>Year</c>: year</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if you set <c>PaymentType</c> to <c>Subscription</c>. The default value is <c>Month</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PeriodCycle")]
        [Validation(Required=false)]
        public string PeriodCycle { get; set; }

        /// <summary>
        /// <para>The provisioned TPS capacity for a reserved and elastic instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("ProvisionedCapacity")]
        [Validation(Required=false)]
        public int? ProvisionedCapacity { get; set; }

        /// <summary>
        /// <para>The queue capacity of the instance.</para>
        /// <para>For information about the valid values, see the instance specifications on the <a href="https://common-buy.aliyun.com/?commodityCode=ons_onsproxy_pre">ApsaraMQ for RabbitMQ</a> product page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("QueueCapacity")]
        [Validation(Required=false)]
        public int? QueueCapacity { get; set; }

        /// <summary>
        /// <para>The renewal status. This parameter is equivalent to <c>AutoRenew</c>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>AutoRenewal</c>: Enables auto-renewal.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Both <c>AutoRenew</c> and <c>RenewStatus</c> specify the renewal method. If you specify both parameters, the value of <c>RenewStatus</c> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RenewStatus")]
        [Validation(Required=false)]
        public string RenewStatus { get; set; }

        /// <summary>
        /// <para>The unit of the auto-renewal duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Month</c>: month</para>
        /// </description></item>
        /// <item><description><para><c>Year</c>: year</para>
        /// </description></item>
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
        /// <para>The ID of the security group. This security group is used for the PrivateLink-based endpoint. The security group must meet the following requirements:</para>
        /// <ol>
        /// <item><description><para>Add an inbound rule to allow traffic on TCP ports 5672 and 5671.</para>
        /// </description></item>
        /// <item><description><para>Managed security groups are not supported.</para>
        /// </description></item>
        /// <item><description><para>The security group must belong to the specified VPC.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-xxx</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The billing type of the serverless instance. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>onDemand</c>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onDemand</para>
        /// </summary>
        [NameInMap("ServerlessChargeType")]
        [Validation(Required=false)]
        public string ServerlessChargeType { get; set; }

        [NameInMap("ServerlessSwitch")]
        [Validation(Required=false)]
        public bool? ServerlessSwitch { get; set; }

        /// <summary>
        /// <para>The message storage space. Unit: GB. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Professional Edition and Enterprise Edition instances: The value is fixed at 0.</description></item>
        /// </list>
        /// <remarks>
        /// <para>A value of 0 means storage is not charged for Professional Edition and Enterprise Edition instances; it does not mean the instances lack storage space.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Platinum Edition instances: m × 100, where m is an integer from 7 to 28.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable access over the public network. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables access over the public network.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables access over the public network.</para>
        /// </description></item>
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
        /// <item><description><para><c>true</c>: Enables the message trace feature.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables the message trace feature.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The message trace feature is included for 15 days at no charge on Platinum Edition instances. For these instances, you must enable this feature and set the retention period to 15 days.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>For other instance types, you can enable or disable this feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportTracing")]
        [Validation(Required=false)]
        public bool? SupportTracing { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The retention period of message traces. Unit: days. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>3</c></para>
        /// </description></item>
        /// <item><description><para><c>7</c></para>
        /// </description></item>
        /// <item><description><para><c>15</c></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if you set <c>SupportTracing</c> to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TracingStorageTime")]
        [Validation(Required=false)]
        public int? TracingStorageTime { get; set; }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is used to create a PrivateLink-based endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The vSwitch IDs used to create a PrivateLink-based endpoint when you create the instance. The vSwitches must meet the following requirements:</para>
        /// <ol>
        /// <item><description><para>You must specify two vSwitches that reside in different availability zones, except for regions that have only a single availability zone.</para>
        /// </description></item>
        /// <item><description><para>The vSwitches must belong to the specified VPC.</para>
        /// </description></item>
        /// <item><description><para>The vSwitches must be in the Available state.</para>
        /// </description></item>
        /// <item><description><para>Each vSwitch must have at least 20 available IP addresses.</para>
        /// </description></item>
        /// <item><description><para>The availability zones for the specified vSwitches must support NLB instance creation.</para>
        /// </description></item>
        /// </ol>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VswitchIds")]
        [Validation(Required=false)]
        public string VswitchIdsShrink { get; set; }

    }

}
