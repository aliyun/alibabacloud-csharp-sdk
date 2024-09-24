// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeHybridMonitorTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// <list type="bullet">
        /// <item><description>If the request was successful, the value <c>successful</c> is returned.</description></item>
        /// <item><description>If the request failed, an error message is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11145B76-566A-5D80-A8A3-FAD98D310079</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The metric import tasks.</para>
        /// </summary>
        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<DescribeHybridMonitorTaskListResponseBodyTaskList> TaskList { get; set; }
        public class DescribeHybridMonitorTaskListResponseBodyTaskList : TeaModel {
            /// <summary>
            /// <para>The tags of the metric import task.</para>
            /// </summary>
            [NameInMap("AttachLabels")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels> AttachLabels { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListAttachLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The interval at which the CloudMonitor agent collects host monitoring data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>15</description></item>
            /// <item><description>30</description></item>
            /// <item><description>60</description></item>
            /// </list>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("CollectInterval")]
            [Validation(Required=false)]
            public int? CollectInterval { get; set; }

            /// <summary>
            /// <para>The URL of the destination from which the CloudMonitor agent collects host monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://localhost">http://localhost</a></para>
            /// </summary>
            [NameInMap("CollectTargetEndpoint")]
            [Validation(Required=false)]
            public string CollectTargetEndpoint { get; set; }

            /// <summary>
            /// <para>The relative path from which the CloudMonitor agent collects monitoring data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/metrics</para>
            /// </summary>
            [NameInMap("CollectTargetPath")]
            [Validation(Required=false)]
            public string CollectTargetPath { get; set; }

            /// <summary>
            /// <para>The type of the monitoring data. Valid values: Spring, Tomcat, Nginx, Tengine, JVM, Redis, and MySQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nginx</para>
            /// </summary>
            [NameInMap("CollectTargetType")]
            [Validation(Required=false)]
            public string CollectTargetType { get; set; }

            /// <summary>
            /// <para>The timeout period during which the CloudMonitor agent collects host monitoring data. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0</description></item>
            /// <item><description>15</description></item>
            /// <item><description>30</description></item>
            /// <item><description>60</description></item>
            /// </list>
            /// <para>Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("CollectTimout")]
            [Validation(Required=false)]
            public int? CollectTimout { get; set; }

            /// <summary>
            /// <para>The timestamp when the metric import task was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639382496000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the metric import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The additional information of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>The ID of the application group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3607****</para>
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// <para>The instances where monitoring data is collected in batches.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>C:\UserData\log\*.Log</para>
            /// </summary>
            [NameInMap("LogFilePath")]
            [Validation(Required=false)]
            public string LogFilePath { get; set; }

            /// <summary>
            /// <para>The method that is used to aggregate on-premises log data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;metric&quot;: &quot;metric1&quot;,&quot;filters&quot;: [{&quot;column&quot;: &quot;filed2&quot;,&quot;type&quot;: &quot;include&quot;,&quot;values&quot;: [&quot;222222&quot;]}],&quot;groupBys&quot;: [{&quot;column&quot;: &quot;filed3&quot;,&quot;name&quot;: &quot;filed3&quot;}],&quot;calculates&quot;: [{&quot;column&quot;: &quot;field1&quot;,&quot;name&quot;: &quot;avg&quot;,&quot;type&quot;: &quot;avg&quot;}]},{&quot;metric&quot;: &quot;metric2&quot;,&quot;filters&quot;: [{&quot;column&quot;: &quot;field1&quot;,&quot;type&quot;: &quot;include&quot;,&quot;values&quot;: [&quot;11111&quot;]}],&quot;groupBys&quot;: [{&quot;column&quot;: &quot;filed2&quot;,&quot;name&quot;: &quot;filed2&quot;}],&quot;calculates&quot;: [{&quot;column&quot;: &quot;field1&quot;,&quot;name&quot;: &quot;avg&quot;,&quot;type&quot;: &quot;avg&quot;}]}]</para>
            /// </summary>
            [NameInMap("LogProcess")]
            [Validation(Required=false)]
            public string LogProcess { get; set; }

            /// <summary>
            /// <para>The sample on-premises log.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;logContent&quot;:&quot;100.116.134.26 1119 - [13/Aug/2019:16:55:46 +0800] POST metrichub-cn-hongkong.aliyun.com /agent/metrics/putLines 200 0 \&quot;-\&quot; \&quot;127.0.0.1:7001\&quot; \&quot;Go-http-client/1.1\&quot; \&quot;-\&quot; \&quot;-\&quot; \&quot;0a98a21a15656865460656276e\&quot;&quot;,&quot;addData&quot;:{&quot;field1&quot;:[&quot;1119&quot;,&quot;1119&quot;],&quot;filed2&quot;:[&quot;POSTx&quot;,&quot;POST&quot;],&quot;filed3&quot;:[&quot;true&quot;,&quot;200&quot;]}}</para>
            /// </summary>
            [NameInMap("LogSample")]
            [Validation(Required=false)]
            public string LogSample { get; set; }

            /// <summary>
            /// <para>The result that is returned after on-premises log data is split based on the specified matching mode.</para>
            /// <remarks>
            /// <para>The matching modes of on-premises log data include full regex mode, delimiter mode, and JSON mode.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;type&quot;: &quot;regex&quot;,&quot;regex&quot;: &quot;\\d+\\.\\d+\\.\\d+\\.\\d+\\s+(\\d+)\\s+\\S+\\s+[\\d+/\\S+/\\d+:\\d+:\\d+:\\d+\\s+\\+\\d+\\]\\s+(\\S+)\\s+\\S+\\s+/\\S+/\\S+/\\S+\\s+(\\d+)&quot;,&quot;columns&quot;: [{&quot;name&quot;: &quot;field1&quot;},{&quot;name&quot;: &quot;filed2&quot;,&quot;translate&quot;: {&quot;default&quot;: &quot;-&quot;,&quot;mappings&quot;: [{&quot;from&quot;: &quot;(\\w+)&quot;,&quot;to&quot;: &quot;$1x&quot;,&quot;type&quot;: &quot;regex&quot;}]}},{&quot;name&quot;: &quot;filed3&quot;,&quot;translate&quot;: {&quot;default&quot;: &quot;-&quot;,&quot;mappings&quot;: [{&quot;from&quot;: &quot;NumberRange(100,300)&quot;,&quot;to&quot;: &quot;true&quot;,&quot;type&quot;: &quot;function&quot;}]}}]}</para>
            /// </summary>
            [NameInMap("LogSplit")]
            [Validation(Required=false)]
            public string LogSplit { get; set; }

            /// <summary>
            /// <para>The conditions that are used to match the instances in the application group.</para>
            /// </summary>
            [NameInMap("MatchExpress")]
            [Validation(Required=false)]
            public List<DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress> MatchExpress { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListMatchExpress : TeaModel {
                /// <summary>
                /// <para>The method that is used to match the instance name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>startWith: starts with a prefix</description></item>
                /// <item><description>endWith: ends with a suffix</description></item>
                /// <item><description>all: matches all</description></item>
                /// <item><description>equals: equals</description></item>
                /// <item><description>contains: contains</description></item>
                /// <item><description>notContains: does not contain</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The keyword that corresponds to the instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ECS_instance1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The relationship between the conditions that are used to filter metric import tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>or</description></item>
            /// <item><description>and</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>or</para>
            /// </summary>
            [NameInMap("MatchExpressRelation")]
            [Validation(Required=false)]
            public string MatchExpressRelation { get; set; }

            /// <summary>
            /// <para>The namespace to which the host belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The network type of the host. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>vpc</c></description></item>
            /// <item><description><c>Internet</c></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("NetworkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

            /// <summary>
            /// <para>The configurations of the logs that are imported from Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;express&quot;: [],&quot;filter&quot;: {&quot;filters&quot;: [{&quot;key&quot;: &quot;task_type&quot;,&quot;operator&quot;: &quot;=&quot;,&quot;value&quot;: &quot;1&quot;}]},&quot;groupby&quot;: [{&quot;alias&quot;: &quot;isp&quot;,&quot;key&quot;: &quot;isp&quot;,&quot;sqlKey&quot;: &quot;t.<c>isp</c>&quot;,&quot;valueKey&quot;: &quot;isp&quot;}],&quot;interval&quot;: 60,&quot;labels&quot;: [{&quot;name&quot;: &quot;<b>cms_app</b>&quot;,&quot;type&quot;: 0,&quot;value&quot;: &quot;sitemonitor&quot;}],&quot;statistics&quot;: [{&quot;alias&quot;: &quot;http_dns_time_avg&quot;,&quot;function&quot;: &quot;avg&quot;,&quot;key&quot;: &quot;http_dns_time&quot;}]}</para>
            /// </summary>
            [NameInMap("SLSProcess")]
            [Validation(Required=false)]
            public string SLSProcess { get; set; }

            /// <summary>
            /// <para>The configurations of the logs that are imported from Log Service.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the <c>TaskType</c> parameter is set to <c>aliyun_sls</c>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("SLSProcessConfig")]
            [Validation(Required=false)]
            public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig SLSProcessConfig { get; set; }
            public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfig : TeaModel {
                /// <summary>
                /// <para>The extended fields that indicate the results of basic operations that are performed on aggregation results.</para>
                /// </summary>
                [NameInMap("Express")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress> Express { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigExpress : TeaModel {
                    /// <summary>
                    /// <para>The alias of the extended field that indicates the result of basic operations that are performed on aggregation results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SuccRate</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The extended field that indicates the result of basic operations that are performed on aggregation results.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>success_count</para>
                    /// </summary>
                    [NameInMap("Express")]
                    [Validation(Required=false)]
                    public string Express { get; set; }

                }

                /// <summary>
                /// <para>The conditions that are used to filter logs imported from Log Service.</para>
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter Filter { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilter : TeaModel {
                    /// <summary>
                    /// <para>The conditions that are used to filter logs imported from Log Service.</para>
                    /// </summary>
                    [NameInMap("Filters")]
                    [Validation(Required=false)]
                    public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters> Filters { get; set; }
                    public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigFilterFilters : TeaModel {
                        /// <summary>
                        /// <para>The method that is used to filter logs imported from Log Service. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><c>contain</c>: contains</description></item>
                        /// <item><description><c>notContain</c>: does not contain</description></item>
                        /// <item><description><c>&gt;</c>: greater than</description></item>
                        /// <item><description><c>&lt;</c>: less than</description></item>
                        /// <item><description><c>=</c>: equal to</description></item>
                        /// <item><description><c>! =</c>: not equal to</description></item>
                        /// <item><description><c>&gt;=</c>: greater than or equal to</description></item>
                        /// <item><description><c>&lt;=</c>: less than or equal to</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>=</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The name of the key that is used to filter logs imported from Log Service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>host</para>
                        /// </summary>
                        [NameInMap("SLSKeyName")]
                        [Validation(Required=false)]
                        public string SLSKeyName { get; set; }

                        /// <summary>
                        /// <para>The value of the key that is used to filter logs imported from Log Service.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>200</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The relationship between multiple filter conditions. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>and (default): Logs are processed only if all filter conditions are met.</description></item>
                    /// <item><description>or: Logs are processed if one of the filter conditions is met.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>and</para>
                    /// </summary>
                    [NameInMap("Relation")]
                    [Validation(Required=false)]
                    public string Relation { get; set; }

                }

                /// <summary>
                /// <para>The dimensions based on which data is aggregated. This parameter is equivalent to the GROUP BY clause in SQL.</para>
                /// </summary>
                [NameInMap("GroupBy")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy> GroupBy { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigGroupBy : TeaModel {
                    /// <summary>
                    /// <para>The alias of the aggregation result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ApiResult</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The name of the key that is used to aggregate logs imported from Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>code</para>
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

                /// <summary>
                /// <para>The methods that are used to aggregate logs imported from Log Service.</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public List<DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics> Statistics { get; set; }
                public class DescribeHybridMonitorTaskListResponseBodyTaskListSLSProcessConfigStatistics : TeaModel {
                    /// <summary>
                    /// <para>The alias of the aggregation result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>level_count</para>
                    /// </summary>
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    /// <summary>
                    /// <para>The function that is used to aggregate log data within a statistical period. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>count: counts the number.</description></item>
                    /// <item><description>sum: calculates the total value.</description></item>
                    /// <item><description>avg: calculates the average value.</description></item>
                    /// <item><description>max: calculates the maximum value.</description></item>
                    /// <item><description>min: calculates the minimum value.</description></item>
                    /// <item><description>value: collects samples within the statistical period.</description></item>
                    /// <item><description>countps: calculates the average number of the specified field per second by using the following formula: Counted number of the specified field/Total number of seconds within the statistical period.</description></item>
                    /// <item><description>sumps: calculates the average number of the specified field per second by using the following formula: Total value of the specified field/Total number of seconds within the statistical period.</description></item>
                    /// <item><description>distinct: counts the number of logs where the specified field appears within the statistical period.</description></item>
                    /// <item><description>distribution: counts the number of logs that meet a specified condition within the statistical period.</description></item>
                    /// <item><description>percentile: sorts the values of the specified field in ascending order, and then returns the value that is at the specified percentile within the statistical period. Example: P50.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>count</para>
                    /// </summary>
                    [NameInMap("Function")]
                    [Validation(Required=false)]
                    public string Function { get; set; }

                    /// <summary>
                    /// <para>The value of the function that is used to aggregate logs imported from Log Service.</para>
                    /// <list type="bullet">
                    /// <item><description>If the <c>Function</c> parameter is set to <c>distribution</c>, this parameter indicates the lower limit of the statistical interval. For example, 200 indicates that the number of HTTP requests whose status code is 2XX is calculated.</description></item>
                    /// <item><description>If the <c>Function</c> parameter is set to <c>percentile</c>, this parameter specifies the percentile at which the expected value is. For example, 0.5 specifies P50.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Parameter1")]
                    [Validation(Required=false)]
                    public string Parameter1 { get; set; }

                    /// <summary>
                    /// <para>The value of the function that is used to aggregate logs imported from Log Service.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only if the <c>Function</c> parameter is set to <c>distribution</c>. This parameter indicates the upper limit of the statistical interval. For example, 299 indicates that the number of HTTP requests whose status code is 2XX is calculated.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>299</para>
                    /// </summary>
                    [NameInMap("Parameter2")]
                    [Validation(Required=false)]
                    public string Parameter2 { get; set; }

                    /// <summary>
                    /// <para>The name of the key that is used to aggregate logs imported from Log Service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the member account.</para>
            /// <remarks>
            /// <para>This parameter is displayed only when you call this operation by using a management account.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>120886317861****</para>
            /// </summary>
            [NameInMap("TargetUserId")]
            [Validation(Required=false)]
            public string TargetUserId { get; set; }

            /// <summary>
            /// <para>The ID of the metric import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>36****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the metric import task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_task</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the metric import task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>aliyun_fc: metric import tasks for Alibaba Cloud services</description></item>
            /// <item><description>aliyun_sls: metrics for logs imported from Log Service</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>aliyun_sls</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The region where the host resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("UploadRegion")]
            [Validation(Required=false)]
            public string UploadRegion { get; set; }

            /// <summary>
            /// <para>The configuration file of the Alibaba Cloud service that you want to monitor by using Hybrid Cloud Monitoring.</para>
            /// <list type="bullet">
            /// <item><description>namespace: the namespace of the Alibaba Cloud service.</description></item>
            /// <item><description>metric_list: the metrics of the Alibaba Cloud service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>products:- namespace: acs_ecs_dashboard metric_info: - metric_list: - cpu_total</para>
            /// </summary>
            [NameInMap("YARMConfig")]
            [Validation(Required=false)]
            public string YARMConfig { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
