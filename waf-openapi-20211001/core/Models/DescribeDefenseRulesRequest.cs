// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseRulesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the protection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>template</b> (default): template protection rules.</para>
        /// </description></item>
        /// <item><description><para><b>resource</b>: rules for protected objects.</para>
        /// </description></item>
        /// <item><description><para><b>global</b>: global rules.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>template</para>
        /// </summary>
        [NameInMap("DefenseType")]
        [Validation(Required=false)]
        public string DefenseType { get; set; }

        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query conditions. Specify this parameter as a JSON string.</para>
        /// <remarks>
        /// <para>The query results for protection rules vary based on the query conditions. For more information, see <b>Query parameter details</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;name\&quot;:\&quot;IPblock_20220822_10\&quot;,\&quot;scene\&quot;:\&quot;custom_acl\&quot;,\&quot;templateId\&quot;:5327}</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the protection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>whitelist</b>: a whitelist rule</para>
        /// </description></item>
        /// <item><description><para><b>defense</b> (default): a protection rule</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only when <b>DefenseType</b> is set to <b>template</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

    }

}
