// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeSecurityProxyResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of NAT firewalls.</para>
        /// </summary>
        [NameInMap("ProxyList")]
        [Validation(Required=false)]
        public List<DescribeSecurityProxyResponseBodyProxyList> ProxyList { get; set; }
        public class DescribeSecurityProxyResponseBodyProxyList : TeaModel {
            /// <summary>
            /// <para>The IPv4 CIDR block of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The error details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“”</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// <para>The UID of the Cloud Firewall member accounts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1797733170015112</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

            /// <summary>
            /// <para>The ID of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-2zex8sf4s5vus8rq3rjqo</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The name of the NAT gateway.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs-slb-eip-waf</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The ID of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>proxy-nat4921f192b6cf438d93f8</para>
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public string ProxyId { get; set; }

            /// <summary>
            /// <para>The name of the NAT firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nat-idmp-fir</para>
            /// </summary>
            [NameInMap("ProxyName")]
            [Validation(Required=false)]
            public string ProxyName { get; set; }

            /// <summary>
            /// <para>The region ID of the VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The list of SNAT IP addresses.</para>
            /// </summary>
            [NameInMap("SnatIpList")]
            [Validation(Required=false)]
            public List<string> SnatIpList { get; set; }

            /// <summary>
            /// <para>The status of Cloud Firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>configuring</b>: Being created.</description></item>
            /// <item><description><b>deleting</b>: Being deleted.</description></item>
            /// <item><description><b>normal</b>: Normal.</description></item>
            /// <item><description><b>abnormal</b>: Abnormal.</description></item>
            /// <item><description><b>opening</b>: Being enabled.</description></item>
            /// <item><description><b>closing</b>: Being disabled.</description></item>
            /// <item><description><b>closed</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether strict mode is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Strict mode is enabled.</description></item>
            /// <item><description>0: Strict mode is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("StrictMode")]
            [Validation(Required=false)]
            public int? StrictMode { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch to which the Cloud Firewall interface belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-5gu2qqfmjmwl8ktzgfekl</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC-connected instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-wz9xn35tq33hunzvpu0se</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the VPC instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1kw9igsq0yyzeanqamx</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F0F82705-CFC7-5F83-86C8-A063892F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
