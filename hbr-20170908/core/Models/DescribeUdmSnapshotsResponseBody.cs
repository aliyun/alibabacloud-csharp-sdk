// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeUdmSnapshotsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Snapshots")]
        [Validation(Required=false)]
        public List<DescribeUdmSnapshotsResponseBodySnapshots> Snapshots { get; set; }
        public class DescribeUdmSnapshotsResponseBodySnapshots : TeaModel {
            [NameInMap("ActualBytes")]
            [Validation(Required=false)]
            public string ActualBytes { get; set; }

            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            [NameInMap("BytesTotal")]
            [Validation(Required=false)]
            public long? BytesTotal { get; set; }

            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public long? CompleteTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeUdmSnapshotsResponseBodySnapshotsDetail Detail { get; set; }
            public class DescribeUdmSnapshotsResponseBodySnapshotsDetail : TeaModel {
                [NameInMap("ConsistentLevel")]
                [Validation(Required=false)]
                public string ConsistentLevel { get; set; }
                [NameInMap("ContainOsDisk")]
                [Validation(Required=false)]
                public bool? ContainOsDisk { get; set; }
                [NameInMap("DiskDevName")]
                [Validation(Required=false)]
                public string DiskDevName { get; set; }
                [NameInMap("DiskHbrSnapshotIdWithDeviceMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> DiskHbrSnapshotIdWithDeviceMap { get; set; }
                [NameInMap("DiskIdList")]
                [Validation(Required=false)]
                public List<string> DiskIdList { get; set; }
                [NameInMap("DowngradeReason")]
                [Validation(Required=false)]
                public string DowngradeReason { get; set; }
                [NameInMap("InstanceIdWithDiskIdListMap")]
                [Validation(Required=false)]
                public Dictionary<string, string> InstanceIdWithDiskIdListMap { get; set; }
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }
                [NameInMap("NativeSnapshotIdList")]
                [Validation(Required=false)]
                public List<string> NativeSnapshotIdList { get; set; }
                [NameInMap("OsDiskId")]
                [Validation(Required=false)]
                public string OsDiskId { get; set; }
                [NameInMap("OsName")]
                [Validation(Required=false)]
                public string OsName { get; set; }
                [NameInMap("OsNameEn")]
                [Validation(Required=false)]
                public string OsNameEn { get; set; }
                [NameInMap("OsType")]
                [Validation(Required=false)]
                public string OsType { get; set; }
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }
                [NameInMap("SnapshotGroupId")]
                [Validation(Required=false)]
                public string SnapshotGroupId { get; set; }
                [NameInMap("SystemDisk")]
                [Validation(Required=false)]
                public bool? SystemDisk { get; set; }
                [NameInMap("VmName")]
                [Validation(Required=false)]
                public string VmName { get; set; }
            };

            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            [NameInMap("NativeSnapshotId")]
            [Validation(Required=false)]
            public string NativeSnapshotId { get; set; }

            [NameInMap("NativeSnapshotInfo")]
            [Validation(Required=false)]
            public string NativeSnapshotInfo { get; set; }

            [NameInMap("ParentSnapshotHash")]
            [Validation(Required=false)]
            public string ParentSnapshotHash { get; set; }

            [NameInMap("Prefix")]
            [Validation(Required=false)]
            public string Prefix { get; set; }

            [NameInMap("RealSnapshotTime")]
            [Validation(Required=false)]
            public long? RealSnapshotTime { get; set; }

            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            [NameInMap("SnapshotHash")]
            [Validation(Required=false)]
            public string SnapshotHash { get; set; }

            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
