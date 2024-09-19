// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeNetworkRulesResponseBody : TeaModel {
        /// <summary>
        /// The details of the port forwarding rule.
        /// </summary>
        [NameInMap("NetworkRules")]
        [Validation(Required=false)]
        public List<DescribeNetworkRulesResponseBodyNetworkRules> NetworkRules { get; set; }
        public class DescribeNetworkRulesResponseBodyNetworkRules : TeaModel {
            /// <summary>
            /// The port of the origin server.
            /// </summary>
            [NameInMap("BackendPort")]
            [Validation(Required=false)]
            public int? BackendPort { get; set; }

            /// <summary>
            /// The forwarding port.
            /// </summary>
            [NameInMap("FrontendPort")]
            [Validation(Required=false)]
            public int? FrontendPort { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// Indicates whether the port forwarding rule is automatically created. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsAutoCreate")]
            [Validation(Required=false)]
            public bool? IsAutoCreate { get; set; }

            [NameInMap("PayloadRuleEnable")]
            [Validation(Required=false)]
            public long? PayloadRuleEnable { get; set; }

            /// <summary>
            /// The forwarding protocol. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("ProxyEnable")]
            [Validation(Required=false)]
            public long? ProxyEnable { get; set; }

            [NameInMap("ProxyStatus")]
            [Validation(Required=false)]
            public string ProxyStatus { get; set; }

            /// <summary>
            /// The IP addresses of origin servers.
            /// </summary>
            [NameInMap("RealServers")]
            [Validation(Required=false)]
            public List<string> RealServers { get; set; }

            /// <summary>
            /// The remarks of the port forwarding rule.
            /// </summary>
            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned port forwarding rules.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
