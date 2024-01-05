// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeOtsTableSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The number of backup snapshots that are displayed on the current page.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The returned message. If the request was successful, "successful" is returned. If the request failed, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The token that is required to obtain the next page of backup snapshots.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The backup snapshots.
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeOtsTableSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeOtsTableSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// The actual data amount of backup snapshots after duplicates are removed. Unit: bytes.
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public string ActualBytes { get; set; }

            /// <summary>
            /// The backup type. Valid value: **COMPLETE**, which indicates full backup.
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// The total amount of data. Unit: bytes.
            /// </summary>
            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            /// <summary>
            /// The time when the backup snapshot was completed. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            /// <summary>
            /// The time when the Tablestore instance was created. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The time when the backup snapshot was created. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The name of the Tablestore instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The ID of the backup job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The hash value of the parent backup snapshot.
            /// </summary>
            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            /// <summary>
            /// The time when the backup job ended. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("RangeEnd")]
            [Validation(Required=false)]
            public long? RangeEnd { get; set; }

            /// <summary>
            /// The time when the backup job started. The value is a UNIX timestamp. Unit: milliseconds.
            /// </summary>
            [NameInMap("RangeStart")]
            [Validation(Required=false)]
            public long? RangeStart { get; set; }

            /// <summary>
            /// The retention period of the backup snapshot. Unit: days.
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// The hash value of the backup snapshot.
            /// </summary>
            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            /// <summary>
            /// The ID of the backup snapshot.
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   **ECS_FILE**: backup snapshots for Elastic Compute Service (ECS) files
            /// *   **OSS**: backup snapshots for Object Storage Service (OSS) buckets
            /// *   **NAS**: backup snapshots for Apsara File Storage NAS file systems
            /// *   **OTS_TABLE**: backup snapshots for Tablestore instances
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The time when the backup snapshot started. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the backup job. Valid values:
            /// 
            /// *   **COMPLETE**: The backup job is completed.
            /// *   **PARTIAL_COMPLETE**: The backup job is partially completed.
            /// *   **FAILED**: The backup job has failed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the table in the Tablestore instance.
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// The time when the backup snapshot was updated. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// The ID of the backup vault that stores the backup snapshot.
            /// </summary>
            [NameInMap("VaultId")]
            [Validation(Required=false)]
            public string VaultId { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
