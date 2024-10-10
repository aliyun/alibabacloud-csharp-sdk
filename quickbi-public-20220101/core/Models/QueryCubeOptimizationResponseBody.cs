// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryCubeOptimizationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryCubeOptimizationResponseBodyResult> Result { get; set; }
        public class QueryCubeOptimizationResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>OPENQUICKENGINE</para>
            /// </summary>
            [NameInMap("AdviceType")]
            [Validation(Required=false)]
            public string AdviceType { get; set; }

            [NameInMap("CubePerformanceDiagnoseModel")]
            [Validation(Required=false)]
            public QueryCubeOptimizationResponseBodyResultCubePerformanceDiagnoseModel CubePerformanceDiagnoseModel { get; set; }
            public class QueryCubeOptimizationResponseBodyResultCubePerformanceDiagnoseModel : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CacheCostTimeAvg")]
                [Validation(Required=false)]
                public double? CacheCostTimeAvg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CacheQueryCount")]
                [Validation(Required=false)]
                public int? CacheQueryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1.0</para>
                /// </summary>
                [NameInMap("CostTimeAvg")]
                [Validation(Required=false)]
                public double? CostTimeAvg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3e45b61a-9ba8-4c7c-8248-8dbe69945636</para>
                /// </summary>
                [NameInMap("CubeId")]
                [Validation(Required=false)]
                public string CubeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("CubeName")]
                [Validation(Required=false)]
                public string CubeName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("QueryCount")]
                [Validation(Required=false)]
                public int? QueryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QueryCountAvg")]
                [Validation(Required=false)]
                public double? QueryCountAvg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("QueryOverFivePercentNum")]
                [Validation(Required=false)]
                public double? QueryOverFivePercentNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("QueryOverFiveSecPercent")]
                [Validation(Required=false)]
                public string QueryOverFiveSecPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("QueryOverTenSecPercent")]
                [Validation(Required=false)]
                public string QueryOverTenSecPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("QueryOverTenSecPercentNum")]
                [Validation(Required=false)]
                public double? QueryOverTenSecPercentNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QueryTimeoutCount")]
                [Validation(Required=false)]
                public int? QueryTimeoutCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("QueryTimeoutCountPercent")]
                [Validation(Required=false)]
                public double? QueryTimeoutCountPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("QuickIndexCostTimeAvg")]
                [Validation(Required=false)]
                public double? QuickIndexCostTimeAvg { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("QuickIndexQueryCount")]
                [Validation(Required=false)]
                public int? QuickIndexQueryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("RepeatQueryPercent")]
                [Validation(Required=false)]
                public string RepeatQueryPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RepeatQueryPercentNum")]
                [Validation(Required=false)]
                public double? RepeatQueryPercentNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RepeatSqlQueryCount")]
                [Validation(Required=false)]
                public int? RepeatSqlQueryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.3</para>
                /// </summary>
                [NameInMap("RepeatSqlQueryPercent")]
                [Validation(Required=false)]
                public string RepeatSqlQueryPercent { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6ea74bff-c818-4188-b462-dbb45a24dbac</para>
                /// </summary>
                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>eco0sh0prods</para>
                /// </summary>
                [NameInMap("WorkspaceName")]
                [Validation(Required=false)]
                public string WorkspaceName { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
