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
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The destination IPv4 CIDR block that matches the QoS rule traffic.</para>
        /// <remarks>
        /// <para>When this parameter is unavailable, specify <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.0/24</para>
        /// </summary>
        [NameInMap("DstCidr")]
        [Validation(Required=false)]
        public string DstCidr { get; set; }

        /// <summary>
        /// <para>The destination IPv6 CIDR block that matches the QoS rule traffic.</para>
        /// <remarks>
        /// <para>When this parameter is unavailable, specify <b>SrcCidr</b> or <b>DstCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:0db8:1234:5678::/64</para>
        /// </summary>
        [NameInMap("DstIPv6Cidr")]
        [Validation(Required=false)]
        public string DstIPv6Cidr { get; set; }

        /// <summary>
        /// <para>The range of destination ports that match the QoS rule traffic. Valid values: <b>0</b> to <b>65535</b>. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number. Different protocols correspond to different ports. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b> (uneditable): -1/-1.</description></item>
        /// <item><description><b>ICMP(IPv4)</b> (uneditable): -1/-1.</description></item>
        /// <item><description><b>ICMPv6(IPv6)</b> (uneditable): -1/-1.</description></item>
        /// <item><description><b>TCP</b> (editable): -1/-1.</description></item>
        /// <item><description><b>UDP</b> (editable): -1/-1.</description></item>
        /// <item><description><b>GRE</b> (uneditable): -1/-1.</description></item>
        /// <item><description><b>SSH</b> (uneditable): 22/22.</description></item>
        /// <item><description><b>Telnet</b> (uneditable): 23/23.</description></item>
        /// <item><description><b>HTTP</b> (uneditable): 80/80.</description></item>
        /// <item><description><b>HTTPS</b> (uneditable): 443/443.</description></item>
        /// <item><description><b>MS SQL</b> (uneditable): 1443/1443.</description></item>
        /// <item><description><b>Oracle</b> (uneditable): 1521/1521.</description></item>
        /// <item><description><b>MySql</b> (uneditable): 3306/3306.</description></item>
        /// <item><description><b>RDP</b> (uneditable): 3389/3389.</description></item>
        /// <item><description><b>PostgreSQL</b> (uneditable): 5432/5432.</description></item>
        /// <item><description><b>Redis</b> (uneditable): 6379/6379.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("DstPortRange")]
        [Validation(Required=false)]
        public string DstPortRange { get; set; }

        /// <summary>
        /// <para>The DSCP value that matches the QoS rule traffic. Valid values: <b>0</b> to <b>63</b>. If no value is matched, the value is -1.</para>
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
        /// <para>The priority of the QoS rule. Valid values: <b>1</b> to <b>9000</b>. A larger value indicates a higher priority. The priority of each QoS rule must be unique in the same QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The protocol of the QoS rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALL</b></description></item>
        /// <item><description><b>ICMP(IPv4)</b></description></item>
        /// <item><description><b>ICMPv6(IPv6)</b></description></item>
        /// <item><description><b>TCP</b></description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>GRE</b></description></item>
        /// <item><description><b>SSH</b></description></item>
        /// <item><description><b>Telnet</b></description></item>
        /// <item><description><b>HTTP</b></description></item>
        /// <item><description><b>HTTPS</b></description></item>
        /// <item><description><b>MS SQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>MySql</b></description></item>
        /// <item><description><b>RDP</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>Redis</b></description></item>
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
        /// <para>The ID of the QoS policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-2giu0a6vd5x0mv4700</para>
        /// </summary>
        [NameInMap("QosId")]
        [Validation(Required=false)]
        public string QosId { get; set; }

        /// <summary>
        /// <para>The ID of the QoS queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-queue-9nyx2u7n71s2rcy4n5</para>
        /// </summary>
        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        /// <summary>
        /// <para>The region ID of the QoS policy.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The new DSCP value. Valid values: <b>0</b> to <b>63</b>. If you do not change the value, set the value to -1.</para>
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
        /// <para>The source IPv4 CIDR block that matches the QoS rule traffic.</para>
        /// <remarks>
        /// <para>When this parameter is unavailable, specify <b>SrcIPv6Cidr</b> or <b>DstIPv6Cidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.1.0/24</para>
        /// </summary>
        [NameInMap("SrcCidr")]
        [Validation(Required=false)]
        public string SrcCidr { get; set; }

        /// <summary>
        /// <para>The source IPv6 CIDR block that matches the QoS rule traffic.</para>
        /// <remarks>
        /// <para>When this parameter is unavailable, specify <b>SrcCidr</b> or <b>DstCidr</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2001:0db8:1234:5678::/64</para>
        /// </summary>
        [NameInMap("SrcIPv6Cidr")]
        [Validation(Required=false)]
        public string SrcIPv6Cidr { get; set; }

        /// <summary>
        /// <para>The range of source ports that match the QoS rule traffic. Valid values: <b>0</b> to <b>65535</b>. If the traffic does not match, the value is -1. You can specify only one port. The start port number must be the same as the end port number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("SrcPortRange")]
        [Validation(Required=false)]
        public string SrcPortRange { get; set; }

    }

}
