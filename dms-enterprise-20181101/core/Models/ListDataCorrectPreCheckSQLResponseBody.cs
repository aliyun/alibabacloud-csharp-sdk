// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataCorrectPreCheckSQLResponseBody : TeaModel {
        /// <summary>
        /// The SQL statement.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the data change ticket. You can call the [ListOrders](~~144643~~) operation to query the ID of the data change ticket.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the database. The database can be a physical database or a logical database.
        /// 
        /// *   To query the ID of a physical database, call the [ListDatabases](~~141873~~) or [SearchDatabase](~~141876~~) operation.
        /// *   To query the ID of a logical database, call the [ListLogicDatabases](~~141874~~) or [SearchDatabase](~~141876~~) operation.
        /// </summary>
        [NameInMap("PreCheckSQLList")]
        [Validation(Required=false)]
        public List<ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList> PreCheckSQLList { get; set; }
        public class ListDataCorrectPreCheckSQLResponseBodyPreCheckSQLList : TeaModel {
            /// <summary>
            /// The review status of the SQL statement. Valid values:
            /// 
            /// *   **WAITING**: The SQL statement is pending for review.
            /// *   **RUNNING**: The SQL statement is being reviewed.
            /// *   **IGNORE**: The SQL statement review is skipped.
            /// *   **PASS**: The SQL statement passed the review.
            /// *   **BLOCK**: The SQL statement failed the review.
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// The estimated number of affected rows.
            /// </summary>
            [NameInMap("CheckSQL")]
            [Validation(Required=false)]
            public string CheckSQL { get; set; }

            /// <summary>
            /// The name of the table whose data is changed.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            [NameInMap("SqlReviewStatus")]
            [Validation(Required=false)]
            public string SqlReviewStatus { get; set; }

            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public string TableNames { get; set; }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the database.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
