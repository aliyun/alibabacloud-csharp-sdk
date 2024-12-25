// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class RemoveAccessControlListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The IP entries that you want to remove from the network ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>entry</b>: the IP address or CIDR block that you want to remove from the network ACL. Separate multiple IP addresses or CIDR blocks with commas (,).</description></item>
        /// <item><description><b>comment</b>: the description of the network ACL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;entry&quot;:&quot;10.0.10.0/24&quot;,&quot;comment&quot;:&quot;privaterule1&quot;}]</para>
        /// </summary>
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public string AclEntrys { get; set; }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-bp1l0kk4gxce43k******</para>
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
        /// <para>The ID of the region where the network ACL is created.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
