// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemCustomizeRulesRequest : TeaModel {
        /// <summary>
        /// <para>The alert type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scan</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the custom rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10223</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the custom rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc: descending order</para>
        /// </description></item>
        /// <item><description><para>asc: ascending order</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the custom rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: sorts the rules by modification time.</para>
        /// </description></item>
        /// <item><description><para>Id: sorts the rules by rule ID. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Id</para>
        /// </summary>
        [NameInMap("OrderField")]
        [Validation(Required=false)]
        public string OrderField { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is deployed. You must select the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: your assets are outside China.</para>
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
        /// <para>The user ID that is used to switch the administrator\&quot;s view to the view of a member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all members in the enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The name of the rule. The name can contain letters, digits, underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_scan</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The type of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>predefine</b>: predefined</para>
        /// </description></item>
        /// <item><description><para><b>customize</b>: custom</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>customize</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: initial</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: testing with simulated data</para>
        /// </description></item>
        /// <item><description><para><b>15</b>: testing with business data</para>
        /// </description></item>
        /// <item><description><para><b>20</b>: testing with business data is complete</para>
        /// </description></item>
        /// <item><description><para><b>100</b>: published</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The threat level. The value is a JSON array. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>serious</b>: high</para>
        /// </description></item>
        /// <item><description><para><b>suspicious</b>: medium</para>
        /// </description></item>
        /// <item><description><para><b>remind</b>: low</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;serious&quot;,&quot;suspicious&quot;,&quot;remind&quot;]</para>
        /// </summary>
        [NameInMap("ThreatLevel")]
        [Validation(Required=false)]
        public List<string> ThreatLevel { get; set; }

    }

}
