// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListRulesRequest : TeaModel {
        /// <summary>
        /// The direction to which the forwarding rule is applied. Valid values:
        /// 
        /// *   **Request** (default): The forwarding rule is applied to the client requests received by ALB.
        /// *   **Response**: The forwarding rule is applied to the responses returned by backend servers.
        /// 
        /// > You cannot set this parameter to Response if you use basic ALB instances.
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// The listener IDs.
        /// </summary>
        [NameInMap("ListenerIds")]
        [Validation(Required=false)]
        public List<string> ListenerIds { get; set; }

        /// <summary>
        /// The Application Load Balancer (ALB) instance IDs.
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// The maximum number of entries to return.
        /// 
        /// Valid values: **1 to 100**.
        /// 
        /// Default value: **20**. If you do not specify this parameter, the default value is used.
        /// 
        /// > This parameter is optional.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The starting point of the current query. If you do not specify this parameter, the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The forwarding rules.
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public List<string> RuleIds { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListRulesRequestTag> Tag { get; set; }
        public class ListRulesRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
