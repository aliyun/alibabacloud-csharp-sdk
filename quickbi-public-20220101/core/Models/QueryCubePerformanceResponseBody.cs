// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCubePerformanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>685072a0-1fd5-40ef-ae6b-cf94e79e718f</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Array of report objects</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCubePerformanceResponseBodyResult> Result { get; set; }
        public class QueryCubePerformanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The average duration of cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CacheCostTimeAvg")]
            [Validation(Required=false)]
            public double? CacheCostTimeAvg { get; set; }

            /// <summary>
            /// <para>The number of cache hits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CacheQueryCount")]
            [Validation(Required=false)]
            public int? CacheQueryCount { get; set; }

            /// <summary>
            /// <para>The average query duration associated with the SQL pattern.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CostTimeAvg")]
            [Validation(Required=false)]
            public double? CostTimeAvg { get; set; }

            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7c7223ae-****-3c744528014b</para>
            /// </summary>
            [NameInMap("CubeId")]
            [Validation(Required=false)]
            public string CubeId { get; set; }

            /// <summary>
            /// <para>The name of the dataset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("CubeName")]
            [Validation(Required=false)]
            public string CubeName { get; set; }

            /// <summary>
            /// <para>The number of queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public int? QueryCount { get; set; }

            /// <summary>
            /// <para>The average number of queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QueryCountAvg")]
            [Validation(Required=false)]
            public double? QueryCountAvg { get; set; }

            /// <summary>
            /// <para>The percentage of the number of queries that exceed the 5S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("QueryOverFivePercentNum")]
            [Validation(Required=false)]
            public double? QueryOverFivePercentNum { get; set; }

            /// <summary>
            /// <para>Query the proportion of more than 5S.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("QueryOverFiveSecPercent")]
            [Validation(Required=false)]
            public string QueryOverFiveSecPercent { get; set; }

            /// <summary>
            /// <para>The percentage of queries that exceed 10s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("QueryOverTenSecPercent")]
            [Validation(Required=false)]
            public string QueryOverTenSecPercent { get; set; }

            /// <summary>
            /// <para>The percentage of queries that exceed 10s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("QueryTimeoutCountPercent")]
            [Validation(Required=false)]
            public double? QueryTimeoutCountPercent { get; set; }

            /// <summary>
            /// <para>The average time consumed by the Quick engine query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("QuickIndexCostTimeAvg")]
            [Validation(Required=false)]
            public double? QuickIndexCostTimeAvg { get; set; }

            /// <summary>
            /// <para>The number of times that the Quick engine is hit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatQueryPercentNum")]
            [Validation(Required=false)]
            public double? RepeatQueryPercentNum { get; set; }

            /// <summary>
            /// <para>The number of times the query is repeated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryCount")]
            [Validation(Required=false)]
            public int? RepeatSqlQueryCount { get; set; }

            /// <summary>
            /// <para>The proportion of duplicate queries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryPercent")]
            [Validation(Required=false)]
            public string RepeatSqlQueryPercent { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the work belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>87c6b145-090c-43e1-9426-8f93be23****</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            /// <summary>
            /// <para>The name of the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>taascontainerprod</para>
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
