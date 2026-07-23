// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentAccuracyTestResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDataAgentAccuracyTestResultsResponseBodyData Data { get; set; }
        public class ListDataAgentAccuracyTestResultsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The accuracy rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("AccuracyRate")]
            [Validation(Required=false)]
            public double? AccuracyRate { get; set; }

            /// <summary>
            /// <para>The ID of the accuracy test task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>692abb8f-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
            /// </summary>
            [NameInMap("AccuracyTestTaskId")]
            [Validation(Required=false)]
            public string AccuracyTestTaskId { get; set; }

            /// <summary>
            /// <para>The data content.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ListDataAgentAccuracyTestResultsResponseBodyDataContent> Content { get; set; }
            public class ListDataAgentAccuracyTestResultsResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The ID of the accuracy test task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>692abb8f-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("AccuracyTestTaskId")]
                [Validation(Required=false)]
                public string AccuracyTestTaskId { get; set; }

                /// <summary>
                /// <para>The actual answer from the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>在公司历史职位记录中，共有97,750名员工曾拥有Senior Engineer头衔。</para>
                /// </summary>
                [NameInMap("AgentResult")]
                [Validation(Required=false)]
                public string AgentResult { get; set; }

                [NameInMap("AgentSql")]
                [Validation(Required=false)]
                public string AgentSql { get; set; }

                /// <summary>
                /// <para>The expected answer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>97750</para>
                /// </summary>
                [NameInMap("AnswerResult")]
                [Validation(Required=false)]
                public string AnswerResult { get; set; }

                /// <summary>
                /// <para>The expected SQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT COUNT(*) FROM titles WHERE title = \&quot;Senior Engineer\&quot;;</para>
                /// </summary>
                [NameInMap("AnswerSql")]
                [Validation(Required=false)]
                public string AnswerSql { get; set; }

                /// <summary>
                /// <para>The AI evaluation result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsTrue")]
                [Validation(Required=false)]
                public bool? IsTrue { get; set; }

                /// <summary>
                /// <para>The test question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>拥有Senior Engineer头衔的员工有多少人？</para>
                /// </summary>
                [NameInMap("Question")]
                [Validation(Required=false)]
                public string Question { get; set; }

                /// <summary>
                /// <para>The error reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL 中不应该使用COUNT(DISTINCT)</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The improvement suggestion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>在问题中描述清楚是否需去重</para>
                /// </summary>
                [NameInMap("Recommendation")]
                [Validation(Required=false)]
                public string Recommendation { get; set; }

                /// <summary>
                /// <para>The result ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>at-emhnbwewfngrxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("ResultId")]
                [Validation(Required=false)]
                public string ResultId { get; set; }

                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The subtask ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f1eb8728-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("SubtaskId")]
                [Validation(Required=false)]
                public string SubtaskId { get; set; }

            }

            /// <summary>
            /// <para>The number of test cases that passed evaluation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("CorrectCount")]
            [Validation(Required=false)]
            public long? CorrectCount { get; set; }

            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public string FailedCount { get; set; }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("PendingCount")]
            [Validation(Required=false)]
            public string PendingCount { get; set; }

            /// <summary>
            /// <para>The total number of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public int? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public int? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no use</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no use</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>67E910F2-4B62-5B0C-ACA3-7547695C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
