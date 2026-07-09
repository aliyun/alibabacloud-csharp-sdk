// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleQuery : TeaModel {
        [NameInMap("aggregate")]
        [Validation(Required=false)]
        public string Aggregate { get; set; }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.</para>
        /// <para>Specifies whether to perform alert detection only after data is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.  </para>
        /// <para>The list of filter dimensions for the resource.</para>
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
        /// <para>Applicable query type: PROMQL_QUERY.</para>
        /// <para>The duration for which alert data persists. Unit: seconds.</para>
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
        /// <para>Applicable query type: PROMQL_QUERY.</para>
        /// <para>The query expression (PromQL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum(sum(max_over_time(kube_pod_status_phase{phase=~\&quot;Pending\&quot;,job=\&quot;_kube-state-metrics\&quot;}[5m])) by (pod)) &gt; 1000</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>The set join operation configuration for the results of subquery 1 (queries[0]) and subquery 2 (queries[1]).</para>
        /// </summary>
        [NameInMap("firstJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin FirstJoin { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>The list of group field names.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// <para>The ID of the associated application group. This parameter takes effect only when relationType is set to GROUP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23423</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>The group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>none: no grouping.</description></item>
        /// <item><description>label: automatic label-based grouping.</description></item>
        /// <item><description>custom: custom label-based grouping.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>label</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>The array of label filters.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<AlertRuleQueryLabelFilters> LabelFilters { get; set; }
        public class AlertRuleQueryLabelFilters : TeaModel {
            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The comparison operator that determines how to match the label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>=</para>
            /// </summary>
            [NameInMap("operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("logSet")]
        [Validation(Required=false)]
        public string LogSet { get; set; }

        [NameInMap("markTags")]
        [Validation(Required=false)]
        public List<AlertRuleQueryMarkTags> MarkTags { get; set; }
        public class AlertRuleQueryMarkTags : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

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
        /// <para>The collection of monitoring metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_usage</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// <para>The namespace of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("offsetSecs")]
        [Validation(Required=false)]
        public long? OffsetSecs { get; set; }

        /// <summary>
        /// <para>Applicable query types: SLS_MULTI_QUERY and APM_MULTI_QUERY.</para>
        /// <para>The list of subqueries.</para>
        /// <para>For the SLS_MULTI_QUERY query type, a maximum of three subqueries are supported. The number and order of subqueries must match the sub-datasource config in datasource.dsList.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<AlertRuleQueryQueries> Queries { get; set; }
        public class AlertRuleQueryQueries : TeaModel {
            /// <summary>
            /// <para>Applicable query type: APM_MULTI_QUERY.</para>
            /// <para>The ID of the APM predefined metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstat.jvm.ThreadNewCount</para>
            /// </summary>
            [NameInMap("apmAlertMetricId")]
            [Validation(Required=false)]
            public string ApmAlertMetricId { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.</para>
            /// <para>The dimension filter configuration for the APM metric. Must be used together with apmAlertMetricId.</para>
            /// </summary>
            [NameInMap("apmFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesApmFilters> ApmFilters { get; set; }
            public class AlertRuleQueryQueriesApmFilters : TeaModel {
                /// <summary>
                /// <para>The dimension in the APM metric.</para>
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
                /// <item><description>eq: equal to</description></item>
                /// <item><description>neq: not equal to</description></item>
                /// <item><description>match: regex match</description></item>
                /// <item><description>nmatch: regex not match</description></item>
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
            /// <para>Applicable query type: ARMS_MULTI_QUERY.</para>
            /// <para>The list of aggregation dimensions for the query, specifying which metric dimensions to aggregate by.</para>
            /// </summary>
            [NameInMap("apmGroupBy")]
            [Validation(Required=false)]
            public List<string> ApmGroupBy { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.</para>
            /// <para>The alert data duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The relative time offset end time.</para>
            /// <para>If start and end are specified, do not specify window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Applicable query types: APM_MULTI_QUERY, SLS_MULTI_QUERY.</para>
            /// <para>The query expression.</para>
            /// <list type="bullet">
            /// <item><description>For APM_MULTI_QUERY, this field is optional and contains the PromQL generated for predefined metrics (used for data preview).</description></item>
            /// <item><description>For SLS_MULTI_QUERY, this field contains the SQL query statement.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sum by (rpc,acs_arms_service_id,pid,rpcType) (sum_over_time_lorc(arms_app_requests_count_ign_destid_endpoint_parent_ppid_prpc{callKind=~\&quot;http|rpc|custom_entry|server|consumer\&quot;,pid=\&quot;gaddp9ap8q@cb005ffdf44b8ac\&quot;,source=\&quot;apm\&quot;}[1m]))</para>
            /// </summary>
            [NameInMap("expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            [NameInMap("labelFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesLabelFilters> LabelFilters { get; set; }
            public class AlertRuleQueryQueriesLabelFilters : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("metric")]
            [Validation(Required=false)]
            public string Metric { get; set; }

            [NameInMap("metricSet")]
            [Validation(Required=false)]
            public string MetricSet { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("promQl")]
            [Validation(Required=false)]
            public string PromQl { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The relative time offset start time for the SLS query.</para>
            /// <para>If start and end are specified, do not specify window. Example: start=15, timeUnit=minute indicates 15 minutes ago.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The time unit for the start, end, and window parameters: day/hour/minute/second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The time frame query interval. If window is specified, do not specify start or end.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public long? Window { get; set; }

        }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// <para>The resource scope of the rule query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER: all resources under the user UID.</description></item>
        /// <item><description>GROUP: application group.</description></item>
        /// <item><description>INSTANCE: specified instance list.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>The set join operation configuration for the results of subquery 2 (queries[2]) and subquery 3 (queries[3]).</para>
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
        /// <para>The query type. </para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROMQL_QUERY: PromQL query.</description></item>
        /// <item><description>SLS_MULTI_QUERY: SLS query.</description></item>
        /// <item><description>APM_MULTI_QUERY: APM query.</description></item>
        /// <item><description>CMS_BASIC_QUERY: basic cloud service monitoring query.</description></item>
        /// </list>
        /// <para>Different query types use different valid fields in the query object. For more information, see the &quot;Applicable query type&quot; description of each field.</para>
        /// <para>The query type must match the data source type. The mappings are as follows:</para>
        /// <list type="bullet">
        /// <item><description>Prometheus data source (PROMETHEUS_DS): PROMQL_QUERY</description></item>
        /// <item><description>APM data source (APM_DS): APM_MULTI_QUERY</description></item>
        /// <item><description>SLS data source (SLS_MULTI_DS): SLS_MULTI_QUERY</description></item>
        /// <item><description>Basic cloud service monitoring data source (CMS_BASIC_DS): CMS_BASIC_QUERY</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMQL_QUERY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("windowSecs")]
        [Validation(Required=false)]
        public long? WindowSecs { get; set; }

    }

}
