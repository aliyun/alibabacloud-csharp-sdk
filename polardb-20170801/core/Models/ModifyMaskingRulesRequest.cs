// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyMaskingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of all clusters in your account, including cluster IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-*****************</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>The default algorithm.</para>
        /// <remarks>
        /// <para>You must specify either MaskingAlgo or DefaultAIgo.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>aes-128-gcm</para>
        /// </summary>
        [NameInMap("DefaultAlgo")]
        [Validation(Required=false)]
        public string DefaultAlgo { get; set; }

        /// <summary>
        /// <para>Enables or disables the specified data masking rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables the specified rules.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables the specified rules.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only when the <c>RuleNameList</c> parameter is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The type of rule to modify. Valid values:</para>
        /// <para>v1: Modifies a data masking rule.
        /// v2: Modifies an encryption rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("InterfaceVersion")]
        [Validation(Required=false)]
        public string InterfaceVersion { get; set; }

        /// <summary>
        /// <para>The masking algorithm. Specify one or more algorithms and their parameters. Format: <c>[{ &quot;name&quot;: &quot;algorithm_name&quot;, &quot;params&quot;: {&quot;key&quot;: &quot;value&quot;} }]</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        /// &quot;name&quot;: &quot;aes-128-gcm&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("MaskingAlgo")]
        [Validation(Required=false)]
        public string MaskingAlgo { get; set; }

        /// <summary>
        /// <para>A JSON string that specifies the rule configuration. Example: <c>{&quot;auto&quot;: {&quot;databases&quot;: [&quot;db1&quot;], &quot;tables&quot;: [&quot;tb1&quot;], &quot;columns&quot;: [&quot;c1,c2&quot;] }, &quot;description&quot;: &quot;This rule will be applied to the columns c1 and c2 in table t1&quot;, &quot;enabled&quot;: true, &quot;applies_to&quot;: [&quot;user&quot;]}</c>. The JSON string includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><c>&quot;auto&quot;</c>: Required. The object that contains the configuration for the dynamic data masking algorithm.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;databases&quot;</c>: Optional. The databases to which the rule applies. Separate multiple database names with a comma (,). If this parameter is omitted, the rule applies to all databases in the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;tables&quot;</c>: Optional. The tables to which the rule applies. Separate multiple table names with a comma (,). If this parameter is omitted, the rule applies to all tables in the cluster.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;columns&quot;</c>: Required. The columns to which the rule applies. Separate multiple column names with a comma (,).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;description&quot;</c>: Optional. The rule description, up to 64 characters in length.</para>
        /// </description></item>
        /// <item><description><para><c>&quot;enabled&quot;</c>: Required. Specifies whether the data masking rule is enabled. Valid values: <b>true</b> (enabled) and <b>false</b> (disabled).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;applies_to&quot;</c>: The database accounts to which the rule applies. Separate multiple account names with a comma (,).</para>
        /// </description></item>
        /// <item><description><para><c>&quot;exempted&quot;</c>: The database accounts that are exempt from the rule. Separate multiple account names with a comma (,).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you specify the <c>RuleName</c> parameter, you must also specify the <c>RuleConfig</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>You must specify either <c>&quot;applies_to&quot;</c> or <c>&quot;exempted&quot;</c>.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;auto&quot;: {&quot;databases&quot;: [&quot;db1&quot;], &quot;tables&quot;: [&quot;tb1&quot;], &quot;columns&quot;: [&quot;c1,c2&quot;] }, &quot;description&quot;: &quot;This rule will be applied to the columns c1 and c2 in table t1&quot;, &quot;enabled&quot;: true, &quot;applies_to&quot;: [&quot;user&quot;]}</para>
        /// </summary>
        [NameInMap("RuleConfig")]
        [Validation(Required=false)]
        public string RuleConfig { get; set; }

        /// <summary>
        /// <para>The name of the data masking rule. You can specify only one rule name at a time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeMaskingRules</a> operation to query the details of all data masking rules in the target cluster, including rule names.</para>
        /// </description></item>
        /// <item><description><para>If a rule with the specified name does not exist, the system creates a new one based on the provided <c>RuleConfig</c>.</para>
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

        /// <summary>
        /// <para>A comma-separated list of data masking rule names.</para>
        /// <remarks>
        /// <para>You must specify either the <c>RuleName</c> or <c>RuleNameList</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testrule</para>
        /// </summary>
        [NameInMap("RuleNameList")]
        [Validation(Required=false)]
        public string RuleNameList { get; set; }

        /// <summary>
        /// <para>The version of the data masking rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>v1 (default)</para>
        /// </description></item>
        /// <item><description><para>v2</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("RuleVersion")]
        [Validation(Required=false)]
        public string RuleVersion { get; set; }

    }

}
