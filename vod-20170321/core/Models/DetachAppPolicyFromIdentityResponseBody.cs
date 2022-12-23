// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityResponseBody : TeaModel {
        /// <summary>
        /// The name of the policy that failed to be detached from the identity.
        /// </summary>
        [NameInMap("FailedPolicyNames")]
        [Validation(Required=false)]
        public List<string> FailedPolicyNames { get; set; }

        /// <summary>
        /// The name of the policy that was not found.
        /// </summary>
        [NameInMap("NonExistPolicyNames")]
        [Validation(Required=false)]
        public List<string> NonExistPolicyNames { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
