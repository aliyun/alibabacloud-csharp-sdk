// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyACLRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n*******</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the access control rule.</para>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/114017.html">DescribeACLAttribute</a> operation to query the IDs of access control rules in an ACL instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-u98qztgtgvhb********</para>
        /// </summary>
        [NameInMap("AcrId")]
        [Validation(Required=false)]
        public string AcrId { get; set; }

        /// <summary>
        /// <para>The description of the access control rule.</para>
        /// <para>The description must be <b>1</b> to <b>512</b> characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>The destination CIDR block must be in CIDR format. For example: 192.168.10.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>Examples of the destination port range format:</para>
        /// <list type="bullet">
        /// <item><description>1/200: ports 1 to 200.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The direction in which the access control rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound. This is the direction of traffic from an external network to the on-premises network where the Smart Access Gateway instance is deployed.</description></item>
        /// <item><description><b>out</b>: outbound. This is the direction of traffic from the on-premises network where the Smart Access Gateway instance is deployed to an external network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>A list of application group IDs that the access control rule matches.</para>
        /// </summary>
        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        /// <summary>
        /// <para>A list of application IDs that the access control rule matches.</para>
        /// </summary>
        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public List<string> DpiSignatureIds { get; set; }

        /// <summary>
        /// <para>The protocol used by the access control rule.</para>
        /// <para>For the protocols supported by the access control feature, see the information in the console. The protocol is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the access control rule.</para>
        /// <para>The name must be 2 to 128 characters in length, start with a letter or a Chinese character, and can contain digits, underscores (_), and hyphens (-).</para>
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
        /// <para>The authorization policy of the access control rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows access.</description></item>
        /// <item><description><b>drop</b>: denies access.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The priority of the access control rule.</para>
        /// <para>A smaller value indicates a higher priority. If rules have the same priority, the one that is first delivered to the Smart Access Gateway device takes precedence.</para>
        /// <para>Valid values: 1 to <b>100</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The region ID of the access control list (ACL) instance.</para>
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
        /// <para>The source CIDR block must be in CIDR format. For example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range. Valid values: <b>-1</b> or <b>1</b> to <b>65535</b>.</para>
        /// <para>Examples of the source port range format:</para>
        /// <list type="bullet">
        /// <item><description>1/200: ports 1 to 200.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The type of the access control rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LAN</b>: (Default) private network. This value indicates that the access control rule applies to traffic from private IP addresses.</description></item>
        /// <item><description><b>WAN</b>: public network. This value indicates that the access control rule applies to traffic from public IP addresses.</description></item>
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
