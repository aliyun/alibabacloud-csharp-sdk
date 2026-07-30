// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDetectionRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert ATT&amp;CK technique.</para>
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
        /// <para>The alert description. You can use $$ to reference query output fields.</para>
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

        [NameInMap("AlertLevelMapping")]
        [Validation(Required=false)]
        public string AlertLevelMapping { get; set; }

        /// <summary>
        /// <para>The alert name. You can use $$ to reference query output fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Detected high-frequency multi-type network attacks from $src_ip$</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The ID of the detection rule alert template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALERT_ACTIVITY: other alerts.</description></item>
        /// <item><description>EDR_ALERT_ACTIVITY: endpoint detection and response alerts.</description></item>
        /// <item><description>FIREWALL_ALERT_ACTIVITY: firewall alerts.</description></item>
        /// <item><description>WAF_ALERT_ACTIVITY: web application firewall alerts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("AlertSchemaId")]
        [Validation(Required=false)]
        public string AlertSchemaId { get; set; }

        /// <summary>
        /// <para>The alert tactic stage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TA0042</para>
        /// </summary>
        [NameInMap("AlertTacticId")]
        [Validation(Required=false)]
        public string AlertTacticId { get; set; }

        /// <summary>
        /// <para>The alert threshold count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AlertThresholdCount")]
        [Validation(Required=false)]
        public int? AlertThresholdCount { get; set; }

        /// <summary>
        /// <para>The list of alert threshold fields, separated by commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>alert_type,ip</para>
        /// </summary>
        [NameInMap("AlertThresholdGroup")]
        [Validation(Required=false)]
        public string AlertThresholdGroup { get; set; }

        /// <summary>
        /// <para>The length of the alert threshold period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AlertThresholdPeriod")]
        [Validation(Required=false)]
        public string AlertThresholdPeriod { get; set; }

        /// <summary>
        /// <para>The Alarm Metric of the alerting rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebShell</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("AlertTypeMapping")]
        [Validation(Required=false)]
        public string AlertTypeMapping { get; set; }

        /// <summary>
        /// <para>The content of the detection rule expression.</para>
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
        /// <para>The type of the detection rule expression. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>sql: SQL.</description></item>
        /// <item><description>playbook: playbook.</description></item>
        /// </list>
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
        /// <para>dr-123</para>
        /// </summary>
        [NameInMap("DetectionRuleDescription")]
        [Validation(Required=false)]
        public string DetectionRuleDescription { get; set; }

        /// <summary>
        /// <para>The name of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dr-ha1i09ob3zmqrs85****</para>
        /// </summary>
        [NameInMap("DetectionRuleName")]
        [Validation(Required=false)]
        public string DetectionRuleName { get; set; }

        /// <summary>
        /// <para>The status of the detection rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DetectionRuleStatus")]
        [Validation(Required=false)]
        public string DetectionRuleStatus { get; set; }

        /// <summary>
        /// <para>The ID of the detection rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfw-out-ip_aegis-netstat</para>
        /// </summary>
        [NameInMap("DetectionRuleTemplateId")]
        [Validation(Required=false)]
        public string DetectionRuleTemplateId { get; set; }

        /// <summary>
        /// <para>The version of the detection rule template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("DetectionRuleTemplateVersion")]
        [Validation(Required=false)]
        public string DetectionRuleTemplateVersion { get; set; }

        /// <summary>
        /// <para>The type of the detection rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>preset: preset detection rule.</description></item>
        /// <item><description>custom: custom detection rule.</description></item>
        /// <item><description>custom_template: rule template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DetectionRuleType")]
        [Validation(Required=false)]
        public string DetectionRuleType { get; set; }

        [NameInMap("DetectionRules")]
        [Validation(Required=false)]
        public string DetectionRules { get; set; }

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
        /// <para>The event aggregation period configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("IncidentAggregationExpression")]
        [Validation(Required=false)]
        public string IncidentAggregationExpression { get; set; }

        /// <summary>
        /// <para>The event aggregation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: No event is generated.</description></item>
        /// <item><description>graph_compute: Graph computing. This value is supported by predefined rules.</description></item>
        /// <item><description>expert: Expert rule.</description></item>
        /// <item><description>passthrough: Alerting pass-through (one-to-one).</description></item>
        /// <item><description>window: Same-type aggregation (window).</description></item>
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
        /// <para>The custom parameters of the playbook.</para>
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
        /// <para>The UUID of the playbook.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system_aliyun_clb_process_book</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <para>The region in which the data management center of the threat analysis feature resides. Specify this parameter based on the region where your assets reside. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: Your assets reside in the Chinese mainland.</description></item>
        /// <item><description>ap-southeast-1: Your assets reside outside the Chinese mainland.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the member to which the administrator switches the view.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The scheduling start time. The value is a 13-digit UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("ScheduleBeginTime")]
        [Validation(Required=false)]
        public long? ScheduleBeginTime { get; set; }

        /// <summary>
        /// <para>The scheduling cron expression. This parameter is required when ScheduleType is set to cron.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/5 * * * *</para>
        /// </summary>
        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// <para>The maximum number of retries upon timeout. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScheduleMaxRetries")]
        [Validation(Required=false)]
        public int? ScheduleMaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum timeout period, in seconds. Valid values: 60 to 1800.</para>
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
        /// <item><description>fixed_rate: fixed interval.</description></item>
        /// <item><description>cron: cron expression.</description></item>
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
