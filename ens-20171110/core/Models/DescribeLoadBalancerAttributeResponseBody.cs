// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The IP address that the Edge Load Balancer (ELB) instance uses to provide services.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The IP version of the ELB instance. Valid values: ipv4 and ipv6.
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The list of backend servers.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerAttributeResponseBodyBackendServers> BackendServers { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyBackendServers : TeaModel {
            /// <summary>
            /// The IP address of the backend server.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The port that is used by the backend server.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The ID of the backend server.
            /// </summary>
            [NameInMap("ServerId")]
            [Validation(Required=false)]
            public string ServerId { get; set; }

            /// <summary>
            /// The type of backend server.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The weight of the backend server.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

        /// <summary>
        /// The peak bandwidth of the ELB. The default value is -1, which indicates that the bandwidth is unlimited.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The time when the ELB instance was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The time when the ELB instance was disabled.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The ID of the ENS node.
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// The frontend ports that are used by the ELB instance.
        /// </summary>
        [NameInMap("ListenerPorts")]
        [Validation(Required=false)]
        public List<string> ListenerPorts { get; set; }

        /// <summary>
        /// The frontend ports and protocols that are used by the ELB instance.
        /// </summary>
        [NameInMap("ListenerPortsAndProtocols")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols> ListenerPortsAndProtocols { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocols : TeaModel {
            /// <summary>
            /// The description of the listener.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The destination listening port to which requests are forwarded.
            /// </summary>
            [NameInMap("ForwardPort")]
            [Validation(Required=false)]
            public int? ForwardPort { get; set; }

            /// <summary>
            /// Indicates whether the listener is enabled.
            /// </summary>
            [NameInMap("ListenerForward")]
            [Validation(Required=false)]
            public string ListenerForward { get; set; }

            /// <summary>
            /// The listener port of the instance.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The listener protocol of the instance.
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

        }

        /// <summary>
        /// The ID of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The specifications of the ELB instance.
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// The status of the ELB instance. Valid values:
        /// 
        /// *   **Active** (default): The listener for the instance can forward the received traffic based on the rule.
        /// *   **InActive**: The listener for the instance does not forward the received traffic.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The ID of the network.
        /// </summary>
        [NameInMap("NetworkId")]
        [Validation(Required=false)]
        public string NetworkId { get; set; }

        /// <summary>
        /// The billing method. Valid values:
        /// 
        /// *   **PrePaid**: subscription.
        /// *   **PostPaid**: pay-as-you-go. Only this billing method is supported.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the vSwitch.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

    }

}
