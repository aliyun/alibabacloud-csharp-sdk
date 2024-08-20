// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnWafPolicyRequest : TeaModel {
        /// <summary>
        /// The type of the WAF protection policy. Valid values:
        /// 
        /// *   waf_group: basic web protection
        /// *   custom_acl: custom protection
        /// *   whitelist: IP address whitelist
        /// *   ip_blacklist: IP address blacklist
        /// *   region_block: region blacklist
        /// *   bot: bot management
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DefenseScene")]
        [Validation(Required=false)]
        public string DefenseScene { get; set; }

        /// <summary>
        /// The name of the protection policy. The name can be up to 64 characters in length and can contain letters, digits, and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// The status of the protection policy. Valid values:
        /// 
        /// *   on: The policy is enabled.
        /// *   off: The policy is disabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyStatus")]
        [Validation(Required=false)]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// Specifies whether to set the current policy as the default policy. Valid values:
        /// 
        /// *   default: sets the current policy as the default policy.
        /// *   custom: does not set the current policy as the default policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public string PolicyType { get; set; }

    }

}
