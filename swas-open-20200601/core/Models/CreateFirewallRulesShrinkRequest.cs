// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SWAS_OPEN20200601.Models
{
    public class CreateFirewallRulesShrinkRequest : TeaModel {
        /// <summary>
        /// The client token.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Details about the firewall rules.
        /// </summary>
        [NameInMap("FirewallRules")]
        [Validation(Required=false)]
        public string FirewallRulesShrink { get; set; }

        /// <summary>
        /// The ID of the simple application server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID of the simple application server. You can call the [ListRegions](https://help.aliyun.com/document_detail/189315.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The tags that you want to add to the firewall. You can specify up to 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFirewallRulesShrinkRequestTag> Tag { get; set; }
        public class CreateFirewallRulesShrinkRequestTag : TeaModel {
            /// <summary>
            /// The tag key. Valid values of N: 1 to 20.
            /// 
            /// The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot contain http:// or https://. The tag key cannot start with acs: or aliyun.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: 1 to 20.
            /// 
            /// The tag value can be an empty string. The tag value can be up to 64 characters in length and cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
