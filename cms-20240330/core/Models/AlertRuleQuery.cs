// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleQuery : TeaModel {
        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.</para>
        /// <para>Specifies whether to run the alert check only after the data is complete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// <para>A list of filter dimensions for the resource.</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>The realm to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rum</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.</para>
        /// <para>The duration for which the alert data persists, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>An array of entity field filters.</para>
        /// </summary>
        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<AlertRuleQueryEntityFields> EntityFields { get; set; }
        public class AlertRuleQueryEntityFields : TeaModel {
            /// <summary>
            /// <para>The name of the entity field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instanceId</para>
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The value of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-abc123</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>A resource filter used to screen target resources.</para>
        /// </summary>
        [NameInMap("entityFilter")]
        [Validation(Required=false)]
        public AlertRuleQueryEntityFilter EntityFilter { get; set; }
        public class AlertRuleQueryEntityFilter : TeaModel {
            /// <summary>
            /// <para>The domain of the resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rum</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>A list of filter conditions to further screen resources.</para>
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
                /// <para>The value to match.</para>
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
        /// <para>The configuration for the join operation on the result sets of subquery 1 (queries[0]) and subquery 2 (queries[1]).</para>
        /// </summary>
        [NameInMap("firstJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin FirstJoin { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>A list of grouping field names.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.</para>
        /// <para>The ID of the associated application group. This parameter is valid only when relationType is set to GROUP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23423</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
        /// <para>The grouping type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>none: No grouping.</para>
        /// </description></item>
        /// <item><description><para>label: Automatic grouping by tag.</para>
        /// </description></item>
        /// <item><description><para>custom: Custom grouping by tag.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>label</para>
        /// </summary>
        [NameInMap("groupType")]
        [Validation(Required=false)]
        public string GroupType { get; set; }

        /// <summary>
        /// <para>An array of label filters.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<AlertRuleQueryLabelFilters> LabelFilters { get; set; }
        public class AlertRuleQueryLabelFilters : TeaModel {
            /// <summary>
            /// <para>The name of the label.</para>
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
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        /// <para>The name of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The collection of metrics.</para>
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

        /// <summary>
        /// <para>Applicable query types: SLS_MULTI_QUERY and APM_MULTI_QUERY.</para>
        /// <para>A list of subqueries.</para>
        /// <para>For the SLS_MULTI_QUERY type, you can include up to three subqueries. The number and order of subqueries must match the sub-datasource configurations in datasource.dsList.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<AlertRuleQueryQueries> Queries { get; set; }
        public class AlertRuleQueryQueries : TeaModel {
            /// <summary>
            /// <para>Applicable query type: APM_MULTI_QUERY.</para>
            /// <para>The ID of the predefined Application Performance Management (APM) metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstat.jvm.ThreadNewCount</para>
            /// </summary>
            [NameInMap("apmAlertMetricId")]
            [Validation(Required=false)]
            public string ApmAlertMetricId { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.</para>
            /// <para>The dimension filter configuration for the APM metric. This parameter must be used with apmAlertMetricId.</para>
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
                /// <para>The filter operation type:</para>
                /// <list type="bullet">
                /// <item><description><para>eq: Equal to</para>
                /// </description></item>
                /// <item><description><para>neq: Not equal to</para>
                /// </description></item>
                /// <item><description><para>match: Regular expression match</para>
                /// </description></item>
                /// <item><description><para>nmatch: Regular expression non-match</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value that corresponds to the filter operation.</para>
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
            /// <para>A list of aggregation dimensions for the query. This specifies the metric dimensions to use for aggregation.</para>
            /// </summary>
            [NameInMap("apmGroupBy")]
            [Validation(Required=false)]
            public List<string> ApmGroupBy { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.</para>
            /// <para>The duration of the alert data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The relative end time of the time offset.</para>
            /// <para>If you specify start and end, do not specify window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Applicable query types: APM_MULTI_QUERY and SLS_MULTI_QUERY.</para>
            /// <para>The query expression.</para>
            /// <list type="bullet">
            /// <item><description><para>For APM_MULTI_QUERY, this parameter is optional. It is the PromQL expression generated for a predefined metric, used for data preview.</para>
            /// </description></item>
            /// <item><description><para>For SLS_MULTI_QUERY, this parameter is the SQL search statement.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sum by (rpc,acs_arms_service_id,pid,rpcType) (sum_over_time_lorc(arms_app_requests_count_ign_destid_endpoint_parent_ppid_prpc{callKind=~\&quot;http|rpc|custom_entry|server|consumer\&quot;,pid=\&quot;gaddp9ap8q@cb005ffdf44b8ac\&quot;,source=\&quot;apm\&quot;}[1m]))</para>
            /// </summary>
            [NameInMap("expr")]
            [Validation(Required=false)]
            public string Expr { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("promQl")]
            [Validation(Required=false)]
            public string PromQl { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The relative start time of the time offset for an SLS query.</para>
            /// <para>If you specify start and end, do not specify window. For example, if start is 15 and timeUnit is minute, the time offset starts 15 minutes ago.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The time unit for the start, end, and window parameters. Valid values: day, hour, minute, and second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.</para>
            /// <para>The query interval for a time frame. If you specify window, do not specify start and end.</para>
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
        /// <para>The resource scope for the rule query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>USER: All resources under the user ID.</para>
        /// </description></item>
        /// <item><description><para>GROUP: An application group.</para>
        /// </description></item>
        /// <item><description><para>INSTANCE: A list of specified instances.</para>
        /// </description></item>
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
        /// <para>The configuration for the join operation on the result sets of subquery 2 (queries[2]) and subquery 3 (queries[3]).</para>
        /// </summary>
        [NameInMap("secondJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin SecondJoin { get; set; }

        /// <summary>
        /// <para>A list of service IDs.</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// <para>The query type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PROMQL_QUERY: A PromQL query.</para>
        /// </description></item>
        /// <item><description><para>SLS_MULTI_QUERY: A Simple Log Service (SLS) query.</para>
        /// </description></item>
        /// <item><description><para>APM_MULTI_QUERY: An APM query.</para>
        /// </description></item>
        /// <item><description><para>CMS_BASIC_QUERY: A basic CloudMonitor query.</para>
        /// </description></item>
        /// </list>
        /// <para>Different query types have different valid parameters in the query object. For more information, see the &quot;Applicable query type&quot; description for each parameter.</para>
        /// <para>The query type must match the data source type. The mappings are as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>Prometheus data source (PROMETHEUS_DS): PROMQL_QUERY</para>
        /// </description></item>
        /// <item><description><para>APM data source (APM_DS): APM_MULTI_QUERY</para>
        /// </description></item>
        /// <item><description><para>SLS data source (SLS_MULTI_DS): SLS_MULTI_QUERY</para>
        /// </description></item>
        /// <item><description><para>Basic CloudMonitor data source (CMS_BASIC_DS): CMS_BASIC_QUERY</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMQL_QUERY</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
