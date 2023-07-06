// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLResponseBody : TeaModel {
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
        /// The information about the parsed SQL statements.
        /// </summary>
        [NameInMap("OriginSQLList")]
        [Validation(Required=false)]
        public List<ListSQLReviewOriginSQLResponseBodyOriginSQLList> OriginSQLList { get; set; }
        public class ListSQLReviewOriginSQLResponseBodyOriginSQLList : TeaModel {
            /// <summary>
            /// The review status of the SQL statement. Valid values:
            /// 
            /// *   **new**: The SQL statement is pending for analysis.
            /// *   **unknown**: The SQL statement failed to be parsed.
            /// *   **check_not_pass**: The SQL statement failed the review.
            /// *   **check_pass**: The SQL statement passed the review.
            /// *   **force_pass**: The SQL statement passed the review by manual effort.
            /// *   **force_not_pass**: The SQL statement failed the review by manual effort.
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// The time when the SQL statement is reviewed.
            /// </summary>
            [NameInMap("CheckedTime")]
            [Validation(Required=false)]
            public string CheckedTime { get; set; }

            /// <summary>
            /// The ID of the file.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// The name of the file.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// The statistics of optimization suggestions for SQL statements. The value is a JSON string. The following optimization suggestions are involved:
            /// 
            /// *   **MUST_IMPROVE**: The SQL statement must be improved.
            /// *   **POTENTIAL_ISSUE**: The SQL statement contains potential issues.
            /// *   **SUGGEST_IMPROVE**: We recommend that you improve the SQL statement.
            /// *   **USEDMSTOOLKIT**: We recommend that you change schemas without locking tables.
            /// *   **USEDMSDML_UNLOCK**: We recommend that you change data without locking tables.
            /// *   **TABLEINDEXSUGGEST**: We recommend that you use SQL statements that use indexes.
            /// </summary>
            [NameInMap("ReviewSummary")]
            [Validation(Required=false)]
            public string ReviewSummary { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("SQLContent")]
            [Validation(Required=false)]
            public string SQLContent { get; set; }

            /// <summary>
            /// The ID of the SQL statement.
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public long? SQLId { get; set; }

            /// <summary>
            /// SQLName.
            /// </summary>
            [NameInMap("SQLName")]
            [Validation(Required=false)]
            public string SQLName { get; set; }

            /// <summary>
            /// The key that is used to query the details of optimization suggestions. You can call the [GetSQLReviewOptimizeDetail](https://icms.alibaba-inc.com/content/dms/doc?l=1\&m=61777\&n=2712723\&spm) operation to query the details of optimization suggestions based on the key.
            /// </summary>
            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            /// <summary>
            /// The MD5 hash value of the SQL statement.
            /// </summary>
            [NameInMap("SqlHash")]
            [Validation(Required=false)]
            public string SqlHash { get; set; }

            /// <summary>
            /// The description of the review status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

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

        /// <summary>
        /// The total number of the SQL statements.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
