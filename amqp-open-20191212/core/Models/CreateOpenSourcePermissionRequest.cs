// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class CreateOpenSourcePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see How to ensure idempotence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f6af6bb123988d191bfe01c9a9b</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The regular expression for the configure permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>^$</para>
        /// </summary>
        [NameInMap("Configure")]
        [Validation(Required=false)]
        public string Configure { get; set; }

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
        /// <para>The regular expression for the read permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>^$</para>
        /// </summary>
        [NameInMap("Read")]
        [Validation(Required=false)]
        public string Read { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myName</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The vhost name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vhostName</para>
        /// </summary>
        [NameInMap("Vhost")]
        [Validation(Required=false)]
        public string Vhost { get; set; }

        /// <summary>
        /// <para>The regular expression for the write permission.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order_exchange</para>
        /// </summary>
        [NameInMap("Write")]
        [Validation(Required=false)]
        public string Write { get; set; }

    }

}
