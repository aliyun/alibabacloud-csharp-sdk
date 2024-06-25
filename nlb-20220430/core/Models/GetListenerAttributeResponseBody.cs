// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether Application-Layer Protocol Negotiation (ALPN) is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
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
        /// The CA certificates. Only one CA certificate is supported.
        /// 
        /// >  This parameter takes effect only for listeners that use SSL over TCP.
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// Indicates whether mutual authentication is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// The server certificates. Only one server certificate is supported.
        /// 
        /// >  This parameter takes effect only for listeners that use SSL over TCP.
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// The maximum number of connections that can be created per second on the NLB instance. Valid values: **0** to **1000000**. **0** specifies that the number of connections is unlimited.
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// The last port in the listening port range. Valid values: **0** to **65535**. The number of the last port must be smaller than that of the first port.
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public string EndPort { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Unit: seconds. Valid values: **1** to **900**.
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
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The listening port. Valid values: **0** to **65535**. A value of **0** specifies all ports. If you set the value to **0**, you must also set the **StartPort** and **EndPort** parameters.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The listening protocol. Valid values: **TCP**, **UDP**, and **TCPSSL**.
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
        /// The ID of the NLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The size of the largest TCP segment. Unit: bytes. Valid values: **0** to **1500**. **0** specifies that the maximum segment size remains unchanged.
        /// 
        /// >  This parameter is supported only by listeners that use SSL over TCP.
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// Indicates whether the Proxy protocol is used to pass client IP addresses to backend servers. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ProxyProtocolEnabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolEnabled { get; set; }

        /// <summary>
        /// Indicates whether the Proxy protocol passes the VpcId, PrivateLinkEpId, and PrivateLinkEpsId parameters to backend servers.
        /// </summary>
        [NameInMap("ProxyProtocolV2Config")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyProxyProtocolV2Config ProxyProtocolV2Config { get; set; }
        public class GetListenerAttributeResponseBodyProxyProtocolV2Config : TeaModel {
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
        /// The ID of the region where the NLB instance is deployed.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether fine-grained monitoring is enabled. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("SecSensorEnabled")]
        [Validation(Required=false)]
        public bool? SecSensorEnabled { get; set; }

        /// <summary>
        /// The ID of the security policy. System security policies and custom security policies are supported.
        /// 
        /// Valid values: **tls_cipher_policy_1_0**, **tls_cipher_policy_1_1**, **tls_cipher_policy_1_2**, **tls_cipher_policy_1_2_strict**, and **tls_cipher_policy_1_2_strict_with_1_3**.
        /// 
        /// >  This parameter takes effect only for listeners that use SSL over TCP.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The ID of the server group.
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// The first port in the listening port range. Valid values: **0** to **65535**.
        /// </summary>
        [NameInMap("StartPort")]
        [Validation(Required=false)]
        public string StartPort { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyTags> Tags { get; set; }
        public class GetListenerAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

    }

}
