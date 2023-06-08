// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// >You can call this operation up to 30 times per second per account.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeDcdnUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// The configuration returned.
            /// </summary>
            [NameInMap("ArgName")]
            [Validation(Required=false)]
            public string ArgName { get; set; }

            /// <summary>
            /// The value of the configuration. Valid values:
            /// 
            /// *   cc_rule: HTTP flood protection
            /// *   ddos_dispatch: DDoS mitigation
            /// *   edge_safe: application security on edge nodes
            /// *   blocked_regions: region blacklist
            /// *   http_acl_policy: precise access control
            /// *   bot_manager: bot traffic management
            /// *   ip_reputation: IP reputation library
            /// </summary>
            [NameInMap("ArgValue")]
            [Validation(Required=false)]
            public string ArgValue { get; set; }

            /// <summary>
            /// The configuration that you want to query. Valid values:
            /// 
            /// *   domain_business_control: user configurations
            /// *   bot_basic: the basic edition of bot traffic management, which supports authorized crawlers and provides threat intelligence
            /// *   bot_Advance: the advanced edition of bot traffic management, which supports authorized crawlers and AI intelligent protection and provides threat intelligence
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        /// <summary>
        /// The configuration returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
