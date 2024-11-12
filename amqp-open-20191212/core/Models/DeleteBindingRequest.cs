// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class DeleteBindingRequest : TeaModel {
        /// <summary>
        /// <para>The binding key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.test.</para>
        /// </summary>
        [NameInMap("BindingKey")]
        [Validation(Required=false)]
        public string BindingKey { get; set; }

        /// <summary>
        /// <para>The type of the object that you want to unbind from the source exchange. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>QUEUE</b></description></item>
        /// <item><description><b>EXCHANGE</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUEUE</para>
        /// </summary>
        [NameInMap("BindingType")]
        [Validation(Required=false)]
        public string BindingType { get; set; }

        /// <summary>
        /// <para>The name of the object that you want to unbind from the source exchange.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoQueue</para>
        /// </summary>
        [NameInMap("DestinationName")]
        [Validation(Required=false)]
        public string DestinationName { get; set; }

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
        /// <para>The name of the source exchange.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NormalEX</para>
        /// </summary>
        [NameInMap("SourceExchange")]
        [Validation(Required=false)]
        public string SourceExchange { get; set; }

        /// <summary>
        /// <para>The vhost name.</para>
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
