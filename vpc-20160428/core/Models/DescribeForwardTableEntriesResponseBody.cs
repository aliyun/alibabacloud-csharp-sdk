// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of DNAT entries.</para>
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public DescribeForwardTableEntriesResponseBodyForwardTableEntries ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            [NameInMap("ForwardTableEntry")]
            [Validation(Required=false)]
            public List<DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry> ForwardTableEntry { get; set; }
            public class DescribeForwardTableEntriesResponseBodyForwardTableEntriesForwardTableEntry : TeaModel {
                /// <summary>
                /// <list type="bullet">
                /// <item><description>The EIPs that can be accessed over the Internet when you query DNAT entries of Internet NAT gateways.</description></item>
                /// <item><description>The NAT IP addresses that can be accessed by external networks when you query DNAT entries of VPC NAT gateways.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>139.79.XX.XX</para>
                /// </summary>
                [NameInMap("ExternalIp")]
                [Validation(Required=false)]
                public string ExternalIp { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>The external port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.</description></item>
                /// <item><description>The port that is used when the NAT IP address can be accessed by external networks when you query DNAT entries of VPC NAT gateways.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ExternalPort")]
                [Validation(Required=false)]
                public string ExternalPort { get; set; }

                /// <summary>
                /// <para>The ID of the DNAT entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fwd-119smw5tk****</para>
                /// </summary>
                [NameInMap("ForwardEntryId")]
                [Validation(Required=false)]
                public string ForwardEntryId { get; set; }

                /// <summary>
                /// <para>The name of the DNAT entry.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardEntry-1</para>
                /// </summary>
                [NameInMap("ForwardEntryName")]
                [Validation(Required=false)]
                public string ForwardEntryName { get; set; }

                /// <summary>
                /// <para>The ID of the DNAT table to which the DNAT entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ftb-11tc6xgmv****</para>
                /// </summary>
                [NameInMap("ForwardTableId")]
                [Validation(Required=false)]
                public string ForwardTableId { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// <list type="bullet">
                /// <item><description>The private IP address of the ECS instance that uses DNAT entries to communicate with the Internet when you query DNAT entries of Internet NAT gateways.</description></item>
                /// <item><description>The private IP address that uses DNAT entries when you query DNAT entries of VPC NAT gateways.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("InternalIp")]
                [Validation(Required=false)]
                public string InternalIp { get; set; }

                /// <summary>
                /// <list type="bullet">
                /// <item><description>The internal port or port range that is used for port forwarding when you query DNAT entries of Internet NAT gateways.</description></item>
                /// <item><description>The destination ECS instance port to be mapped when you query DNAT entries of VPC NAT gateways.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("InternalPort")]
                [Validation(Required=false)]
                public string InternalPort { get; set; }

                /// <summary>
                /// <para>The protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TCP</b></description></item>
                /// <item><description><b>UDP</b></description></item>
                /// <item><description><b>Any</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("IpProtocol")]
                [Validation(Required=false)]
                public string IpProtocol { get; set; }

                /// <summary>
                /// <para>The ID of the NAT gateway to which the DNAT entry belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ngw-bp1uewa15k4iy5770****</para>
                /// </summary>
                [NameInMap("NatGatewayId")]
                [Validation(Required=false)]
                public string NatGatewayId { get; set; }

                /// <summary>
                /// <para>The status of the DNAT entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A6C4A8B1-7561-4509-949C-20DEB40D71E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
