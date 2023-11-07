// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataExportPreCheckDetailResponseBody : TeaModel {
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
        /// Indicates the result of the precheck task.
        /// </summary>
        [NameInMap("PreCheckResult")]
        [Validation(Required=false)]
        public GetDataExportPreCheckDetailResponseBodyPreCheckResult PreCheckResult { get; set; }
        public class GetDataExportPreCheckDetailResponseBodyPreCheckResult : TeaModel {
            /// <summary>
            /// Specifies whether to skip verification. Valid values:
            /// 
            /// - true
            /// - false
            /// </summary>
            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            /// <summary>
            /// The list of pre-check details.
            /// </summary>
            [NameInMap("PreCheckDetailList")]
            [Validation(Required=false)]
            public GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList PreCheckDetailList { get; set; }
            public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailList : TeaModel {
                [NameInMap("PreCheckDetailList")]
                [Validation(Required=false)]
                public List<GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList> PreCheckDetailList { get; set; }
                public class GetDataExportPreCheckDetailResponseBodyPreCheckResultPreCheckDetailListPreCheckDetailList : TeaModel {
                    /// <summary>
                    /// The estimated number of data rows to be affected.
                    /// </summary>
                    [NameInMap("AffectRows")]
                    [Validation(Required=false)]
                    public long? AffectRows { get; set; }

                    /// <summary>
                    /// The SQL statement.
                    /// </summary>
                    [NameInMap("SQL")]
                    [Validation(Required=false)]
                    public string SQL { get; set; }

                }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
