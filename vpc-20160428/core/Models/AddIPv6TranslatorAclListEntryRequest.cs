// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AddIPv6TranslatorAclListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The description of the access control policy group entry.</para>
        /// <para>The description must be 2 to 100 characters in length and must start with an uppercase letter, lowercase letter, or Chinese character. It can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>clientIP1</para>
        /// </summary>
        [NameInMap("AclEntryComment")]
        [Validation(Required=false)]
        public string AclEntryComment { get; set; }

        /// <summary>
        /// <para>The IPv6 address or IPv6 CIDR block to add to the access control policy group entry. Example: 12XX:0:0:XXXX::0102 or 12XX:0:0:XXXX::/60.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12XX:0:0:XXXX::0102</para>
        /// </summary>
        [NameInMap("AclEntryIp")]
        [Validation(Required=false)]
        public string AclEntryIp { get; set; }

        /// <summary>
        /// <para>The ID of the access control policy group to which the IP entry belongs.</para>
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
        /// <para>The region ID of the access control policy group.</para>
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
