// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddAccessControlListEntryRequest : TeaModel {
        /// <summary>
        /// <para>The ACL settings.</para>
        /// <list type="bullet">
        /// <item><description>entry: the entries that you want to add to the ACL. You can add CIDR blocks. Separate multiple CIDR blocks with commas (,).</description></item>
        /// <item><description>comment: the description of the ACL.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can add at most 50 IP addresses or CIDR blocks to an ACL in each call. If the IP address or CIDR block that you want to add to an ACL already exists, the IP address or CIDR block is not added. The entries that you add must be CIDR blocks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;entry\&quot;: \&quot;192.168.1.0/24\&quot;, \&quot;comment\&quot;: \&quot;test\&quot;}]</para>
        /// </summary>
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public string AclEntrys { get; set; }

        /// <summary>
        /// <para>The ID of the access control list (ACL).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-bp1ohqkonqybecf4llbrc</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
