// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateNetworkAclEntryRequest : TeaModel {
        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("CidrBlock")]
        [Validation(Required=false)]
        public string CidrBlock { get; set; }

        /// <summary>
        /// <para>The description of the network ACL.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my NetworkAcl.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The direction in which the rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ingress</b></description></item>
        /// <item><description><b>egress</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ingress</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-1</para>
        /// </summary>
        [NameInMap("NetworkAclEntryName")]
        [Validation(Required=false)]
        public string NetworkAclEntryName { get; set; }

        /// <summary>
        /// <para>The ID of the network ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nacl-bp1lhl0taikrbgnh****</para>
        /// </summary>
        [NameInMap("NetworkAclId")]
        [Validation(Required=false)]
        public string NetworkAclId { get; set; }

        /// <summary>
        /// <para>The action that is performed on network traffic that matches the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows network traffic.</description></item>
        /// <item><description><b>drop</b>: blocks network traffic.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The port range.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>Protocol</b> to <b>all</b> or <b>icmp</b>, set this parameter to -1/-1, which specifies all ports.</description></item>
        /// <item><description>If you set <b>Protocol</b> to <b>tcp</b> or <b>udp</b>, the port can be <b>1 to 65535</b>. You can set this parameter to <b>1/200</b> or <b>80/80</b>, which specifies ports 1 to 200 or port 80.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("PortRange")]
        [Validation(Required=false)]
        public string PortRange { get; set; }

        /// <summary>
        /// <para>The priority of the rule. Valid values: <b>1 to 100</b>. Default value: <b>1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The type of the protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>icmp</b>: ICMP</description></item>
        /// <item><description><b>tcp</b>: TCP</description></item>
        /// <item><description><b>udp</b>: UDP</description></item>
        /// <item><description><b>all</b>: all protocols</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

    }

}
