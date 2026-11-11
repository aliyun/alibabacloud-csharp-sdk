// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class QueryConfigUnified : TeaModel {
        /// <summary>
        /// <para>The aggregation function used when the type is UMODEL_METRICSET_QUERY or UMODEL_LOGSET_QUERY.</para>
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
        /// <para><b>[Deprecated]</b> Specifies whether to perform alert detection after data completion. This parameter was originally used when the type was PROMETHEUS_MULTI_QUERY. It duplicates enableDataCompleteCheck and returns a 400 error in the write path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>The list of dimensions used when the type is CLOUD_MONITORING_QUERY. Each dimension is a key-value string map.</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>The duration in seconds used when the type is PROMETHEUS_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public long? DurationSecs { get; set; }

        /// <summary>
        /// <para>Specifies whether the data integrity check is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enableDataCompleteCheck")]
        [Validation(Required=false)]
        public bool? EnableDataCompleteCheck { get; set; }

        /// <summary>
        /// <para>The domain to which the entity belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s</para>
        /// </summary>
        [NameInMap("entityDomain")]
        [Validation(Required=false)]
        public string EntityDomain { get; set; }

        /// <summary>
        /// <para>The entity fields to be returned in the response.</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<EntityFields> EntityFields { get; set; }

        /// <summary>
        /// <para>The list of entity filters.</para>
        /// </summary>
        [NameInMap("entityFilters")]
        [Validation(Required=false)]
        public List<EntityFilters> EntityFilters { get; set; }

        /// <summary>
        /// <para>The type of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s.pod</para>
        /// </summary>
        [NameInMap("entityType")]
        [Validation(Required=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// <para>The query expression or Search Processing Language (SPL) statement. Recommended when the type is PROMETHEUS_SINGLE_QUERY. Optional when the type is UMODEL_METRICSET_QUERY for custom SPL. Required when the type is UMODEL_LOGSET_QUERY, where an SPL query statement must be provided and validated by the business layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The list of Application Performance Monitoring (APM) filter conditions.</para>
        /// </summary>
        [NameInMap("filterList")]
        [Validation(Required=false)]
        public List<FilterList> FilterList { get; set; }

        /// <summary>
        /// <para>The list of filter values for predefined metrics when the type is PROMETHEUS_PREDEFINED_METRIC_QUERY or PROMETHEUS_METRIC_GROUP_QUERY [Deprecated].</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>The list of grouping fields used when the type is SLS_MULTI_QUERY and the groupType is custom.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>The group ID used when the type is CLOUD_MONITORING_QUERY. This parameter has dual semantics: an og- prefix indicates an observation group (GROUP_V2, where the prefix defines the semantics and relationType is not required, and the backend resolves members through the entity library); a pure number indicates an application group (GROUP_V1 legacy resource group, which requires relationType=GROUP).</para>
        /// 
        /// <b>Example:</b>
        /// <para>og-845e0a26455f437c</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The grouping strategy used when the type is SLS_MULTI_QUERY. Valid values: none, label, and custom.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The list of joins used when the type is SLS_MULTI_QUERY. A maximum of two joins are supported. joinings[0] corresponds to the set operation between query 0 and query 1, and joinings[1] corresponds to the set operation between query 1 and query 2.</para>
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
        /// <para>The raw V1 query JSON string returned as a fallback when the type is UNKNOWN_QUERY and parsing fails in the read path. This string includes the field values that triggered the failure, such as filter.operator=ABC. The frontend displays this field in read-only mode when it is not empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("legacyRaw")]
        [Validation(Required=false)]
        public string LegacyRaw { get; set; }

        /// <summary>
        /// <para>The legacy type returned when the type is UNKNOWN_QUERY. This parameter indicates that the rule cannot be edited by using the new API. Submit a ticket to contact the CloudMonitor product team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("legacyType")]
        [Validation(Required=false)]
        public string LegacyType { get; set; }

        /// <summary>
        /// <para>The name of the logset when the type is UMODEL_LOGSET_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        /// <summary>
        /// <para>The measure group key. This parameter is optional when the type is APM_MULTI_QUERY and corresponds to alertMetricInput.groupKey in V1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("measureGroupKey")]
        [Validation(Required=false)]
        public string MeasureGroupKey { get; set; }

        /// <summary>
        /// <para>The list of APM measure configurations.</para>
        /// </summary>
        [NameInMap("measureList")]
        [Validation(Required=false)]
        public List<MeasureList> MeasureList { get; set; }

        /// <summary>
        /// <para>The name of the metric when the type is UMODEL_METRICSET_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>node_cpu_seconds_total</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric group ID when the type is PROMETHEUS_PREDEFINED_METRIC_QUERY or PROMETHEUS_METRIC_GROUP_QUERY [Deprecated].</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-id-001</para>
        /// </summary>
        [NameInMap("metricGroupId")]
        [Validation(Required=false)]
        public string MetricGroupId { get; set; }

        /// <summary>
        /// <para>The predefined metric ID when the type is PROMETHEUS_PREDEFINED_METRIC_QUERY.</para>
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
        /// <para><b>[Deprecated]</b> The list of predefined metric IDs originally used when the type was PROMETHEUS_METRIC_GROUP_QUERY. This query type is deprecated, and the write path returns a 400 error.</para>
        /// </summary>
        [NameInMap("metricIds")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> MetricIds { get; set; }

        /// <summary>
        /// <para>The name of the metricset when the type is UMODEL_METRICSET_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cms.acs_ecs_dashboard.CPUUtilization</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The CloudMonitor namespace, which is the cloud service name, when the type is CLOUD_MONITORING_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The query time offset in seconds used when the type is UMODEL_METRICSET_QUERY or UMODEL_LOGSET_QUERY. This parameter is used together with windowSecs to implement offset queries in the range of [T - windowSecs - offsetSecs, T - offsetSecs]. Valid values: 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <summary>
        /// <para>The list of parameter values for predefined metrics when the type is PROMETHEUS_PREDEFINED_METRIC_QUERY or PROMETHEUS_METRIC_GROUP_QUERY [Deprecated].</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<PrometheusMetricParamValue> ParamValues { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The Prometheus query statement when the type is PROMETHEUS_SINGLE_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg(rate(node_cpu_seconds_total{mode=&quot;idle&quot;}[5m])) * 100</para>
        /// </summary>
        [NameInMap("promQl")]
        [Validation(Required=false)]
        [Obsolete]
        public string PromQl { get; set; }

        /// <summary>
        /// <para>The list of subqueries, which is polymorphic based on the type. When the type is SLS_MULTI_QUERY, each entry is an SlsNamedQueryEntry object containing timeUnit, start, end, window, and expr. When the type is PROMETHEUS_MULTI_QUERY, each entry is a PrometheusNamedQueryEntry object containing name and expr. When the type is UMODEL_METRICSET_MULTI_QUERY, each entry is a MetricSetNamedQueryEntry object.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<Queries> Queries { get; set; }

        /// <summary>
        /// <para>The resource association type when the type is CLOUD_MONITORING_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>The list of service IDs (type=APM_MULTI_QUERY).</para>
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
        /// <para>The aggregation time window in seconds. Used when type=UMODEL_METRICSET_QUERY or UMODEL_LOGSET_QUERY. Valid range: [60, 86400].</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}
