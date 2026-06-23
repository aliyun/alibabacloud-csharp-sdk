// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateVirtualHostRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ApsaraMQ for RabbitMQ instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amqp-cn-v0h1kb9n***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the vhost to create. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The name can contain only letters, digits, hyphens (-), underscores (_), periods (.), number signs (#), forward slashes (/), and at signs (@).</para>
        /// </description></item>
        /// <item><description><para>The name must be 1 to 255 characters in length.</para>
        /// </description></item>
        /// <item><description><para>The vhost name cannot be changed after creation. To use a different name, delete the vhost and create a new one.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Demo</para>
        /// </summary>
        [NameInMap("VirtualHost")]
        [Validation(Required=false)]
        public string VirtualHost { get; set; }

    }

}
