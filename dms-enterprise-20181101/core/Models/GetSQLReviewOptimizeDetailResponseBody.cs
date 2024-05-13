// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewOptimizeDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The details of optimization suggestions for SQL statements.
        /// </summary>
        [NameInMap("OptimizeDetail")]
        [Validation(Required=false)]
        public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail OptimizeDetail { get; set; }
        public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetail : TeaModel {
            /// <summary>
            /// The ID of the database.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public int? DbId { get; set; }

            /// <summary>
            /// The ID of the instance to which the database belongs.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public int? InstanceId { get; set; }

            /// <summary>
            /// The quality of the SQL statement.
            /// </summary>
            [NameInMap("QualityResult")]
            [Validation(Required=false)]
            public GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult QualityResult { get; set; }
            public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResult : TeaModel {
                /// <summary>
                /// The error message returned.
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// Indicates whether an error occurs. Valid values:
                /// 
                /// *   **true**: An error occurs.
                /// *   **false**: No error occurs.
                /// </summary>
                [NameInMap("OccurError")]
                [Validation(Required=false)]
                public bool? OccurError { get; set; }

                /// <summary>
                /// The review results based on rules.
                /// </summary>
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults> Results { get; set; }
                public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResults : TeaModel {
                    /// <summary>
                    /// The comment that is specified when you create the SQL review rule. For more information, see [SQL review optimization](https://help.aliyun.com/document_detail/194114.html).
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    /// <summary>
                    /// The optimization suggestion for the SQL statement. Valid values:
                    /// 
                    /// *   **MUST_IMPROVE**: The SQL statement must be improved.
                    /// *   **POTENTIAL_ISSUE**: The SQL statement contains potential issues.
                    /// *   **SUGGEST_IMPROVE**: We recommend that you improve the SQL statement.
                    /// *   **USEDMSTOOLKIT**: We recommend that you change schemas without locking tables.
                    /// *   **USEDMSDML_UNLOCK**: We recommend that you change data without locking tables.
                    /// *   **TABLEINDEXSUGGEST**: We recommend that you use SQL statements that use indexes.
                    /// </summary>
                    [NameInMap("Feedback")]
                    [Validation(Required=false)]
                    public string Feedback { get; set; }

                    /// <summary>
                    /// The review results.
                    /// </summary>
                    [NameInMap("Messages")]
                    [Validation(Required=false)]
                    public List<string> Messages { get; set; }

                    /// <summary>
                    /// The name of the rule. For more information, see [SQL review optimization](https://help.aliyun.com/document_detail/194114.html).
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                    /// <summary>
                    /// The type of the SQL review rule. Valid values:
                    /// 
                    /// *   **REVIEW**: a rule that is used to review SQL statements based on standards.
                    /// *   **OPTIMIZE**: a rule that is used to provide optimization suggestions.
                    /// </summary>
                    [NameInMap("RuleType")]
                    [Validation(Required=false)]
                    public string RuleType { get; set; }

                    /// <summary>
                    /// The SQL script for data changes.
                    /// </summary>
                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public List<GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts> Scripts { get; set; }
                    public class GetSQLReviewOptimizeDetailResponseBodyOptimizeDetailQualityResultResultsScripts : TeaModel {
                        /// <summary>
                        /// The content of the SQL script.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The purpose of the SQL script. The value is set to AddIndex.
                        /// </summary>
                        [NameInMap("OpType")]
                        [Validation(Required=false)]
                        public string OpType { get; set; }

                        /// <summary>
                        /// The name of the table.
                        /// </summary>
                        [NameInMap("TableName")]
                        [Validation(Required=false)]
                        public string TableName { get; set; }

                    }

                }

            }

            /// <summary>
            /// The key that is used to query the details of optimization suggestions.
            /// </summary>
            [NameInMap("QueryKey")]
            [Validation(Required=false)]
            public string QueryKey { get; set; }

            /// <summary>
            /// The type of the SQL statement. Valid values: DELETE, UPDATE, and ALTER_TABLE.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
