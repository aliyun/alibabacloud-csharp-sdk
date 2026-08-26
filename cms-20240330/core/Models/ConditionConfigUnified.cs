// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        /// <summary>
        /// <para>The aggregate functions (used by APM_SIMPLE_CONDITION. For UMODEL conditions, the aggregation semantics have been migrated to QueryConfigUnified and this field no longer takes effect).</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The consecutive trigger count threshold (type=SLS_MULTI_CONDITION). An alert is fired only after the condition is met N times. Default value: 1.</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>The list of comparison conditions (APM_COMPOSITE_CONDITION).</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<CompareList> CompareList { get; set; }

        /// <summary>
        /// <para>The multi-metric composite trigger configuration for CLOUD_MONITORING_CONDITION when escalationType=COMPOSITE (requires relation, severity, times, escalations).</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringCompositeEscalation CompositeEscalation { get; set; }

        /// <summary>
        /// <para>The count comparison operator (type=UMODEL_LOGSET_CONDITION).</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold (type=UMODEL_LOGSET_CONDITION).</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds. Used directly by PROMETHEUS_SIMPLE / UMODEL_METRICSET_CONDITION / UMODEL_LOGSET_CONDITION. For UMODEL_METRICSET_MULTI_CONDITION, this serves as the global default and can be overridden by the durationSecs field in each trigger.</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable severity suppression by highest level (type=UMODEL_METRICSET_MULTI_CONDITION / PROMETHEUS_MULTI_CONDITION). Default value: true. When enabled, only the highest severity trigger is reported for the same entity.</para>
        /// </summary>
        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        /// <summary>
        /// <para>The expression type for CLOUD_MONITORING_CONDITION: SIMPLE / COMPOSITE / EXPRESS / PROMETHEUS (write paths support only SIMPLE / COMPOSITE). Specify the corresponding escalation sub-object based on the type.</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>The expression-based trigger configuration for CLOUD_MONITORING_CONDITION when escalationType=EXPRESS (read path output only).</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringExpressEscalation ExpressEscalation { get; set; }

        /// <summary>
        /// <para>The raw V1 condition JSON string returned when type=UNKNOWN_CONDITION and the read path fails to parse the condition. If this field is not empty, display it as read-only on the frontend.</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>Returned when type=UNKNOWN_CONDITION. Indicates that this rule cannot be edited through the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The log field name (used when type=UMODEL_LOGSET_CONDITION and matchOperator=CONTAINS/EQUALS/REGEX).</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The log match operator (type=UMODEL_LOGSET_CONDITION).</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The log match value (used when type=UMODEL_LOGSET_CONDITION and matchOperator=CONTAINS/EQUALS/REGEX).</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range (used when UMODEL_METRICSET_CONDITION and operator=IN_RANGE/OUT_OF_RANGE).</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range (used when UMODEL_METRICSET_CONDITION and operator=IN_RANGE/OUT_OF_RANGE).</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The no-data alert level (SLS_MULTI_CONDITION). APM and Prometheus conditions have migrated to noDataPolicy + noDataAlertSeverity.</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>The no-data alert severity level (PROMETHEUS_SIMPLE_CONDITION / PROMETHEUS_MULTI_CONDITION, takes effect when noDataPolicy=NO_DATA_TO_ALERT). SLS_MULTI_CONDITION still uses noDataAlertLevel.</para>
        /// </summary>
        [NameInMap("noDataAlertSeverity")]
        [Validation(Required=false)]
        public string NoDataAlertSeverity { get; set; }

        /// <summary>
        /// <para>The value to append when no data is available (APM_SIMPLE_CONDITION / APM_COMPOSITE_CONDITION). Nullable.</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public double? NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>The no-data handling policy (CLOUD_MONITORING_CONDITION / PROMETHEUS_MULTI_CONDITION / PROMETHEUS_SIMPLE_CONDITION / APM_SIMPLE_CONDITION / APM_COMPOSITE_CONDITION): NO_DATA_TO_OK / NO_DATA_TO_ALERT / KEEP_LAST_STATE / APPEND_VALUE (APM only).</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The comparison operator. For UMODEL_METRICSET_CONDITION: GT (greater than) / GE (greater than or equal to) / LT (less than) / LE (less than or equal to) / EQ (equal to) / NE (not equal to) / IN_RANGE (within range, requires min/max) / OUT_OF_RANGE (outside range, requires min/max) / PRESENT (field exists) / NOT_PRESENT (field does not exist). Not used by UMODEL_LOGSET_CONDITION. For APM_SIMPLE_CONDITION: GT/GTE/LT/LTE/EQ/NE/YOY_UP/YOY_DOWN (YOY_* requires yoyTimeUnit/yoyTimeValue).</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The PromQL-based trigger configuration for CLOUD_MONITORING_CONDITION when escalationType=PROMETHEUS (read path output only).</para>
        /// </summary>
        [NameInMap("prometheus")]
        [Validation(Required=false)]
        public CloudMonitoringPrometheusEscalation Prometheus { get; set; }

        /// <summary>
        /// <para>The logical relationship between conditions (APM_COMPOSITE_CONDITION).</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The severity level (UMODEL_METRICSET_CONDITION / UMODEL_LOGSET_CONDITION / PROMETHEUS_SIMPLE / APM_COMPOSITE).</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The single-metric multi-level trigger configuration for CLOUD_MONITORING_CONDITION when escalationType=SIMPLE (requires metricName, period, escalations).</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringSimpleEscalation SimpleEscalation { get; set; }

        /// <summary>
        /// <para>The threshold (used by UMODEL_METRICSET_CONDITION with non-range operators).</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>The multi-threshold list (APM_SIMPLE_CONDITION).</para>
        /// </summary>
        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<ThresholdList> ThresholdList { get; set; }

        /// <summary>
        /// <para>The list of triggers (polymorphic by type. CLOUD_MONITORING_CONDITION does not use this field. Use simpleEscalation.escalations / compositeEscalation.escalations instead). For SLS_MULTI_CONDITION, each case contains matchField / matchOperator / matchValue / countOperator / countThreshold / severity, with at least one required. For UMODEL_METRICSET_MULTI_CONDITION, each trigger contains severity, durationSecs, and an expression (SIMPLE/COMPOSITE). For PROMETHEUS_MULTI_CONDITION, each trigger contains severity, durationSecs, and an expression (SIMPLE/COMPOSITE). Triggers are sorted by severity priority, and the first match fires.</para>
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<Triggers> Triggers { get; set; }

        /// <summary>
        /// <para>The detection condition type. Valid values and their required fields: PROMETHEUS_SIMPLE_CONDITION (requires operator, threshold, durationSecs, severity). UMODEL_METRICSET_CONDITION (requires operator, durationSecs, severity. Non-range operators require threshold. operator=IN_RANGE/OUT_OF_RANGE requires min and max). UMODEL_LOGSET_CONDITION (requires matchOperator, durationSecs, severity. matchOperator=CONTAINS/EQUALS/REGEX requires matchField and matchValue. countOperator/countThreshold are optional). UMODEL_METRICSET_MULTI_CONDITION (requires triggers[*]. Optional durationSecs as global default, enableSeveritySuppression). APM_SIMPLE_CONDITION (requires operator, aggregate. Use thresholdList or threshold. operator=YOY_UP/YOY_DOWN requires yoyTimeUnit and yoyTimeValue. Optional noDataPolicy, noDataAppendValue). APM_COMPOSITE_CONDITION (requires compareList, relation, severity. Optional noDataPolicy, noDataAppendValue). CLOUD_MONITORING_CONDITION (requires escalationType. escalationType=SIMPLE requires simpleEscalation. escalationType=COMPOSITE requires compositeEscalation. Optional noDataPolicy). UNKNOWN_CONDITION (read-only fallback. Do not use in write paths). Do not use non-enumerated values such as SLS_CONDITION or CMS_BASIC_CONDITION. The backend returns an Invalidtype 400 error.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The year-over-year time unit (APM_SIMPLE_CONDITION, takes effect only when operator=YOY_UP/YOY_DOWN).</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The year-over-year time value (APM_SIMPLE_CONDITION, takes effect only when operator=YOY_UP/YOY_DOWN).</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
