// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class SetAccountAliasRequest : TeaModel {
        /// <summary>
        /// The alias of the Alibaba Cloud account.
        /// 
        /// The alias must be 3 to 32 characters in length, and can contain lowercase letters, digits, and hyphens (-).
        /// 
        /// > It cannot start or end with a hyphen (-), and cannot contain consecutive hyphens (-).
        /// </summary>
        [NameInMap("AccountAlias")]
        [Validation(Required=false)]
        public string AccountAlias { get; set; }

    }

}
