// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddACLRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n*****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The description of the ACL rule.</para>
        /// <para>The description must be 1 to <b>512</b> characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desctest</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>For example: 192.168.10.0/24.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range.</para>
        /// <para>Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
        /// <para>Use the format 1/200 or 80/80. A value of -1/-1 means all ports.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/200</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The direction of traffic to which the ACL rule applies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound. Traffic from an external network to the local branch where the SAG instance is deployed.</description></item>
        /// <item><description><b>out</b>: outbound. Traffic from the local branch where the SAG instance is deployed to an external network.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>A list of application group IDs. The ACL rule matches traffic of the specified application groups.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/196754.html">ListDpiGroups</a>. You can specify up to <b>10</b> application group IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        /// <summary>
        /// <para>A list of application IDs. The ACL rule matches traffic of the specified applications.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/196630.html">ListDpiSignatures</a>. You can specify up to <b>10</b> application IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public List<string> DpiSignatureIds { get; set; }

        /// <summary>
        /// <para>The protocol to which the ACL rule applies.</para>
        /// <para>For a list of supported protocols, see the console. The protocol is not case-sensitive.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the ACL rule.</para>
        /// <para>The name must be 2 to 100 characters in length, start with a letter, and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The authorization policy of the ACL rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows access.</description></item>
        /// <item><description><b>drop</b>: denies access.</description></item>
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
        /// <para>The priority of the ACL rule.</para>
        /// <para>A smaller value indicates a higher priority. If multiple rules have the same priority, the rule that is first delivered to the Smart Access Gateway device takes precedence.</para>
        /// <para>Valid values: 1 to <b>100</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the region where the access control list (ACL) is located.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/69813.html">DescribeRegions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>For example: 192.168.1.0/24.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.20.0/24</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range.</para>
        /// <para>Valid values: <b>-1</b> and <b>1</b> to <b>65535</b>.</para>
        /// <para>Use the format 1/200 or 80/80. A value of -1/-1 means all ports.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/200</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The type of the ACL rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LAN</b>: (Default) private network. The ACL rule controls traffic on private networks.</description></item>
        /// <item><description><b>WAN</b>: public network. The ACL rule controls traffic on public networks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LAN</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
