// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpCidrsResponseBody : TeaModel {
        /// <summary>
        /// <para>The CIDR blocks of the NAT gateway.</para>
        /// </summary>
        [NameInMap("NatIpCidrs")]
        [Validation(Required=false)]
        public List<ListNatIpCidrsResponseBodyNatIpCidrs> NatIpCidrs { get; set; }
        public class ListNatIpCidrsResponseBodyNatIpCidrs : TeaModel {
            /// <summary>
            /// <para>The time when the CIDR block was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-28T20:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the CIDR block is the default CIDR block of the NAT gateway. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The CIDR block is the default CIDR block of the NAT gateway.</description></item>
            /// <item><description><b>false</b>: The CIDR block is not the default CIDR block of the NAT gateway.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the VPC NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-gw8v16wgvtq26vh59****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The CIDR block of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/24</para>
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// <para>The description of the CIDR block of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NatIpCidrDescription")]
            [Validation(Required=false)]
            public string NatIpCidrDescription { get; set; }

            /// <summary>
            /// <para>The ID of the CIDR block of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcnatcidr-gw8ov42ei6xh1jys2****</para>
            /// </summary>
            [NameInMap("NatIpCidrId")]
            [Validation(Required=false)]
            public string NatIpCidrId { get; set; }

            /// <summary>
            /// <para>The name of the CIDR block of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("NatIpCidrName")]
            [Validation(Required=false)]
            public string NatIpCidrName { get; set; }

            /// <summary>
            /// <para>The status of the CIDR block of the NAT gateway. If <b>Available</b> is returned, it indicates that the CIDR block is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("NatIpCidrStatus")]
            [Validation(Required=false)]
            public string NatIpCidrStatus { get; set; }

        }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the value of <b>NextToken</b> is not returned, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If the value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7479A224-4A28-4895-9604-11F48BCE6A88</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of CIDR blocks that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
