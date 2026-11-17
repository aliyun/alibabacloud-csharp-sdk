// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateServiceLinkedRoleForProductRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cloud service or the name of the service-linked role associated with the cloud service.</para>
        /// <list type="bullet">
        /// <item><description>AliyunServiceRoleForEventBridgeSendToFC: Performs event delivery to Function Compute.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToSMS: Performs event delivery as text messages to Alibaba Cloud Short Message Service.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToDirectMail: Performs event delivery as emails to Alibaba Cloud Direct Mail.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceRocketMQ: Integrates consumed messages from Message Queue for RocketMQ instances into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceMNS: Integrates Alibaba Cloud Message Service (MNS) into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeConnectVPC: Allows EventBridge to access your VPC.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceActionTrail: Retrieves operation records from ActionTrail as event sources.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceRabbitMQ: Integrates Message Queue for RabbitMQ instances into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRabbitMQ: Performs event delivery of EventBridge events to Message Queue for RabbitMQ instances.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRocketMQ: Performs event delivery of EventBridge events to Message Queue for RocketMQ instances.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceCMS: Integrates Alibaba Cloud monitoring (CMS) into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToKafka: Performs event delivery of EventBridge events to Message Queue for Apache Kafka clusters.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceKafka: Integrates Message Queue for Apache Kafka into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToRDS: Performs event delivery of EventBridge events to Relational Database Service (RDS) instances.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSendToSAE: Performs event delivery of EventBridge events to Serverless App DPI engine (SAE) applications.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceMqtt: Integrates Micro MSMQ for MQTT into EventBridge.</description></item>
        /// <item><description>AliyunServiceRoleForEventBridgeSourceSLS: Integrates Simple Log Service into EventBridge.</description></item>
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
