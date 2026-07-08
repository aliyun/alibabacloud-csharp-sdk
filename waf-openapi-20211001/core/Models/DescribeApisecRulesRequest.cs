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
        /// <para>Call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
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
        /// <para>For threat detection (risk) and security events (event), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: important</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: medium</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: low</para>
        /// </description></item>
        /// </list>
        /// <para>For sensitive data (sensitive_word), valid values are:</para>
        /// <list type="bullet">
        /// <item><description><para><b>S1</b>: S1</para>
        /// </description></item>
        /// <item><description><para><b>S2</b>: S2</para>
        /// </description></item>
        /// <item><description><para><b>S3</b>: S3</para>
        /// </description></item>
        /// <item><description><para><b>S4</b>: S4</para>
        /// </description></item>
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
        /// <item><description><para><b>custom</b>: custom</para>
        /// </description></item>
        /// <item><description><para><b>default</b>: built-in</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland</para>
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
        /// <para>The ID of the resource group.</para>
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
        /// <item><description><para><b>1</b>: enabled</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: disabled</para>
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
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>risk</b>: threat detection</para>
        /// </description></item>
        /// <item><description><para><b>event</b>: security event</para>
        /// </description></item>
        /// <item><description><para><b>sensitive_word</b>: sensitive data</para>
        /// </description></item>
        /// <item><description><para><b>auth_flag</b>: authentication credential</para>
        /// </description></item>
        /// <item><description><para><b>api_tag</b>: business purpose</para>
        /// </description></item>
        /// <item><description><para><b>desensitization</b>: data masking</para>
        /// </description></item>
        /// <item><description><para><b>whitelist</b>: whitelist</para>
        /// </description></item>
        /// <item><description><para><b>recognition</b>: API</para>
        /// </description></item>
        /// <item><description><para><b>offline_api</b>: lifecycle management</para>
        /// </description></item>
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
