// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_elasticity-cn-0x***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the returned rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The level of the rule.</para>
        /// <para>For risk detection (risk) and security events (event), valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High risk.</description></item>
        /// <item><description><b>medium</b>: Medium risk.</description></item>
        /// <item><description><b>low</b>: Low risk.</description></item>
        /// </list>
        /// <para>For sensitive data (sensitive_word), valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>S1</b>: S1 level.</description></item>
        /// <item><description><b>S2</b>: S2 level.</description></item>
        /// <item><description><b>S3</b>: S3 level.</description></item>
        /// <item><description><b>S4</b>: S4 level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>information leakage</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b>: Custom.</description></item>
        /// <item><description><b>default</b>: Built-in.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number to return in a paged query. Default value: <b>1</b>, which indicates the first page of paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page in a paged query. Default value: <b>10</b>, which indicates 10 entries per paging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

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
        /// <para>The enabling status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: shutdown.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>risk</b>: Risk detection.</description></item>
        /// <item><description><b>event</b>: Security events.</description></item>
        /// <item><description><b>sensitive_word</b>: Sensitive data.</description></item>
        /// <item><description><b>auth_flag</b>: Authentication credentials.</description></item>
        /// <item><description><b>api_tag</b>: Business purpose.</description></item>
        /// <item><description><b>desensitization</b>: Data masking.</description></item>
        /// <item><description><b>whitelist</b>: Whitelist.</description></item>
        /// <item><description><b>recognition</b>: API identification.</description></item>
        /// <item><description><b>offline_api</b>: Lifecycle management.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>risk</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
