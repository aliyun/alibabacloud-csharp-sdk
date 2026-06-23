// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp_open20191212.Models
{
    public class AddInstanceWhiteListShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the instance receiving the whitelist entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rabbitmq-cn-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP addresses or VPC IDs to add to the whitelist. Specify IP addresses as CIDR blocks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.0.0.20/30</para>
        /// </summary>
        [NameInMap("WhiteListItem")]
        [Validation(Required=false)]
        public string WhiteListItemShrink { get; set; }

        /// <summary>
        /// <para>The type of the whitelist. Set this parameter to <c>2</c> if <c>WhiteListItem</c> contains IP addresses, or to <c>1</c> if it contains VPC IDs.</para>
        /// <para>You can add a VPC whitelist only to instances that have an <c>anytunnel</c> VPC endpoint. Newer instances use the <c>privateLink</c> endpoint type, which does not support this feature.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("WhiteListType")]
        [Validation(Required=false)]
        public int? WhiteListType { get; set; }

    }

}
