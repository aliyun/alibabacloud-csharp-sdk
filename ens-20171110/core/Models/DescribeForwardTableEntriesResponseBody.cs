// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details of DNAT entries.</para>
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public List<DescribeForwardTableEntriesResponseBodyForwardTableEntries> ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            /// <summary>
            /// <para>The EIP in the DNAT entry. The public IP address is used to access the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.XXX.XXX.70</para>
            /// </summary>
            [NameInMap("ExternalIp")]
            [Validation(Required=false)]
            public string ExternalIp { get; set; }

            /// <summary>
            /// <para>The external port or port range that is used in port forwarding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("ExternalPort")]
            [Validation(Required=false)]
            public string ExternalPort { get; set; }

            /// <summary>
            /// <para>The ID of the DNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fwd-5tf66679oi2uoxcvlg0g2****</para>
            /// </summary>
            [NameInMap("ForwardEntryId")]
            [Validation(Required=false)]
            public string ForwardEntryId { get; set; }

            /// <summary>
            /// <para>The name of the DNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test0</para>
            /// </summary>
            [NameInMap("ForwardEntryName")]
            [Validation(Required=false)]
            public string ForwardEntryName { get; set; }

            /// <summary>
            /// <para>The probe port of DNAT.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public string HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The private IP address of the instance that uses the DNAT entry for Internet communication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.XXX.XXX.3</para>
            /// </summary>
            [NameInMap("InternalIp")]
            [Validation(Required=false)]
            public string InternalIp { get; set; }

            /// <summary>
            /// <para>The internal port or port range that is used for port forwarding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: forwards TCP packets.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: forwards UDP packets.</para>
            /// </description></item>
            /// <item><description><para><b>Any</b>: forwards all packets.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Any</para>
            /// </summary>
            [NameInMap("IpProtocol")]
            [Validation(Required=false)]
            public string IpProtocol { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-5tawjw5j7sgd2deujxuk0****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The secondary EIP that is used to access the Internet.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.XXX.XXX.7</para>
            /// </summary>
            [NameInMap("StandbyExternalIp")]
            [Validation(Required=false)]
            public string StandbyExternalIp { get; set; }

            /// <summary>
            /// <para>The status of the secondary EIP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Running</para>
            /// </description></item>
            /// <item><description><para>Stopping</para>
            /// </description></item>
            /// <item><description><para>Stopped</para>
            /// </description></item>
            /// <item><description><para>Starting</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Stopped</para>
            /// </summary>
            [NameInMap("StandbyStatus")]
            [Validation(Required=false)]
            public string StandbyStatus { get; set; }

            /// <summary>
            /// <para>The status of the DNAT entry. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The DNAT entry is being created or modified.</para>
            /// </description></item>
            /// <item><description><para>Available: The DNAT entry is available.</para>
            /// </description></item>
            /// <item><description><para>Deleting: The DNAT entry is being deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
