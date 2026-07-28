// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListNatIpCidrsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NAT CIDR blocks.</para>
        /// </summary>
        [NameInMap("NatIpCidrs")]
        [Validation(Required=false)]
        public List<ListNatIpCidrsResponseBodyNatIpCidrs> NatIpCidrs { get; set; }
        public class ListNatIpCidrsResponseBodyNatIpCidrs : TeaModel {
            /// <summary>
            /// <para>The time when the NAT CIDR block was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-28T20:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the NAT CIDR block is the default NAT CIDR block. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The NAT CIDR block is the default NAT CIDR block.</description></item>
            /// <item><description><b>false</b>: The NAT CIDR block is not the default NAT CIDR block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The instance ID of the VPC NAT gateway to which the NAT CIDR block belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-gw8v16wgvtq26vh59****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The NAT CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.0.0/24</para>
            /// </summary>
            [NameInMap("NatIpCidr")]
            [Validation(Required=false)]
            public string NatIpCidr { get; set; }

            /// <summary>
            /// <para>The description of the NAT CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("NatIpCidrDescription")]
            [Validation(Required=false)]
            public string NatIpCidrDescription { get; set; }

            /// <summary>
            /// <para>The instance ID of the NAT CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpcnatcidr-gw8ov42ei6xh1jys2****</para>
            /// </summary>
            [NameInMap("NatIpCidrId")]
            [Validation(Required=false)]
            public string NatIpCidrId { get; set; }

            /// <summary>
            /// <para>The name of the NAT CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Name</para>
            /// </summary>
            [NameInMap("NatIpCidrName")]
            [Validation(Required=false)]
            public string NatIpCidrName { get; set; }

            /// <summary>
            /// <para>The status of the NAT CIDR block. The value is <b>Available</b>, which indicates that the NAT CIDR block is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("NatIpCidrStatus")]
            [Validation(Required=false)]
            public string NatIpCidrStatus { get; set; }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent requests exist.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7479A224-4A28-4895-9604-11F48BCE6A88</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of NAT CIDR block entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
