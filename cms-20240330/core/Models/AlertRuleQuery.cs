// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleQuery : TeaModel {
        /// <summary>
        /// <para>Specified when type is METRIC_SET_QUERY or LOG_SET_QUERY. The aggregation functions: AVG, MAX, MIN, SUM, and LAST.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AVG</para>
        /// </summary>
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY. Specifies whether to perform alert detection after the data is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>The list of resource filter dimensions.  </para>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>The domain to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rum</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY. The alert data duration in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The array of entity field filters.</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<AlertRuleQueryEntityFields> EntityFields { get; set; }
        public class AlertRuleQueryEntityFields : TeaModel {
            /// <summary>
            /// <para>The entity field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The field value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-abc123</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The resource filter used to filter target resources.</para>
        /// </summary>
        [NameInMap("entityFilter")]
        [Validation(Required=false)]
        public AlertRuleQueryEntityFilter EntityFilter { get; set; }
        public class AlertRuleQueryEntityFilter : TeaModel {
            /// <summary>
            /// <para>The resource type domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rum</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The list of filter conditions used to further filter resources.</para>
            /// </summary>
            [NameInMap("filters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryEntityFilterFilters> Filters { get; set; }
            public class AlertRuleQueryEntityFilterFilters : TeaModel {
                /// <summary>
                /// <para>The field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>The comparison operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>=</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The matched value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>wait_throw</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apm</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY. The query expression in PromQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum(sum(max_over_time(kube_pod_status_phase{phase=~\&quot;Pending\&quot;,job=\&quot;_kube-state-metrics\&quot;}[5m])) by (pod)) &gt; 1000</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY. The set join operation configuration for the results of subquery 1 (queries[0]) and subquery 2 (queries[1]).</para>
        /// </summary>
        [NameInMap("firstJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin FirstJoin { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY. The list of group field names.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY. The associated application group ID. This field is valid only when relationType is set to GROUP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23423</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY. The group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: No grouping.</description></item>
        /// <item><description>label: Automatic label grouping.</description></item>
        /// <item><description>custom: Custom label grouping.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>label</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The array of tag filters.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<AlertRuleQueryLabelFilters> LabelFilters { get; set; }
        public class AlertRuleQueryLabelFilters : TeaModel {
            /// <summary>
            /// <para>The tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The comparison operator that determines how to match the tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>=</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specified when type is LOG_SET_QUERY. The log set name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>china-log-set</para>
        /// </summary>
        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        /// <summary>
        /// <para>The list of mark tags for the alert rule, used for categorization and retrieval.</para>
        /// </summary>
        [NameInMap("markTags")]
        [Validation(Required=false)]
        public List<AlertRuleQueryMarkTags> MarkTags { get; set; }
        public class AlertRuleQueryMarkTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The monitoring metrics set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_usage</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY. The namespace of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Specified when type is METRIC_SET_QUERY or LOG_SET_QUERY. The query time offset in seconds. This field is used together with windowSecs to implement offset queries for the [T - windowSecs - offsetSecs, T - offsetSecs] range. Valid values: 0 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <summary>
        /// <para>Applicable query types: SLS_MULTI_QUERY and APM_MULTI_QUERY. The list of subqueries. For the SLS_MULTI_QUERY type, a maximum of three subqueries are supported, and the number and order of the subqueries must match the sub-datasource configurations in datasource.dsList.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<AlertRuleQueryQueries> Queries { get; set; }
        public class AlertRuleQueryQueries : TeaModel {
            /// <summary>
            /// <para>Applicable query type: APM_MULTI_QUERY. The ID of the APM predefined metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstat.jvm.ThreadNewCount</para>
            /// </summary>
            [NameInMap("apmAlertMetricId")]
            [Validation(Required=false)]
            public string ApmAlertMetricId { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY. The dimension filter configuration for APM metrics. This field must be used together with apmAlertMetricId.</para>
            /// </summary>
            [NameInMap("apmFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesApmFilters> ApmFilters { get; set; }
            public class AlertRuleQueryQueriesApmFilters : TeaModel {
                /// <summary>
                /// <para>The dimension in APM metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rpcType</para>
                /// </summary>
                [NameInMap("dim")]
                [Validation(Required=false)]
                public string Dim { get; set; }

                /// <summary>
                /// <para>The filter operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>eq: Equal to.</description></item>
                /// <item><description>neq: Not equal to.</description></item>
                /// <item><description>match: Regular expression match.</description></item>
                /// <item><description>nmatch: Regular expression mismatch.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value corresponding to the filter operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h3ji7a0y9i@2ac80e27fdfd0a2</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY. The list of aggregation dimensions for the query, which specifies the metric dimensions used for aggregation.</para>
            /// </summary>
            [NameInMap("apmGroupBy")]
            [Validation(Required=false)]
            public List<string> ApmGroupBy { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY. The alert data duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY. The relative end time of the time offset. If start and end are specified, do not specify window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Applicable query types: APM_MULTI_QUERY and SLS_MULTI_QUERY. The query expression.</para>
            /// <list type="bullet">
            /// <item><description>For APM_MULTI_QUERY, this field is optional and contains the PromQL generated for predefined metrics, which is used to preview data.</description></item>
            /// <item><description>For SLS_MULTI_QUERY, this field contains the SQL query statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sum by (rpc,acs_arms_service_id,pid,rpcType) (sum_over_time_lorc(arms_app_requests_count_ign_destid_endpoint_parent_ppid_prpc{callKind=~\&quot;http|rpc|custom_entry|server|consumer\&quot;,pid=\&quot;gaddp9ap8q@cb005ffdf44b8ac\&quot;,source=\&quot;apm\&quot;}[1m]))</para>
            /// </summary>
            [NameInMap("expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            /// <summary>
            /// <para>Valid only for METRIC_SET_MULTI_QUERY. The label filter conditions. This field is optional and independent for each query.</para>
            /// </summary>
            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesLabelFilters> LabelFilters { get; set; }
            public class AlertRuleQueryQueriesLabelFilters : TeaModel {
                /// <summary>
                /// <para>The key for label filtering, which is the label name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>host</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The label filter operator, such as =, !=, =<del>, or !</del>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>=</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The value for label filtering.</para>
                /// 
                /// <b>Example:</b>
                /// <para>web-01</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Valid only for METRIC_SET_MULTI_QUERY. The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpuUsage</para>
            /// </summary>
            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            /// <summary>
            /// <para>Valid only for METRIC_SET_MULTI_QUERY. The metric set name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs_metrics</para>
            /// </summary>
            [NameInMap("metricSet")]
            [Validation(Required=false)]
            public string MetricSet { get; set; }

            /// <summary>
            /// <para>The subquery name, which uniquely identifies the query within the same alert rule and is referenced by the expression condition in triggers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpuUsageQuery</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The PromQL query statement, used when type is APM_MULTI_QUERY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>avg(rate(http_requests_total[5m]))</para>
            /// </summary>
            [NameInMap("promQl")]
            [Validation(Required=false)]
            public string PromQl { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY. The relative start time of the time offset for the SLS query. If start and end are specified, do not specify window. For example, if start is set to 15 and timeUnit is set to minute, it indicates 15 minutes ago.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY. The time unit for the start, end, and window parameters. Valid values: day, hour, minute, and second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY. The time frame query interval. If window is specified, do not specify start and end.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public long? Window { get; set; }

        }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY. The resource scope for the rule query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: All resources under the user UID.</description></item>
        /// <item><description>GROUP: Application group.</description></item>
        /// <item><description>INSTANCE: Specified instance list.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY. The set join operation configuration for the results of subquery 2 (queries[2]) and subquery 3 (queries[3]).</para>
        /// </summary>
        [NameInMap("secondJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin SecondJoin { get; set; }

        /// <summary>
        /// <para>The list of service IDs.</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROMQL_QUERY: PromQL query.</description></item>
        /// <item><description>SLS_MULTI_QUERY: SLS query.</description></item>
        /// <item><description>APM_MULTI_QUERY: APM query.</description></item>
        /// <item><description>CMS_BASIC_QUERY: CloudMonitor Basic query.
        /// Different query types have different valid fields in the query object. For details, see the Applicable query type description in each field. The query type must match the datasource type. The mappings are as follows:</description></item>
        /// <item><description>Prometheus datasource (PROMETHEUS_DS): PROMQL_QUERY.</description></item>
        /// <item><description>APM datasource (APM_DS): APM_MULTI_QUERY.</description></item>
        /// <item><description>SLS datasource (SLS_MULTI_DS): SLS_MULTI_QUERY.</description></item>
        /// <item><description>CloudMonitor Basic datasource (CMS_BASIC_DS): CMS_BASIC_QUERY.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMQL_QUERY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Specified when type is METRIC_SET_QUERY or LOG_SET_QUERY. The aggregation time window in seconds. Valid values: 60 to 86400.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}
