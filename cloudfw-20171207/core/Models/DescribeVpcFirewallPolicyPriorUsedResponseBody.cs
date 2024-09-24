// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallPolicyPriorUsedResponseBody : TeaModel {
        /// <summary>
        /// The lowest priority for the access control policies.
        /// </summary>
        [NameInMap("End")]
        [Validation(Required=false)]
        public int? End { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The highest priority for the access control policies.
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public int? Start { get; set; }

    }

}
