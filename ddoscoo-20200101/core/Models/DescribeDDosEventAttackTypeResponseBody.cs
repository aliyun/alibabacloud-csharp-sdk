// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAttackTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the attack types.</para>
        /// </summary>
        [NameInMap("AttackTypes")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAttackTypeResponseBodyAttackTypes> AttackTypes { get; set; }
        public class DescribeDDosEventAttackTypeResponseBodyAttackTypes : TeaModel {
            /// <summary>
            /// <para>The type of the attack Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>QOTD-Reflect-Flood</b>: QOTD reflection attacks</description></item>
            /// <item><description><b>CharGEN-Reflect-Flood</b>: CHARGEN reflection attacks</description></item>
            /// <item><description><b>DNS-Reflect-Flood</b>: DNS reflection attacks</description></item>
            /// <item><description><b>TFTP-Reflect-Flood</b>: TFTP reflection attacks</description></item>
            /// <item><description><b>Portmap-Reflect-Flood</b>: Portmap reflection attacks</description></item>
            /// <item><description><b>NTP-Reflect-Flood</b>: NTP reflection attacks</description></item>
            /// <item><description><b>NetBIOS-Reflect-Flood</b>: NetBIOS reflection attacks</description></item>
            /// <item><description><b>SNMPv2-Reflect-Flood</b>: SNMPv2 reflection attacks</description></item>
            /// <item><description><b>CLDAP-Reflect-Flood</b>: CLDAP reflection attacks</description></item>
            /// <item><description><b>Ripv1-Reflect-Flood</b>: RIPv1 reflection attacks</description></item>
            /// <item><description><b>OpenVPN-Reflect-Flood</b>: OpenVPN reflection attacks</description></item>
            /// <item><description><b>SSDP-Reflect-Flood</b>: SSDP reflection attacks</description></item>
            /// <item><description><b>NetAssistant-Reflect-Flood</b>: NetAssistant reflection attacks</description></item>
            /// <item><description><b>WSDiscovery-Reflect-Flood</b>: WS-Discovery reflection attacks</description></item>
            /// <item><description><b>Kad-Reflect-Flood</b>: Kad reflection attacks</description></item>
            /// <item><description><b>mDNS-Reflect-Flood</b>: mDNS reflection attacks</description></item>
            /// <item><description><b>10001-Reflect-Flood</b>: reflection attacks over port 10001</description></item>
            /// <item><description><b>Memcached-Reflect-Flood</b>: Memcached reflection attacks</description></item>
            /// <item><description><b>QNP-Reflect-Flood</b>: QNP reflection attacks</description></item>
            /// <item><description><b>DVR-Reflect-Flood</b>: DVR reflection attacks</description></item>
            /// <item><description><b>CoAP-Reflect-Flood</b>: CoAP reflection attacks</description></item>
            /// <item><description><b>ADDP-Reflect-Flood</b>: ADDP reflection attacks</description></item>
            /// <item><description><b>Tcp-Syn</b>: TCP SYN flood attacks</description></item>
            /// <item><description><b>Tcp-Fin</b>: TCP FIN flood attacks</description></item>
            /// <item><description><b>Tcp-Ack</b>: TCP ACK flood attacks</description></item>
            /// <item><description><b>Tcp-Rst</b>: TCP RST flood attacks</description></item>
            /// <item><description><b>Tcp-Pushack</b>: TCP PSH-ACK flood attacks</description></item>
            /// <item><description><b>Tcp-Synack</b>: TCP SYN-ACK flood attacks</description></item>
            /// <item><description><b>Udp-None</b>: UDP attacks</description></item>
            /// <item><description><b>Udp-Ssh</b>: UDP-based SSH attacks</description></item>
            /// <item><description><b>Udp-Dns</b>: UDP-based DNS attacks</description></item>
            /// <item><description><b>Udp-Http</b>: UDP-based HTTP attacks</description></item>
            /// <item><description><b>Udp-Https</b>: UDP-based HTTPS attacks</description></item>
            /// <item><description><b>Udp-Ntp</b>: UDP-based NTP attacks</description></item>
            /// <item><description><b>Udp-Ldap</b>: UDP-based LDAP attacks</description></item>
            /// <item><description><b>Udp-Ssdp</b>: UDP-based SSDP attacks</description></item>
            /// <item><description><b>Udp-Memcached</b>: Memcached UDP reflection attacks</description></item>
            /// <item><description><b>Tcp-Other</b>: other TCP attacks</description></item>
            /// <item><description><b>Icmp</b>: ICMP flood attacks</description></item>
            /// <item><description><b>Igmp</b>: IGMP flood attacks</description></item>
            /// <item><description><b>Ipv6</b>: IPv6 attacks</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Tcp-Syn</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public string AttackType { get; set; }

            /// <summary>
            /// <para>The number of request packets of the attack type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145902</para>
            /// </summary>
            [NameInMap("InPkts")]
            [Validation(Required=false)]
            public long? InPkts { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6F644A6E-40E7-483F-9DBB-CC27E16BB555</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
