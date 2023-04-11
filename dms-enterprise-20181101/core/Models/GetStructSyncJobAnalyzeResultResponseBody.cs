// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobAnalyzeResultResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
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
        /// The analysis result of the schema synchronization task.
        /// </summary>
        [NameInMap("StructSyncJobAnalyzeResult")]
        [Validation(Required=false)]
        public GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult StructSyncJobAnalyzeResult { get; set; }
        public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResult : TeaModel {
            /// <summary>
            /// The details of the analysis results.
            /// </summary>
            [NameInMap("ResultList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList> ResultList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultResultList : TeaModel {
                /// <summary>
                /// The SQL script.
                /// </summary>
                [NameInMap("Script")]
                [Validation(Required=false)]
                public string Script { get; set; }

                /// <summary>
                /// The name of the source table.
                /// </summary>
                [NameInMap("SourceTableName")]
                [Validation(Required=false)]
                public string SourceTableName { get; set; }

                /// <summary>
                /// The name of the destination table.
                /// </summary>
                [NameInMap("TargetTableName")]
                [Validation(Required=false)]
                public string TargetTableName { get; set; }

            }

            /// <summary>
            /// The statistics on the analysis results.
            /// </summary>
            [NameInMap("SummaryList")]
            [Validation(Required=false)]
            public List<GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList> SummaryList { get; set; }
            public class GetStructSyncJobAnalyzeResultResponseBodyStructSyncJobAnalyzeResultSummaryList : TeaModel {
                /// <summary>
                /// The type of the comparison. Valid values:
                /// 
                /// *   **CREATE_TABLE**: compares the created tables.
                /// *   **ALTER_TABLE**: compares the modified tables.
                /// *   **EQUAL_TABLE**: compares the identical tables.
                /// *   **PASS_TABLE**: compares the tables that are skipped during schema synchronization.
                /// *   **NOT_COMPARE**: does not compare tables.
                /// </summary>
                [NameInMap("CompareType")]
                [Validation(Required=false)]
                public string CompareType { get; set; }

                /// <summary>
                /// The number of tables.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
