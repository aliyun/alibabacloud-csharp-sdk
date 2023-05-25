// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddIpControlPolicyItemResponseBody : TeaModel {
        /// <summary>
        /// When you call this operation, note that:
        /// 
        /// *   This operation is intended for API providers.
        /// *   An added policy immediately takes effect on all APIs that are bound to the access control list (ACL).
        /// *   A maximum of 100 policies can be added to an ACL.
        /// </summary>
        [NameInMap("PolicyItemId")]
        [Validation(Required=false)]
        public string PolicyItemId { get; set; }

        /// <summary>
        /// Adds a policy to an existing ACL.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
