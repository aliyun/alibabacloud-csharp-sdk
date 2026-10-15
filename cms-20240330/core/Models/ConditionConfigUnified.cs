// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        /// <summary>
        /// <para>The minimum deviation or absolute deviation dead zone for dynamic baselines. This parameter takes effect only for baseline operators in UMODEL_METRICSET_CONDITION and APM_SIMPLE_CONDITION. If the absolute difference between the current value and the boundary is less than the absDeviation value, no alert is triggered. The unit is the same as the metric unit. The value must be greater than or equal to 0. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The aggregation function used for APM_SIMPLE_CONDITION. For UModel conditions, this semantic has been migrated to QueryConfigUnified, and this field no longer takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The consecutive trigger count threshold for SLS_MULTI_CONDITION. An alert is triggered only after the condition is met for the specified number of consecutive times. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>The baseline period. This parameter takes effect only for baseline operators. Valid values: AUTO (automatic identification), DAILY (daily), WEEKLY (weekly), and NONE (no period). For weekly baselines, the backend automatically extends the historical training window to 14 days or more. Automatic identification cannot echo specific identification conclusions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The list of multiple comparisons for APM_COMPOSITE_CONDITION.</para>
        /// </summary>
        [NameInMap("compareList")]
        [Validation(Required=false)]
        public List<CompareList> CompareList { get; set; }

        /// <summary>
        /// <para>The multi-metric composite trigger configuration for CLOUD_MONITORING_CONDITION when escalationType is set to COMPOSITE. The relation, severity, times, and escalations parameters are required.</para>
        /// </summary>
        [NameInMap("compositeEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringCompositeEscalation CompositeEscalation { get; set; }

        /// <summary>
        /// <para>The count comparison operator for UMODEL_LOGSET_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GTE</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold for UMODEL_LOGSET_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds. This parameter is directly used for PROMETHEUS_SIMPLE, UMODEL_METRICSET_CONDITION, and UMODEL_LOGSET_CONDITION. For UMODEL_METRICSET_MULTI_CONDITION, it serves as the global default value, and each trigger can override it with its own durationSecs value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable severity suppression for UMODEL_METRICSET_MULTI_CONDITION and PROMETHEUS_MULTI_CONDITION. Default value: true. When enabled, only the highest severity trigger is reported for the same entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        /// <summary>
        /// <para>The expression type for CLOUD_MONITORING_CONDITION. Valid values: SIMPLE, COMPOSITE, EXPRESS, and PROMETHEUS. The write path only supports SIMPLE and COMPOSITE. Specify the corresponding escalation sub-object based on the type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("escalationType")]
        [Validation(Required=false)]
        public string EscalationType { get; set; }

        /// <summary>
        /// <para>The expression trigger configuration for CLOUD_MONITORING_CONDITION when escalationType is set to EXPRESS. This parameter is output only in the read path.</para>
        /// </summary>
        [NameInMap("expressEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringExpressEscalation ExpressEscalation { get; set; }

        /// <summary>
        /// <para>The original V1 condition JSON string returned as a fallback when parsing fails in the read path and the type is UNKNOWN_CONDITION. The frontend displays this field as read-only when it is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>The legacy type returned when the type is UNKNOWN_CONDITION. This indicates that the rule cannot be edited by using the new API. Submit a ticket to contact the CloudMonitor product team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The log field name used for UMODEL_LOGSET_CONDITION when matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The log match operator for UMODEL_LOGSET_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRESENT</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The log match value used for UMODEL_LOGSET_CONDITION when matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range used for UMODEL_METRICSET_CONDITION when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range used for UMODEL_METRICSET_CONDITION when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The no-data alert level for SLS_MULTI_CONDITION. For APM and Prometheus conditions, this parameter has been migrated to noDataPolicy and noDataAlertSeverity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>The no-data alert severity. This parameter takes effect for PROMETHEUS_SIMPLE_CONDITION, PROMETHEUS_MULTI_CONDITION, UMODEL_METRICSET_CONDITION, and UMODEL_METRICSET_MULTI_CONDITION when noDataPolicy is set to NO_DATA_TO_ALERT. For UMODEL_METRICSET conditions, this field is required when noDataPolicy is set to NO_DATA_TO_ALERT, and must not be specified for other policies. SLS_MULTI_CONDITION still uses noDataAlertLevel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertSeverity")]
        [Validation(Required=false)]
        public string NoDataAlertSeverity { get; set; }

        /// <summary>
        /// <para>The compensated value when no data is available for APM_SIMPLE_CONDITION and APM_COMPOSITE_CONDITION. This parameter is nullable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public double? NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>The tolerance duration in seconds before no data is determined. This parameter takes effect for UMODEL_METRICSET_CONDITION and UMODEL_METRICSET_MULTI_CONDITION when noDataPolicy is not empty. The noDataPolicy is applied only after no data is continuously reported for longer than this duration. This prevents empty query results in a single cycle caused by UModel data write jitter. The value must be a positive integer. If not specified, the backend uses the fallback value of max(collection interval × 2, 300).</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("noDataDurationSecs")]
        [Validation(Required=false)]
        public int? NoDataDurationSecs { get; set; }

        /// <summary>
        /// <para>The no-data processing policy for CLOUD_MONITORING_CONDITION, PROMETHEUS_MULTI_CONDITION, PROMETHEUS_SIMPLE_CONDITION, APM_SIMPLE_CONDITION, APM_COMPOSITE_CONDITION, UMODEL_METRICSET_CONDITION, and UMODEL_METRICSET_MULTI_CONDITION. Valid values: NO_DATA_TO_OK (treats no data as normal and recovers existing alerts), NO_DATA_TO_ALERT (triggers an alert for no data), KEEP_LAST_STATE (maintains the last state before no data), and APPEND_VALUE (APM only). If not specified, no-data determination is disabled, and the behavior remains the same as before this feature was released. UMODEL_METRICSET_CONDITION and UMODEL_METRICSET_MULTI_CONDITION do not support APPEND_VALUE because their data sources do not support backfilling.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The comparison operator. For UMODEL_METRICSET_CONDITION, valid values are GT (greater than), GE (greater than or equal to), LT (less than), LE (less than or equal to), EQ (equal to), NE (not equal to), IN_RANGE (within the range, requires min and max), OUT_OF_RANGE (outside the range, requires min and max), PRESENT (field exists), NOT_PRESENT (field does not exist), ABOVE_UPPER (dynamic baseline spike), BELOW_LOWER (dynamic baseline drop), and OUT_OF_BAND (bidirectional dynamic baseline, requires sensitivity, do not specify threshold, min, or max). This field is not used for UMODEL_LOGSET_CONDITION. For APM_SIMPLE_CONDITION, valid values are GT, GTE, LT, LTE, EQ, NE, YOY_UP, YOY_DOWN (YOY operators require yoyTimeUnit and yoyTimeValue), ABOVE_UPPER, BELOW_LOWER, and OUT_OF_BAND (dynamic baseline, requires sensitivity).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GT</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The PromQL trigger configuration for CLOUD_MONITORING_CONDITION when escalationType is set to PROMETHEUS. This parameter is output only in the read path.</para>
        /// </summary>
        [NameInMap("prometheus")]
        [Validation(Required=false)]
        public CloudMonitoringPrometheusEscalation Prometheus { get; set; }

        /// <summary>
        /// <para>The logical relation between conditions for APM_COMPOSITE_CONDITION.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity for UMODEL_METRICSET_CONDITION and APM_SIMPLE_CONDITION. This parameter takes effect only when operator is set to ABOVE_UPPER, BELOW_LOWER, or OUT_OF_BAND. Valid values: HIGH (narrowest band and most sensitive), MEDIUM, and LOW (widest band and least sensitive).</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The severity level for UMODEL_METRICSET_CONDITION, UMODEL_LOGSET_CONDITION, PROMETHEUS_SIMPLE, and APM_COMPOSITE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The single-metric multi-level trigger configuration for CLOUD_MONITORING_CONDITION when escalationType is set to SIMPLE. The metricName, period, and escalations parameters are required.</para>
        /// </summary>
        [NameInMap("simpleEscalation")]
        [Validation(Required=false)]
        public CloudMonitoringSimpleEscalation SimpleEscalation { get; set; }

        /// <summary>
        /// <para>The threshold used for UMODEL_METRICSET_CONDITION when a non-range operator is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

        /// <summary>
        /// <para>The list of multiple thresholds for APM_SIMPLE_CONDITION.</para>
        /// </summary>
        [NameInMap("thresholdList")]
        [Validation(Required=false)]
        public List<ThresholdList> ThresholdList { get; set; }

        /// <summary>
        /// <para>The list of triggers. This field is polymorphic based on the type. CLOUD_MONITORING_CONDITION does not use this field; use simpleEscalation.escalations or compositeEscalation.escalations instead. For SLS_MULTI_CONDITION, each case includes matchField, matchOperator, matchValue, countOperator, countThreshold, and severity, and at least one case is required. For UMODEL_METRICSET_MULTI_CONDITION, each trigger includes severity, durationSecs, and an expression (SIMPLE or COMPOSITE). For PROMETHEUS_MULTI_CONDITION, each trigger includes severity, durationSecs, and an expression (SIMPLE or COMPOSITE). Triggers are sorted by severity priority, and the first matched trigger is executed.</para>
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<Triggers> Triggers { get; set; }

        /// <summary>
        /// <para>The detection condition type. Valid values and required fields: PROMETHEUS_SIMPLE_CONDITION (requires operator, threshold, durationSecs, and severity), UMODEL_METRICSET_CONDITION (requires operator, durationSecs, and severity; requires threshold for non-range operators; requires min and max when operator is IN_RANGE or OUT_OF_RANGE; noDataPolicy and noDataDurationSecs are optional, but noDataAlertSeverity is required when noDataPolicy is NO_DATA_TO_ALERT), UMODEL_LOGSET_CONDITION (requires matchOperator, durationSecs, and severity; requires matchField and matchValue when matchOperator is CONTAINS, EQUALS, or REGEX; countOperator and countThreshold are optional), UMODEL_METRICSET_MULTI_CONDITION (requires triggers; durationSecs as global default and enableSeveritySuppression are optional; noDataPolicy and noDataDurationSecs are optional, but noDataAlertSeverity is required when noDataPolicy is NO_DATA_TO_ALERT), APM_SIMPLE_CONDITION (requires operator and aggregate; requires thresholdList or threshold; requires yoyTimeUnit and yoyTimeValue when operator is YOY_UP or YOY_DOWN; noDataPolicy and noDataAppendValue are optional), APM_COMPOSITE_CONDITION (requires compareList, relation, and severity; noDataPolicy and noDataAppendValue are optional), CLOUD_MONITORING_CONDITION (requires escalationType; requires simpleEscalation when escalationType is SIMPLE; requires compositeEscalation when escalationType is COMPOSITE; noDataPolicy is optional), and UNKNOWN_CONDITION (read-only fallback, do not use in the write path). Non-enum values such as SLS_CONDITION or CMS_BASIC_CONDITION are prohibited. The backend returns an Invalidtype 400 error for invalid values.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS_SIMPLE_CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The year-over-year time unit for APM_SIMPLE_CONDITION. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The year-over-year time value for APM_SIMPLE_CONDITION. This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
