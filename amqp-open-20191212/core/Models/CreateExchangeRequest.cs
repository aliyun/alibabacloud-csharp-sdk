// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateExchangeRequest : TeaModel {
        /// <summary>
        /// <para>The alternate exchange. An alternate exchange is used to receive messages that fail to be routed to queues from the current exchange.</para>
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
        /// <item><description><b>true</b>: If the last queue that is bound to the exchange is unbound, the exchange is automatically deleted.</description></item>
        /// <item><description><b>false</b>: If the last queue that is bound to the exchange is unbound, the exchange is not automatically deleted.</description></item>
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
        /// <para>The name of the exchange that you want to create. The exchange name must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 255 characters in length, and can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</description></item>
        /// <item><description>After the exchange is created, you cannot change its name. If you want to change its name, delete the exchange and create another exchange.</description></item>
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
        /// <para>The exchange type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>DIRECT</b>: An exchange of this type routes a message to the queue whose binding key is exactly the same as the routing key of the message.</description></item>
        /// <item><description><b>TOPIC</b>: This type of exchange is similar to direct exchanges. An exchange of this type routes a message to one or more queues based on the results of the fuzzy match or multi-condition match between the routing key of the message and the binding keys of the current exchange.</description></item>
        /// <item><description><b>FANOUT</b>: An exchange of this type routes all received messages to all queues bound to this exchange. You can use a fanout exchange to broadcast messages.</description></item>
        /// <item><description><b>HEADERS</b>: This type of exchange is similar to direct exchanges. The only difference is that a headers exchange routes messages based on the headers attributes instead of routing keys. When you bind a headers exchange to a queue, you must configure binding attributes in the key-value format for the binding. When you send a message to a headers exchange, you must configure the headers attributes in the key-value format for the message. After a headers exchange receives a message, the exchange routes the message based on the matching results between the headers attributes of the message and the binding attributes of the bound queues.</description></item>
        /// <item><description><b>X-CONSISTENT-HASH</b>: An exchange of this type allows you to perform hash calculations on routing keys or header values and use consistent hashing to route a message to different queues.</description></item>
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
        /// <para>The ID of the ApsaraMQ for RabbitMQ for which you want to create an exchange.</para>
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
        /// <item><description><b>false</b></description></item>
        /// <item><description><b>true</b></description></item>
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
        /// <para>The name of the vhost to which the exchange that you want to create belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

        [NameInMap("XDelayedType")]
        [Validation(Required=false)]
        public string XDelayedType { get; set; }

    }

}
