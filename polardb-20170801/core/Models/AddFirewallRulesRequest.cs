// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class AddFirewallRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-************</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the configuration parameters and their values for the firewall rule to add. All parameter values must be strings. For example: <c>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;mode&quot;:&quot;Collecting&quot;,&quot;users&quot;:{&quot;applies_to&quot;:[]},&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-************&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;},{&quot;EndpointName&quot;:&quot;pe-************&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-************&quot;},{&quot;EndpointName&quot;:&quot;pe-************&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-************K&quot;}]&quot;,&quot;type&quot;:&quot;WhiteList&quot;}</c>. The JSON string contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><c>&quot;id&quot;</c>: Required. The name of the firewall rule.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;endpoint&quot;</c>: Required. The information about the instance endpoint.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;mode&quot;:&quot;Collecting&quot;,&quot;users&quot;:{&quot;applies_to&quot;:[]},&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-<b><b><b><b><b><b>&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-<b><b><b><b><b><b>&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-************K&quot;}]&quot;,&quot;type&quot;:&quot;WhiteList&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The name of the firewall rule. You can specify only one rule name.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeFirewallRules</a> operation to view the details of all firewall rules for the target cluster, including the rule names.</para>
        /// </description></item>
        /// <item><description><para>If the specified rule name does not exist in the cluster, the system automatically creates a new firewall rule based on the name and the value of the <c>RuleConfig</c> parameter.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
