// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeForwardTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the queried DNAT entries.</para>
        /// </summary>
        [NameInMap("ForwardTableEntries")]
        [Validation(Required=false)]
        public List<DescribeForwardTableEntriesResponseBodyForwardTableEntries> ForwardTableEntries { get; set; }
        public class DescribeForwardTableEntriesResponseBodyForwardTableEntries : TeaModel {
            /// <summary>
            /// <para>The elastic IP address that provides public network access in the DNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120.XXX.XXX.70</para>
            /// </summary>
            [NameInMap("ExternalIp")]
            [Validation(Required=false)]
            public string ExternalIp { get; set; }

            /// <summary>
            /// <para>The external port or port range used for port forwarding.</para>
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
            /// <para>The health check port of the DNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckPort")]
            [Validation(Required=false)]
            public string HealthCheckPort { get; set; }

            /// <summary>
            /// <para>The private IP address of the instance that communicates with the Internet through the DNAT entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.XXX.XXX.3</para>
            /// </summary>
            [NameInMap("InternalIp")]
            [Validation(Required=false)]
            public string InternalIp { get; set; }

            /// <summary>
            /// <para>The internal port or port range used for port forwarding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("InternalPort")]
            [Validation(Required=false)]
            public string InternalPort { get; set; }

            /// <summary>
            /// <para>The protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>TCP</b>: Forwards TCP packets.</para>
            /// </description></item>
            /// <item><description><para><b>UDP</b>: Forwards UDP packets.</para>
            /// </description></item>
            /// <item><description><para><b>Any</b>: Forwards packets of all protocols.</para>
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
            /// <para>The standby elastic IP address that provides public network access.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101.XXX.XXX.7</para>
            /// </summary>
            [NameInMap("StandbyExternalIp")]
            [Validation(Required=false)]
            public string StandbyExternalIp { get; set; }

            /// <summary>
            /// <para>The status of the standby elastic IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: Enabled.</description></item>
            /// <item><description>Stopping: Disabling.</description></item>
            /// <item><description>Stopped: Disabled.</description></item>
            /// <item><description>Starting: Enabling.</description></item>
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
            /// <item><description>Pending: The entry is being configured, created, or modified.</description></item>
            /// <item><description>Available: The entry is available.</description></item>
            /// <item><description>Deleting: The entry is being deleted.</description></item>
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
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
