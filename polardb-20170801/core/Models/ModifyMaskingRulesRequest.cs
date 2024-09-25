// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyMaskingRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/98094.html">DescribeDBClusters</a> operation to query the details of the clusters that belong to your Alibaba Cloud account, such as cluster IDs.</para>
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
        /// <para>Specifies whether to enable the specified masking rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when the <c>RuleNameList</c> parameter is specfied.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public string Enable { get; set; }

        /// <summary>
        /// <para>The parameter that is used to specify the masking rule that you want to modify and the value in the JSON format. All parameter values are of the string type. Example: <c>{&quot;auto&quot;: {&quot;databases&quot;: [&quot;db1&quot;], &quot;tables&quot;: [&quot;tb1&quot;], &quot;columns&quot;: [&quot;c1,c2&quot;] }, &quot;description&quot;: &quot;This rule will be applied to the columns c1 and c2 in table t1&quot;, &quot;enabled&quot;: true, &quot;applies_to&quot;: [&quot;user&quot;]}</c>. Parameters in the function:</para>
        /// <list type="bullet">
        /// <item><description><c>&quot;auto&quot;</c>: specifies that the dynamic masking algorithm is supported. This parameter is required.</description></item>
        /// <item><description><c>&quot;databases&quot;</c>: Optional. The names of databases to which the masking rule is applied. Separate the names with commas (,). If you leave this parameter empty, the masking rule applies to all databases in the cluster.</description></item>
        /// <item><description><c>&quot;tables&quot;</c>: Optional. The names of tables to which the masking rule is applied. Separate the names with commas (,). If you leave this parameter empty, the rule applies to all tables in the cluster.</description></item>
        /// <item><description><c>&quot;columns&quot;</c>: Required. The names of fields to which the masking rule is applied. Separate the names with commas (,).</description></item>
        /// <item><description><c>&quot;description&quot;</c>: Optional. The description of the masking rule. The description can be up to 64 characters in length.</description></item>
        /// <item><description><c>&quot;enabled&quot;</c>: Required. Specifies whether to enable the masking rule. Valid values: <b>true</b> and <b>false</b>.</description></item>
        /// <item><description><c>&quot;applies_to&quot;</c>: The names of database accounts to which the masking rule is applied. Separate the names with commas (,).</description></item>
        /// <item><description><c>&quot;exempted&quot;</c>: The names of database accounts to which the masking rule is not applied. Separate the names with commas (,).</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify <c>RuleName</c>, <c>RuleConfig</c> parameter is required. </description></item>
        /// <item><description>You need to select either <c>&quot;applies_to&quot;</c> or <c>&quot;exempted&quot;</c>.</description></item>
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
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/212573.html">DescribeMaskingRules</a> operation to query the details of all masking rules for a specified cluster, such as the names of the masking rules.</description></item>
        /// <item><description>If the rule name does not exist in the cluster, the system automatically creates a masking rule based on the name and the value of <c>RuleConfig</c>.</description></item>
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
        /// <para>The list of masking rule names. You can specify one or more masking rules at a time. Separate the masking rule names with commas (,).</para>
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
        /// <para>The version of the masking rule. Default value: v1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>v1</description></item>
        /// <item><description>v2</description></item>
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
