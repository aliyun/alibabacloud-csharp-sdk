// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable Application-Layer Protocol Negotiation (ALPN). Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("AlpnEnabled")]
        [Validation(Required=false)]
        public bool? AlpnEnabled { get; set; }

        /// <summary>
        /// The ALPN policy.
        /// 
        /// Valid values:
        /// 
        /// *   HTTP1Only
        /// *   HTTP2Only
        /// *   HTTP2Preferred
        /// *   HTTP2Optional
        /// </summary>
        [NameInMap("AlpnPolicy")]
        [Validation(Required=false)]
        public string AlpnPolicy { get; set; }

        /// <summary>
        /// The certificate authority (CA) certificates. This parameter takes effect only for listeners that use SSL over TCP.
        /// 
        /// > You can specify only one CA certificate.
        /// </summary>
        [NameInMap("CaCertificateIds")]
        [Validation(Required=false)]
        public List<string> CaCertificateIds { get; set; }

        /// <summary>
        /// Specifies whether to enable mutual authentication. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// The server certificates. This parameter takes effect only for listeners that use SSL over TCP.
        /// 
        /// > You can specify only one server certificate.
        /// </summary>
        [NameInMap("CertificateIds")]
        [Validation(Required=false)]
        public List<string> CertificateIds { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The maximum number of connections that can be created per second on the NLB instance. Valid values: **0** to **1000000**. **0** specifies that the number of connections is unlimited.
        /// </summary>
        [NameInMap("Cps")]
        [Validation(Required=false)]
        public int? Cps { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false**(default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The last port in the listener port range. Valid values: **0** to **65535**. The number of the last port must be greater than the number of the first port.
        /// 
        /// > This parameter is required when **ListenerPort** is set to **0**.
        /// </summary>
        [NameInMap("EndPort")]
        [Validation(Required=false)]
        public int? EndPort { get; set; }

        /// <summary>
        /// The timeout period of idle connections. Unit: seconds. Valid values: **1** to **900**. Default value: **900**.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 2 to 256 characters in length, and can contain letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// The listener port. Valid values: **0** to **65535**.
        /// 
        /// If you set the value to **0**, the listener listens by port range. If you set the value to **0**, you must specify **StartPort** and **EndPort**.
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
        /// The ID of the Network Load Balancer (NLB) instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The maximum size of a TCP segment. Unit: bytes. Valid values: **0** to **1500**. **0** specifies that the maximum segment size remains unchanged.
        /// 
        /// > This parameter is supported only by TCP listeners and listeners that use SSL over TCP.
        /// </summary>
        [NameInMap("Mss")]
        [Validation(Required=false)]
        public int? Mss { get; set; }

        /// <summary>
        /// Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("ProxyProtocolEnabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolEnabled { get; set; }

        /// <summary>
        /// The region ID of the NLB instance.
        /// 
        /// You can call the [DescribeRegions](~~443657~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to enable fine-grained monitoring. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default)
        /// </summary>
        [NameInMap("SecSensorEnabled")]
        [Validation(Required=false)]
        public bool? SecSensorEnabled { get; set; }

        /// <summary>
        /// The security policy ID. System security policies and custom security policies are supported.
        /// 
        /// Valid values: **tls_cipher_policy\_1\_0** (default), **tls_cipher_policy\_1\_1**, **tls_cipher_policy\_1\_2**, **tls_cipher_policy\_1\_2\_strict**, and **tls_cipher_policy\_1\_2\_strict_with\_1\_3**.
        /// 
        /// > This parameter takes effect only for listeners that use SSL over TCP.
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
        /// The first port in the listener port range. Valid values: **0** to **65535**.
        /// 
        /// > This parameter is required when **ListenerPort** is set to **0**.
        /// </summary>
        [NameInMap("StartPort")]
        [Validation(Required=false)]
        public int? StartPort { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerRequestTag> Tag { get; set; }
        public class CreateListenerRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
