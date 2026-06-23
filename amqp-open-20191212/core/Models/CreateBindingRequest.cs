// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateBindingRequest : TeaModel {
        /// <summary>
        /// <para>The key-value pairs for the message header attributes. The message header attributes consist of one or more key-value pairs. The x-match attribute is required. Other attributes are custom. The x-match attribute supports the following values:</para>
        /// <list type="bullet">
        /// <item><description><para>all: This is the default value. All key-value pairs in the message header must match.</para>
        /// </description></item>
        /// <item><description><para>any: At least one key-value pair in the message header must match.</para>
        /// </description></item>
        /// </list>
        /// <para>Separate attributes with semicolons (;) and separate keys from values with colons (:). Example: x-match:all;type:report;format:pdf
        /// This parameter is valid only for headers exchanges. For other types of exchanges, this parameter is ignored.</para>
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
        /// <item><description><para>If the source exchange is not a topic exchange:</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain letters, digits, hyphens (-), underscores (_), periods (.), forward slashes (/), and at signs (@).</para>
        /// </description></item>
        /// <item><description><para>The length must be 1 to 255 characters.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If the source exchange is a topic exchange:</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain letters, digits, hyphens (-), underscores (_), asterisks (\*), periods (.), number signs (#), forward slashes (/), and at signs (@).</para>
        /// </description></item>
        /// <item><description><para>The key cannot start or end with a period (.). If the key starts with a number sign (#) or an asterisk (\<em>), a period (.) must immediately follow. If the key ends with a number sign (#) or an asterisk (\</em>), a period (.) must immediately precede it. If a number sign (#) or an asterisk (\*) is in the middle of the key, it must have a period (.) on both sides.</para>
        /// </description></item>
        /// <item><description><para>The length must be 1 to 255 characters.</para>
        /// </description></item>
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
        /// <para>The type of the destination object. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: Queue</para>
        /// </description></item>
        /// <item><description><para>1: Exchange</para>
        /// </description></item>
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
        /// <para>The name of the binding destination. The destination must be created in the console. It must belong to the same vhost as <c>SourceExchange</c>. The <c>VirtualHost</c> parameter specifies the vhost.</para>
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
        /// <para>The name of the source exchange. This exchange must be created in the console.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NormalEX</para>
        /// </summary>
        [NameInMap("SourceExchange")]
        [Validation(Required=false)]
        public string SourceExchange { get; set; }

        /// <summary>
        /// <para>The name of the vhost. The vhost must be created in the console. Both <c>DestinationName</c> and <c>SourceExchange</c> must belong to this vhost.</para>
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
