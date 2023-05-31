// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeBackupFilesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the backup files returned.
        /// </summary>
        [NameInMap("BackupFiles")]
        [Validation(Required=false)]
        public List<DescribeBackupFilesResponseBodyBackupFiles> BackupFiles { get; set; }
        public class DescribeBackupFilesResponseBodyBackupFiles : TeaModel {
            /// <summary>
            /// The name of the anti-ransomware policy.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The size of the backup file. Unit: bytes.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The path to the subdirectory of the backup file.
            /// </summary>
            [NameInMap("Subtree")]
            [Validation(Required=false)]
            public string Subtree { get; set; }

            /// <summary>
            /// The type of the protected file. Valid values:
            /// 
            /// *   **file**: files
            /// *   **dir**: folders
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public DescribeBackupFilesResponseBodyPageInfo PageInfo { get; set; }
        public class DescribeBackupFilesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The number of backup files returned on the current page.
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
            /// The number of entries returned per page. Default value: **10**.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of backup files returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
