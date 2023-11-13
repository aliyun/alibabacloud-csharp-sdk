// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAttackTypeResponseBody : TeaModel {
        /// <summary>
        /// The information about the attack types.
        /// </summary>
        [NameInMap("AttackTypes")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAttackTypeResponseBodyAttackTypes> AttackTypes { get; set; }
        public class DescribeDDosEventAttackTypeResponseBodyAttackTypes : TeaModel {
            /// <summary>
            /// The type of the attack Valid values:
            /// 
            /// *   **QOTD-Reflect-Flood**: QOTD reflection attacks
            /// *   **CharGEN-Reflect-Flood**: CHARGEN reflection attacks
            /// *   **DNS-Reflect-Flood**: DNS reflection attacks
            /// *   **TFTP-Reflect-Flood**: TFTP reflection attacks
            /// *   **Portmap-Reflect-Flood**: Portmap reflection attacks
            /// *   **NTP-Reflect-Flood**: NTP reflection attacks
            /// *   **NetBIOS-Reflect-Flood**: NetBIOS reflection attacks
            /// *   **SNMPv2-Reflect-Flood**: SNMPv2 reflection attacks
            /// *   **CLDAP-Reflect-Flood**: CLDAP reflection attacks
            /// *   **Ripv1-Reflect-Flood**: RIPv1 reflection attacks
            /// *   **OpenVPN-Reflect-Flood**: OpenVPN reflection attacks
            /// *   **SSDP-Reflect-Flood**: SSDP reflection attacks
            /// *   **NetAssistant-Reflect-Flood**: NetAssistant reflection attacks
            /// *   **WSDiscovery-Reflect-Flood**: WS-Discovery reflection attacks
            /// *   **Kad-Reflect-Flood**: Kad reflection attacks
            /// *   **mDNS-Reflect-Flood**: mDNS reflection attacks
            /// *   **10001-Reflect-Flood**: reflection attacks over port 10001
            /// *   **Memcached-Reflect-Flood**: Memcached reflection attacks
            /// *   **QNP-Reflect-Flood**: QNP reflection attacks
            /// *   **DVR-Reflect-Flood**: DVR reflection attacks
            /// *   **CoAP-Reflect-Flood**: CoAP reflection attacks
            /// *   **ADDP-Reflect-Flood**: ADDP reflection attacks
            /// *   **Tcp-Syn**: TCP SYN flood attacks
            /// *   **Tcp-Fin**: TCP FIN flood attacks
            /// *   **Tcp-Ack**: TCP ACK flood attacks
            /// *   **Tcp-Rst**: TCP RST flood attacks
            /// *   **Tcp-Pushack**: TCP PSH-ACK flood attacks
            /// *   **Tcp-Synack**: TCP SYN-ACK flood attacks
            /// *   **Udp-None**: UDP attacks
            /// *   **Udp-Ssh**: UDP-based SSH attacks
            /// *   **Udp-Dns**: UDP-based DNS attacks
            /// *   **Udp-Http**: UDP-based HTTP attacks
            /// *   **Udp-Https**: UDP-based HTTPS attacks
            /// *   **Udp-Ntp**: UDP-based NTP attacks
            /// *   **Udp-Ldap**: UDP-based LDAP attacks
            /// *   **Udp-Ssdp**: UDP-based SSDP attacks
            /// *   **Udp-Memcached**: Memcached UDP reflection attacks
            /// *   **Tcp-Other**: other TCP attacks
            /// *   **Icmp**: ICMP flood attacks
            /// *   **Igmp**: IGMP flood attacks
            /// *   **Ipv6**: IPv6 attacks
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            /// <summary>
            /// The number of request packets of the attack type.
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
