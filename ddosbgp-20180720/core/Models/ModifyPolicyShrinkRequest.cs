// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class ModifyPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// The type of the action. Valid values:
        /// 
        /// *   **10**: modifies the name. If you specify this value, `Name` is required.
        /// *   **11**: modifies the blacklist validity period. If you specify this value, `BlackIpListExpireAt` is required. Only IP-specific mitigation policies support this value.
        /// *   **12**: changes the status of the feature of adding back-to-origin CIDR blocks of Anti-DDoS Proxy to the whitelist. If you specify this value, `WhitenGfbrNets` is required. Only IP-specific mitigation policies support this value.
        /// *   **13**: changes the status of the ICMP blocking feature. If you specify this value, `EnableDropIcmp` is required. Only IP-specific mitigation policies support this value.
        /// *   **20**: adds IP addresses to the blacklist or the whitelist. If you specify this value, you must specify at least one of `WhiteIpList` and `BlackIpList`. Only IP-specific mitigation policies support this value.
        /// *   **21**: removes IP addresses from the blacklist or the whitelist. If you specify this value, at least one of `WhiteIpList` and `BlackIpList` is required. Only IP-specific mitigation policies support this value.
        /// *   **22**: clears the whitelist. Only IP-specific mitigation policies support this value.
        /// *   **23**: clears the blacklist. Only IP-specific mitigation policies support this value.
        /// *   **30**: modifies the status and level of intelligent protection. If you specify this value, `EnableIntelligence` and `IntelligenceLevel` are required. Only IP-specific mitigation policies support this value.
        /// *   **31**: modifies the location blacklist settings. If you specify this value, one of `RegionBlockCountryList` and `RegionBlockProvinceList` is required. Only IP-specific mitigation policies support this value.
        /// *   **32**: modifies the settings for source rate limiting. If you specify this value, `SourceLimit` and `SourceBlockList` are required. Only IP-specific mitigation policies support this value.
        /// *   **33**: modifies the settings for reflection attack filtering. If you specify this value, `ReflectBlockUdpPortList` is required. Only IP-specific mitigation policies support this value.
        /// *   **40**: creates a port blocking rule. If you specify this value, `PortRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **41**: modifies the port blocking rule. If you specify this value, `PortRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **42**: deletes the port blocking rule. If you specify this value, `PortRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **50**: creates a byte-match filter rule. If you specify this value, `FingerPrintRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **51**: modifies the byte-match filter rule. If you specify this value, `FingerPrintRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **52**: deletes the byte-match filter rule. If you specify this value, `FingerPrintRuleList` is required. Only IP-specific mitigation policies support this value.
        /// *   **60**: changes the status of the port-specific mitigation feature. If you specify this value, `EnableL4Defense` is required. Only port-specific mitigation policies support this value.
        /// *   **61**: creates a port-specific mitigation rule. If you specify this value, `L4RuleList` is required. Only port-specific mitigation policies support this value.
        /// *   **62**: modifies the port-specific mitigation rule. If you specify this value, `L4RuleList` is required. Only port-specific mitigation policies support this value.
        /// *   **63**: deletes the port-specific mitigation rule. If you specify this value, `L4RuleList` is required. Only port-specific mitigation policies support this value.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ActionType")]
        [Validation(Required=false)]
        public int? ActionType { get; set; }

        /// <summary>
        /// The content of the policy.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string ContentShrink { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the policy.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
