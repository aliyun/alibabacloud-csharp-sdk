// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DetachAppPolicyFromIdentityResponseBody : TeaModel {
        /// <summary>
        /// <para>The names of the policies that failed to be granted to the RAM user or RAM role.</para>
        /// </summary>
        [NameInMap("FailedPolicyNames")]
        [Validation(Required=false)]
        public List<string> FailedPolicyNames { get; set; }

        /// <summary>
        /// <para>The name of the policy that was not found.</para>
        /// </summary>
        [NameInMap("NonExistPolicyNames")]
        [Validation(Required=false)]
        public List<string> NonExistPolicyNames { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-****-D7393642C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
