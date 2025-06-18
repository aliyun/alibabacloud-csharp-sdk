// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateServiceLinkedRoleForProductRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cloud service or the name of the service-linked role with which the cloud service is associated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AliyunServiceRoleForEventBridgeSendToFC: allows EventBridge to deliver events to Function Compute.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToSMS: allows EventBridge to deliver events to Short Message Service (SMS).</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToDirectMail: allows EventBridge to deliver events to Direct Mail.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceRocketMQ: allows EventBridge to integrate with ApsaraMQ for RocketMQ.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceMNS: allows EventBridge to integrate with Simple Message Queue (SMQ, formerly MNS).</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeConnectVPC: allows EventBridge to access virtual private clouds (VPCs).</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceActionTrail: allows EventBridge to integrate with ActionTrail.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceRabbitMQ: allows EventBridge to integrate with ApsaraMQ for RabbitMQ.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRabbitMQ: allows EventBridge to deliver events to ApsaraMQ for RabbitMQ.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRocketMQ: allows EventBridge to deliver events to ApsaraMQ for RocketMQ.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceCMS: allow EventBridge to integrate with CloudMonitor.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToKafka: allows EventBridge to deliver events to ApsaraMQ for Kafka.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceKafka: allows EventBridge to integrate with ApsaraMQ for Kafka.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRDS: allows EventBridge to deliver events to ApsaraDB RDS.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToSAE: allows EventBridge to deliver events to Serverless App Engine (SAE).</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceMqtt: allows EventBridge to integrate with ApsaraMQ for MQTT.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceSLS: allows EventBridge to integrate with Simple Log Service.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForEventBridgeSendToMNS</para>
        /// </summary>
        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

    }

}
