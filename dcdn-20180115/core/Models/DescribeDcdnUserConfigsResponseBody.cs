// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// The user configurations.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeDcdnUserConfigsResponseBodyConfigs : TeaModel {
            /// <summary>
            /// The name of the configuration.
            /// 
            /// The configuration is specified by enterprise users and public service sectors.
            /// </summary>
            [NameInMap("ArgName")]
            [Validation(Required=false)]
            public string ArgName { get; set; }

            /// <summary>
            /// The value of the configuration. Valid values:
            /// 
            /// *   cc_rule: HTTP flood protection
            /// *   ddos_dispatch: DDoS mitigation
            /// *   edge_safe: application security on points of presence (POPs)
            /// *   blocked_regions: region blacklist
            /// *   http_acl_policy: precise access control
            /// *   bot_manager: bot traffic management
            /// *   ip_reputation: IP reputation library
            /// </summary>
            [NameInMap("ArgValue")]
            [Validation(Required=false)]
            public string ArgValue { get; set; }

            /// <summary>
            /// The name of the feature.
            /// </summary>
            [NameInMap("FunctionName")]
            [Validation(Required=false)]
            public string FunctionName { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
