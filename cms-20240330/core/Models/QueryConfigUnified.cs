// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        /// <summary>
        /// <para>The aggregation function (used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY).</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to perform alert detection only after data is complete (originally used when type=PROMETHEUS_MULTI_QUERY). This field overlaps with enableDataCompleteCheck. Using this field in write path returns 400.</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>The dimension list (used when type=CLOUD_MONITORING_QUERY. Each dimension is a key/value string mapping).</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>The duration in seconds (used when type=PROMETHEUS_MULTI_QUERY).</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public long? DurationSecs { get; set; }

        /// <summary>
        /// <para>Indicates whether the data integrity check is enabled (used when type=PROMETHEUS_SINGLE_QUERY / PROMETHEUS_MULTI_QUERY / PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        /// <summary>
        /// <para>The entity domain (used when type=UMODEL_METRICSET_QUERY / UMODEL_METRICSET_MULTI_QUERY / UMODEL_LOGSET_QUERY. Works with entityType/entityFilters to locate UModel entities).</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The entity fields to include in the response (used when type=UMODEL_METRICSET_QUERY / UMODEL_METRICSET_MULTI_QUERY / UMODEL_LOGSET_QUERY).</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<EntityFields> EntityFields { get; set; }

        /// <summary>
        /// <para>The entity filter list (used when type=UMODEL_METRICSET_QUERY / UMODEL_METRICSET_MULTI_QUERY / UMODEL_LOGSET_QUERY).</para>
        /// </summary>
        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<EntityFilters> EntityFilters { get; set; }

        /// <summary>
        /// <para>The entity type (used when type=UMODEL_METRICSET_QUERY / UMODEL_METRICSET_MULTI_QUERY / UMODEL_LOGSET_QUERY).</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The query expression or SPL statement. Recommended when type=PROMETHEUS_SINGLE_QUERY. Optional when type=UMODEL_METRICSET_QUERY for custom SPL. Required when type=UMODEL_LOGSET_QUERY, where an SPL query statement must be provided (the service layer enforces this requirement).</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The APM filter condition list.</para>
        /// </summary>
        [NameInMap("filterList")]
        [Validation(Required=false)]
        public List<FilterList> FilterList { get; set; }

        /// <summary>
        /// <para>The list of predefined metric filter values (used when type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>The group field list (used when type=SLS_MULTI_QUERY and groupType=custom).</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>The resource group ID (used when type=CLOUD_MONITORING_QUERY and relationType=GROUP).</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The grouping policy (used when type=SLS_MULTI_QUERY): none / label / custom.</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The join list (used when type=SLS_MULTI_QUERY. Maximum of 2: joinings[0] corresponds to the set operation between query 0 and query 1. joinings[1] corresponds to the set operation between query 1 and query 2).</para>
        /// </summary>
        [NameInMap("joinings")]
        [Validation(Required=false)]
        public List<Joinings> Joinings { get; set; }

        /// <summary>
        /// <para>The label filter conditions (used when type=UMODEL_METRICSET_QUERY. For UMODEL_METRICSET_MULTI_QUERY, place labelFilters in each queries[*] entry).</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        /// <summary>
        /// <para>The original V1 query JSON string returned as a fallback when type=UNKNOWN_QUERY and read path parsing fails (contains the field values that triggered the failure, such as filter.operator=ABC). The frontend displays this field as read-only when it is not empty.</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>Returned when type=UNKNOWN_QUERY, indicating that this rule cannot be edited through the new API. Submit a ticket to contact the CloudMonitor team.</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The log set name (used when type=UMODEL_LOGSET_QUERY).</para>
        /// </summary>
        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        /// <summary>
        /// <para>The measure group key (optional when type=APM_MULTI_QUERY, corresponds to V1 alertMetricInput.groupKey).</para>
        /// </summary>
        [NameInMap("measureGroupKey")]
        [Validation(Required=false)]
        public string MeasureGroupKey { get; set; }

        /// <summary>
        /// <para>The APM measure configuration list.</para>
        /// </summary>
        [NameInMap("measureList")]
        [Validation(Required=false)]
        public List<MeasureList> MeasureList { get; set; }

        /// <summary>
        /// <para>The metric name (required when type=UMODEL_METRICSET_QUERY. Required when type=CLOUD_MONITORING_QUERY, used together with namespace to uniquely identify CloudMonitor monitoring metrics).</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric group ID (used when type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("metricGroupId")]
        [Validation(Required=false)]
        public string MetricGroupId { get; set; }

        /// <summary>
        /// <para>The predefined metric ID (used when type=PROMETHEUS_PREDEFINED_METRIC_QUERY).</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The list of predefined metric IDs (originally used when type=PROMETHEUS_METRIC_GROUP_QUERY). This query type is deprecated. Write path returns 400.</para>
        /// </summary>
        [NameInMap("metricIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The metric set name (used when type=UMODEL_METRICSET_QUERY).</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The CloudMonitor namespace (Alibaba Cloud service name, used when type=CLOUD_MONITORING_QUERY).</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The query time offset in seconds (used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY). Works with windowSecs to implement an offset query over the range [T - windowSecs - offsetSecs, T - offsetSecs]. Valid range: [0, 86400].</para>
        /// </summary>
        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <summary>
        /// <para>The list of predefined metric parameter values (used when type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricParamValue> ParamValues { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The legacy Prometheus query statement field. Use expr instead. This field is retained for backward compatibility. The backend automatically normalizes it to expr.</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        [Obsolete]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>The subquery list (polymorphic by type): when type=SLS_MULTI_QUERY, each entry is a SlsNamedQueryEntry (timeUnit/start/end/window/expr). When type=PROMETHEUS_MULTI_QUERY, each entry is a PrometheusNamedQueryEntry (name/expr). When type=UMODEL_METRICSET_MULTI_QUERY, each entry is a MetricSetNamedQueryEntry.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<Queries> Queries { get; set; }

        /// <summary>
        /// <para>The resource relation type (used when type=CLOUD_MONITORING_QUERY).</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The list of service IDs (used when type=APM_MULTI_QUERY).</para>
        /// </summary>
        [NameInMap("serviceIdList")]
        [Validation(Required=false)]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// <para>The query type. Valid values and associated fields: PROMETHEUS_SINGLE_QUERY (required: expr. Optional: enableDataCompleteCheck). PROMETHEUS_PREDEFINED_METRIC_QUERY (required: metricGroupId, metricId. Optional: paramValues, filterValues, enableDataCompleteCheck). PROMETHEUS_METRIC_GROUP_QUERY ([deprecated] required: metricGroupId, metricIds. Optional: paramValues, filterValues, enableDataCompleteCheck. Write path returns 400). UMODEL_METRICSET_QUERY (required: metricSet, metric, windowSecs, aggregate. Optional: expr, entityDomain/entityType/entityFilters, labelFilters, entityFields, offsetSecs). UMODEL_METRICSET_MULTI_QUERY (required: queries[*]. Optional: entityDomain/entityType/entityFilters, windowSecs, offsetSecs, aggregate). UMODEL_LOGSET_QUERY (required: logSet, expr, windowSecs, aggregate. Optional: entityDomain/entityType/entityFilters, labelFilters, offsetSecs). APM_MULTI_QUERY (required: serviceIdList, measureList. Optional: filterList, measureGroupKey). CLOUD_MONITORING_QUERY (required: namespace, metric, relationType. When relationType=INSTANCE, dimensions is required. When relationType=GROUP, groupId is required. When relationType=USER, leave both empty). UNKNOWN_QUERY (read-only fallback. Do not use in write path). Do not use non-enumerated values (such as CMS_BASIC_QUERY/SLS_QUERY). The backend returns Invalidtype 400.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The aggregation time window in seconds (used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY). Valid range: [60, 86400].</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}
