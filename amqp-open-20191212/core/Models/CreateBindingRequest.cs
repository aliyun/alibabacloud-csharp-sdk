// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateBindingRequest : TeaModel {
        /// <summary>
        /// <para>The key-value pairs that are configured for the headers attributes of a message. One or more key-value pairs can be concatenated to configure the headers attributes of a message. You must specify the x-match attribute as one of the valid values. You can specify custom values for other attributes. Valid values of the x-match attribute:</para>
        /// <list type="bullet">
        /// <item><description>\*\<em>all: \</em>\*A headers exchange routes a message to a queue only if all binding attributes of the queue except for x-match match the headers attributes of the message. This value is the default value.</description></item>
        /// <item><description>\*\<em>any: \</em>\*A headers exchange routes a message to a queue if one or more binding attributes of the queue except for x-match match the headers attributes of the message.</description></item>
        /// </list>
        /// <para>Separate the attributes with semicolons (;). Separate the key and value of an attribute with a colon (:). Example: x-match:all;type:report;format:pdf. This parameter is available for only headers exchanges. You can set this parameter to an arbitrary value for other types of exchanges.</para>
        /// 
        /// <b>Example:</b>
        /// <para>x-match:all;type:report;format:pdf</para>
        /// </summary>
        [NameInMap("Argument")]
        [Validation(Required=false)]
        public string Argument { get; set; }

        /// <summary>
        /// <para>The binding key.</para>
        /// <list type="bullet">
        /// <item><description><para>If the source exchange is not a topic exchange, the binding key must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The binding key can contain only letters, digits, hyphens (-), underscores (_), periods (.), forward slashes (/), and at signs (@).</description></item>
        /// <item><description>The binding key must be 1 to 255 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If the source exchange is a topic exchange, the binding key must meet the following conventions:</para>
        /// <list type="bullet">
        /// <item><description>The binding key can contain letters, digits, hyphens (-), underscores (_), asterisks (\*), periods (.), number signs (#), forward slashes (/), and at signs (@).</description></item>
        /// <item><description>The binding key cannot start or end with a period (.). If a binding key starts with a number sign (#) or an asterisk (\<em>), the number sign (#) or asterisk (\</em>) must be followed by a period (.). If the binding key ends with a number sign (#) or an asterisk (\<em>), the number sign (#) or asterisk (\</em>) must be preceded by a period (.). If a number sign (#) or an asterisk (\<em>) is used in the middle of a binding key, the number sign (#) or asterisk (\</em>) must be preceded and followed by a period (.).</description></item>
        /// <item><description>The binding key must be 1 to 255 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>.test</para>
        /// </summary>
        [NameInMap("BindingKey")]
        [Validation(Required=false)]
        public string BindingKey { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to bind to the source exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\*\<em>0: \</em>\*Queue</description></item>
        /// <item><description>\*\<em>1: \</em>\*Exchange</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BindingType")]
        [Validation(Required=false)]
        public string BindingType { get; set; }

        /// <summary>
        /// <para>The name of the object that you want to bind to the source exchange. You must create the object in the ApsaraMQ for RabbitMQ console in advance. The vhost of the object is the same as the vhost to which the source exchange specified by <b>SourceExchange</b> belongs. The vhost of the source exchange is the one specified by <b>VirtualHost</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoQueue</para>
        /// </summary>
        [NameInMap("DestinationName")]
        [Validation(Required=false)]
        public string DestinationName { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-v0h1kb9nu***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the source exchange. You must create the source exchange in the ApsaraMQ for RabbitMQ console in advance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NormalEX</para>
        /// </summary>
        [NameInMap("SourceExchange")]
        [Validation(Required=false)]
        public string SourceExchange { get; set; }

        /// <summary>
        /// <para>The virtual host (vhost) name. You must create the vhost in the ApsaraMQ for RabbitMQ console in advance. The object specified by <b>DestinationName</b> and the source exchange specified by <b>SourceExchange</b> must belong to the vhost.</para>
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
