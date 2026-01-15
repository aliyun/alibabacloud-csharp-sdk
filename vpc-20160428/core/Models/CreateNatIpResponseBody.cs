// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateNatIpResponseBody : TeaModel {
        /// <summary>
        /// <para>The IPv4Prefix returned by the previous API is obsolete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Ipv4Prefix")]
        [Validation(Required=false)]
        public string Ipv4Prefix { get; set; }

        /// <summary>
        /// <para>The NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.34</para>
        /// </summary>
        [NameInMap("NatIp")]
        [Validation(Required=false)]
        public string NatIp { get; set; }

        /// <summary>
        /// <para>The ID of the NAT IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpcnatip-gw8y7q3cpk3fggs8****</para>
        /// </summary>
        [NameInMap("NatIpId")]
        [Validation(Required=false)]
        public string NatIpId { get; set; }

        /// <summary>
        /// <para>The NatIp parameter that is returned after you create a NatIp. If you use IPv4Prefix to create a NatIp, the information about all NatIp is returned. We recommend that you use this parameter to obtain the information about a NatIp when you create a NatIp.</para>
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<CreateNatIpResponseBodyNatIps> NatIps { get; set; }
        public class CreateNatIpResponseBodyNatIps : TeaModel {
            /// <summary>
            /// <para>The Ipv4Prefix of the created NatIpList list is returned when Ipv4Preix is created.</para>
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
            /// <para>Returns the NatIp address of the created NatIpList list when Ipv4Preix is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.2.128</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>Returns the NatIpId of the created NatIpList list when Ipv4Preix is created.</para>
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
