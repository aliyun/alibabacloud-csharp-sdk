// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpResponseBody : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> The Ipv4Prefix parameter returned by the legacy operation. This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public string Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The created NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.34</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The instance ID of the created NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8y7q3cpk3fggs8****</para>
        /// </summary>
        [NameInMap("NatIpId")]
        [Validation(Required=false)]
        public string NatIpId { get; set; }

        /// <summary>
        /// <para>The NatIp parameter returned after a NAT IP address is created. If you use an IPv4 prefix to create NAT IP addresses, all NAT IP address information is returned. We recommend that you use this parameter to obtain NAT IP address information even when you create a single NAT IP address.</para>
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<CreateNatIpResponseBodyNatIps> NatIps { get; set; }
        public class CreateNatIpResponseBodyNatIps : TeaModel {
            /// <summary>
            /// <para>The IPv4 prefix in the list of created NAT IP addresses when an IPv4 prefix is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.128/28</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("Ipv4Prefix")]
            [Validation(Required=false)]
            public string Ipv4Prefix { get; set; }

            /// <summary>
            /// <para>The NAT IP address in the list of created NAT IP addresses when an IPv4 prefix is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.128</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>The ID of the NAT IP address in the list of created NAT IP addresses when an IPv4 prefix is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcnatip-xxxxxxxx</para>
            /// </summary>
            [NameInMap("NatIpId")]
            [Validation(Required=false)]
            public string NatIpId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E9AD97A0-5338-43F8-8A80-5E274CCBA11B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
