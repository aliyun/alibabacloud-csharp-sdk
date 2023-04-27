// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteScriptResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The error message about the gateway.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the database.
        /// 
        /// >  This parameter is equivalent to the DatabaseId parameter in the SearchDatabase, ListDatabases, and GetDatabase operations. You can call one of these operations to obtain the required database ID. For more information, see [SearchDatabase](~~141876~~), [ListDatabases](~~141873~~), and [GetDatabase](~~141869~~).
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
            /// The ID of the tenant.
            /// 
            /// >  To obtain the tenant ID, move the pointer over the profile picture in the upper-right corner of the Data Management (DMS) console. For more information, see [Tenant information](~~181330~~).
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("RowCount")]
            [Validation(Required=false)]
            public long? RowCount { get; set; }

            /// <summary>
            /// The total number of entries that are returned.
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Rows { get; set; }

            /// <summary>
            /// The rows that are queried after the SQL statement is executed.
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
