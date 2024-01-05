// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeUdmSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code. The status code 200 indicates that the call is successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The message that is returned. If the call is successful, "successful" is returned. If the call fails, an error message is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about snapshots.
        /// </summary>
        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeUdmSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeUdmSnapshotsResponseBodySnapshots : TeaModel {
            /// <summary>
            /// The size of the backup snapshot. Unit: bytes.
            /// </summary>
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public string ActualBytes { get; set; }

            /// <summary>
            /// The special retention type, which is valid only for special backups. Valid values:
            /// 
            /// *   **WEEKLY**: weekly backups
            /// *   **MONTHLY**: monthly backups
            /// *   **YEARLY**: yearly backups
            /// </summary>
            [NameInMap("AdvancedRetentionType")]
            [Validation(Required=false)]
            public string AdvancedRetentionType { get; set; }

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
            /// The time when the backup snapshot was created.
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
            /// The snapshot details.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeUdmSnapshotsResponseBodySnapshotsDetail Detail { get; set; }
            public class DescribeUdmSnapshotsResponseBodySnapshotsDetail : TeaModel {
                /// <summary>
                /// The consistency level.
                /// </summary>
                [NameInMap("ConsistentLevel")]
                [Validation(Required=false)]
                public string ConsistentLevel { get; set; }

                /// <summary>
                /// Indicates whether the system disk is included.
                /// </summary>
                [NameInMap("ContainOsDisk")]
                [Validation(Required=false)]
                public bool? ContainOsDisk { get; set; }

                /// <summary>
                /// The type of the source disk.
                /// </summary>
                [NameInMap("DiskCategory")]
                [Validation(Required=false)]
                public string DiskCategory { get; set; }

                /// <summary>
                /// The name of the disk.
                /// </summary>
                [NameInMap("DiskDevName")]
                [Validation(Required=false)]
                public string DiskDevName { get; set; }

                /// <summary>
                /// The mapping between the device and the recovery point ID.
                /// </summary>
                [NameInMap("DiskHbrSnapshotIdWithDeviceMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> DiskHbrSnapshotIdWithDeviceMap { get; set; }

                /// <summary>
                /// The IDs of the disks that are backed up at the recovery point.
                /// </summary>
                [NameInMap("DiskIdList")]
                [Validation(Required=false)]
                public List<string> DiskIdList { get; set; }

                /// <summary>
                /// The reason for the downgrade.
                /// </summary>
                [NameInMap("DowngradeReason")]
                [Validation(Required=false)]
                public string DowngradeReason { get; set; }

                /// <summary>
                /// The hostname.
                /// </summary>
                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                /// <summary>
                /// The mapping between the instance ID and the disk ID.
                /// </summary>
                [NameInMap("InstanceIdWithDiskIdListMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> InstanceIdWithDiskIdListMap { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The specifications of the source instance.
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// Indicates whether the backup is created by the instant clone feature.
                /// </summary>
                [NameInMap("InstantAccess")]
                [Validation(Required=false)]
                public bool? InstantAccess { get; set; }

                /// <summary>
                /// The list of snapshot IDs, corresponding to DiskIdList.
                /// </summary>
                [NameInMap("NativeSnapshotIdList")]
                [Validation(Required=false)]
                public List<string> NativeSnapshotIdList { get; set; }

                /// <summary>
                /// The ID of the system disk.
                /// </summary>
                [NameInMap("OsDiskId")]
                [Validation(Required=false)]
                public string OsDiskId { get; set; }

                /// <summary>
                /// The name of the operating system.
                /// </summary>
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }

                /// <summary>
                /// The English name of the operating system.
                /// </summary>
                [NameInMap("OsNameEn")]
                [Validation(Required=false)]
                public string OsNameEn { get; set; }

                /// <summary>
                /// The type of the operating system. Valid values: linux and windows.
                /// </summary>
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }

                /// <summary>
                /// The performance level of the source disk.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// The system platform.
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

                /// <summary>
                /// The ID of the snapshot group.
                /// </summary>
                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }

                /// <summary>
                /// Indicates whether the disk is a system disk.
                /// </summary>
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public bool? SystemDisk { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("VmName")]
                [Validation(Required=false)]
                public string VmName { get; set; }

            }

            /// <summary>
            /// The ID of the cloud disk or local disk.
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// The expiration time of the backup.
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            /// <summary>
            /// The ID of the ECS instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The ID of the backup job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The ID of the backup snapshot.
            /// </summary>
            [NameInMap("NativeSnapshotId")]
            [Validation(Required=false)]
            public string NativeSnapshotId { get; set; }

            /// <summary>
            /// The snapshot information.
            /// </summary>
            [NameInMap("NativeSnapshotInfo")]
            [Validation(Required=false)]
            public string NativeSnapshotInfo { get; set; }

            /// <summary>
            /// The hash value of the parent backup snapshot.
            /// </summary>
            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            /// <summary>
            /// The prefix of the backup snapshot.
            /// </summary>
            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            /// <summary>
            /// The timestamp of the backup snapshot. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("RealSnapshotTime")]
            [Validation(Required=false)]
            public long? RealSnapshotTime { get; set; }

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
            /// *   **UDM_ECS**: ECS instance backup
            /// *   **UDM_ECS_DISK**: disk backup subtask of ECS instance backup
            /// *   **UDM_DISK**: disk backup
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// The time when the backup snapshot was created. The value is a UNIX timestamp. Unit: seconds.
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
            /// The time when the backup snapshot was updated. The value is a UNIX timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        /// <summary>
        /// Indicates whether the call is successful. Valid values:
        /// 
        /// *   true: The call is successful.
        /// *   false: The call fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of backup snapshots.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
