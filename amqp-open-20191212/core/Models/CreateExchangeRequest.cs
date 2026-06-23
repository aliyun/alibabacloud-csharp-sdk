// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateExchangeRequest : TeaModel {
        /// <summary>
        /// <para>The alternate exchange. Configure an alternate exchange to receive messages that fail to be routed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoAE</para>
        /// </summary>
        [NameInMap("AlternateExchange")]
        [Validation(Required=false)]
        public string AlternateExchange { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically delete the exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes. The exchange is automatically deleted after the last queue is unbound from it.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: No. The exchange is not automatically deleted after the last queue is unbound from it.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoDeleteState")]
        [Validation(Required=false)]
        public bool? AutoDeleteState { get; set; }

        /// <summary>
        /// <para>The name of the exchange. Note:</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@). The name must be 1 to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The name of an exchange cannot be changed after the exchange is created. To change the name, delete the exchange and create a new one.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoExchange</para>
        /// </summary>
        [NameInMap("ExchangeName")]
        [Validation(Required=false)]
        public string ExchangeName { get; set; }

        /// <summary>
        /// <para>The type of the exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DIRECT</b>: This routing rule type routes messages to a queue whose binding key exactly matches the routing key of the message.</para>
        /// </description></item>
        /// <item><description><para><b>TOPIC</b>: This type is similar to the DIRECT type. It routes messages to bound queues using routing key pattern matching and string comparison.</para>
        /// </description></item>
        /// <item><description><para><b>FANOUT</b>: This routing rule type is simple. It routes all messages sent to the exchange to all queues that are bound to the exchange. This works like a broadcast feature.</para>
        /// </description></item>
        /// <item><description><para><b>HEADERS</b>: This type is similar to the DIRECT type. It uses header properties instead of a routing key for routing. When a queue is bound to a headers exchange, key-value pairs are defined for the binding. When a message is sent to the exchange, key-value pairs are defined in the message header. The exchange routes the message by comparing the key-value pairs in the header with the key-value pairs of the binding.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECT</para>
        /// </summary>
        [NameInMap("ExchangeType")]
        [Validation(Required=false)]
        public string ExchangeType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-v0h1kb9nu***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the exchange is an internal exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: No</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Yes</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Internal")]
        [Validation(Required=false)]
        public bool? Internal { get; set; }

        /// <summary>
        /// <para>The name of the vhost to which the exchange belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

        /// <summary>
        /// <para>An x-delayed-message exchange lets you use the x-delay header property to specify a delivery delay for a message in milliseconds. The routing rule for the delayed message is determined by the exchange type that you specify for the XDelayedType parameter. This parameter sets the actual exchange type to which the message is delivered after the delay. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>DIRECT</b>: Delivers the delayed message to the specified queue that is bound to a DIRECT exchange.</para>
        /// </description></item>
        /// <item><description><para><b>TOPIC</b>: Delivers the delayed message to queues that are bound to a TOPIC exchange.</para>
        /// </description></item>
        /// <item><description><para><b>FANOUT</b>: Delivers the delayed message to queues that are bound to a FANOUT exchange.</para>
        /// </description></item>
        /// <item><description><para><b>HEADERS</b>: Delivers the delayed message to queues that are bound to a HEADERS exchange.</para>
        /// </description></item>
        /// <item><description><para><b>X-JMS-TOPIC</b>: Delivers the delayed message to queues that are bound to an X-JMS-TOPIC exchange.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DIRECT</para>
        /// </summary>
        [NameInMap("XDelayedType")]
        [Validation(Required=false)]
        public string XDelayedType { get; set; }

    }

}
