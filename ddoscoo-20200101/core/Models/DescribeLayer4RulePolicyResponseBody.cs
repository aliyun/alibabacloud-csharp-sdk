// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeLayer4RulePolicyResponseBody : TeaModel {
        /// <summary>
        /// The port of the origin server.
        /// </summary>
        [NameInMap("BackendPort")]
        [Validation(Required=false)]
        public int? BackendPort { get; set; }

        /// <summary>
        /// The mode that is used to forward service traffic. Valid values:
        /// 
        /// *   0: the default mode. In this mode, Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the origin IP address that you specified when you created the port forwarding rule. You can call the [CreateNetworkRules](~~157482~~) operation to create a port forwarding rule.
        /// *   1: the origin redundancy mode. In this mode, Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary or secondary origin servers. You can call the [ConfigLayer4RulePolicy](~~312684~~) operation to configure IP addresses.
        /// </summary>
        [NameInMap("BakMode")]
        [Validation(Required=false)]
        public string BakMode { get; set; }

        /// <summary>
        /// The origin server that is used to receive service traffic. Valid values:
        /// 
        /// *   **1**: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.
        /// *   **2**: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.
        /// </summary>
        [NameInMap("CurrentIndex")]
        [Validation(Required=false)]
        public int? CurrentIndex { get; set; }

        /// <summary>
        /// The type of the protocol.
        /// </summary>
        [NameInMap("ForwardProtocol")]
        [Validation(Required=false)]
        public string ForwardProtocol { get; set; }

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
        /// An array that consists of the information about the primary origin server, including the IP addresses, forwarding protocol, and forwarding port.
        /// </summary>
        [NameInMap("PriRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodyPriRealServers> PriRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodyPriRealServers : TeaModel {
            /// <summary>
            /// The origin server that is used to receive service traffic. Valid values:
            /// 
            /// *   **1**: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.
            /// *   **2**: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.
            /// </summary>
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

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
            /// The type of the protocol.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The IP address of the primary origin server.
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the information about the secondary origin server, including the IP addresses, forwarding protocol, and forwarding port.
        /// </summary>
        [NameInMap("SecRealServers")]
        [Validation(Required=false)]
        public List<DescribeLayer4RulePolicyResponseBodySecRealServers> SecRealServers { get; set; }
        public class DescribeLayer4RulePolicyResponseBodySecRealServers : TeaModel {
            /// <summary>
            /// The origin server that is used to receive service traffic. Valid values:
            /// 
            /// *   **1**: the primary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the primary origin server.
            /// *   **2**: the secondary origin server, which indicates that Anti-DDoS Pro or Anti-DDoS Premium forwards service traffic to the IP addresses of the secondary origin server.
            /// </summary>
            [NameInMap("CurrentIndex")]
            [Validation(Required=false)]
            public int? CurrentIndex { get; set; }

            /// <summary>
            /// The IP address of the instance.
            /// </summary>
            [NameInMap("Eip")]
            [Validation(Required=false)]
            public string Eip { get; set; }

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
            /// The type of the protocol.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The IP address of the secondary origin server.
            /// </summary>
            [NameInMap("RealServer")]
            [Validation(Required=false)]
            public string RealServer { get; set; }

        }

    }

}
