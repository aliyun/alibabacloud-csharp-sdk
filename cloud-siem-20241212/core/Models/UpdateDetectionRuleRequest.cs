// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class UpdateDetectionRuleRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Discovery</para>
        /// </summary>
        [NameInMap("AlertAttCk")]
        [Validation(Required=false)]
        public string AlertAttCk { get; set; }

        [NameInMap("AlertDescription")]
        [Validation(Required=false)]
        public string AlertDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public string AlertLevel { get; set; }

        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALERT_ACTIVITY</para>
        /// </summary>
        [NameInMap("AlertSchemaId")]
        [Validation(Required=false)]
        public string AlertSchemaId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TA0042</para>
        /// </summary>
        [NameInMap("AlertTacticId")]
        [Validation(Required=false)]
        public string AlertTacticId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AlertThresholdCount")]
        [Validation(Required=false)]
        public int? AlertThresholdCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>alert_type,ip</para>
        /// </summary>
        [NameInMap("AlertThresholdGroup")]
        [Validation(Required=false)]
        public string AlertThresholdGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("AlertThresholdPeriod")]
        [Validation(Required=false)]
        public string AlertThresholdPeriod { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>siem_rule_type_alert_storm</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>sql</para>
        /// </summary>
        [NameInMap("DetectionExpressionType")]
        [Validation(Required=false)]
        public string DetectionExpressionType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Check the enumeration behavior of local system groups. An attacker may attempt to find the Local Systems group and its permission settings.</para>
        /// </summary>
        [NameInMap("DetectionRuleDescription")]
        [Validation(Required=false)]
        public string DetectionRuleDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jndi-attack-success_http_dns</para>
        /// </summary>
        [NameInMap("DetectionRuleId")]
        [Validation(Required=false)]
        public string DetectionRuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CTDR Port Scan Behavior</para>
        /// </summary>
        [NameInMap("DetectionRuleName")]
        [Validation(Required=false)]
        public string DetectionRuleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("DetectionRuleStatus")]
        [Validation(Required=false)]
        public string DetectionRuleStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("DetectionRuleType")]
        [Validation(Required=false)]
        public string DetectionRuleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;NormalizationSchemaId\&quot;:\&quot;host\&quot;,\&quot;NormalizationFieldMappings\&quot;:[{\&quot;NormalizationFieldName\&quot;:\&quot;uuid\&quot;,\&quot;MappingFieldName\&quot;:\&quot;host\&quot;,\&quot;NormalizationFieldType\&quot;:\&quot;varchar\&quot;}]}]</para>
        /// </summary>
        [NameInMap("EntityMappings")]
        [Validation(Required=false)]
        public string EntityMappings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60m</para>
        /// </summary>
        [NameInMap("IncidentAggregationExpression")]
        [Validation(Required=false)]
        public string IncidentAggregationExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>window</para>
        /// </summary>
        [NameInMap("IncidentAggregationType")]
        [Validation(Required=false)]
        public string IncidentAggregationType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>NETWORK_CATEGORY</para>
        /// </summary>
        [NameInMap("LogCategoryId")]
        [Validation(Required=false)]
        public string LogCategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>API_RISK_ACTIVITY</para>
        /// </summary>
        [NameInMap("LogSchemaId")]
        [Validation(Required=false)]
        public string LogSchemaId { get; set; }

        /// <summary>
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
        /// <b>Example:</b>
        /// <para>31568394-7a86-487c-b8ec-b3f42b59****</para>
        /// </summary>
        [NameInMap("PlaybookUuid")]
        [Validation(Required=false)]
        public string PlaybookUuid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1733269771123</para>
        /// </summary>
        [NameInMap("ScheduleBeginTime")]
        [Validation(Required=false)]
        public long? ScheduleBeginTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1h</para>
        /// </summary>
        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ScheduleMaxRetries")]
        [Validation(Required=false)]
        public int? ScheduleMaxRetries { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ScheduleMaxTimeout")]
        [Validation(Required=false)]
        public int? ScheduleMaxTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fixed_rate</para>
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5m</para>
        /// </summary>
        [NameInMap("ScheduleWindow")]
        [Validation(Required=false)]
        public string ScheduleWindow { get; set; }

    }

}
