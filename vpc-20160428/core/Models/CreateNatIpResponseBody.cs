// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv4 prefix returned by the legacy operation. This parameter is deprecated.</para>
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
        /// <para>The NAT IP address information returned after the NAT IP address is created. When you create a NAT IP address by using an IPv4 prefix, all NAT IP address information is returned. When you create a single NAT IP address, we recommend that you use this parameter to obtain the NAT IP address information.</para>
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<CreateNatIpResponseBodyNatIps> NatIps { get; set; }
        public class CreateNatIpResponseBodyNatIps : TeaModel {
            /// <summary>
            /// <para>The IPv4 prefix in the list of NAT IP addresses created by using an IPv4 prefix.</para>
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
            /// <para>The NAT IP address in the list of NAT IP addresses created by using an IPv4 prefix.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.128</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>The NAT IP address ID in the list of NAT IP addresses created by using an IPv4 prefix.</para>
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
