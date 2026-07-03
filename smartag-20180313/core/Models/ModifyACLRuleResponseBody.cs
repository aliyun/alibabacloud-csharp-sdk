// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyACLRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the ACL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acl-jdc7tir4fkplwr****</para>
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// <para>The ID of the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acr-r8hezn2pi39s5a****</para>
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
        /// <para>The destination CIDR block is in CIDR format. For example: 192.168.10.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("DestCidr")]
        [Validation(Required=false)]
        public string DestCidr { get; set; }

        /// <summary>
        /// <para>The destination port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
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

        [NameInMap("DpiGroupIds")]
        [Validation(Required=false)]
        public ModifyACLRuleResponseBodyDpiGroupIds DpiGroupIds { get; set; }
        public class ModifyACLRuleResponseBodyDpiGroupIds : TeaModel {
            [NameInMap("DpiGroupId")]
            [Validation(Required=false)]
            public List<string> DpiGroupId { get; set; }

        }

        [NameInMap("DpiSignatureIds")]
        [Validation(Required=false)]
        public ModifyACLRuleResponseBodyDpiSignatureIds DpiSignatureIds { get; set; }
        public class ModifyACLRuleResponseBodyDpiSignatureIds : TeaModel {
            [NameInMap("DpiSignatureId")]
            [Validation(Required=false)]
            public List<string> DpiSignatureId { get; set; }

        }

        /// <summary>
        /// <para>The timestamp that indicates when the access control rule was created.</para>
        /// <para>The value is a UNIX timestamp. If rules have the same priority, the one with the smaller timestamp takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1553777700000</para>
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// <para>The protocol used by the access control rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
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
        /// <para>7F3DD2C1-0F6B-4575-9106-B2D50DF7A711</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The source CIDR block.</para>
        /// <para>The source CIDR block is in CIDR format. For example: 192.168.1.0/24.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("SourceCidr")]
        [Validation(Required=false)]
        public string SourceCidr { get; set; }

        /// <summary>
        /// <para>The source port range.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1/-1</para>
        /// </summary>
        [NameInMap("SourcePortRange")]
        [Validation(Required=false)]
        public string SourcePortRange { get; set; }

    }

}
