// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddACLRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID of the access control instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0*******</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-c1hkd054qywi******</para>
        /// </summary>
        [NameInMap("AcrId")]
        [Validation(Required=false)]
        public string AcrId { get; set; }

        /// <summary>
        /// <para>The description of the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>The destination CIDR block must be in CIDR format. Example: 192.168.10.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.10.0/24</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/65535</para>
        /// </summary>
        [NameInMap("DestPortRange")]
        [Validation(Required=false)]
        public string DestPortRange { get; set; }

        /// <summary>
        /// <para>The direction in which the access control rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: inbound. Traffic from external networks to the local branch where the Smart Access Gateway instance is deployed.</description></item>
        /// <item><description><b>out</b>: outbound. Traffic from the local branch where the Smart Access Gateway instance is deployed to external networks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>out</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public AddACLRuleResponseBodyDpiGroupIds DpiGroupIds { get; set; }
        public class AddACLRuleResponseBodyDpiGroupIds : TeaModel {
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public List<string> DpiGroupId { get; set; }

        }

        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public AddACLRuleResponseBodyDpiSignatureIds DpiSignatureIds { get; set; }
        public class AddACLRuleResponseBodyDpiSignatureIds : TeaModel {
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public List<string> DpiSignatureId { get; set; }

        }

        /// <summary>
        /// <para>The timestamp when the access control rule was created.</para>
        /// <para>The timestamp is of the Long type. If multiple rules have the same priority, the rule with the smaller timestamp takes effect first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1553766882689</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The protocol to which the access control rule is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The authorization policy of the access control rule.</para>
        /// <list type="bullet">
        /// <item><description><para><b>accept</b>: Allows the traffic.</para>
        /// </description></item>
        /// <item><description><para><b>drop</b>: Denies the traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>drop</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The priority of the access control rule.</para>
        /// <para>A smaller value indicates a higher priority. If multiple rules have the same priority, the rule that is first delivered to the Smart Access Gateway device takes effect first.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>880F84CB-9B54-4413-A8A3-8832C82D1BC4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>The source CIDR block must be in CIDR format. Example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.20.0/24</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1/65535</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

        /// <summary>
        /// <para>The type of the access control rule.</para>
        /// <list type="bullet">
        /// <item><description><para><b>LAN</b>: private network, indicating the Settings of access control rules for traffic with a private endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>WAN</b>: public network, indicating the Settings of access control rules for traffic with public IP addresses.</para>
        /// </description></item>
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
