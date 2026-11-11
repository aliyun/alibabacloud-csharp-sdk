// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeTransitRouterPolicyBasedRoutesResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned on each page. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no more results are available.</description></item>
        /// <item><description>If <b>NextToken</b> returns a value, the value is the token used to start the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The policy-based route rules.</para>
        /// </summary>
        [NameInMap("PolicyBasedRoutes")]
        [Validation(Required=false)]
        public List<DescribeTransitRouterPolicyBasedRoutesResponseBodyPolicyBasedRoutes> PolicyBasedRoutes { get; set; }
        public class DescribeTransitRouterPolicyBasedRoutesResponseBodyPolicyBasedRoutes : TeaModel {
            /// <summary>
            /// <para>The address family. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>IPv4</description></item>
            /// <item><description>IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("AddressFamily")]
            [Validation(Required=false)]
            public string AddressFamily { get; set; }

            /// <summary>
            /// <para>The description of the policy route table instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The destination port. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
            /// <para>Matches traffic whose port number falls within the destination port range. If this parameter is not specified, traffic to any destination port is matched.</para>
            /// <para>The port range format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>80: specifies port 80.</description></item>
            /// <item><description>80/80: specifies port 80.</description></item>
            /// <item><description>1/200: specifies ports 1 to 200.</description></item>
            /// <item><description>-1/-1: specifies all ports.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("DestPortRange")]
            [Validation(Required=false)]
            public string DestPortRange { get; set; }

            /// <summary>
            /// <para>The destination CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.185.33.0/24</para>
            /// </summary>
            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            /// <summary>
            /// <para>The Differentiated Services Code Point (DSCP) value of the traffic packets to match. Valid values: <b>0</b> to <b>63</b>.</para>
            /// <para>The input format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>1: matches traffic with a DSCP value of 1.</description></item>
            /// <item><description>1/10: matches traffic with a DSCP value from 1 to 10.</description></item>
            /// <item><description>-1/-1: matches traffic with any DSCP value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1/10</para>
            /// </summary>
            [NameInMap("Dscp")]
            [Validation(Required=false)]
            public string Dscp { get; set; }

            /// <summary>
            /// <para>The name of the policy-based route rule.</para>
            /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The instance ID of the policy-based routing rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pbr-123qwead</para>
            /// </summary>
            [NameInMap("PolicyBasedRouteId")]
            [Validation(Required=false)]
            public string PolicyBasedRouteId { get; set; }

            /// <summary>
            /// <para>The instance ID of the policy routing table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ptbl-123adsfzc</para>
            /// </summary>
            [NameInMap("PolicyTableId")]
            [Validation(Required=false)]
            public string PolicyTableId { get; set; }

            /// <summary>
            /// <para>The priority of the policy-based route. Valid values: <b>1</b> to <b>100</b>.</para>
            /// <para>The priority of each policy-based route in a transit router policy route table must be unique. A smaller value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The protocol type of the traffic packets.</para>
            /// <para>Traffic classification rules support matching traffic of various protocol types, such as <b>HTTP</b>, <b>HTTPS</b>, <b>TCP</b>, <b>UDP</b>, <b>SSH</b>, and <b>Telnet</b>. For more protocol types, log on to the <a href="https://cen.console.aliyun.com/cen/list">Cloud Enterprise Network (CEN) console</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The source CIDR block.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.0.0/8</para>
            /// </summary>
            [NameInMap("SourceCidr")]
            [Validation(Required=false)]
            public string SourceCidr { get; set; }

            /// <summary>
            /// <para>The source port. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
            /// <para>Matches traffic whose port number falls within the source port range. If this parameter is not specified, traffic from any source port is matched.</para>
            /// <para>The port range format is described as follows:</para>
            /// <list type="bullet">
            /// <item><description>80: specifies port 80.</description></item>
            /// <item><description>80/80: specifies port 80.</description></item>
            /// <item><description>1/200: specifies ports 1 to 200.</description></item>
            /// <item><description>-1/-1: specifies all ports.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>80/80</para>
            /// </summary>
            [NameInMap("SourcePortRange")]
            [Validation(Required=false)]
            public string SourcePortRange { get; set; }

            /// <summary>
            /// <para>The status of the policy-based route. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: creating</description></item>
            /// <item><description><b>Active</b>: available</description></item>
            /// <item><description><b>Deleting</b>: deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The target route table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vtb-123adf</para>
            /// </summary>
            [NameInMap("TargetRouteTableId")]
            [Validation(Required=false)]
            public string TargetRouteTableId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7DDDC17-FA06-4AC2-8F35-59D2470FCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
