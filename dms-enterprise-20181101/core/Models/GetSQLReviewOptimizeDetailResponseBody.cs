// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewOptimizeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The details of optimization suggestions for SQL statements.</para>
        /// </summary>
        [NameInMap("OptimizeDetail")]
        [Validation(Required=false)]
        public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail OptimizeDetail { get; set; }
        public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail : TeaModel {
            /// <summary>
            /// <para>The ID of the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>111222</para>
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the database belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123321</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public int? InstanceId { get; set; }

            /// <summary>
            /// <para>The quality of the SQL statement.</para>
            /// </summary>
            [NameInMap("QualityResult")]
            [Validation(Required=false)]
            public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult QualityResult { get; set; }
            public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult : TeaModel {
                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>syntax error</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>Indicates whether an error occurs. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: An error occurs.</description></item>
                /// <item><description><b>false</b>: No error occurs.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("OccurError")]
                [Validation(Required=false)]
                public bool? OccurError { get; set; }

                /// <summary>
                /// <para>The review results based on rules.</para>
                /// </summary>
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults> Results { get; set; }
                public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults : TeaModel {
                    /// <summary>
                    /// <para>The comment that is specified when you create the SQL review rule. For more information, see <a href="https://help.aliyun.com/document_detail/194114.html">SQL review optimization</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx business rule: the query must have a where condition.</para>
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    /// <summary>
                    /// <para>The optimization suggestion for the SQL statement. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>MUST_IMPROVE</b>: The SQL statement must be improved.</description></item>
                    /// <item><description><b>POTENTIAL_ISSUE</b>: The SQL statement contains potential issues.</description></item>
                    /// <item><description><b>SUGGEST_IMPROVE</b>: We recommend that you improve the SQL statement.</description></item>
                    /// <item><description><b>USEDMSTOOLKIT</b>: We recommend that you change schemas without locking tables.</description></item>
                    /// <item><description><b>USEDMSDML_UNLOCK</b>: We recommend that you change data without locking tables.</description></item>
                    /// <item><description><b>TABLEINDEXSUGGEST</b>: We recommend that you use SQL statements that use indexes.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MUST_IMPROVE</para>
                    /// </summary>
                    [NameInMap("Feedback")]
                    [Validation(Required=false)]
                    public string Feedback { get; set; }

                    /// <summary>
                    /// <para>The review results.</para>
                    /// </summary>
                    [NameInMap("Messages")]
                    [Validation(Required=false)]
                    public List<string> Messages { get; set; }

                    /// <summary>
                    /// <para>The name of the rule. For more information, see <a href="https://help.aliyun.com/document_detail/194114.html">SQL review optimization</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT_SUGGEST_ASSIGN_WHERE</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// <para>The type of the SQL review rule. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>REVIEW</b>: a rule that is used to review SQL statements based on standards.</description></item>
                    /// <item><description><b>OPTIMIZE</b>: a rule that is used to provide optimization suggestions.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>REVIEW</para>
                    /// </summary>
                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    /// <summary>
                    /// <para>The SQL script for data changes.</para>
                    /// </summary>
                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts> Scripts { get; set; }
                    public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts : TeaModel {
                        /// <summary>
                        /// <para>The content of the SQL script.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>alter table xxx add index idx_xx(yyy);</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The purpose of the SQL script. The value is set to AddIndex.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>AddIndex</para>
                        /// </summary>
                        [NameInMap("OpType")]
                        [Validation(Required=false)]
                        public string OpType { get; set; }

                        /// <summary>
                        /// <para>The name of the table.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xxx</para>
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The key that is used to query the details of optimization suggestions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a57e54ec5433475ea3082d882fdb****</para>
            /// </summary>
            [NameInMap("QueryKey")]
            [Validation(Required=false)]
            public string QueryKey { get; set; }

            /// <summary>
            /// <para>The type of the SQL statement. Valid values: DELETE, UPDATE, and ALTER_TABLE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>UPDATE</para>
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0C1CB646-1DE4-4AD0-B4A4-7D47DD52E931</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
