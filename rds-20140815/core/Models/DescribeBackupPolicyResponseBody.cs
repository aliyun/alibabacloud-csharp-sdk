// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        [NameInMap("PreferredNextBackupTime")]
        [Validation(Required=false)]
        public string PreferredNextBackupTime { get; set; }

        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        [NameInMap("BackupLog")]
        [Validation(Required=false)]
        public string BackupLog { get; set; }

        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        [NameInMap("LocalLogRetentionHours")]
        [Validation(Required=false)]
        public int? LocalLogRetentionHours { get; set; }

        [NameInMap("LocalLogRetentionSpace")]
        [Validation(Required=false)]
        public string LocalLogRetentionSpace { get; set; }

        [NameInMap("Duplication")]
        [Validation(Required=false)]
        public string Duplication { get; set; }

        [NameInMap("DuplicationContent")]
        [Validation(Required=false)]
        public string DuplicationContent { get; set; }

        [NameInMap("HighSpaceUsageProtection")]
        [Validation(Required=false)]
        public string HighSpaceUsageProtection { get; set; }

        [NameInMap("LogBackupFrequency")]
        [Validation(Required=false)]
        public string LogBackupFrequency { get; set; }

        [NameInMap("CompressType")]
        [Validation(Required=false)]
        public string CompressType { get; set; }

        [NameInMap("ArchiveBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string ArchiveBackupRetentionPeriod { get; set; }

        [NameInMap("ArchiveBackupKeepPolicy")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepPolicy { get; set; }

        [NameInMap("ArchiveBackupKeepCount")]
        [Validation(Required=false)]
        public string ArchiveBackupKeepCount { get; set; }

        [NameInMap("ReleasedKeepPolicy")]
        [Validation(Required=false)]
        public string ReleasedKeepPolicy { get; set; }

        [NameInMap("LogBackupLocalRetentionNumber")]
        [Validation(Required=false)]
        public int? LogBackupLocalRetentionNumber { get; set; }

        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("SupportReleasedKeep")]
        [Validation(Required=false)]
        public int? SupportReleasedKeep { get; set; }

        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public string BackupInterval { get; set; }

        [NameInMap("DuplicationLocation")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyDuplicationLocation DuplicationLocation { get; set; }
        public class DescribeBackupPolicyResponseBodyDuplicationLocation : TeaModel {
            [NameInMap("Sotrage")]
            [Validation(Required=false)]
            public string Sotrage { get; set; }
            [NameInMap("Location")]
            [Validation(Required=false)]
            public DescribeBackupPolicyResponseBodyDuplicationLocationLocation Location { get; set; }
            public class DescribeBackupPolicyResponseBodyDuplicationLocationLocation : TeaModel {
                [NameInMap("Endpoint")]
                [Validation(Required=false)]
                public string Endpoint { get; set; }

                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

            }
        };

    }

}
