// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddIPv6TranslatorAclListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The remarks of the ACL entry.</para>
        /// <para>It must be 2 to 100 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientIP1</para>
        /// </summary>
        [NameInMap("AclEntryComment")]
        [Validation(Required=false)]
        public string AclEntryComment { get; set; }

        /// <summary>
        /// <para>The IPv6 address or IPv6 CIDR block that you want to add to the ACL entry, for example, 12XX:0:0:XXXX::0102 or 12XX:0:0:XXXX::/60.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12XX:0:0:XXXX::0102</para>
        /// </summary>
        [NameInMap("AclEntryIp")]
        [Validation(Required=false)]
        public string AclEntryIp { get; set; }

        /// <summary>
        /// <para>The ID of the ACL to which you want to add the IP entry.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transacl-bp1dcdvfe2****</para>
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
        /// <para>The region ID of the ACL.</para>
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
