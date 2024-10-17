// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetSQLReviewCheckResultStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the SQL review.</para>
        /// </summary>
        [NameInMap("CheckResultStatus")]
        [Validation(Required=false)]
        public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus CheckResultStatus { get; set; }
        public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatus : TeaModel {
            /// <summary>
            /// <para>The result of the SQL status check.</para>
            /// </summary>
            [NameInMap("CheckStatusResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult CheckStatusResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusCheckStatusResult : TeaModel {
                /// <summary>
                /// <para>The number of SQL statements that failed to pass the review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CheckNotPass")]
                [Validation(Required=false)]
                public long? CheckNotPass { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that passed the review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CheckPass")]
                [Validation(Required=false)]
                public long? CheckPass { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that failed to pass the manual review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ForceNotPass")]
                [Validation(Required=false)]
                public long? ForceNotPass { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that passed the manual review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ForcePass")]
                [Validation(Required=false)]
                public long? ForcePass { get; set; }

                /// <summary>
                /// <para>The number of SQL statements to be reviewed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("New")]
                [Validation(Required=false)]
                public long? New { get; set; }

                /// <summary>
                /// <para>The number of abnormal SQL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Unknown")]
                [Validation(Required=false)]
                public long? Unknown { get; set; }

            }

            /// <summary>
            /// <para>The number of SQL statements that were reviewed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CheckedCount")]
            [Validation(Required=false)]
            public long? CheckedCount { get; set; }

            /// <summary>
            /// <para>The optimization suggestion for SQL statements.</para>
            /// </summary>
            [NameInMap("SQLReviewResult")]
            [Validation(Required=false)]
            public GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult SQLReviewResult { get; set; }
            public class GetSQLReviewCheckResultStatusResponseBodyCheckResultStatusSQLReviewResult : TeaModel {
                /// <summary>
                /// <para>The number of SQL statements that must be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MustImprove")]
                [Validation(Required=false)]
                public long? MustImprove { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that have potential issues.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PotentialIssue")]
                [Validation(Required=false)]
                public long? PotentialIssue { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that can be modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("SuggestImprove")]
                [Validation(Required=false)]
                public long? SuggestImprove { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that can use indexes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TableIndexSuggest")]
                [Validation(Required=false)]
                public long? TableIndexSuggest { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that can be used for lock-free data changes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UseDmsDmlUnlock")]
                [Validation(Required=false)]
                public long? UseDmsDmlUnlock { get; set; }

                /// <summary>
                /// <para>The number of SQL statements that can be used for lock-free schema changes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UseDmsToolkit")]
                [Validation(Required=false)]
                public long? UseDmsToolkit { get; set; }

            }

            /// <summary>
            /// <para>The total number of SQL statements.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalSQLCount")]
            [Validation(Required=false)]
            public long? TotalSQLCount { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UnknownError</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
