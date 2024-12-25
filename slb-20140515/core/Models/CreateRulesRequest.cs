// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateRulesRequest : TeaModel {
        /// <summary>
        /// <para>The frontend listener port that is used by the SLB instance.</para>
        /// <para>Valid values: <b>1 to 65535</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>443</para>
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// <para>The frontend protocol that is used by the SLB instance.</para>
        /// <remarks>
        /// <para>This parameter is required if the same port is used by listeners that use different protocols.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>https</para>
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the SLB instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1ca0zt07t934w******</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Server Load Balancer (SLB) instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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
        /// <para>The forwarding rules that you want to create. You can create at most 10 forwarding rules in each call. Each forwarding rule contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>RuleName</b>: Required. The value must be of the STRING type. The name of the forwarding rule. The name must be 1 to 40 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_). Forwarding rule names must be unique within the same listener.</description></item>
        /// <item><description><b>Domain</b>: Optional. The value must be a string. The domain name that is associated with the forwarding rule. You must specify this parameter or the <b>URL</b> parameter.</description></item>
        /// <item><description><b>Url</b>: Optional. The value must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&amp;). The value must be a string. The URL cannot be only a forward slash (/). However, it must start with a forward slash (/). You must specify this parameter or the <b>Domain</b> parameter.</description></item>
        /// <item><description><b>VServerGroupId</b>: Required. The value must be a string. The ID of the vServer group to be specified in the forwarding rule.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You must specify at least one between the <c>Domain</c> and <c>URL</c> parameters. You can also specify both. The combination of <c>Domain</c> and <c>Url</c> must be unique within the same listener.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;RuleName&quot;:&quot;Rule2&quot;,&quot;Domain&quot;:&quot;test.com&quot;,&quot;VServerGroupId&quot;:&quot;rsp-bp114ni******&quot;}]</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public string RuleList { get; set; }

    }

}
