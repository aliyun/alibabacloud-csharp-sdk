// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NAT IP addresses.</para>
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<ListNatIpsResponseBodyNatIps> NatIps { get; set; }
        public class ListNatIpsResponseBodyNatIps : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the IP prefix to which the NAT IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/28</para>
            /// </summary>
            [NameInMap("Ipv4Prefix")]
            [Validation(Required=false)]
            public string Ipv4Prefix { get; set; }

            /// <summary>
            /// <para>Indicates whether the NAT IP address is the default one. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The NAT IP address is the default one.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The NAT IP address is not the default one.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC NAT gateway to which the NAT IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-gw8v16wgvtq26vh59****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The NAT IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.126</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>The CIDR block to which the NAT IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24</para>
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// <para>The description of the NAT IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("NatIpDescription")]
            [Validation(Required=false)]
            public string NatIpDescription { get; set; }

            /// <summary>
            /// <para>The instance ID of the NAT IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcnatip-gw8a863sut1zijxh0****</para>
            /// </summary>
            [NameInMap("NatIpId")]
            [Validation(Required=false)]
            public string NatIpId { get; set; }

            /// <summary>
            /// <para>The name of the NAT IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("NatIpName")]
            [Validation(Required=false)]
            public string NatIpName { get; set; }

            /// <summary>
            /// <para>The status of the NAT IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: available.</description></item>
            /// <item><description><b>Deleted</b>: deleted.</description></item>
            /// <item><description><b>Deleting</b>: being deleted.</description></item>
            /// <item><description><b>Creating</b>: being created.</description></item>
            /// <item><description><b>Associated</b>: associated with an SNAT or DNAT entry.</description></item>
            /// <item><description><b>Associating</b>: being associated with an SNAT or DNAT entry.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("NatIpStatus")]
            [Validation(Required=false)]
            public string NatIpStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E78CEEA-BF8F-44D1-9DCD-D9141135B71E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of NAT IP addresses returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
