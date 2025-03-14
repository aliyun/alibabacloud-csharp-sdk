// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryComponentPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BCE45E6D-9304-4F94-86BB-5A772B1615FF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryComponentPerformanceResponseBodyResult> Result { get; set; }
        public class QueryComponentPerformanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The average duration of cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("CacheCostTimeAvg")]
            [Validation(Required=false)]
            public double? CacheCostTimeAvg { get; set; }

            /// <summary>
            /// <para>The number of cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CacheQueryCount")]
            [Validation(Required=false)]
            public int? CacheQueryCount { get; set; }

            /// <summary>
            /// <para>The component ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0696083a-ca72-4d89-8e7a-c017910e0***</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>The name of the add-on.</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>The average query duration associated with the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("CostTimeAvg")]
            [Validation(Required=false)]
            public double? CostTimeAvg { get; set; }

            /// <summary>
            /// <para>The number of queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public int? QueryCount { get; set; }

            /// <summary>
            /// <para>The average number of queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QueryCountAvg")]
            [Validation(Required=false)]
            public double? QueryCountAvg { get; set; }

            /// <summary>
            /// <para>The query exceeds the 5S number of queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QueryOverFivePercentNum")]
            [Validation(Required=false)]
            public double? QueryOverFivePercentNum { get; set; }

            /// <summary>
            /// <para>Query the proportion of more than 5S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QueryOverFiveSecPercent")]
            [Validation(Required=false)]
            public string QueryOverFiveSecPercent { get; set; }

            /// <summary>
            /// <para>The percentage of queries that exceed 10s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QueryOverTenSecPercent")]
            [Validation(Required=false)]
            public string QueryOverTenSecPercent { get; set; }

            /// <summary>
            /// <para>The percentage of queries that exceed 10s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QueryOverTenSecPercentNum")]
            [Validation(Required=false)]
            public double? QueryOverTenSecPercentNum { get; set; }

            /// <summary>
            /// <para>The number of times that the chart query times out.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QueryTimeoutCount")]
            [Validation(Required=false)]
            public int? QueryTimeoutCount { get; set; }

            /// <summary>
            /// <para>The percentage of timeout times for chart queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QueryTimeoutCountPercent")]
            [Validation(Required=false)]
            public double? QueryTimeoutCountPercent { get; set; }

            /// <summary>
            /// <para>The average time consumed by the Quick engine query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("QuickIndexCostTimeAvg")]
            [Validation(Required=false)]
            public double? QuickIndexCostTimeAvg { get; set; }

            /// <summary>
            /// <para>The number of times that the Quick engine is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("QuickIndexQueryCount")]
            [Validation(Required=false)]
            public int? QuickIndexQueryCount { get; set; }

            /// <summary>
            /// <para>The proportion of duplicate queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("RepeatQueryPercent")]
            [Validation(Required=false)]
            public string RepeatQueryPercent { get; set; }

            /// <summary>
            /// <para>The number of duplicate queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RepeatQueryPercentNum")]
            [Validation(Required=false)]
            public double? RepeatQueryPercentNum { get; set; }

            /// <summary>
            /// <para>The number of times the query is repeated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryCount")]
            [Validation(Required=false)]
            public int? RepeatSqlQueryCount { get; set; }

            /// <summary>
            /// <para>The proportion of duplicate queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryPercent")]
            [Validation(Required=false)]
            public string RepeatSqlQueryPercent { get; set; }

            /// <summary>
            /// <para>The ID of the work.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <para>The name of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ClusterRiskReport</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <para>The format of the report.</para>
            /// 
            /// <b>Example:</b>
            /// <para>report</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <para>The unique ID of the space.</para>
            /// 
            /// <b>Example:</b>
            /// <para>89713491-cb4f-4579-b889-e82c35f1****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// </summary>
            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
