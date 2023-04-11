// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncExecSqlDetailResponseBody : TeaModel {
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
        /// The details of the SQL statements.
        /// </summary>
        [NameInMap("StructSyncExecSqlDetail")]
        [Validation(Required=false)]
        public GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail StructSyncExecSqlDetail { get; set; }
        public class GetStructSyncExecSqlDetailResponseBodyStructSyncExecSqlDetail : TeaModel {
            /// <summary>
            /// The SQL statements that are executed.
            /// </summary>
            [NameInMap("ExecSql")]
            [Validation(Required=false)]
            public string ExecSql { get; set; }

            /// <summary>
            /// The total number of SQL statements.
            /// </summary>
            [NameInMap("TotalSqlCount")]
            [Validation(Required=false)]
            public long? TotalSqlCount { get; set; }

        }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
