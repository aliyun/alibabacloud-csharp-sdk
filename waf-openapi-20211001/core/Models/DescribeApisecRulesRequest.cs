// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecRulesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Web Application Firewall (WAF) instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The level of the policy.</para>
        /// <para>If Type is set to risk or event, you can set this parameter to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// <para>If Type is set to sensitive_word, you can set this parameter to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>S1</b></description></item>
        /// <item><description><b>S2</b></description></item>
        /// <item><description><b>S3</b></description></item>
        /// <item><description><b>S4</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>high</para>
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Information Leak</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The source of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>custom</b></description></item>
        /// <item><description><b>default</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: Chinese mainland</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland</description></item>
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
        /// <para>The status of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// <para>The type of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>risk</b>: risk detection</description></item>
        /// <item><description><b>event</b>: security event</description></item>
        /// <item><description><b>sensitive_word</b>: sensitive data</description></item>
        /// <item><description><b>auth_flag</b>: authentication credential</description></item>
        /// <item><description><b>api_tag</b>: business purpose</description></item>
        /// <item><description><b>desensitization</b>: masking</description></item>
        /// <item><description><b>whitelist</b>: whitelist</description></item>
        /// <item><description><b>recognition</b>: API recognition</description></item>
        /// <item><description><b>offline_api</b>: lifecycle management</description></item>
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
