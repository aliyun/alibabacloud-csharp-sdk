// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DetachFromPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// The protected objects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpPortProtocolList")]
        [Validation(Required=false)]
        public string IpPortProtocolListShrink { get; set; }

        /// <summary>
        /// The type of the policy. Valid values:
        /// 
        /// *   **default**: the default mitigation policies.
        /// *   **l3**: IP-specific mitigation policies.
        /// *   **l4**: port-specific mitigation policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
