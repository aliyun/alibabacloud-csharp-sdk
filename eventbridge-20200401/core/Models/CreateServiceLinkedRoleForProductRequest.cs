// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class CreateServiceLinkedRoleForProductRequest : TeaModel {
        /// <summary>
        /// <para>The name of the cloud service or the service-linked role (SLR) that is associated with the service.</para>
        /// <list type="bullet">
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToFC: Delivers events to Function Compute (FC).</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToSMS: Delivers events as text messages to Short Message Service (SMS).</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToDirectMail: Delivers events as emails to Alibaba Cloud DirectMail.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceRocketMQ: Integrates messages from ApsaraMQ for RocketMQ instances into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceMNS: Integrates Message Service (MNS) into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeConnectVPC: Lets EventBridge access your Virtual Private Cloud (VPC) network.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceActionTrail: Uses operation records from ActionTrail as event sources.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceRabbitMQ: Integrates ApsaraMQ for RabbitMQ instances into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToRabbitMQ: Delivers EventBridge events to ApsaraMQ for RabbitMQ instances.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToRocketMQ: Delivers EventBridge events to ApsaraMQ for RocketMQ instances.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceCMS: Integrates CloudMonitor (CMS) into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToKafka: Delivers EventBridge events to ApsaraMQ for Kafka clusters.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceKafka: Integrates ApsaraMQ for Kafka into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToRDS: Delivers EventBridge events to Relational Database Service (RDS) instances.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSendToSAE: Delivers EventBridge events to Serverless App Engine (SAE) applications.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceMqtt: Integrates ApsaraMQ for MQTT into EventBridge.</para>
        /// </description></item>
        /// <item><description><para>AliyunServiceRoleForEventBridgeSourceSLS: Integrates Simple Log Service (SLS) into EventBridge.</para>
        /// </description></item>
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
