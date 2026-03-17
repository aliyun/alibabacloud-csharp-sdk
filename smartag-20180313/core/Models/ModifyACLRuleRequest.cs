// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyACLRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0n*******</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the ACL rule.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/114017.html">DescribeACLAttribute</a> operation to query the ID of the ACL rule that is added to the ACL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-u98qztgtgvhb********</para>
        /// </summary>
        [NameInMap("AcrId")]
        [Validation(Required=false)]
        public string AcrId { get; set; }

        /// <summary>
        /// <para>The description of the ACL rule.</para>
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
        /// <para>Specify the value of this parameter in CIDR notation. Example: 192.168.10.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range. Valid values: <b>1</b> to <b>65535</b> and <b>-1</b>.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>1/200: port 1 to port 200.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>\-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The direction of traffic in which the ACL rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: The ACL rule controls inbound network traffic of the on-premises network that is associated with the SAG instance.</description></item>
        /// <item><description><b>out</b>: The ACL rule controls outbound network traffic of the on-premises network that is associated with the SAG instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public List<string> DpiGroupIds { get; set; }

        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public List<string> DpiSignatureIds { get; set; }

        /// <summary>
        /// <para>The protocol used by the ACL rule.</para>
        /// <para>The supported protocols provided in this topic are for reference only. The actual protocols in the SAG console shall prevail. The value of the parameter is not case-sensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tcp</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the ACL rule.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
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
        /// <para>The action of the ACL rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows network traffic.</description></item>
        /// <item><description><b>drop</b>: blocks network traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>accept</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The priority of the ACL rule.</para>
        /// <para>A smaller value indicates a higher priority. If multiple rules have the same priority, the rule that is applied earlier takes effect.</para>
        /// <para>Valid values: <b>1 to 100</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the region where the ACL is deployed.</para>
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
        /// <para>Specify the value of this parameter in CIDR notation. Example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range. Valid values: <b>1</b> to <b>65535</b> and <b>-1</b>.</para>
        /// <para>Examples:</para>
        /// <list type="bullet">
        /// <item><description>1/200: port 1 to port 200.</description></item>
        /// <item><description>80/80: port 80.</description></item>
        /// <item><description>\-1/-1: all ports.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>80/80</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The type of the ACL rule: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>LAN</b>: The ACL rule controls traffic of private IP addresses.</description></item>
        /// <item><description><b>WAN</b>: The ACL rule controls traffic of public IP addresses.</description></item>
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
