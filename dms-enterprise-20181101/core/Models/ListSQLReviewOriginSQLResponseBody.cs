// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListSQLReviewOriginSQLResponseBody : TeaModel {
        /// <summary>
        /// The MD5 hash value of the SQL statement.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The description of the review status.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The parameters that are used to filter SQL statements involved in the ticket.
        /// </summary>
        [NameInMap("OriginSQLList")]
        [Validation(Required=false)]
        public List<ListSQLReviewOriginSQLResponseBodyOriginSQLList> OriginSQLList { get; set; }
        public class ListSQLReviewOriginSQLResponseBodyOriginSQLList : TeaModel {
            /// <summary>
            /// The ID of the file.
            /// </summary>
            [NameInMap("CheckStatus")]
            [Validation(Required=false)]
            public string CheckStatus { get; set; }

            /// <summary>
            /// Queries the details of the SQL statements that are involved in an SQL review ticket.
            /// </summary>
            [NameInMap("CheckedTime")]
            [Validation(Required=false)]
            public string CheckedTime { get; set; }

            /// <summary>
            /// The key that is used to query the details of optimization suggestions. You can call the [GetSQLReviewOptimizeDetail](https://icms.alibaba-inc.com/content/dms/doc?l=1\&m=61777\&n=2712723\&spm) operation to query the details of optimization suggestions based on the key.
            /// </summary>
            [NameInMap("FileId")]
            [Validation(Required=false)]
            public long? FileId { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            [NameInMap("ReviewSummary")]
            [Validation(Required=false)]
            public string ReviewSummary { get; set; }

            /// <summary>
            /// The error message returned.
            /// </summary>
            [NameInMap("SQLContent")]
            [Validation(Required=false)]
            public string SQLContent { get; set; }

            /// <summary>
            /// The time when the SQL statement is reviewed.
            /// </summary>
            [NameInMap("SQLId")]
            [Validation(Required=false)]
            public long? SQLId { get; set; }

            [NameInMap("SQLName")]
            [Validation(Required=false)]
            public string SQLName { get; set; }

            [NameInMap("SQLReviewQueryKey")]
            [Validation(Required=false)]
            public string SQLReviewQueryKey { get; set; }

            [NameInMap("SqlHash")]
            [Validation(Required=false)]
            public string SqlHash { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

        }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the SQL statement.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
