// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTopNMetricShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The query filter conditions. Multiple filter conditions are evaluated using a logical AND.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The number of data entries to return after the statistics are sorted in descending order. Maximum value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>Specifies the type of data to return. Different Metric values correspond to different data content. The following Metric values are supported by this API operation:</para>
        /// <remarks>
        /// <para>The definition of &quot;attack request&quot; is described in the API operation description. The following descriptions reference this concept.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>real_client_ip: performs aggregation and sorting of the source IP addresses of attack requests in descending order, and returns the top N entries.</description></item>
        /// <item><description>http_user_agent: performs aggregation and sorting of the User-Agent values of attack requests in descending order, and returns the top N entries.</description></item>
        /// <item><description>matched_host: performs aggregation and sorting of the protected objects hit by attack requests in descending order, and returns the top N entries.</description></item>
        /// <item><description>remote_region_id: performs aggregation and sorting of the countries to which the source IP addresses of attack requests belong in descending order, and returns the top N entries.</description></item>
        /// <item><description>request_path: performs aggregation and sorting of the URLs (excluding query strings) of attack requests in descending order, and returns the top N entries.</description></item>
        /// <item><description>block_defense_scene: performs aggregation and sorting of the final action modules of blocked requests (whose action is not &quot;monitor&quot;) in descending order, and returns the top N entries.</description></item>
        /// <item><description>defense_scene: performs aggregation and sorting of all protection modules hit by attack requests in descending order, and returns the top N entries.</description></item>
        /// <item><description>defense_scene_rule_id: queries the top rule IDs of hit non-monitor rules and the protection modules to which the rules belong. This query returns statistics only for non-monitor mode rules. The returned data format is as follows:<br>
        ///  <c>{ &quot;Attribute&quot;: &quot;waf_base&quot;, &quot;Value&quot;: 140, &quot;Name&quot;: &quot;111034&quot; }</c></description></item>
        /// <item><description>defense_scene_with_rule_id: returns the top N rule IDs ranked by the number of hit requests and the protection modules to which the rules belong, connected by &quot;-&quot;. This query does not distinguish between rule actions and includes both monitor rules and block rules. The returned format is as follows:<br>
        ///  <c>{ &quot;Attribute&quot;: &quot;&quot;,  &quot;Value&quot;: 1,  &quot;Name&quot;: &quot;120075-waf_base&quot; }</c></description></item>
        /// <item><description>defense_scene_top_rule_id: queries the top rule hits of a specific protection module. Specify filter conditions in the Conditions field of Filter. For example, to query the top rule hits of the &quot;custom ACL&quot; module, set the Conditions field as follows:<br>
        ///  <c>{ &quot;Key&quot;: &quot;defense_scene_map&quot;, &quot;OpValue&quot;: &quot;contain&quot;, &quot;Values&quot;: &quot;custom_acl&quot; }</c></description></item>
        /// <item><description>defense_scene_rule_type: queries the top hit rule types of the web core protection module. Only the web core protection module supports this query because only web core protection has rule child classes. Specify filter conditions in the Conditions field of Filter. The format is as follows:<br>
        /// <c>    { &quot;Key&quot;: &quot;defense_scene&quot;, &quot;OpValue&quot;: &quot;eq&quot;, &quot;Values&quot;: &quot;waf_base&quot; }</c></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>real_client_ip</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
