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
        /// <item><description><para>true: The queue is automatically deleted after the last consumer unsubscribes from it.</para>
        /// </description></item>
        /// <item><description><para>false: The queue is not automatically deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoDeleteState")]
        [Validation(Required=false)]
        public bool? AutoDeleteState { get; set; }

        /// <summary>
        /// <para>The auto-expiration time for the queue. The queue is automatically deleted if it is not accessed within the specified time period.</para>
        /// <para>Unit: milliseconds.</para>
        /// <remarks>
        /// <para>This feature must be enabled before you can use this parameter. To enable the feature, &lt;props=&quot;china&quot;&gt;<a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>&lt;props=&quot;intl&quot;&gt;<a href="https://ticket-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AutoExpireState")]
        [Validation(Required=false)]
        public long? AutoExpireState { get; set; }

        /// <summary>
        /// <para>The dead-letter exchange. This type of exchange is used to receive rejected messages.</para>
        /// <para>If a consumer rejects a message and the message is not requeued, ApsaraMQ for RabbitMQ routes the message to the specified dead-letter exchange. The dead-letter exchange then routes the message to a bound queue for storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DLExchange</para>
        /// </summary>
        [NameInMap("DeadLetterExchange")]
        [Validation(Required=false)]
        public string DeadLetterExchange { get; set; }

        /// <summary>
        /// <para>The dead-letter routing key.
        /// The key can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@). The key must be 1 to 255 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test.dl</para>
        /// </summary>
        [NameInMap("DeadLetterRoutingKey")]
        [Validation(Required=false)]
        public string DeadLetterRoutingKey { get; set; }

        /// <summary>
        /// <para>Specifies whether the queue is an exclusive queue. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The queue is an exclusive queue. An exclusive queue can be used only by the connection that declares it. The queue is automatically deleted after the connection is closed.</para>
        /// </description></item>
        /// <item><description><para>false: The queue is not an exclusive queue.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ExclusiveState")]
        [Validation(Required=false)]
        public bool? ExclusiveState { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance to which the queue belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-v0h1kb9nu***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is not supported in the current version.</para>
        /// <para>The maximum number of messages that can be stored in the queue. If this limit is exceeded, the earliest messages in the queue are deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// <para>The priority of the queue. The recommended value is an integer from 1 to 10.</para>
        /// <remarks>
        /// <para>This parameter is used for message priority. It is supported only by dedicated instances and can be used only after the message priority feature is enabled. To enable the feature, &lt;props=&quot;china&quot;&gt;<a href="https://selfservice.console.aliyun.com/ticket/createIndex">submit a ticket</a>&lt;props=&quot;intl&quot;&gt;<a href="https://ticket-intl.console.aliyun.com/#/ticket/createIndex">submit a ticket</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaximumPriority")]
        [Validation(Required=false)]
        public int? MaximumPriority { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) of a message in the queue.</para>
        /// <list type="bullet">
        /// <item><description><para>A message expires if its retention time in the queue exceeds the configured TTL.</para>
        /// </description></item>
        /// <item><description><para>The message TTL must be a non-negative integer. The maximum value is 1 day. The unit is milliseconds. For example, if the value is 1000, the message can be stored in the queue for a maximum of 1 second.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MessageTTL")]
        [Validation(Required=false)]
        public long? MessageTTL { get; set; }

        /// <summary>
        /// <para>The name of the queue to create.</para>
        /// <list type="bullet">
        /// <item><description><para>The queue name can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@). The name must be 1 to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>After a queue is created, its name cannot be changed. To change the name, delete the queue and create a new one.</para>
        /// </description></item>
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
        /// <para>The name of the vhost to which the queue belongs.
        /// The name can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@). The name must be 1 to 255 characters in length.</para>
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
