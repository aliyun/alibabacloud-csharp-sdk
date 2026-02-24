// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleQuery : TeaModel {
        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.
        /// Whether to perform alert evaluation only after data completeness is ensured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("checkAfterDataComplete")]
        [Validation(Required=false)]
        public bool? CheckAfterDataComplete { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.
        /// List of filtering dimensions for the resource.</para>
        /// </summary>
        [NameInMap("dimensions")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> Dimensions { get; set; }

        /// <summary>
        /// <para>资源所属的领域。</para>
        /// 
        /// <b>Example:</b>
        /// <para>rum</para>
        /// </summary>
        [NameInMap("domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.
        /// Duration of alert data, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("entityFields")]
        [Validation(Required=false)]
        public List<AlertRuleQueryEntityFields> EntityFields { get; set; }
        public class AlertRuleQueryEntityFields : TeaModel {
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>资源过滤器，用于筛选目标资源。</para>
        /// </summary>
        [NameInMap("entityFilter")]
        [Validation(Required=false)]
        public AlertRuleQueryEntityFilter EntityFilter { get; set; }
        public class AlertRuleQueryEntityFilter : TeaModel {
            /// <summary>
            /// <para>资源类型域。</para>
            /// 
            /// <b>Example:</b>
            /// <para>rum</para>
            /// </summary>
            [NameInMap("domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>过滤条件列表，用于进一步筛选资源。</para>
            /// </summary>
            [NameInMap("filters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryEntityFilterFilters> Filters { get; set; }
            public class AlertRuleQueryEntityFilterFilters : TeaModel {
                /// <summary>
                /// <para>字段</para>
                /// 
                /// <b>Example:</b>
                /// <para>instanceId</para>
                /// </summary>
                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>比较运算符。</para>
                /// 
                /// <b>Example:</b>
                /// <para>=</para>
                /// </summary>
                [NameInMap("operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>匹配的值。</para>
                /// 
                /// <b>Example:</b>
                /// <para>wait_throw</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>资源类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>apm</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Applicable query type: PROMQL_QUERY.
        /// Query expression (PromQL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sum(sum(max_over_time(kube_pod_status_phase{phase=~\&quot;Pending\&quot;,job=\&quot;_kube-state-metrics\&quot;}[5m])) by (pod)) &gt; 1000</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.
        /// Configuration for the set join operation between the results of subquery 1 (queries[0]) and subquery 2 (queries[1]).</para>
        /// </summary>
        [NameInMap("firstJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin FirstJoin { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.
        /// List of grouping field names.</para>
        /// </summary>
        [NameInMap("groupFieldList")]
        [Validation(Required=false)]
        public List<string> GroupFieldList { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.
        /// Associated application group ID, valid only when relationType = GROUP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23423</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.
        /// Grouping type, with the following possible values:</para>
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

        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<AlertRuleQueryLabelFilters> LabelFilters { get; set; }
        public class AlertRuleQueryLabelFilters : TeaModel {
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

        /// <summary>
        /// <para>指标名。</para>
        /// 
        /// <b>Example:</b>
        /// <para>memory</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>监控指标集合。</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_usage</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.
        /// Namespace of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Applicable query types: SLS_MULTI_QUERY, APM_MULTI_QUERY.
        /// List of subqueries.</para>
        /// <para>For the SLS_MULTI_QUERY type, the list can contain up to three subqueries, and the number and order of subqueries must match the sub-datasource configurations in datasource.dsList.</para>
        /// </summary>
        [NameInMap("queries")]
        [Validation(Required=false)]
        public List<AlertRuleQueryQueries> Queries { get; set; }
        public class AlertRuleQueryQueries : TeaModel {
            /// <summary>
            /// <para>Applicable query type: APM_MULTI_QUERY.
            /// ID of the APM predefined metric.</para>
            /// 
            /// <b>Example:</b>
            /// <para>appstat.jvm.ThreadNewCount</para>
            /// </summary>
            [NameInMap("apmAlertMetricId")]
            [Validation(Required=false)]
            public string ApmAlertMetricId { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.
            /// Dimension filter configuration for APM metrics. Must be used in conjunction with apmAlertMetricId.</para>
            /// </summary>
            [NameInMap("apmFilters")]
            [Validation(Required=false)]
            public List<AlertRuleQueryQueriesApmFilters> ApmFilters { get; set; }
            public class AlertRuleQueryQueriesApmFilters : TeaModel {
                /// <summary>
                /// <para>Dimension in APM metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rpcType</para>
                /// </summary>
                [NameInMap("dim")]
                [Validation(Required=false)]
                public string Dim { get; set; }

                /// <summary>
                /// <para>Filter operation types:</para>
                /// <list type="bullet">
                /// <item><description>eq: equals.</description></item>
                /// <item><description>neq: not equals.</description></item>
                /// <item><description>match: regular expression match.</description></item>
                /// <item><description>nmatch: regular expression not match.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>eq</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The corresponding value for the filter operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>h3ji7a0y9i@2ac80e27fdfd0a2</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.
            /// List of aggregation dimensions for the query, i.e., the dimensions by which the metric is aggregated.</para>
            /// </summary>
            [NameInMap("apmGroupBy")]
            [Validation(Required=false)]
            public List<string> ApmGroupBy { get; set; }

            /// <summary>
            /// <para>Applicable query type: ARMS_MULTI_QUERY.
            /// Alert (data) duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.
            /// Time offset end time (relative).
            /// If start and end are specified, do not specify window.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("end")]
            [Validation(Required=false)]
            public long? End { get; set; }

            /// <summary>
            /// <para>Applicable query types: APM_MULTI_QUERY, SLS_MULTI_QUERY.
            /// Query expression.</para>
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

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.
            /// SLS query time offset start time (relative).
            /// If start and end are specified, do not specify window. For example: start=15, timeUnit=minute, which means 15 minutes ago.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("start")]
            [Validation(Required=false)]
            public long? Start { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.
            /// Time units for the start, end, and window parameters: day/hour/minute/second.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hour</para>
            /// </summary>
            [NameInMap("timeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

            /// <summary>
            /// <para>Applicable query type: SLS_MULTI_QUERY.
            /// Exact-hour time query interval. If window is specified, start and end should not be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("window")]
            [Validation(Required=false)]
            public long? Window { get; set; }

        }

        /// <summary>
        /// <para>Applicable query type: CMS_BASIC_QUERY.
        /// Resource scope for the rule query, with the following allowed values:</para>
        /// <list type="bullet">
        /// <item><description>USER: All resources under the user\&quot;s UID.</description></item>
        /// <item><description>GROUP: Application group.</description></item>
        /// <item><description>INSTANCE: Specified list of instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("relationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        /// <summary>
        /// <para>Applicable query type: SLS_MULTI_QUERY.
        /// Configuration for the set join operation between the results of subquery 2 (queries[2]) and subquery 3 (queries[3]).</para>
        /// </summary>
        [NameInMap("secondJoin")]
        [Validation(Required=false)]
        public AlertRuleSlsQueryJoin SecondJoin { get; set; }

        /// <summary>
        /// <para>Service ID list.</para>
        /// </summary>
        [NameInMap("serviceIds")]
        [Validation(Required=false)]
        public List<string> ServiceIds { get; set; }

        /// <summary>
        /// <para>Query type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROMQL_QUERY: PromQL query</description></item>
        /// <item><description>SLS_MULTI_QUERY: SLS query</description></item>
        /// <item><description>APM_MULTI_QUERY: APM query</description></item>
        /// <item><description>CMS_BASIC_QUERY: Basic CloudMonitor query</description></item>
        /// </list>
        /// <para>The valid fields within the query object vary depending on the query type. Refer to the &quot;Applicable query type&quot; description in each field\&quot;s documentation for details.</para>
        /// <para>The query type must match the data source type, with the following correspondences:</para>
        /// <list type="bullet">
        /// <item><description>Prometheus data source (PROMETHEUS_DS): PROMQL_QUERY</description></item>
        /// <item><description>APM data source (APM_DS): APM_MULTI_QUERY</description></item>
        /// <item><description>SLS data source (SLS_MULTI_DS): SLS_MULTI_QUERY</description></item>
        /// <item><description>Basic CloudMonitor data source (CMS_BASIC_DS): CMS_BASIC_QUERY.</description></item>
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
