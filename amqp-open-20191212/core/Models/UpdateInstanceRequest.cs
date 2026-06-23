// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class UpdateInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The client token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c2c5d1274axxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deployment architecture of the Serverless instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>shared: A shared architecture. This applies to reserved plus elastic (shared) and pay-as-you-go instances.</para>
        /// </description></item>
        /// <item><description><para>dedicated: A dedicated architecture. This applies to reserved plus elastic (dedicated) instances.</para>
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
        /// <para>This feature is for dedicated instances only. Specifies whether to enable data encryption.</para>
        /// <list type="bullet">
        /// <item><description><para>You cannot change the EncryptedInstance and KmsKeyId properties of a dedicated instance. This includes changing its encryption status or downgrading it to a shared instance. Do not include the EncryptedInstance and KmsKeyId parameters when you call UpdateInstance to upgrade or downgrade a dedicated instance.</para>
        /// </description></item>
        /// <item><description><para>The EncryptedInstance and KmsKeyId parameters are used only when you upgrade a shared instance to an encrypted dedicated instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EncryptedInstance")]
        [Validation(Required=false)]
        public bool? EncryptedInstance { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-jtexxxxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance type. This parameter is required for subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>professional: Professional Edition</para>
        /// </description></item>
        /// <item><description><para>enterprise: Enterprise Edition</para>
        /// </description></item>
        /// <item><description><para>vip: Platinum Edition</para>
        /// </description></item>
        /// </list>
        /// <para>You do not need to specify this parameter for pay-as-you-go instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>professional</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>This feature is for dedicated instances only. This parameter is required if EncryptedInstance is set to true.
        /// It specifies the ID of the KMS key used for data encryption.
        /// The key must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The KMS key must be in the same region as the ApsaraMQ for RabbitMQ instance.</para>
        /// </description></item>
        /// <item><description><para>The key cannot be a service key.</para>
        /// </description></item>
        /// <item><description><para>The key must be active.</para>
        /// </description></item>
        /// <item><description><para>The key must be a symmetric key.</para>
        /// </description></item>
        /// <item><description><para>The key must be used for encryption and decryption.</para>
        /// </description></item>
        /// <item><description><para>If the KMS key expires or is deleted, data reads and writes will fail, and the ApsaraMQ for RabbitMQ instance will become unavailable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>key-bjj66c2a893vmhawtq5fd</para>
        /// </summary>
        [NameInMap("KmsKeyId")]
        [Validation(Required=false)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// <para>The maximum number of connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public int? MaxConnections { get; set; }

        /// <summary>
        /// <para>The peak TPS for public network traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("MaxEipTps")]
        [Validation(Required=false)]
        public long? MaxEipTps { get; set; }

        /// <summary>
        /// <para>The peak transactions per second (TPS) for private network traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxPrivateTps")]
        [Validation(Required=false)]
        public long? MaxPrivateTps { get; set; }

        /// <summary>
        /// <para>The type of specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>UPGRADE: Upgrade</para>
        /// </description></item>
        /// <item><description><para>DOWNGRADE: Downgrade</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("ModifyType")]
        [Validation(Required=false)]
        public string ModifyType { get; set; }

        /// <summary>
        /// <para>The provisioned TPS capacity for a reserved plus elastic instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("ProvisionedCapacity")]
        [Validation(Required=false)]
        public int? ProvisionedCapacity { get; set; }

        /// <summary>
        /// <para>The maximum number of queues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("QueueCapacity")]
        [Validation(Required=false)]
        public int? QueueCapacity { get; set; }

        /// <summary>
        /// <para>The billing method of the pay-as-you-go (Serverless) instance. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>onDemand: Pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>onDemand</para>
        /// </summary>
        [NameInMap("ServerlessChargeType")]
        [Validation(Required=false)]
        public string ServerlessChargeType { get; set; }

        /// <summary>
        /// <para>The message storage capacity. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Internet access.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportEip")]
        [Validation(Required=false)]
        public bool? SupportEip { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the message trace feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportTracing")]
        [Validation(Required=false)]
        public bool? SupportTracing { get; set; }

        /// <summary>
        /// <para>The retention period for message traces. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TracingStorageTime")]
        [Validation(Required=false)]
        public int? TracingStorageTime { get; set; }

    }

}
