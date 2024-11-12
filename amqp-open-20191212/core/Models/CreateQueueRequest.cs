// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateQueueRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically delete the queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The queue is automatically deleted. After the last consumer unsubscribes from the queue, the queue is automatically deleted.</description></item>
        /// <item><description>false: The queue is not automatically deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoDeleteState")]
        [Validation(Required=false)]
        public bool? AutoDeleteState { get; set; }

        /// <summary>
        /// <para>The validity period after which the queue is automatically deleted. If the queue is not accessed within the specified period of time, the queue is automatically deleted.</para>
        /// <para>Unit: milliseconds.</para>
        /// <remarks>
        /// <para> You can use the feature that corresponds to this parameter only after you enable the feature. To enable the feature, <a href="https://ticket-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AutoExpireState")]
        [Validation(Required=false)]
        public long? AutoExpireState { get; set; }

        /// <summary>
        /// <para>The dead-letter exchange. A dead-letter exchange is used to receive rejected messages.</para>
        /// <para>If a consumer rejects a message that cannot be redelivered, ApsaraMQ for RabbitMQ routes the message to the specified dead-letter exchange. Then, the dead-letter exchange routes the message to the queue that is bound to the dead-letter exchange for storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLExchange</para>
        /// </summary>
        [NameInMap("DeadLetterExchange")]
        [Validation(Required=false)]
        public string DeadLetterExchange { get; set; }

        /// <summary>
        /// <para>The dead-letter routing key. The key must be 1 to 255 characters in length, and can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.dl</para>
        /// </summary>
        [NameInMap("DeadLetterRoutingKey")]
        [Validation(Required=false)]
        public string DeadLetterRoutingKey { get; set; }

        /// <summary>
        /// <para>Specifies whether the exchange is an exclusive exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The exchange is an exclusive exchange. Only the connection that declares the exclusive exchange can use the exclusive exchange. After the connection is closed, the exclusive exchange is automatically deleted.</description></item>
        /// <item><description>false: The exchange is not an exclusive exchange.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExclusiveState")]
        [Validation(Required=false)]
        public bool? ExclusiveState { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance on which you want to create a queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-v0h1kb9nu***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable in the current version of ApsaraMQ for RabbitMQ.</para>
        /// <para>The maximum number of messages that can be stored in the queue. If this threshold is exceeded, the earliest stored messages in the queue are deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// <para>Queue priorities are not supported. The value does not affect the call or return results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumPriority")]
        [Validation(Required=false)]
        public int? MaximumPriority { get; set; }

        /// <summary>
        /// <para>The message time to live (TTL) of the queue.</para>
        /// <list type="bullet">
        /// <item><description>If the retention period of a message in the queue exceeds the message TTL of the queue, the message expires.</description></item>
        /// <item><description>The message TTL must be set to a non-negative integer. The maximum message TTL is one day. Unit: milliseconds. For example, if the message TTL is 1,000 milliseconds, the message can be retained for up to 1 second in the queue.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MessageTTL")]
        [Validation(Required=false)]
        public long? MessageTTL { get; set; }

        /// <summary>
        /// <para>The name of the queue that you want to create.</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 255 characters in length, and can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</description></item>
        /// <item><description>After the queue is created, you cannot change the name of the queue. If you want to change the name of the queue, delete the queue and create another queue.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoQueue</para>
        /// </summary>
        [NameInMap("QueueName")]
        [Validation(Required=false)]
        public string QueueName { get; set; }

        /// <summary>
        /// <para>The name of the vhost to which the queue that you want to create belongs. The name must be 1 to 255 characters in length, and can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
