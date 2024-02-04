// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasAnomalySQLListResponseBody : TeaModel {
        /// <summary>
        /// The list of suspicious SQLs.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasAnomalySQLListResponseBodyData> Data { get; set; }
        public class DescribeOasAnomalySQLListResponseBodyData : TeaModel {
            /// <summary>
            /// Average CPU time of the suspicious SQL.
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            [NameInMap("AvgDbTime")]
            [Validation(Required=false)]
            public double? AvgDbTime { get; set; }

            /// <summary>
            /// Average response time of the suspicious SQL.
            /// </summary>
            [NameInMap("AvgElapsedTime")]
            [Validation(Required=false)]
            public double? AvgElapsedTime { get; set; }

            /// <summary>
            /// Average time to obtain the execution plan of the suspicious SQL.
            /// </summary>
            [NameInMap("AvgGetPlanTime")]
            [Validation(Required=false)]
            public double? AvgGetPlanTime { get; set; }

            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public float? AvgLogicalReads { get; set; }

            [NameInMap("AvgRetryCount")]
            [Validation(Required=false)]
            public float? AvgRetryCount { get; set; }

            /// <summary>
            /// CPU time of the suspicious SQL.
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// The type of the diagnosis.
            /// </summary>
            [NameInMap("DiagTypes")]
            [Validation(Required=false)]
            public List<string> DiagTypes { get; set; }

            /// <summary>
            /// The details of diagnosis.
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            [NameInMap("DynamicSql")]
            [Validation(Required=false)]
            public bool? DynamicSql { get; set; }

            /// <summary>
            /// Total execution count of the suspicious SQL.
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public double? Executions { get; set; }

            /// <summary>
            /// Last execution time of the suspicious SQL.
            /// </summary>
            [NameInMap("LastExecutedTime")]
            [Validation(Required=false)]
            public double? LastExecutedTime { get; set; }

            /// <summary>
            /// Risk level.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// SQL ID.
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            [NameInMap("SqlList")]
            [Validation(Required=false)]
            public List<DescribeOasAnomalySQLListResponseBodyDataSqlList> SqlList { get; set; }
            public class DescribeOasAnomalySQLListResponseBodyDataSqlList : TeaModel {
                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                [NameInMap("AvgDbTime")]
                [Validation(Required=false)]
                public double? AvgDbTime { get; set; }

                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                [NameInMap("AvgGetPlanTime")]
                [Validation(Required=false)]
                public double? AvgGetPlanTime { get; set; }

                [NameInMap("AvgLogicalReads")]
                [Validation(Required=false)]
                public float? AvgLogicalReads { get; set; }

                [NameInMap("AvgRetryCount")]
                [Validation(Required=false)]
                public float? AvgRetryCount { get; set; }

                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                [NameInMap("DiagTypes")]
                [Validation(Required=false)]
                public List<string> DiagTypes { get; set; }

                [NameInMap("Diagnosis")]
                [Validation(Required=false)]
                public string Diagnosis { get; set; }

                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                [NameInMap("LastExecutedTime")]
                [Validation(Required=false)]
                public double? LastExecutedTime { get; set; }

                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlTextShort")]
                [Validation(Required=false)]
                public string SqlTextShort { get; set; }

                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                [NameInMap("SumDbTime")]
                [Validation(Required=false)]
                public double? SumDbTime { get; set; }

                [NameInMap("SumElapsedTime")]
                [Validation(Required=false)]
                public string SumElapsedTime { get; set; }

                [NameInMap("SumRetryCount")]
                [Validation(Required=false)]
                public float? SumRetryCount { get; set; }

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// Prefix of the SQL text.
            /// </summary>
            [NameInMap("SqlTextShort")]
            [Validation(Required=false)]
            public string SqlTextShort { get; set; }

            /// <summary>
            /// Suggestion for the suspicious SQL.
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            [NameInMap("SumDbTime")]
            [Validation(Required=false)]
            public double? SumDbTime { get; set; }

            /// <summary>
            /// Total response time of the suspicious SQL.
            /// </summary>
            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public string SumElapsedTime { get; set; }

            [NameInMap("SumRetryCount")]
            [Validation(Required=false)]
            public float? SumRetryCount { get; set; }

            /// <summary>
            /// Username.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total count.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
