// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of IP addresses of the NAT gateway.</para>
        /// </summary>
        [NameInMap("NatIps")]
        [Validation(Required=false)]
        public List<ListNatIpsResponseBodyNatIps> NatIps { get; set; }
        public class ListNatIpsResponseBodyNatIps : TeaModel {
            [NameInMap("Ipv4Prefix")]
            [Validation(Required=false)]
            public string Ipv4Prefix { get; set; }

            /// <summary>
            /// <para>Indicates whether the IP address is the default IP address of the NAT gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes</description></item>
            /// <item><description><b>false</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the Virtual Private Cloud (VPC) NAT gateway to which the IP address is assigned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-gw8v16wgvtq26vh59****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.126</para>
            /// </summary>
            [NameInMap("NatIp")]
            [Validation(Required=false)]
            public string NatIp { get; set; }

            /// <summary>
            /// <para>The CIDR block to which the IP address belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/24</para>
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// <para>The description of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("NatIpDescription")]
            [Validation(Required=false)]
            public string NatIpDescription { get; set; }

            /// <summary>
            /// <para>The ID of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcnatip-gw8a863sut1zijxh0****</para>
            /// </summary>
            [NameInMap("NatIpId")]
            [Validation(Required=false)]
            public string NatIpId { get; set; }

            /// <summary>
            /// <para>The name of the IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("NatIpName")]
            [Validation(Required=false)]
            public string NatIpName { get; set; }

            /// <summary>
            /// <para>The status of the IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Available</b>: available</description></item>
            /// <item><description><b>Deleted</b>: deleted</description></item>
            /// <item><description><b>Deleting</b>: deleting</description></item>
            /// <item><description><b>Creating</b>: creating</description></item>
            /// <item><description><b>Associated</b>: specified in an SNAT or DNAT entry</description></item>
            /// <item><description><b>Associating</b>: being specified in an SNAT or DNAT entry</description></item>
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
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the value of <b>NextToken</b> is not returned, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If the value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7E78CEEA-BF8F-44D1-9DCD-D9141135B71E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of IP addresses that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
