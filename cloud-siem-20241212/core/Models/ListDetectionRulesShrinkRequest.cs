// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDetectionRulesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ATT&amp;CK technique of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Discovery</para>
        /// </summary>
        [NameInMap("AlertAttCk")]
        [Validation(Required=false)]
        public string AlertAttCk { get; set; }

        /// <summary>
        /// <para>The threat level of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>5: Critical.</description></item>
        /// <item><description>4: High.</description></item>
        /// <item><description>3: Medium.</description></item>
        /// <item><description>2: Low.</description></item>
        /// <item><description>1: Informational.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public string AlertLevel { get; set; }

        /// <summary>
        /// <para>The tactic phase of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0042</para>
        /// </summary>
        [NameInMap("AlertTacticId")]
        [Validation(Required=false)]
        public string AlertTacticId { get; set; }

        /// <summary>
        /// <para>The alerting type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>siem_rule_type_alert_storm</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// <para>The expression content of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>playbook</para>
        /// </summary>
        [NameInMap("DetectionExpressionType")]
        [Validation(Required=false)]
        public string DetectionExpressionType { get; set; }

        /// <summary>
        /// <para>The ID of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-ppa85gfw69tgwkys****</para>
        /// </summary>
        [NameInMap("DetectionRuleId")]
        [Validation(Required=false)]
        public string DetectionRuleId { get; set; }

        /// <summary>
        /// <para>The list of detection rule IDs.</para>
        /// </summary>
        [NameInMap("DetectionRuleIds")]
        [Validation(Required=false)]
        public string DetectionRuleIdsShrink { get; set; }

        /// <summary>
        /// <para>The name of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detect Discovery Behavior for Local Systems Groups</para>
        /// </summary>
        [NameInMap("DetectionRuleName")]
        [Validation(Required=false)]
        public string DetectionRuleName { get; set; }

        /// <summary>
        /// <para>The status of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DetectionRuleStatus")]
        [Validation(Required=false)]
        public string DetectionRuleStatus { get; set; }

        /// <summary>
        /// <para>The type of the detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preset: Preset detection rule.</description></item>
        /// <item><description>custom: Custom detection rule.</description></item>
        /// <item><description>custom_template: Rule template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>preset</para>
        /// </summary>
        [NameInMap("DetectionRuleType")]
        [Validation(Required=false)]
        public string DetectionRuleType { get; set; }

        /// <summary>
        /// <para>The event summaries type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: No event is generated.</description></item>
        /// <item><description>graph_compute: Graph computing (supported by preset rules).</description></item>
        /// <item><description>expert: Expert rules.</description></item>
        /// <item><description>passthrough: Alerting pass-through (one-to-one).</description></item>
        /// <item><description>window: Similar aggregation (window).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>graph_compute</para>
        /// </summary>
        [NameInMap("IncidentAggregationType")]
        [Validation(Required=false)]
        public string IncidentAggregationType { get; set; }

        /// <summary>
        /// <para>The language of the response message. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// <para>Note: This parameter is required in actual calls. If it is not provided, the service returns a 400 error &quot;The specified Lang can not be empty.&quot;. Explicitly specify the language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the log normalization category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY</para>
        /// </summary>
        [NameInMap("LogCategoryId")]
        [Validation(Required=false)]
        public string LogCategoryId { get; set; }

        /// <summary>
        /// <para>The ID of the log normalization schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API_RISK_ACTIVITY</para>
        /// </summary>
        [NameInMap("LogSchemaId")]
        [Validation(Required=false)]
        public string LogSchemaId { get; set; }

        /// <summary>
        /// <para>The collection of log schema IDs, which matches any schema by its full ID. If this parameter is not provided, this condition is not applied. If an empty array is explicitly provided, zero records are returned. If both this parameter and LogSchemaId are provided, the intersection is used.</para>
        /// </summary>
        [NameInMap("LogSchemaIds")]
        [Validation(Required=false)]
        public string LogSchemaIdsShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>asc</b>: Ascending order. This is the default value.</description></item>
        /// <item><description><b>desc</b>: Descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("OrderDirection")]
        [Validation(Required=false)]
        public string OrderDirection { get; set; }

        /// <summary>
        /// <para>The field used for sorting. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GmtCreate: Creation time.</description></item>
        /// <item><description>GmtModified: Update time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GmtModified</para>
        /// </summary>
        [NameInMap("OrderFieldName")]
        [Validation(Required=false)]
        public string OrderFieldName { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region where the data management center of Threat Analysis is located. Select the region of the management center based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: The assets are located in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: The assets are located outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the user whose perspective the administrator switches to.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

    }

}
