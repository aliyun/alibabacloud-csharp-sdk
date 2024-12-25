// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddListenerWhiteListItemRequest : TeaModel {
        /// <summary>
        /// <para>The frontend port that is used by the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The frontend protocol that is used by the CLB instance.</para>
        /// <remarks>
        /// <para> This parameter is required when listeners that use different protocols listen on the same port.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1o94dp5i6ea*******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Classic Load Balancer (CLB) instance is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IP addresses or CIDR blocks that you want to add to the whitelist.</para>
        /// <para>This parameter takes effect when the <b>AccessControlStatus</b> parameter of the listener is set to <b>open_white_list</b>.</para>
        /// <para>Separate multiple IP addresses or CIDR blocks with commas (,).</para>
        /// <para>You cannot enter <b>0.0.0.0</b> or <b>0.0.0.0/0</b>. To disable access control, you can call the <a href="https://help.aliyun.com/document_detail/27599.html">SetListenerAccessControlStatus</a> operation to set the value of the <b>AccessControlStatus</b> parameter to <b>close</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("SourceItems")]
        [Validation(Required=false)]
        public string SourceItems { get; set; }

    }

}
