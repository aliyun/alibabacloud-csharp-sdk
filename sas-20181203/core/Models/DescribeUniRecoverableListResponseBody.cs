// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUniRecoverableListResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned on the current page.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// An array that consists of the backup snapshots.
        /// </summary>
        [NameInMap("RecoverableInfoList")]
        [Validation(Required=false)]
        public List<DescribeUniRecoverableListResponseBodyRecoverableInfoList> RecoverableInfoList { get; set; }
        public class DescribeUniRecoverableListResponseBodyRecoverableInfoList : TeaModel {
            /// <summary>
            /// The timestamp of the first backup. Unit: milliseconds.
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// The timestamp of the last backup. Unit: milliseconds.
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// The identifier of the point in time for restoration in the backup version that is used. The database is an Oracle database.
            /// </summary>
            [NameInMap("ResetScn")]
            [Validation(Required=false)]
            public string ResetScn { get; set; }

            /// <summary>
            /// The point in time for restoration in the backup version that is used. The database is an Oracle database.
            /// </summary>
            [NameInMap("ResetTime")]
            [Validation(Required=false)]
            public long? ResetTime { get; set; }

            /// <summary>
            /// The information about the database. This parameter is available when the database is a Microsoft SQL Server (MSSQL) database. The value is a JSON string. Valid values:
            /// 
            /// *   **name**: the name of the database
            /// *   **files**: the path to the database files
            /// </summary>
            [NameInMap("RestoreInfo")]
            [Validation(Required=false)]
            public string RestoreInfo { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
