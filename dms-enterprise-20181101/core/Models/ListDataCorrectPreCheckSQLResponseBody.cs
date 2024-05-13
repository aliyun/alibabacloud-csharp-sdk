// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataCorrectPreCheckSQLResponseBody : TeaModel {
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
        /// The precheck information about SQL statements.
        /// </summary>
        [NameInMap("PreCheckSQLList")]
        [Validation(Required=false)]
        public List<ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList> PreCheckSQLList { get; set; }
        public class ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList : TeaModel {
            /// <summary>
            /// The estimated number of affected rows.
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("CheckSQL")]
            [Validation(Required=false)]
            public string CheckSQL { get; set; }

            /// <summary>
            /// The ID of the database.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The key that is used to query the details of optimization suggestions. You can call the [GetSQLReviewOptimizeDetail](https://help.aliyun.com/document_detail/265977.html) operation to query the details of optimization suggestions based on the key.
            /// </summary>
            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            /// <summary>
            /// The review status of the SQL statement. Valid values:
            /// 
            /// *   **WAITING**: The SQL statement is pending for review.
            /// *   **RUNNING**: The SQL statement is being reviewed.
            /// *   **IGNORE**: The SQL statement review is skipped.
            /// *   **PASS**: The SQL statement passed the review.
            /// *   **BLOCK**: The SQL statement failed the review.
            /// </summary>
            [NameInMap("SqlReviewStatus")]
            [Validation(Required=false)]
            public string SqlReviewStatus { get; set; }

            /// <summary>
            /// The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// The name of the table whose data is changed.
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
