// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCubeOptimizationResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of dataset optimization suggestions, which includes dataset performance diagnostics information and corresponding optimization suggestion types.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCubeOptimizationResponseBodyResult> Result { get; set; }
        public class QueryCubeOptimizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The type of the suggestion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>OPEN_CACHE</b>: Enable caching.</description></item>
            /// <item><description><b>OPEN_QUICK_ENGINE</b>: Enable the Quick engine.</description></item>
            /// <item><description><b>INCREASE_CACHE_TIME</b>: Increase the cache duration.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OPENQUICKENGINE</para>
            /// </summary>
            [NameInMap("AdviceType")]
            [Validation(Required=false)]
            public string AdviceType { get; set; }

            /// <summary>
            /// <para>The dataset diagnostics information.</para>
            /// </summary>
            [NameInMap("CubePerformanceDiagnoseModel")]
            [Validation(Required=false)]
            public QueryCubeOptimizationResponseBodyResultCubePerformanceDiagnoseModel CubePerformanceDiagnoseModel { get; set; }
            public class QueryCubeOptimizationResponseBodyResultCubePerformanceDiagnoseModel : TeaModel {
                /// <summary>
                /// <para>The average duration for cache hits.</para>
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("CacheQueryCount")]
                [Validation(Required=false)]
                public int? CacheQueryCount { get; set; }

                /// <summary>
                /// <para>The average query duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("CostTimeAvg")]
                [Validation(Required=false)]
                public double? CostTimeAvg { get; set; }

                /// <summary>
                /// <para>The dataset ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3e45b61a-9ba8-4c7c-8248-8dbe69945636</para>
                /// </summary>
                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                /// <summary>
                /// <para>The dataset name.</para>
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("QueryCountAvg")]
                [Validation(Required=false)]
                public double? QueryCountAvg { get; set; }

                /// <summary>
                /// <para>The proportion of queries that exceed 5 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("QueryOverFivePercentNum")]
                [Validation(Required=false)]
                public double? QueryOverFivePercentNum { get; set; }

                /// <summary>
                /// <para>The percentage of queries that exceed 5 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("QueryOverFiveSecPercent")]
                [Validation(Required=false)]
                public string QueryOverFiveSecPercent { get; set; }

                /// <summary>
                /// <para>The percentage of queries that exceed 10 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("QueryOverTenSecPercent")]
                [Validation(Required=false)]
                public string QueryOverTenSecPercent { get; set; }

                /// <summary>
                /// <para>The proportion of queries that exceed 10 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("QueryOverTenSecPercentNum")]
                [Validation(Required=false)]
                public double? QueryOverTenSecPercentNum { get; set; }

                /// <summary>
                /// <para>The number of chart query timeouts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QueryTimeoutCount")]
                [Validation(Required=false)]
                public int? QueryTimeoutCount { get; set; }

                /// <summary>
                /// <para>The percentage of chart query timeouts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("QueryTimeoutCountPercent")]
                [Validation(Required=false)]
                public double? QueryTimeoutCountPercent { get; set; }

                /// <summary>
                /// <para>The average query duration for Quick engine hits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QuickIndexCostTimeAvg")]
                [Validation(Required=false)]
                public double? QuickIndexCostTimeAvg { get; set; }

                /// <summary>
                /// <para>The number of Quick engine hits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QuickIndexQueryCount")]
                [Validation(Required=false)]
                public int? QuickIndexQueryCount { get; set; }

                /// <summary>
                /// <para>The percentage of repeated queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("RepeatQueryPercent")]
                [Validation(Required=false)]
                public string RepeatQueryPercent { get; set; }

                /// <summary>
                /// <para>The number of repeated queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RepeatQueryPercentNum")]
                [Validation(Required=false)]
                public double? RepeatQueryPercentNum { get; set; }

                /// <summary>
                /// <para>The number of repeated SQL queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RepeatSqlQueryCount")]
                [Validation(Required=false)]
                public int? RepeatSqlQueryCount { get; set; }

                /// <summary>
                /// <para>The percentage of repeated queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("RepeatSqlQueryPercent")]
                [Validation(Required=false)]
                public string RepeatSqlQueryPercent { get; set; }

                /// <summary>
                /// <para>The workspace ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6ea74bff-c818-4188-b462-dbb45a24dbac</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <para>The workspace name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>eco0sh0prods</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
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
