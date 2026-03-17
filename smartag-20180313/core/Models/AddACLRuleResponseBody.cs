// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class AddACLRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-xhwhyuo43l0*******</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the ACL rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-c1hkd054qywi******</para>
        /// </summary>
        [NameInMap("AcrId")]
        [Validation(Required=false)]
        public string AcrId { get; set; }

        /// <summary>
        /// <para>The description of the ACL rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>The value of this parameter is specified in CIDR notation. Example: 192.168.10.0/24.</para>
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
        /// <para>The direction of traffic in which the ACL rule is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>in</b>: The ACL rule controls inbound network traffic of the on-premises network that is associated with the SAG instance.</description></item>
        /// <item><description><b>out</b>: The ACL rule controls outbound network traffic of the on-premises network that is associated with the SAG instance.</description></item>
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
        /// <para>The timestamp when the ACL rule was created.</para>
        /// <para>The timestamp is of the Long data type. If multiple ACL rules have the same priority, the rule with the earliest timestamp takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1553766882689</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The protocol used by the ACL rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("IpProtocol")]
        [Validation(Required=false)]
        public string IpProtocol { get; set; }

        /// <summary>
        /// <para>The name of the ACL rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>doctest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The action policy of the ACL rule.</para>
        /// <list type="bullet">
        /// <item><description><b>accept</b>: allows the network traffic.</description></item>
        /// <item><description><b>drop</b>: blocks the network traffic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>drop</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// <para>The priority of the ACL rule.</para>
        /// <para>A smaller value indicates a higher priority. If rules have the same priority, whichever applied to the SAG devices earlier takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>880F84CB-9B54-4413-A8A3-8832C82D1BC4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>The value of this parameter is specified in CIDR notation. Example: 192.168.1.0/24.</para>
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
        /// <para>The type of the ACL rule:</para>
        /// <list type="bullet">
        /// <item><description><b>LAN</b>: The ACL rule controls network traffic transmitted through private IP addresses.</description></item>
        /// <item><description><b>WAN</b>: The ACL rule controls network traffic transmitted through public IP addresses.</description></item>
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
