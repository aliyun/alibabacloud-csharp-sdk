// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddAccessControlListEntryRequest : TeaModel {
        /// <summary>
        /// The ACL settings.
        /// 
        /// *   entry: the entries that you want to add to the ACL. You can add CIDR blocks. Separate multiple CIDR blocks with commas (,).
        /// *   comment: the description of the ACL.
        /// 
        /// > You can add at most 50 IP addresses or CIDR blocks to an ACL in each call. If the IP address or CIDR block that you want to add to an ACL already exists, the IP address or CIDR block is not added. The entries that you add must be CIDR blocks.
        /// </summary>
        [NameInMap("AclEntrys")]
        [Validation(Required=false)]
        public string AclEntrys { get; set; }

        /// <summary>
        /// The ID of the access control list (ACL).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
