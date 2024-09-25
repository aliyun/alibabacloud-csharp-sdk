// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyIPv6TranslatorAclListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The remarks of the ACL rule.</para>
        /// <para>It must be 2 to 100 characters in length, and can contain digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>client IP</para>
        /// </summary>
        [NameInMap("AclEntryComment")]
        [Validation(Required=false)]
        public string AclEntryComment { get; set; }

        /// <summary>
        /// <para>The ID of the ACL rule to which the IP entry belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transaclentry-bp1jzyn7ra8pyxehd****</para>
        /// </summary>
        [NameInMap("AclEntryId")]
        [Validation(Required=false)]
        public string AclEntryId { get; set; }

        /// <summary>
        /// <para>The ID of the ACL to which the IP entry belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6transacl-bp1b4z3tleyhq1s50****</para>
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
        /// <para>The region of the ACL.</para>
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
