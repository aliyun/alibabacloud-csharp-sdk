// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// The ID of the ACL. The ID is unique.
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// The ID of a policy. Separate multiple IDs with semicolons (;). A maximum of 100 IDs can be entered.
        /// </summary>
        [NameInMap("PolicyItemIds")]
        [Validation(Required=false)]
        public string PolicyItemIds { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
