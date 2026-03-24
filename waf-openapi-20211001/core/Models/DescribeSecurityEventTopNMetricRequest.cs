// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeSecurityEventTopNMetricRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for the query. A logical AND operator is used between multiple filter conditions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public DescribeSecurityEventTopNMetricRequestFilter Filter { get; set; }
        public class DescribeSecurityEventTopNMetricRequestFilter : TeaModel {
            /// <summary>
            /// <para>A list of filter conditions. Each object in the array represents a filter condition.</para>
            /// </summary>
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<DescribeSecurityEventTopNMetricRequestFilterConditions> Conditions { get; set; }
            public class DescribeSecurityEventTopNMetricRequestFilterConditions : TeaModel {
                /// <summary>
                /// <para>The field to filter by. This operation supports all fields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>matched_host</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("OpValue")]
                [Validation(Required=false)]
                public string OpValue { get; set; }

                /// <summary>
                /// <para>The filter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.waf-top</para>
                /// </summary>
                [NameInMap("Values")]
                [Validation(Required=false)]
                public object Values { get; set; }

            }

            /// <summary>
            /// <para>The time range to query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("DateRange")]
            [Validation(Required=false)]
            public DescribeSecurityEventTopNMetricRequestFilterDateRange DateRange { get; set; }
            public class DescribeSecurityEventTopNMetricRequestFilterDateRange : TeaModel {
                /// <summary>
                /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: seconds.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888600</para>
                /// </summary>
                [NameInMap("EndDate")]
                [Validation(Required=false)]
                public long? EndDate { get; set; }

                /// <summary>
                /// <para>The start of the time range to query. The value is a UNIX timestamp. Unit: seconds. You can query data within the last 30 days.</para>
                /// <remarks>
                /// <h2>The start time must be within the last 30 days.</h2>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713888000</para>
                /// </summary>
                [NameInMap("StartDate")]
                [Validation(Required=false)]
                public long? StartDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
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
        /// <para>The maximum number of entries to return. The entries are sorted in descending order. Maximum value: 10.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public long? Limit { get; set; }

        /// <summary>
        /// <para>Specifies the content of the returned data. Different metrics correspond to different data content. This operation supports the following metrics:</para>
        /// <remarks>
        /// <para>For the definition of an attack request, see the Description section of this topic. The following descriptions use this definition.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>real_client_ip: Aggregates the source IP addresses of attack requests, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>http_user_agent: Aggregates the User-Agent headers of attack requests, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>matched_host: Aggregates the protected objects that are hit by attack requests, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>remote_region_id: Aggregates the countries of origin for the source IP addresses of attack requests, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>request_path: Aggregates the URLs of attack requests, excluding query strings, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>block_defense_scene: Aggregates the final protection modules that handled blocked requests, sorts them in descending order, and returns the top N results. Blocked requests are requests whose action is not Monitor.</para>
        /// </description></item>
        /// <item><description><para>defense_scene: Aggregates all protection modules that are hit by attack requests, sorts them in descending order, and returns the top N results.</para>
        /// </description></item>
        /// <item><description><para>defense_scene_rule_id: Queries the top rule IDs of hit rules that are not in Monitor mode and their corresponding protection modules. This query returns statistics only for rules that are not in Monitor mode. The data is returned in the following format:<br>
        /// <c>{ &quot;Attribute&quot;: &quot;waf_base&quot;, &quot;Value&quot;: 140, &quot;Name&quot;: &quot;111034&quot; }</c><br></para>
        /// </description></item>
        /// <item><description><para>defense_scene_with_rule_id: Returns the top N rule IDs based on the number of hits and their corresponding protection modules. The rule ID and module are connected by a hyphen (-). This query includes rules in both Monitor and Block modes. The data is returned in the following format:<br>
        /// <c>{ &quot;Attribute&quot;: &quot;&quot;, &quot;Value&quot;: 1, &quot;Name&quot;: &quot;120075-waf_base&quot; }</c><br></para>
        /// </description></item>
        /// <item><description><para>defense_scene_top_rule_id: Queries the top rules that are hit in a specific protection module. Specify a filter condition in the Conditions field of the Filter parameter. For example, to query the top rules that are hit in the custom access control list (ACL) module, set the Conditions field as follows:<br>
        /// <c>{ &quot;Key&quot;: &quot;defense_scene_map&quot;, &quot;OpValue&quot;: &quot;contain&quot;, &quot;Values&quot;: &quot;custom_acl&quot; }</c><br></para>
        /// </description></item>
        /// <item><description><para>defense_scene_rule_type: Queries the top rule types that are hit in the core web protection module. Only the core web protection module supports this query because it is the only module that has rule subtypes. Specify a filter condition in the Conditions field of the Filter parameter as follows:<br>
        /// <c>{ &quot;Key&quot;: &quot;defense_scene&quot;, &quot;OpValue&quot;: &quot;eq&quot;, &quot;Values&quot;: &quot;waf_base&quot; }</c><br></para>
        /// </description></item>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

    }

}
