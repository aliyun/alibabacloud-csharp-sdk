// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafScenesResponseBody : TeaModel {
        /// <summary>
        /// >You can call this operation up to 20 times per second per account.
        /// </summary>
        [NameInMap("DefenseScenes")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafScenesResponseBodyDefenseScenes> DefenseScenes { get; set; }
        public class DescribeDcdnWafScenesResponseBodyDefenseScenes : TeaModel {
            /// <summary>
            /// The types of the protection policies.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The total number of protection rules that were configured in this type of the policy.
            /// </summary>
            [NameInMap("PolicyCount")]
            [Validation(Required=false)]
            public int? PolicyCount { get; set; }

            /// <summary>
            /// The types of the protection policies that you want to query. Separate multiple types with commas (,). Valid values:
            /// 
            /// *   waf_group: basic web protection
            /// *   custom_acl: custom protection
            /// *   whitelist: IP address whitelist
            /// *   ip_blacklist: IP address blacklist
            /// *   region_block: region blacklist
            /// *   bot: bot management
            /// 
            /// >  If you do not set this parameter, all types of protection policies are queried.
            /// </summary>
            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        /// <summary>
        /// The type of the protection policy, which is the same as the DefenseScenes parameter in request parameters.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
