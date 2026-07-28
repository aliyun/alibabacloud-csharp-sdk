// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateExpressConnectTrafficQosRuleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The destination IP address IPv4 CIDR block for traffic matching in the QoS rule.</para>
        /// <remarks>
        /// <para>You cannot specify this parameter together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>1.1.**.**</c>/24</para>
        /// </summary>
        [NameInMap("DstCidr")]
        [Validation(Required=false)]
        public string DstCidr { get; set; }

        /// <summary>
        /// <para>The destination IP address IPv6 CIDR block for traffic matching in the QoS rule.</para>
        /// <remarks>
        /// <para>You cannot specify this parameter together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:0db8:1234:****::/64</para>
        /// </summary>
        [NameInMap("DstIPv6Cidr")]
        [Validation(Required=false)]
        public string DstIPv6Cidr { get; set; }

        /// <summary>
        /// <para>The destination port range for traffic matching in the QoS rule. Valid values: <b>0</b> to <b>65535</b>. Set the value to -1 if no matching is required. Currently, only a single port number can be specified. The start and end port numbers must be the same. The destination port range is fixed for each protocol type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b>: -1/-1. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>ICMP(IPv4)</b>: -1/-1. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>ICMPv6(IPv6)</b>: -1/-1. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b>: -1/-1. Editable.</para>
        /// </description></item>
        /// <item><description><para><b>UDP</b>: -1/-1. Editable.</para>
        /// </description></item>
        /// <item><description><para><b>GRE</b>: -1/-1. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>SSH</b>: 22/22. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>Telnet</b>: 23/23. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>HTTP</b>: 80/80. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: 443/443. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>MS SQL</b>: 1443/1443. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b>: 1521/1521. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>MySql</b>: 3306/3306. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>RDP</b>: 3389/3389. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b>: 5432/5432. Not editable.</para>
        /// </description></item>
        /// <item><description><para><b>Redis</b>: 6379/6379. Not editable.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("DstPortRange")]
        [Validation(Required=false)]
        public string DstPortRange { get; set; }

        /// <summary>
        /// <para>The DSCP value for traffic matching in the QoS rule. Valid values: <b>0</b> to <b>63</b>. Set the value to -1 if no matching is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MatchDscp")]
        [Validation(Required=false)]
        public int? MatchDscp { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The priority of the QoS rule. Valid values: <b>1</b> to <b>9000</b>. A larger value indicates a higher priority. The priority must be unique within the same QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The protocol type of the QoS rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ALL</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMP(IPv4)</b></para>
        /// </description></item>
        /// <item><description><para><b>ICMPv6(IPv6)</b></para>
        /// </description></item>
        /// <item><description><para><b>TCP</b></para>
        /// </description></item>
        /// <item><description><para><b>UDP</b></para>
        /// </description></item>
        /// <item><description><para><b>GRE</b></para>
        /// </description></item>
        /// <item><description><para><b>SSH</b></para>
        /// </description></item>
        /// <item><description><para><b>Telnet</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTP</b></para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b></para>
        /// </description></item>
        /// <item><description><para><b>MS SQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>MySql</b></para>
        /// </description></item>
        /// <item><description><para><b>RDP</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The QoS policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv****</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The QoS queue ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-9nyx2u7n71s2rc****</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>The region ID of the QoS policy.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The new DSCP value to remark on the traffic. Valid values: <b>0</b> to <b>63</b>. Set the value to -1 if no remarking is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RemarkingDscp")]
        [Validation(Required=false)]
        public int? RemarkingDscp { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The description of the QoS rule.</para>
        /// <para>The description must be 0 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-rule-test</para>
        /// </summary>
        [NameInMap("RuleDescription")]
        [Validation(Required=false)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// <para>The name of the QoS rule.</para>
        /// <para>The name must be 0 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-rule-test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The source IPv4 CIDR block for traffic matching in the QoS rule.</para>
        /// <remarks>
        /// <para>You cannot specify this parameter together with <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><c>1.1.**.**</c>/24</para>
        /// </summary>
        [NameInMap("SrcCidr")]
        [Validation(Required=false)]
        public string SrcCidr { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block for traffic matching in the QoS rule.</para>
        /// <remarks>
        /// <para>You cannot specify this parameter together with <b>SrcCidr</b> or <b>DstCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:0db8:1234:****::/64</para>
        /// </summary>
        [NameInMap("SrcIPv6Cidr")]
        [Validation(Required=false)]
        public string SrcIPv6Cidr { get; set; }

        /// <summary>
        /// <para>The source port range for traffic matching in the QoS rule. Valid values: <b>0</b> to <b>65535</b>. Set the value to -1 if no matching is required. Currently, only a single port number can be specified. The start and end port numbers must be the same.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("SrcPortRange")]
        [Validation(Required=false)]
        public string SrcPortRange { get; set; }

    }

}
