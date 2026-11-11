// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class ConditionConfigUnified : TeaModel {
        /// <summary>
        /// <para>The minimum dynamic baseline deviation or absolute deviation dead zone (effective only for baseline operators in UMODEL_METRICSET_CONDITION and APM_SIMPLE_CONDITION). No alert is triggered if |current value - boundary| &lt; absDeviation. The unit is the same as the metric. The value must be greater than or equal to 0. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("absDeviation")]
        [Validation(Required=false)]
        public double? AbsDeviation { get; set; }

        /// <summary>
        /// <para>The aggregation function (APM_SIMPLE_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>The consecutive trigger count threshold (type=SLS_MULTI_CONDITION). An alert is triggered only after the condition is met N times. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("alertCount")]
        [Validation(Required=false)]
        public int? AlertCount { get; set; }

        /// <summary>
        /// <para>The baseline period (effective only for baseline operators). Valid values: AUTO for automatic identification, DAILY for daily, WEEKLY for weekly, and NONE for no period. For weekly periods, the backend automatically expands the historical training window to 14 days or more. Automatic identification cannot return specific identification results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUTO</para>
        /// </summary>
        [NameInMap("baselinePeriod")]
        [Validation(Required=false)]
        public string BaselinePeriod { get; set; }

        /// <summary>
        /// <para>The multiple comparisons (APM_COMPOSITE_CONDITION).</para>
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
        /// <para>The count comparison operator (type=UMODEL_LOGSET_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>GTE</para>
        /// </summary>
        [NameInMap("countOperator")]
        [Validation(Required=false)]
        public string CountOperator { get; set; }

        /// <summary>
        /// <para>The count threshold (type=UMODEL_LOGSET_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("countThreshold")]
        [Validation(Required=false)]
        public long? CountThreshold { get; set; }

        /// <summary>
        /// <para>The duration in seconds. This parameter is used by PROMETHEUS_SIMPLE and UMODEL_METRICSET.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable severity-based suppression (type=UMODEL_METRICSET_MULTI_CONDITION / PROMETHEUS_MULTI_CONDITION). Default value: true. When enabled, only the highest severity trigger is reported for the same entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableSeveritySuppression")]
        [Validation(Required=false)]
        public bool? EnableSeveritySuppression { get; set; }

        /// <summary>
        /// <para>The expression type for CLOUD_MONITORING_CONDITION. Valid values: SIMPLE, COMPOSITE, EXPRESS, and PROMETHEUS. Only SIMPLE and COMPOSITE are supported in the write path. Specify the corresponding escalation sub-object based on the type.</para>
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
        /// <para>The original V1 condition JSON string returned when type is set to UNKNOWN_CONDITION and read path parsing fails as a fallback. The frontend displays this field as read-only when it is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>The value returned when type is set to UNKNOWN_CONDITION, which indicates that this rule cannot be edited by using the new API. Submit a ticket to contact the CloudMonitor product team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The log field name. This parameter is used when type is set to UMODEL_LOGSET_CONDITION and matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("matchField")]
        [Validation(Required=false)]
        public string MatchField { get; set; }

        /// <summary>
        /// <para>The log matching operator (type=UMODEL_LOGSET_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRESENT</para>
        /// </summary>
        [NameInMap("matchOperator")]
        [Validation(Required=false)]
        public string MatchOperator { get; set; }

        /// <summary>
        /// <para>The log matching value. This parameter is used when type is set to UMODEL_LOGSET_CONDITION and matchOperator is set to CONTAINS, EQUALS, or REGEX.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("matchValue")]
        [Validation(Required=false)]
        public string MatchValue { get; set; }

        /// <summary>
        /// <para>The upper bound of the range. This parameter is used for UMODEL_METRICSET_CONDITION when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("max")]
        [Validation(Required=false)]
        public double? Max { get; set; }

        /// <summary>
        /// <para>The lower bound of the range. This parameter is used for UMODEL_METRICSET_CONDITION when operator is set to IN_RANGE or OUT_OF_RANGE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("min")]
        [Validation(Required=false)]
        public double? Min { get; set; }

        /// <summary>
        /// <para>The no-data alert level (SLS_MULTI_CONDITION). APM and Prometheus conditions have been migrated to noDataPolicy and noDataAlertSeverity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertLevel")]
        [Validation(Required=false)]
        public string NoDataAlertLevel { get; set; }

        /// <summary>
        /// <para>The no-data alert severity. This parameter takes effect for PROMETHEUS_SIMPLE_CONDITION and PROMETHEUS_MULTI_CONDITION when noDataPolicy is set to NO_DATA_TO_ALERT. SLS_MULTI_CONDITION still uses noDataAlertLevel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("noDataAlertSeverity")]
        [Validation(Required=false)]
        public string NoDataAlertSeverity { get; set; }

        /// <summary>
        /// <para>The compensated value when no data is available (APM_SIMPLE_CONDITION / APM_COMPOSITE_CONDITION). This parameter is nullable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("noDataAppendValue")]
        [Validation(Required=false)]
        public double? NoDataAppendValue { get; set; }

        /// <summary>
        /// <para>The tolerance duration in seconds before determining that no data is available. This parameter applies to UMODEL_METRICSET_CONDITION and UMODEL_METRICSET_MULTI_CONDITION, and takes effect when noDataPolicy is not empty. The no-data policy is applied only after the continuous no-data period exceeds this duration. This is used to offset single-cycle empty queries caused by UModel data write jitter. The value must be a positive integer. If not specified, the backend defaults to the maximum of twice the collection interval and 300.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("noDataDurationSecs")]
        [Validation(Required=false)]
        public int? NoDataDurationSecs { get; set; }

        /// <summary>
        /// <para>The no-data processing policy (CLOUD_MONITORING_CONDITION / PROMETHEUS_MULTI_CONDITION / PROMETHEUS_SIMPLE_CONDITION / APM_SIMPLE_CONDITION / APM_COMPOSITE_CONDITION). Valid values: NO_DATA_TO_OK, NO_DATA_TO_ALERT, KEEP_LAST_STATE, and APPEND_VALUE (APM only).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example value</para>
        /// </summary>
        [NameInMap("noDataPolicy")]
        [Validation(Required=false)]
        public string NoDataPolicy { get; set; }

        /// <summary>
        /// <para>The comparison operator (UMODEL_METRICSET_CONDITION or APM_SIMPLE_CONDITION).</para>
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
        /// <para>The logical relation between conditions (APM_COMPOSITE_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

        /// <summary>
        /// <para>The dynamic baseline sensitivity (UMODEL_METRICSET_CONDITION / APM_SIMPLE_CONDITION). This parameter takes effect only when operator is set to ABOVE_UPPER, BELOW_LOWER, or OUT_OF_BAND. Valid values: HIGH for the narrowest and most sensitive band, MEDIUM, and LOW for the widest and least sensitive band.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("sensitivity")]
        [Validation(Required=false)]
        public string Sensitivity { get; set; }

        /// <summary>
        /// <para>The severity level (UMODEL / PROMETHEUS_SIMPLE / APM_COMPOSITE).</para>
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
        /// <para>The threshold (UMODEL_METRICSET_CONDITION).</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
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
        /// <para>The trigger list. This parameter is polymorphic by type. CLOUD_MONITORING_CONDITION does not use this field; use simpleEscalation.escalations or compositeEscalation.escalations instead. For SLS_MULTI_CONDITION, each case includes matchField, matchOperator, matchValue, countOperator, countThreshold, and severity, and at least one case is required. For UMODEL_METRICSET_MULTI_CONDITION, each trigger includes severity, durationSecs, and an expression (SIMPLE or COMPOSITE). For PROMETHEUS_MULTI_CONDITION, each trigger includes severity, durationSecs, and an expression (SIMPLE or COMPOSITE). The triggers are sorted by severity priority, and the first match triggers the alert.</para>
        /// </summary>
        [NameInMap("triggers")]
        [Validation(Required=false)]
        public List<Triggers> Triggers { get; set; }

        /// <summary>
        /// <para>The detection condition type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS_SIMPLE_CONDITION</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The year-over-year time unit (APM_SIMPLE_CONDITION). This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>minute</para>
        /// </summary>
        [NameInMap("yoyTimeUnit")]
        [Validation(Required=false)]
        public string YoyTimeUnit { get; set; }

        /// <summary>
        /// <para>The year-over-year time value (APM_SIMPLE_CONDITION). This parameter takes effect only when operator is set to YOY_UP or YOY_DOWN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("yoyTimeValue")]
        [Validation(Required=false)]
        public int? YoyTimeValue { get; set; }

    }

}
