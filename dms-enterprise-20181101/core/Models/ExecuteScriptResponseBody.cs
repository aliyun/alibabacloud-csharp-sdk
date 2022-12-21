// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteScriptResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message about the gateway.
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
        /// The results of the SQL statements that are executed, in the format of an array. Each entry in the array indicates the result of an SQL statement.
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<ExecuteScriptResponseBodyResults> Results { get; set; }
        public class ExecuteScriptResponseBodyResults : TeaModel {
            /// <summary>
            /// The fields that are queried after the SQL statement is executed.
            /// </summary>
            [NameInMap("ColumnNames")]
            [Validation(Required=false)]
            public List<string> ColumnNames { get; set; }

            /// <summary>
            /// The error message that is returned if the SQL statement fails to be executed. For example, an error message is returned because the SQL statement is invalid.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The total number of entries that are returned.
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// The rows that are queried after the SQL statement is executed.
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Rows { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement is executed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
