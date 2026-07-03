// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDetectionRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ATT\&amp;CK tactic of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Discovery</para>
        /// </summary>
        [NameInMap("AlertAttCk")]
        [Validation(Required=false)]
        public string AlertAttCk { get; set; }

        [NameInMap("AlertAttCkMapping")]
        [Validation(Required=false)]
        public string AlertAttCkMapping { get; set; }

        /// <summary>
        /// <para>The description of the alert. You can use $$ to reference fields from the query output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alert from: $product_code$, detected network attack from $src_ip$, affected assets include: $dst_ip$</para>
        /// </summary>
        [NameInMap("AlertDescription")]
        [Validation(Required=false)]
        public string AlertDescription { get; set; }

        /// <summary>
        /// <para>The threat level of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>5: Critical.</para>
        /// </description></item>
        /// <item><description><para>4: Important.</para>
        /// </description></item>
        /// <item><description><para>3: Medium.</para>
        /// </description></item>
        /// <item><description><para>2: Low.</para>
        /// </description></item>
        /// <item><description><para>1: Informational.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public string AlertLevel { get; set; }

        [NameInMap("AlertLevelMapping")]
        [Validation(Required=false)]
        public string AlertLevelMapping { get; set; }

        /// <summary>
        /// <para>The name of the alert. You can use $$ to reference fields from the query output.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detected high-frequency multi-type network attacks from $src_ip$</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The ID of the alert template for the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("AlertSchemaId")]
        [Validation(Required=false)]
        public string AlertSchemaId { get; set; }

        /// <summary>
        /// <para>The ATT\&amp;CK tactic ID of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0042</para>
        /// </summary>
        [NameInMap("AlertTacticId")]
        [Validation(Required=false)]
        public string AlertTacticId { get; set; }

        /// <summary>
        /// <para>The number of alerts for the alert threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AlertThresholdCount")]
        [Validation(Required=false)]
        public int? AlertThresholdCount { get; set; }

        /// <summary>
        /// <para>The fields for the alert threshold. Separate multiple fields with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert_type,ip</para>
        /// </summary>
        [NameInMap("AlertThresholdGroup")]
        [Validation(Required=false)]
        public string AlertThresholdGroup { get; set; }

        /// <summary>
        /// <para>The period for the alert threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AlertThresholdPeriod")]
        [Validation(Required=false)]
        public string AlertThresholdPeriod { get; set; }

        /// <summary>
        /// <para>The type of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>siem_rule_type_alert_storm</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("AlertTypeMapping")]
        [Validation(Required=false)]
        public string AlertTypeMapping { get; set; }

        /// <summary>
        /// <para>The content of the detection expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>*|set session mode=scan;SELECT * FROM log
        /// WHERE schema = \&quot;PROCESS_START_ACTIVITY\&quot;
        /// AND (
        ///     proc_path LIKE \&quot;%/groups\&quot;
        ///     OR (
        ///         (
        ///             proc_path LIKE \&quot;%/cat\&quot;
        ///             OR proc_path LIKE \&quot;%/head\&quot;
        ///             OR proc_path LIKE \&quot;%/tail\&quot;
        ///             OR proc_path LIKE \&quot;%/more\&quot;
        ///         )
        ///         AND cmdline LIKE \&quot;%/etc/group%\&quot;
        ///     )
        /// )</para>
        /// </summary>
        [NameInMap("DetectionExpressionContent")]
        [Validation(Required=false)]
        public string DetectionExpressionContent { get; set; }

        /// <summary>
        /// <para>The type of the detection expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sql</para>
        /// </summary>
        [NameInMap("DetectionExpressionType")]
        [Validation(Required=false)]
        public string DetectionExpressionType { get; set; }

        /// <summary>
        /// <para>The description of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Check the enumeration behavior of local system groups. An attacker may attempt to find the Local Systems group and its permission settings.</para>
        /// </summary>
        [NameInMap("DetectionRuleDescription")]
        [Validation(Required=false)]
        public string DetectionRuleDescription { get; set; }

        /// <summary>
        /// <para>The ID of the detection rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jndi-attack-success_http_dns</para>
        /// </summary>
        [NameInMap("DetectionRuleId")]
        [Validation(Required=false)]
        public string DetectionRuleId { get; set; }

        /// <summary>
        /// <para>The name of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CTDR Port Scan Behavior</para>
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
        /// <item><description><para>preset: a preset detection rule.</para>
        /// </description></item>
        /// <item><description><para>custom: a custom detection rule.</para>
        /// </description></item>
        /// <item><description><para>custom_template: a rule template.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DetectionRuleType")]
        [Validation(Required=false)]
        public string DetectionRuleType { get; set; }

        /// <summary>
        /// <para>The entity mapping configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;NormalizationSchemaId\&quot;:\&quot;host\&quot;,\&quot;NormalizationFieldMappings\&quot;:[{\&quot;NormalizationFieldName\&quot;:\&quot;uuid\&quot;,\&quot;MappingFieldName\&quot;:\&quot;host\&quot;,\&quot;NormalizationFieldType\&quot;:\&quot;varchar\&quot;}]}]</para>
        /// </summary>
        [NameInMap("EntityMappings")]
        [Validation(Required=false)]
        public string EntityMappings { get; set; }

        /// <summary>
        /// <para>The configuration of the event aggregation period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60m</para>
        /// </summary>
        [NameInMap("IncidentAggregationExpression")]
        [Validation(Required=false)]
        public string IncidentAggregationExpression { get; set; }

        /// <summary>
        /// <para>The type of event aggregation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none: Events are not generated.</para>
        /// </description></item>
        /// <item><description><para>graph_compute: graph computing (supported by predefined rules).</para>
        /// </description></item>
        /// <item><description><para>expert: expert rule.</para>
        /// </description></item>
        /// <item><description><para>passthrough: pass-through (one-to-one mapping with alerts).</para>
        /// </description></item>
        /// <item><description><para>window: window-based aggregation of similar events.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>window</para>
        /// </summary>
        [NameInMap("IncidentAggregationType")]
        [Validation(Required=false)]
        public string IncidentAggregationType { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English.</para>
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
        /// <para>The custom parameters for the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;ip&quot;: {
        ///         &quot;ip&quot;: &quot;124.23.<em>.</em>&quot;
        ///     }
        /// }</para>
        /// </summary>
        [NameInMap("PlaybookParameters")]
        [Validation(Required=false)]
        public string PlaybookParameters { get; set; }

        /// <summary>
        /// <para>The unique ID of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31568394-7a86-487c-b8ec-b3f42b59****</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for Threat Analysis. Select the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: The Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Regions outside the Chinese mainland.</para>
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
        /// <para>The start time for scheduling. This is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("ScheduleBeginTime")]
        [Validation(Required=false)]
        public long? ScheduleBeginTime { get; set; }

        /// <summary>
        /// <para>The cron expression for scheduling. This parameter is required when you set ScheduleType to cron.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1h</para>
        /// </summary>
        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// <para>The maximum number of retries after a timeout. The value must be between 1 and 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScheduleMaxRetries")]
        [Validation(Required=false)]
        public int? ScheduleMaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum timeout period. Unit: seconds. The value must be between 60 and 1800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ScheduleMaxTimeout")]
        [Validation(Required=false)]
        public int? ScheduleMaxTimeout { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>fixed_rate: fixed interval.</para>
        /// </description></item>
        /// <item><description><para>cron: cron expression.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fixed_rate</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The length of the scheduling window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("ScheduleWindow")]
        [Validation(Required=false)]
        public string ScheduleWindow { get; set; }

    }

}
