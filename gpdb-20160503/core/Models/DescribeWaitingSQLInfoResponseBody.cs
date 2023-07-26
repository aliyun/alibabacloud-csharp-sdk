// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLInfoResponseBody : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// Details of the lock-waiting query.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWaitingSQLInfoResponseBodyItems> Items { get; set; }
        public class DescribeWaitingSQLInfoResponseBodyItems : TeaModel {
            /// <summary>
            /// The application that sent the query.
            /// </summary>
            [NameInMap("Application")]
            [Validation(Required=false)]
            public string Application { get; set; }

            /// <summary>
            /// The application that sent the blocking query.
            /// </summary>
            [NameInMap("BlockedByApplication")]
            [Validation(Required=false)]
            public string BlockedByApplication { get; set; }

            /// <summary>
            /// The process ID of the blocking query.
            /// </summary>
            [NameInMap("BlockedByPID")]
            [Validation(Required=false)]
            public string BlockedByPID { get; set; }

            /// <summary>
            /// The SQL statement of the blocking query.
            /// </summary>
            [NameInMap("BlockedBySQLStmt")]
            [Validation(Required=false)]
            public string BlockedBySQLStmt { get; set; }

            /// <summary>
            /// The database account that is used to perform the blocking query.
            /// </summary>
            [NameInMap("BlockedByUser")]
            [Validation(Required=false)]
            public string BlockedByUser { get; set; }

            /// <summary>
            /// The authorized locks.
            /// </summary>
            [NameInMap("GrantLocks")]
            [Validation(Required=false)]
            public string GrantLocks { get; set; }

            /// <summary>
            /// The unauthorized locks.
            /// </summary>
            [NameInMap("NotGrantLocks")]
            [Validation(Required=false)]
            public string NotGrantLocks { get; set; }

            /// <summary>
            /// The ID of the process that uniquely identifies the query.
            /// </summary>
            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            /// <summary>
            /// The SQL statement of the query.
            /// </summary>
            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            /// <summary>
            /// The database account that is used to perform the query.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
