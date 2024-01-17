// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ModifyFirewallV2RoutePolicySwitchRequest : TeaModel {
        /// <summary>
        /// The instance ID of the virtual private cloud (VPC) firewall.
        /// </summary>
        [NameInMap("FirewallId")]
        [Validation(Required=false)]
        public string FirewallId { get; set; }

        /// <summary>
        /// The language of the content within the response. Valid values:
        /// 
        /// *   **zh** (default): Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// Specifies whether to restore the traffic redirection configurations. Valid values:
        /// 
        /// *   true: roll back
        /// *   false: withdraw
        /// </summary>
        [NameInMap("ShouldRecover")]
        [Validation(Required=false)]
        public string ShouldRecover { get; set; }

        /// <summary>
        /// The ID of the routing policy.
        /// </summary>
        [NameInMap("TrFirewallRoutePolicyId")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicyId { get; set; }

        /// <summary>
        /// The status of the routing policy. Valid values:
        /// 
        /// *   open: enabled
        /// *   close: disabled
        /// </summary>
        [NameInMap("TrFirewallRoutePolicySwitchStatus")]
        [Validation(Required=false)]
        public string TrFirewallRoutePolicySwitchStatus { get; set; }

    }

}
