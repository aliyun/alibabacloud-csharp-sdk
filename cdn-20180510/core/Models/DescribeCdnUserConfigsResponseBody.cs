// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserConfigsResponseBody : TeaModel {
        /// <summary>
        /// The user configurations.
        /// </summary>
        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<DescribeCdnUserConfigsResponseBodyConfigs> Configs { get; set; }
        public class DescribeCdnUserConfigsResponseBodyConfigs : TeaModel {
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
            /// *   **cc_rule**: HTTP flood protection rules
            /// *   **ddos_dispatch**: integration with Anti-DDoS
            /// *   **edge_safe**: application security settings on POPs
            /// *   **blocked_regions**: blocked regions
            /// *   **http_acl_policy**: access control list (ACL) rules
            /// *   **bot_manager**: bot traffic management
            /// *   **ip_reputation**: IP reputation library
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
