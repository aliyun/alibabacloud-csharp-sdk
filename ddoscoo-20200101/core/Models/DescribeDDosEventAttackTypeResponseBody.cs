// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDDosEventAttackTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The attack type information.</para>
        /// </summary>
        [NameInMap("AttackTypes")]
        [Validation(Required=false)]
        public List<DescribeDDosEventAttackTypeResponseBodyAttackTypes> AttackTypes { get; set; }
        public class DescribeDDosEventAttackTypeResponseBodyAttackTypes : TeaModel {
            /// <summary>
            /// <para>The attack type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>QOTD-Reflect-Flood</b>: QOTD reflection attack</description></item>
            /// <item><description><b>CharGEN-Reflect-Flood</b>: CharGEN reflection attack</description></item>
            /// <item><description><b>DNS-Reflect-Flood</b>: DNS reflection attack</description></item>
            /// <item><description><b>TFTP-Reflect-Flood</b>: TFTP reflection attack</description></item>
            /// <item><description><b>Portmap-Reflect-Flood</b>: Portmap reflection attack</description></item>
            /// <item><description><b>NTP-Reflect-Flood</b>: NTP reflection attack</description></item>
            /// <item><description><b>NetBIOS-Reflect-Flood</b>: NetBIOS reflection attack</description></item>
            /// <item><description><b>SNMPv2-Reflect-Flood</b>: SNMPv2 reflection attack</description></item>
            /// <item><description><b>CLDAP-Reflect-Flood</b>: CLDAP reflection attack</description></item>
            /// <item><description><b>Ripv1-Reflect-Flood</b>: Ripv1 reflection attack</description></item>
            /// <item><description><b>OpenVPN-Reflect-Flood</b>: OpenVPN reflection attack</description></item>
            /// <item><description><b>SSDP-Reflect-Flood</b>: SSDP reflection attack</description></item>
            /// <item><description><b>NetAssistant-Reflect-Flood</b>: NetAssistant reflection attack</description></item>
            /// <item><description><b>WSDiscovery-Reflect-Flood</b>: WSDiscovery reflection attack</description></item>
            /// <item><description><b>Kad-Reflect-Flood</b>: Kad reflection attack</description></item>
            /// <item><description><b>mDNS-Reflect-Flood</b>: mDNS reflection attack</description></item>
            /// <item><description><b>10001-Reflect-Flood</b>: 10001 reflection attack</description></item>
            /// <item><description><b>Memcached-Reflect-Flood</b>: Memcached reflection attack</description></item>
            /// <item><description><b>QNP-Reflect-Flood</b>: QNP reflection attack</description></item>
            /// <item><description><b>DVR-Reflect-Flood</b>: DVR reflection attack</description></item>
            /// <item><description><b>CoAP-Reflect-Flood</b>: CoAP reflection attack</description></item>
            /// <item><description><b>ADDP-Reflect-Flood</b>: ADDP reflection attack</description></item>
            /// <item><description><b>Tcp-Syn</b>: TCP SYN flood attacks</description></item>
            /// <item><description><b>Tcp-Fin</b>: TCP FIN flood attack</description></item>
            /// <item><description><b>Tcp-Ack</b>: TCP ACK Flood attacks</description></item>
            /// <item><description><b>Tcp-Rst</b>: TCP RST flood attack</description></item>
            /// <item><description><b>Tcp-Pushack</b>: TCP PSH+ACK flood attack</description></item>
            /// <item><description><b>Tcp-Synack</b>: TCP SYN+ACK flood attack</description></item>
            /// <item><description><b>Udp-None</b>: UDP attack</description></item>
            /// <item><description><b>Udp-Ssh</b>: UDP SSH protocol attack</description></item>
            /// <item><description><b>Udp-Dns</b>: UDP DNS protocol attack</description></item>
            /// <item><description><b>Udp-Http</b>: UDP HTTP protocol attack</description></item>
            /// <item><description><b>Udp-Https</b>: UDP HTTPS protocol attack</description></item>
            /// <item><description><b>Udp-Ntp</b>: UDP NTP protocol attack</description></item>
            /// <item><description><b>Udp-Ldap</b>: UDP LDAP protocol attack</description></item>
            /// <item><description><b>Udp-Ssdp</b>: UDP SSDP protocol attack</description></item>
            /// <item><description><b>Udp-Memcached</b>: Memcache UDP reflection amplification attack</description></item>
            /// <item><description><b>Tcp-Other</b>: TCP other type attack</description></item>
            /// <item><description><b>Icmp</b>: ICMP flood attack</description></item>
            /// <item><description><b>Igmp</b>: IGMP flood attack</description></item>
            /// <item><description><b>Ipv6</b>: IPv6 attack</description></item>
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
