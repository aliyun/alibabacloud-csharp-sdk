// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// A list of listeners.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// Indicates whether Application-Layer Protocol Negotiation (ALPN) is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("AlpnEnabled")]
            [Validation(Required=false)]
            public bool? AlpnEnabled { get; set; }

            /// <summary>
            /// The ALPN policy. Valid values:
            /// 
            /// *   **HTTP1Only**
            /// *   **HTTP2Only**
            /// *   **HTTP2Preferred**
            /// *   **HTTP2Optional**
            /// </summary>
            [NameInMap("AlpnPolicy")]
            [Validation(Required=false)]
            public string AlpnPolicy { get; set; }

            /// <summary>
            /// A list of CA certificates.
            /// 
            /// >  This parameter takes effect only for listeners that use SSL over TCP.
            /// </summary>
            [NameInMap("CaCertificateIds")]
            [Validation(Required=false)]
            public List<string> CaCertificateIds { get; set; }

            /// <summary>
            /// Indicates whether mutual authentication is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("CaEnabled")]
            [Validation(Required=false)]
            public bool? CaEnabled { get; set; }

            /// <summary>
            /// The server certificate.
            /// 
            /// >  This parameter takes effect only for listeners that use SSL over TCP.
            /// </summary>
            [NameInMap("CertificateIds")]
            [Validation(Required=false)]
            public List<string> CertificateIds { get; set; }

            /// <summary>
            /// The maximum number of connections that can be created per second on the NLB instance. Valid values: **0** to **1000000**. **0** indicates that the number of connections is unlimited.
            /// </summary>
            [NameInMap("Cps")]
            [Validation(Required=false)]
            public int? Cps { get; set; }

            /// <summary>
            /// The last port in the listener port range.
            /// </summary>
            [NameInMap("EndPort")]
            [Validation(Required=false)]
            public string EndPort { get; set; }

            /// <summary>
            /// The timeout period of idle connections. Unit: seconds. Valid values: **1** to **900**. Default value: **900**.
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// The name of the listener.
            /// 
            /// The name must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).
            /// </summary>
            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The information about the listener port of your server.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The listener protocol. Valid values: **TCP**, **UDP**, and **TCPSSL**.
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// The status of the listener. Valid values:
            /// 
            /// *   **Provisioning**: The listener is being created.
            /// *   **Running**: The listener is running.
            /// *   **Configuring**: The listener is being configured.
            /// *   **Stopping**: The listener is being stopped.
            /// *   **Stopped**: The listener is stopped.
            /// *   **Starting**: The listener is being started.
            /// *   **Deleting**: The listener is being deleted.
            /// *   **Deleted**: The listener is deleted.
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// The CLB instance ID.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The size of the largest TCP packet segment. Unit: bytes. Valid values: **0** to **1500**. **0** indicates that the Mss value of TCP packets remains unchanged.
            /// 
            /// >  This parameter takes effect only for listeners that use SSL over TCP.
            /// </summary>
            [NameInMap("Mss")]
            [Validation(Required=false)]
            public int? Mss { get; set; }

            /// <summary>
            /// Indicates whether the Proxy protocol passes source client IP addresses to backend servers. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ProxyProtocolEnabled")]
            [Validation(Required=false)]
            public bool? ProxyProtocolEnabled { get; set; }

            /// <summary>
            /// Indicates whether the Proxy protocol passes the VpcId, PrivateLinkEpId, and PrivateLinkEpsId parameters to backend servers.
            /// </summary>
            [NameInMap("ProxyProtocolV2Config")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
            public class ListListenersResponseBodyListenersProxyProtocolV2Config : TeaModel {
                /// <summary>
                /// Indicates whether the Proxy protocol passes the PrivateLinkEpId parameter to backend servers. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Ppv2PrivateLinkEpIdEnabled")]
                [Validation(Required=false)]
                public bool? Ppv2PrivateLinkEpIdEnabled { get; set; }

                /// <summary>
                /// Indicates whether the Proxy protocol passes the PrivateLinkEpsId parameter to backend servers. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Ppv2PrivateLinkEpsIdEnabled")]
                [Validation(Required=false)]
                public bool? Ppv2PrivateLinkEpsIdEnabled { get; set; }

                /// <summary>
                /// Indicates whether the Proxy protocol passes the VpcId parameter to backend servers. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Ppv2VpcIdEnabled")]
                [Validation(Required=false)]
                public bool? Ppv2VpcIdEnabled { get; set; }

            }

            /// <summary>
            /// The region ID of the NLB instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// Indicates whether fine-grained monitoring is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("SecSensorEnabled")]
            [Validation(Required=false)]
            public bool? SecSensorEnabled { get; set; }

            /// <summary>
            /// The ID of the security policy.
            /// 
            /// >  This parameter takes effect only for listeners that use SSL over TCP.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The server group ID.
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// The first port in the listener port range.
            /// </summary>
            [NameInMap("StartPort")]
            [Validation(Required=false)]
            public string StartPort { get; set; }

            /// <summary>
            /// A list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersTags> Tags { get; set; }
            public class ListListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// *   If **NextToken** is empty, it indicates that no next query is to be sent.
        /// *   If a value of **NextToken** is returned, the value is the token used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
