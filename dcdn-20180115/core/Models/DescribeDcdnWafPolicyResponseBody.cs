// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafPolicyResponseBody : TeaModel {
        /// <summary>
        /// The information about the protection policy.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public DescribeDcdnWafPolicyResponseBodyPolicy Policy { get; set; }
        public class DescribeDcdnWafPolicyResponseBodyPolicy : TeaModel {
            /// <summary>
            /// The type of the protection policy. Valid values:
            /// 
            /// *   waf_group: basic web protection
            /// *   custom_acl: custom protection
            /// *   whitelist: whitelist
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The number of domain names that use the protection policy.
            /// </summary>
            [NameInMap("DomainCount")]
            [Validation(Required=false)]
            public int? DomainCount { get; set; }

            /// <summary>
            /// The time when the protection policy was modified. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ID of the protection policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public long? PolicyId { get; set; }

            /// <summary>
            /// The name of the protection policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The status of the protection policy. Valid values:
            /// 
            /// *   on
            /// *   off
            /// </summary>
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            /// <summary>
            /// Indicates whether the current policy is the default policy. Valid values:
            /// 
            /// *   default
            /// *   custom
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

            /// <summary>
            /// The protection rule configurations that are defined in the protection policy. The configurations only support bot management. For more information, see [Configure protection rules](~~423350~~).
            /// </summary>
            [NameInMap("RuleConfigs")]
            [Validation(Required=false)]
            public string RuleConfigs { get; set; }

            /// <summary>
            /// The number of protection rules in the protection policy.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public long? RuleCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
