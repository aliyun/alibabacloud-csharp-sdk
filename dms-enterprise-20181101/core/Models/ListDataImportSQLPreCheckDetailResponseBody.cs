// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataImportSQLPreCheckDetailResponseBody : TeaModel {
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
        /// The precheck information of SQL statements.
        /// </summary>
        [NameInMap("PreCheckSQLDetailList")]
        [Validation(Required=false)]
        public List<ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList> PreCheckSQLDetailList { get; set; }
        public class ListDataImportSQLPreCheckDetailResponseBodyPreCheckSQLDetailList : TeaModel {
            /// <summary>
            /// Indicates whether the precheck of the SQL statement was skipped. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The SQL ID, which indicates the sequence number of the SQL statement. The number starts with 1.
            /// </summary>
            [NameInMap("SqlId")]
            [Validation(Required=false)]
            public long? SqlId { get; set; }

            /// <summary>
            /// The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// The state of the ticket. Valid values:
            /// 
            /// *   **INIT**: The ticket was being initialized.
            /// *   **RUNNING**: The ticket was in progress.
            /// *   **SUCCESS**: The ticket was complete.
            /// *   **TIMEOUT**: The ticket was skipped due to timeout.
            /// *   **FAIL**: The ticket failed.
            /// </summary>
            [NameInMap("StatusCode")]
            [Validation(Required=false)]
            public string StatusCode { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of SQL statements.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
