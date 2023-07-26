// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeLogBackupsResponseBody : TeaModel {
        /// <summary>
        /// Details of the backup sets.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeLogBackupsResponseBodyItems> Items { get; set; }
        public class DescribeLogBackupsResponseBodyItems : TeaModel {
            /// <summary>
            /// The ID of the backup set.
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// The ID of the coordinator node.
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// The name of the log backup set that is stored in Object Storage Service (OSS).
            /// </summary>
            [NameInMap("LogFileName")]
            [Validation(Required=false)]
            public string LogFileName { get; set; }

            /// <summary>
            /// The size of the log backup set. Unit: bytes.
            /// </summary>
            [NameInMap("LogFileSize")]
            [Validation(Required=false)]
            public long? LogFileSize { get; set; }

            /// <summary>
            /// The timestamp of the log.
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

            /// <summary>
            /// The name of the compute node.
            /// </summary>
            [NameInMap("SegmentName")]
            [Validation(Required=false)]
            public string SegmentName { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of backup sets on the current page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The total size of logs in the time range. Unit: bytes.
        /// </summary>
        [NameInMap("TotalLogSize")]
        [Validation(Required=false)]
        public long? TotalLogSize { get; set; }

    }

}
