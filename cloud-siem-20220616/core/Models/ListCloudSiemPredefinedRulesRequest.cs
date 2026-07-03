// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListCloudSiemPredefinedRulesRequest : TeaModel {
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
        /// <para>The ATT\&amp;CK technique.</para>
        /// 
        /// <b>Example:</b>
        /// <para>T1595.002 Vulnerability Scanning</para>
        /// </summary>
        [NameInMap("AttCk")]
        [Validation(Required=false)]
        public string AttCk { get; set; }

        /// <summary>
        /// <para>The page number. The value must be greater than or equal to 1.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The event generation method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>default: the default built-in method</para>
        /// </description></item>
        /// <item><description><para>singleToSingle: An event is generated for each alert.</para>
        /// </description></item>
        /// <item><description><para>allToSingle: An event is generated for all alerts in an epoch.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>allToSingle</para>
        /// </summary>
        [NameInMap("EventTransferType")]
        [Validation(Required=false)]
        public string EventTransferType { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10223</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The log source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_siem_alb_flow_log</para>
        /// </summary>
        [NameInMap("LogSource")]
        [Validation(Required=false)]
        public string LogSource { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>desc: descending</para>
        /// </description></item>
        /// <item><description><para>asc: ascending</para>
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
        /// <para>The field to sort the rules by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>GmtModified: Sorts by modification time.</para>
        /// </description></item>
        /// <item><description><para>Id: Sorts by rule ID. This is the default value.</para>
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
        /// <para>The number of entries per page. The maximum value is 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of the threat analysis feature is located. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: assets in the Chinese mainland or China (Hong Kong)</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: assets outside China</para>
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
        /// <para>The user ID that the administrator uses to switch to the perspective of a member.</para>
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
        /// <item><description><para>1: the view of all accounts in the enterprise.</para>
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
        /// <para>The rule name. The name can contain only letters, digits, underscores (_), and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_scan</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>predefine: predefined</para>
        /// </description></item>
        /// <item><description><para>customize: custom</para>
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
        /// <para>The start of the time range to query. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1577808000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The rule status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: initial</para>
        /// </description></item>
        /// <item><description><para>10: testing with simulated data</para>
        /// </description></item>
        /// <item><description><para>15: testing with production data</para>
        /// </description></item>
        /// <item><description><para>20: testing with production data is complete</para>
        /// </description></item>
        /// <item><description><para>100: published</para>
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
        /// <item><description><para>serious: high</para>
        /// </description></item>
        /// <item><description><para>suspicious: medium</para>
        /// </description></item>
        /// <item><description><para>remind: low</para>
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
