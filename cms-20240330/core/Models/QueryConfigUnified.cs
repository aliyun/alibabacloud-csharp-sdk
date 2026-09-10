// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        /// <summary>
        /// <para>The aggregate functions. Used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to perform alert detection only after data is complete (originally used when type=PROMETHEUS_MULTI_QUERY). This field overlaps with enableDataCompleteCheck. Using this field on write path returns 400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>The list of dimensions. This parameter is used when type is set to CLOUD_MONITORING_QUERY. Each dimension is a key/value string mapping.</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>The duration in seconds. Used when type=PROMETHEUS_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public long? DurationSecs { get; set; }

        /// <summary>
        /// <para>Indicates whether data integrity check is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        /// <summary>
        /// <para>The entity domain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The entity fields to include in the response.</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<EntityFields> EntityFields { get; set; }

        /// <summary>
        /// <para>The entity filter list.</para>
        /// </summary>
        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<EntityFilters> EntityFilters { get; set; }

        /// <summary>
        /// <para>The entity type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s.pod</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The query expression or SPL statement. Recommended when type=PROMETHEUS_SINGLE_QUERY. Optional when type=UMODEL_METRICSET_QUERY for custom SPL. Required when type=UMODEL_LOGSET_QUERY, where an SPL query statement must be provided (the business layer enforces this requirement).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
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
        /// <para>The predefined metric filter value list (type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>The list of group fields. This parameter is used when type is set to SLS_MULTI_QUERY and groupType is set to custom.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>The group ID (type=CLOUD_MONITORING_QUERY). Dual semantics: og- prefix = observation group (GROUP_V2. The prefix itself conveys the semantics. relationType is not required. The backend resolves members through the entity store). Numeric only = application group (GROUP_V1 legacy resource group. Requires relationType=GROUP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-845e0a26455f437c</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The grouping policy (used when type=SLS_MULTI_QUERY): none / label / custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
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
        /// <para>The label filter conditions.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        /// <summary>
        /// <para>The original V1 query JSON string returned as a fallback when type=UNKNOWN_QUERY and read path parsing fails. Contains the field values that triggered the failure, such as filter.operator=ABC. When the frontend detects that this field is not empty, display it as read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>Returned when type=UNKNOWN_QUERY. Indicates that this rule cannot be edited through the new API. Submit a ticket to contact the CloudMonitor product team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The log set name (type=UMODEL_LOGSET_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample name</para>
        /// </summary>
        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        /// <summary>
        /// <para>The measure group key. This parameter is optional when type is set to APM_MULTI_QUERY. It corresponds to alertMetricInput.groupKey in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample value</para>
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
        /// <para>The metric name (type=UMODEL_METRICSET_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_cpu_seconds_total</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric group ID (type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("metricGroupId")]
        [Validation(Required=false)]
        public string MetricGroupId { get; set; }

        /// <summary>
        /// <para>The predefined metric ID (type=PROMETHEUS_PREDEFINED_METRIC_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para><b>[Deprecated]</b> The predefined metric ID list (originally used with type=PROMETHEUS_METRIC_GROUP_QUERY). This query type is deprecated. Write path returns 400.</para>
        /// </summary>
        [NameInMap("metricIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The metric set name (type=UMODEL_METRICSET_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.acs_ecs_dashboard.CPUUtilization</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The CloudMonitor namespace (Alibaba Cloud service name, type=CLOUD_MONITORING_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample name</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The query time offset in seconds. Used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY. Works with windowSecs to implement an offset query over the range [T - windowSecs - offsetSecs, T - offsetSecs]. Valid range: [0, 86400].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <summary>
        /// <para>The predefined metric parameter value list (type=PROMETHEUS_PREDEFINED_METRIC_QUERY / PROMETHEUS_METRIC_GROUP_QUERY [deprecated]).</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricParamValue> ParamValues { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The Prometheus query statement (type=PROMETHEUS_SINGLE_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg(rate(node_cpu_seconds_total{mode=&quot;idle&quot;}[5m])) * 100</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        [Obsolete]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>The subquery list (polymorphic by type): When type=SLS_MULTI_QUERY, each entry is a SlsNamedQueryEntry (timeUnit/start/end/window/expr). When type=PROMETHEUS_MULTI_QUERY, each entry is a PrometheusNamedQueryEntry (name/expr). When type=UMODEL_METRICSET_MULTI_QUERY, each entry is a MetricSetNamedQueryEntry.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<Queries> Queries { get; set; }

        /// <summary>
        /// <para>The resource association type (type=CLOUD_MONITORING_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The service ID list (type=APM_MULTI_QUERY).</para>
        /// </summary>
        [NameInMap("serviceIdList")]
        [Validation(Required=false)]
        public List<string> ServiceIdList { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS_SINGLE_QUERY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The aggregation time window in seconds. Used when type=UMODEL_METRICSET_QUERY / UMODEL_LOGSET_QUERY. Valid range: [60, 86400].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}
