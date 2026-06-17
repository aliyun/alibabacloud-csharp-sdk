// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyFirewallRulesRequest : TeaModel {
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>A JSON string that contains the configuration parameters of the firewall rule to modify and their values. The parameter values are strings. Example: <c>{ &quot;id&quot;: &quot;test&quot;, &quot;enabled&quot;: &quot;true&quot;, &quot;mode&quot;: &quot;Defending&quot;, &quot;users&quot;: { &quot;applies_to&quot;: [] }, &quot;endpoint&quot;: &quot;[{&quot;EndpointName&quot;:&quot;pe-***************&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Endpoint&quot;},{&quot;EndpointName&quot;:&quot;pe-***************&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-***************&quot;},{&quot;EndpointName&quot;:&quot;pe-***************&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-***************&quot;}]&quot;, &quot;type&quot;: &quot;BlackList&quot;, &quot;sub_rules&quot;: [] }, &quot;RuleName&quot;: &quot;test&quot; }</c>. The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><para><c>&quot;id&quot;</c>: Required. The name of the firewall rule.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;databases&quot;</c>: Optional. The names of the databases to which the rule applies. You can specify multiple database names. Separate the names with commas (,). If you leave this parameter empty, the rule applies to all databases in the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;tables&quot;</c>: Optional. The names of the tables to which the rule applies. You can specify multiple table names. Separate the names with commas (,). If you leave this parameter empty, the rule applies to all tables in the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;columns&quot;</c>: Required. The names of the fields to which the rule applies. You can specify multiple field names. Separate the names with commas (,).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;description&quot;</c>: Optional. The description of the data masking rule. The description can be up to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;enabled&quot;</c>: Required. Specifies whether to enable or disable the data masking rule. Valid values: <b>true</b> (enable) and <b>false</b> (disable).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;applies_to&quot;</c>: The names of the database accounts to which the rule applies. You can specify multiple database account names. Separate the names with commas (,).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;exempted&quot;</c>: The names of the database accounts to which the rule does not apply. You can specify multiple database account names. Separate the names with commas (,).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <c>RuleName</c> parameter, the <c>RuleConfig</c> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>You must specify either <c>&quot;applies_to&quot;</c> or <c>&quot;exempted&quot;</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;id&quot;:&quot;test&quot;,&quot;enabled&quot;:&quot;true&quot;,&quot;mode&quot;:&quot;Collecting&quot;,&quot;users&quot;:{&quot;applies_to&quot;:[]},&quot;endpoint&quot;:&quot;[{&quot;EndpointName&quot;:&quot;pe-<b><b><b><b><b><b>&quot;,&quot;EndpointType&quot;:&quot;Cluster&quot;,&quot;DBEndpointDescription&quot;:&quot;Cluster Address&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-<b><b><b><b><b><b>&quot;},{&quot;EndpointName&quot;:&quot;pe-</b></b></b></b></b></b>&quot;,&quot;EndpointType&quot;:&quot;Custom&quot;,&quot;DBEndpointDescription&quot;:&quot;pc-************K&quot;}]&quot;,&quot;type&quot;:&quot;WhiteList&quot;}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The name of the firewall rule. You can specify only one rule name at a time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeFirewallRules</a> operation to query the details of all firewall rules for the target cluster, including the rule names.</para>
        /// </description></item>
        /// <item><description><para>If the specified rule name does not exist in the current cluster, the system automatically creates a new firewall rule based on the rule name and the value of <c>RuleConfig</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
