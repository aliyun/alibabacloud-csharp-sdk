// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewCheckResultStatusResponseBody : TeaModel {
        /// <summary>
        /// The result of the SQL review.
        /// </summary>
        [NameInMap("CheckResultStatus")]
        [Validation(Required=false)]
        public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus CheckResultStatus { get; set; }
        public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus : TeaModel {
            /// <summary>
            /// The result of the SQL status check.
            /// </summary>
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult CheckStatusResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult : TeaModel {
                /// <summary>
                /// The number of SQL statements that failed to pass the review.
                /// </summary>
                [NameInMap("CheckNotPass")]
                [Validation(Required=false)]
                public long? CheckNotPass { get; set; }

                /// <summary>
                /// The number of SQL statements that passed the review.
                /// </summary>
                [NameInMap("CheckPass")]
                [Validation(Required=false)]
                public long? CheckPass { get; set; }

                /// <summary>
                /// The number of SQL statements that failed to pass the manual review.
                /// </summary>
                [NameInMap("ForceNotPass")]
                [Validation(Required=false)]
                public long? ForceNotPass { get; set; }

                /// <summary>
                /// The number of SQL statements that passed the manual review.
                /// </summary>
                [NameInMap("ForcePass")]
                [Validation(Required=false)]
                public long? ForcePass { get; set; }

                /// <summary>
                /// The number of SQL statements to be reviewed.
                /// </summary>
                [NameInMap("New")]
                [Validation(Required=false)]
                public long? New { get; set; }

                /// <summary>
                /// The number of abnormal SQL statements.
                /// </summary>
                [NameInMap("Unknown")]
                [Validation(Required=false)]
                public long? Unknown { get; set; }

            }

            /// <summary>
            /// The number of SQL statements that were reviewed.
            /// </summary>
            [NameInMap("CheckedCount")]
            [Validation(Required=false)]
            public long? CheckedCount { get; set; }

            /// <summary>
            /// The optimization suggestion for SQL statements.
            /// </summary>
            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult SQLReviewResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult : TeaModel {
                /// <summary>
                /// The number of SQL statements that must be modified.
                /// </summary>
                [NameInMap("MustImprove")]
                [Validation(Required=false)]
                public long? MustImprove { get; set; }

                /// <summary>
                /// The number of SQL statements that have potential issues.
                /// </summary>
                [NameInMap("PotentialIssue")]
                [Validation(Required=false)]
                public long? PotentialIssue { get; set; }

                /// <summary>
                /// The number of SQL statements that can be modified.
                /// </summary>
                [NameInMap("SuggestImprove")]
                [Validation(Required=false)]
                public long? SuggestImprove { get; set; }

                /// <summary>
                /// The number of SQL statements that can use indexes.
                /// </summary>
                [NameInMap("TableIndexSuggest")]
                [Validation(Required=false)]
                public long? TableIndexSuggest { get; set; }

                /// <summary>
                /// The number of SQL statements that can be used for lock-free data changes.
                /// </summary>
                [NameInMap("UseDmsDmlUnlock")]
                [Validation(Required=false)]
                public long? UseDmsDmlUnlock { get; set; }

                /// <summary>
                /// The number of SQL statements that can be used for lock-free schema changes.
                /// </summary>
                [NameInMap("UseDmsToolkit")]
                [Validation(Required=false)]
                public long? UseDmsToolkit { get; set; }

            }

            /// <summary>
            /// The total number of SQL statements.
            /// </summary>
            [NameInMap("TotalSQLCount")]
            [Validation(Required=false)]
            public long? TotalSQLCount { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
