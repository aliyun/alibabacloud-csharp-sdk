// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ListDetectionRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of detection rules.</para>
        /// </summary>
        [NameInMap("DetectionRules")]
        [Validation(Required=false)]
        public List<ListDetectionRulesResponseBodyDetectionRules> DetectionRules { get; set; }
        public class ListDetectionRulesResponseBodyDetectionRules : TeaModel {
            /// <summary>
            /// <para>The ATT\&amp;CK technique of the alert.</para>
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
            /// <para>The alert description. You can use $$ to reference the output fields of the query.</para>
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
            /// <item><description><para>5: critical.</para>
            /// </description></item>
            /// <item><description><para>4: important.</para>
            /// </description></item>
            /// <item><description><para>3: medium.</para>
            /// </description></item>
            /// <item><description><para>2: low.</para>
            /// </description></item>
            /// <item><description><para>1: informational.</para>
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
            /// <para>The alert name. You can use $$ to reference the output fields of the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Detected high-frequency multi-type network attacks from $src_ip$</para>
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// <para>The ID of the alert template for the detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ALERT_ACTIVITY: other alerts.</para>
            /// </description></item>
            /// <item><description><para>EDR_ALERT_ACTIVITY: Endpoint Detection and Response (EDR) alerts.</para>
            /// </description></item>
            /// <item><description><para>FIREWALL_ALERT_ACTIVITY: firewall alerts.</para>
            /// </description></item>
            /// <item><description><para>WAF_ALERT_ACTIVITY: Web Application Firewall (WAF) alerts.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ALERT_ACTIVITY</para>
            /// </summary>
            [NameInMap("AlertSchemaId")]
            [Validation(Required=false)]
            public string AlertSchemaId { get; set; }

            /// <summary>
            /// <para>The alert tactic phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TA0042</para>
            /// </summary>
            [NameInMap("AlertTacticId")]
            [Validation(Required=false)]
            public string AlertTacticId { get; set; }

            /// <summary>
            /// <para>The number of alert thresholds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AlertThresholdCount")]
            [Validation(Required=false)]
            public int? AlertThresholdCount { get; set; }

            /// <summary>
            /// <para>The list of alert threshold fields, separated by commas.</para>
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
            /// <para>The alert type.</para>
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-21 13:47:01</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            /// <para>The type of the detection rule expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>playbook</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>jndi-attack-success_http_netstat</para>
            /// </summary>
            [NameInMap("DetectionRuleId")]
            [Validation(Required=false)]
            public string DetectionRuleId { get; set; }

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
            /// <para>The status of the detection rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: The rule is enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: The rule is disabled.</para>
            /// </description></item>
            /// <item><description><para>testing: The rule is being tested.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para>preset: a built-in detection rule.</para>
            /// </description></item>
            /// <item><description><para>custom: a custom detection rule.</para>
            /// </description></item>
            /// <item><description><para>custom_template: a rule template.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>custom</para>
            /// </summary>
            [NameInMap("DetectionRuleType")]
            [Validation(Required=false)]
            public string DetectionRuleType { get; set; }

            /// <summary>
            /// <para>The entity mapping configuration.</para>
            /// </summary>
            [NameInMap("EntityMappings")]
            [Validation(Required=false)]
            public List<ListDetectionRulesResponseBodyDetectionRulesEntityMappings> EntityMappings { get; set; }
            public class ListDetectionRulesResponseBodyDetectionRulesEntityMappings : TeaModel {
                /// <summary>
                /// <para>The entity mapping configuration.</para>
                /// </summary>
                [NameInMap("NormalizationFieldMappings")]
                [Validation(Required=false)]
                public List<ListDetectionRulesResponseBodyDetectionRulesEntityMappingsNormalizationFieldMappings> NormalizationFieldMappings { get; set; }
                public class ListDetectionRulesResponseBodyDetectionRulesEntityMappingsNormalizationFieldMappings : TeaModel {
                    /// <summary>
                    /// <para>The mapped field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ip</para>
                    /// </summary>
                    [NameInMap("MappingFieldName")]
                    [Validation(Required=false)]
                    public string MappingFieldName { get; set; }

                    /// <summary>
                    /// <para>The standard entity field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>src_ip</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldName")]
                    [Validation(Required=false)]
                    public string NormalizationFieldName { get; set; }

                    /// <summary>
                    /// <para>The data type of the standard entity field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vachar</para>
                    /// </summary>
                    [NameInMap("NormalizationFieldType")]
                    [Validation(Required=false)]
                    public string NormalizationFieldType { get; set; }

                }

                /// <summary>
                /// <para>The entity type ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip</para>
                /// </summary>
                [NameInMap("NormalizationSchemaId")]
                [Validation(Required=false)]
                public string NormalizationSchemaId { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the event aggregation period.</para>
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
            /// <item><description><para>none: No events are generated.</para>
            /// </description></item>
            /// <item><description><para>graph_compute: graph computing (supported by predefined rules).</para>
            /// </description></item>
            /// <item><description><para>expert: expert rule.</para>
            /// </description></item>
            /// <item><description><para>passthrough: alert passthrough (one-to-one).</para>
            /// </description></item>
            /// <item><description><para>window: aggregation of similar alerts (by window).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>passthrough</para>
            /// </summary>
            [NameInMap("IncidentAggregationType")]
            [Validation(Required=false)]
            public string IncidentAggregationType { get; set; }

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
            /// <para>The configuration of the playbook.</para>
            /// </summary>
            [NameInMap("Playbook")]
            [Validation(Required=false)]
            public ListDetectionRulesResponseBodyDetectionRulesPlaybook Playbook { get; set; }
            public class ListDetectionRulesResponseBodyDetectionRulesPlaybook : TeaModel {
                /// <summary>
                /// <para>The configuration of the input parameters for invoking the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;name&quot;: &quot;expireDay&quot;,
                ///         &quot;dataType&quot;: &quot;Integer&quot;,
                ///         &quot;required&quot;: true,
                ///         &quot;isArray&quot;: false,
                ///         &quot;example&quot;: &quot;7&quot;,
                ///         &quot;description&quot;: &quot;desc&quot;,
                ///         &quot;typeName&quot;: &quot;Integer&quot;,
                ///         &quot;dataClass&quot;: &quot;normal&quot;,
                ///         &quot;stanchDefaultValue&quot;: &quot;7&quot;
                ///     }
                /// ]</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The flow configuration of the playbook.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     {
                ///         &quot;id&quot;: &quot;EndEvent_1fqpq4h&quot;,
                ///         &quot;zIndex&quot;: 1,
                ///         &quot;data&quot;: {
                ///             &quot;nodeType&quot;: &quot;endEvent&quot;,
                ///             &quot;appType&quot;: &quot;basic&quot;,
                ///             &quot;valueData&quot;: {</para>
                /// <pre><c>        },
                ///         &quot;icon&quot;: &quot;icon-radio-off-full&quot;
                ///     },
                ///     &quot;position&quot;: {
                ///         &quot;x&quot;: 1369,
                ///         &quot;y&quot;: 174
                ///     }
                /// }
                /// </c></pre>
                /// <para>]</para>
                /// </summary>
                [NameInMap("Flow")]
                [Validation(Required=false)]
                public string Flow { get; set; }

            }

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
            /// <para>dde983ed-eb56-45ea-ac2e-3b12b2a9****</para>
            /// </summary>
            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            /// <summary>
            /// <para>The start time of the scheduling. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1733269771123</para>
            /// </summary>
            [NameInMap("ScheduleBeginTime")]
            [Validation(Required=false)]
            public long? ScheduleBeginTime { get; set; }

            /// <summary>
            /// <para>The cron expression for scheduling. This parameter is required when ScheduleType is set to cron.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5m</para>
            /// </summary>
            [NameInMap("ScheduleExpression")]
            [Validation(Required=false)]
            public string ScheduleExpression { get; set; }

            /// <summary>
            /// <para>The maximum number of retries after a timeout. The value can be from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScheduleMaxRetries")]
            [Validation(Required=false)]
            public int? ScheduleMaxRetries { get; set; }

            /// <summary>
            /// <para>The maximum timeout period, in seconds. The value can be from 60 to 1800.</para>
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
            /// <item><description><para>fixed_rate: fixed interval</para>
            /// </description></item>
            /// <item><description><para>cron: cron expression</para>
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

            /// <summary>
            /// <para>The update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-16 10:51:00</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of data entries to read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to start the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAUqcj6VO4E3ECWIrFczs****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The pagination parameter. This specifies the current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The pagination parameter. This specifies the number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>508DCFFD-4508-54BF-A8A0-E97A0FA6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
