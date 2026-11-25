// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class UpdateInstanceIpWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to clear the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Delete")]
        [Validation(Required=false)]
        public bool? Delete { get; set; }

        /// <summary>
        /// <para>The name of the whitelist group. Default value: user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_group</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/426069.html">GetLindormInstanceList</a> operation to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1z3506imz2f****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IP addresses to add to the whitelist.</para>
        /// <remarks>
        /// <para>A value of 127.0.0.1 indicates that access from all IP addresses is denied. For example, 192.168.0.0/24 allows access from all IP addresses in the 192.168.0.X CIDR block to the Lindorm instance. Separate multiple IP addresses with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.X/24</para>
        /// </summary>
        [NameInMap("SecurityIpList")]
        [Validation(Required=false)]
        public string SecurityIpList { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
