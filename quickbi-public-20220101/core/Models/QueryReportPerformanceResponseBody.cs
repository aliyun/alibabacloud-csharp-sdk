// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryReportPerformanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1FC71085-D5FD-08E0-813A-4D4BD1031BC5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryReportPerformanceResponseBodyResult> Result { get; set; }
        public class QueryReportPerformanceResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2.2</para>
            /// </summary>
            [NameInMap("CacheCostTimeAvg")]
            [Validation(Required=false)]
            public double? CacheCostTimeAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CacheQueryCount")]
            [Validation(Required=false)]
            public int? CacheQueryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ComponentQueryCount")]
            [Validation(Required=false)]
            public int? ComponentQueryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2.0</para>
            /// </summary>
            [NameInMap("ComponentQueryCountAvg")]
            [Validation(Required=false)]
            public double? ComponentQueryCountAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("CostTimeAvg")]
            [Validation(Required=false)]
            public double? CostTimeAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public int? QueryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3.3</para>
            /// </summary>
            [NameInMap("QueryCountAvg")]
            [Validation(Required=false)]
            public double? QueryCountAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
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
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("QueryOverTenSecPercent")]
            [Validation(Required=false)]
            public string QueryOverTenSecPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("QueryOverTenSecPercentNum")]
            [Validation(Required=false)]
            public double? QueryOverTenSecPercentNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("QueryTimeoutCount")]
            [Validation(Required=false)]
            public int? QueryTimeoutCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("QueryTimeoutCountPercent")]
            [Validation(Required=false)]
            public double? QueryTimeoutCountPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("QuickIndexCostTimeAvg")]
            [Validation(Required=false)]
            public double? QuickIndexCostTimeAvg { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("QuickIndexQueryCount")]
            [Validation(Required=false)]
            public int? QuickIndexQueryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.8</para>
            /// </summary>
            [NameInMap("RepeatQueryPercent")]
            [Validation(Required=false)]
            public string RepeatQueryPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RepeatQueryPercentNum")]
            [Validation(Required=false)]
            public double? RepeatQueryPercentNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryCount")]
            [Validation(Required=false)]
            public int? RepeatSqlQueryCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.7</para>
            /// </summary>
            [NameInMap("RepeatSqlQueryPercent")]
            [Validation(Required=false)]
            public string RepeatSqlQueryPercent { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6b407e50-e774-406b-9956-da2425c2****</para>
            /// </summary>
            [NameInMap("ReportId")]
            [Validation(Required=false)]
            public string ReportId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ClusterAddonUpgradeReport</para>
            /// </summary>
            [NameInMap("ReportName")]
            [Validation(Required=false)]
            public string ReportName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>report</para>
            /// </summary>
            [NameInMap("ReportType")]
            [Validation(Required=false)]
            public string ReportType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ab46ed33-6278-4ef7-8013-8c1335f266ee</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

            [NameInMap("WorkspaceName")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
