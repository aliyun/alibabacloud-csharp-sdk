// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class AttachAppPolicyToIdentityResponseBody : TeaModel {
        /// <summary>
        /// The names of the policies that failed to be granted to the RAM user or RAM role.
        /// </summary>
        [NameInMap("FailedPolicyNames")]
        [Validation(Required=false)]
        public List<string> FailedPolicyNames { get; set; }

        /// <summary>
        /// The names of the policies that were not found.
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
