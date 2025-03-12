// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeOasAnomalySQLListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about suspicious SQL statements.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeOasAnomalySQLListResponseBodyData> Data { get; set; }
        public class DescribeOasAnomalySQLListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Average CPU time of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.24</para>
            /// </summary>
            [NameInMap("AvgCpuTime")]
            [Validation(Required=false)]
            public double? AvgCpuTime { get; set; }

            /// <summary>
            /// <para>The average DB time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("AvgDbTime")]
            [Validation(Required=false)]
            public double? AvgDbTime { get; set; }

            /// <summary>
            /// <para>Average response time of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.28</para>
            /// </summary>
            [NameInMap("AvgElapsedTime")]
            [Validation(Required=false)]
            public double? AvgElapsedTime { get; set; }

            /// <summary>
            /// <para>Average time to obtain the execution plan of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AvgGetPlanTime")]
            [Validation(Required=false)]
            public double? AvgGetPlanTime { get; set; }

            /// <summary>
            /// <para>The average number of logical reads.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("AvgLogicalReads")]
            [Validation(Required=false)]
            public float? AvgLogicalReads { get; set; }

            /// <summary>
            /// <para>The average number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("AvgRetryCount")]
            [Validation(Required=false)]
            public float? AvgRetryCount { get; set; }

            /// <summary>
            /// <para>CPU time of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100.23</para>
            /// </summary>
            [NameInMap("CpuTime")]
            [Validation(Required=false)]
            public double? CpuTime { get; set; }

            /// <summary>
            /// <para>The name of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db_***</para>
            /// </summary>
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            /// <summary>
            /// <para>The type of the diagnosis.</para>
            /// </summary>
            [NameInMap("DiagTypes")]
            [Validation(Required=false)]
            public List<string> DiagTypes { get; set; }

            /// <summary>
            /// <para>The details of diagnosis.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public string Diagnosis { get; set; }

            /// <summary>
            /// <para>是否动态SQL</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("DynamicSql")]
            [Validation(Required=false)]
            public bool? DynamicSql { get; set; }

            /// <summary>
            /// <para>Total execution count of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Executions")]
            [Validation(Required=false)]
            public double? Executions { get; set; }

            /// <summary>
            /// <para>Last execution time of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-04-12T04:38:38Z</para>
            /// </summary>
            [NameInMap("LastExecutedTime")]
            [Validation(Required=false)]
            public double? LastExecutedTime { get; set; }

            /// <summary>
            /// <para>Risk level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>SQL ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8D6E84<b><b>0B8FB1823D199E2CA1</b></b></para>
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public string SqlId { get; set; }

            /// <summary>
            /// <para>The list of SQL statements.</para>
            /// </summary>
            [NameInMap("SqlList")]
            [Validation(Required=false)]
            public List<DescribeOasAnomalySQLListResponseBodyDataSqlList> SqlList { get; set; }
            public class DescribeOasAnomalySQLListResponseBodyDataSqlList : TeaModel {
                /// <summary>
                /// <para>The average CPU time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.24</para>
                /// </summary>
                [NameInMap("AvgCpuTime")]
                [Validation(Required=false)]
                public double? AvgCpuTime { get; set; }

                /// <summary>
                /// <para>The average DB time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AvgDbTime")]
                [Validation(Required=false)]
                public double? AvgDbTime { get; set; }

                /// <summary>
                /// <para>The average response time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.28</para>
                /// </summary>
                [NameInMap("AvgElapsedTime")]
                [Validation(Required=false)]
                public double? AvgElapsedTime { get; set; }

                /// <summary>
                /// <para>The average plan generation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgGetPlanTime")]
                [Validation(Required=false)]
                public double? AvgGetPlanTime { get; set; }

                /// <summary>
                /// <para>The average number of logical reads.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("AvgLogicalReads")]
                [Validation(Required=false)]
                public float? AvgLogicalReads { get; set; }

                /// <summary>
                /// <para>The average number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("AvgRetryCount")]
                [Validation(Required=false)]
                public float? AvgRetryCount { get; set; }

                /// <summary>
                /// <para>The total CPU time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100.23</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_hsp****eway</para>
                /// </summary>
                [NameInMap("DbName")]
                [Validation(Required=false)]
                public string DbName { get; set; }

                /// <summary>
                /// <para>The diagnostic types.</para>
                /// </summary>
                [NameInMap("DiagTypes")]
                [Validation(Required=false)]
                public List<string> DiagTypes { get; set; }

                /// <summary>
                /// <para>The diagnostic details. </para>
                /// <remarks>
                /// <para>This parameter is deprecated.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Diagnosis")]
                [Validation(Required=false)]
                public string Diagnosis { get; set; }

                /// <summary>
                /// <para>The total number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Executions")]
                [Validation(Required=false)]
                public double? Executions { get; set; }

                /// <summary>
                /// <para>The last execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-12T04:38:38Z</para>
                /// </summary>
                [NameInMap("LastExecutedTime")]
                [Validation(Required=false)]
                public string LastExecutedTime { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LOW</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public string RiskLevel { get; set; }

                /// <summary>
                /// <para>The ID of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3A645<b><b>789F13DE0CF6D084FF9</b></b></para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The prefix of the SQL text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select * from test</para>
                /// </summary>
                [NameInMap("SqlTextShort")]
                [Validation(Required=false)]
                public string SqlTextShort { get; set; }

                /// <summary>
                /// <para>The suggestion on the suspicious SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;Role\&quot;: \&quot;eSG\&quot;, \&quot;Result\&quot;: \&quot;100\&quot;, \&quot;Suggestion\&quot;: \&quot;TRACER_OTHER_ERR\&quot;}</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The total DB time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SumDbTime")]
                [Validation(Required=false)]
                public double? SumDbTime { get; set; }

                /// <summary>
                /// <para>The total response time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11452126.36</para>
                /// </summary>
                [NameInMap("SumElapsedTime")]
                [Validation(Required=false)]
                public string SumElapsedTime { get; set; }

                /// <summary>
                /// <para>The total number of retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("SumRetryCount")]
                [Validation(Required=false)]
                public float? SumRetryCount { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_user</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>Prefix of the SQL text.</para>
            /// </summary>
            [NameInMap("SqlTextShort")]
            [Validation(Required=false)]
            public string SqlTextShort { get; set; }

            /// <summary>
            /// <para>Suggestion for the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>review</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

            /// <summary>
            /// <para>The total DB time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("SumDbTime")]
            [Validation(Required=false)]
            public double? SumDbTime { get; set; }

            /// <summary>
            /// <para>Total response time of the suspicious SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11452126.36</para>
            /// </summary>
            [NameInMap("SumElapsedTime")]
            [Validation(Required=false)]
            public string SumElapsedTime { get; set; }

            /// <summary>
            /// <para>The total number of retries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("SumRetryCount")]
            [Validation(Required=false)]
            public float? SumRetryCount { get; set; }

            /// <summary>
            /// <para>Username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_user</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469**-AA6F-4D**-B3DB-A***********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
