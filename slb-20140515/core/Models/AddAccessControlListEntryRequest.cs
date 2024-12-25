// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class AddAccessControlListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the network ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>entry</b>: the IP entries that you want to add to the network ACL. You can add CIDR blocks. Separate multiple CIDR blocks with commas (,).</description></item>
        /// <item><description><b>comment</b>: the comment on the network ACL.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can add at most 50 IP entries to a network ACL in each call. If the IP entry that you want to add to a network ACL already exists, the IP entry is not added. The IP entries that you add must be CIDR blocks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;entry&quot;:&quot;<c>10.0.**.**</c>/24&quot;,&quot;comment&quot;:&quot;privaterule1&quot;},{&quot;entry&quot;:&quot;<c>192.168.**.**</c>/16&quot;,&quot;comment&quot;:&quot;privaterule2&quot;}]</para>
        /// </summary>
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public string AclEntrys { get; set; }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-bp1l0kk4gxce43kze*****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
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

    }

}
