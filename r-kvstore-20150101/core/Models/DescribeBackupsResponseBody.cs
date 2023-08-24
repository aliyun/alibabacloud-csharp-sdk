// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupsResponseBodyAccessDeniedDetail : TeaModel {
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        [NameInMap("Backups")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyBackups Backups { get; set; }
        public class DescribeBackupsResponseBodyBackups : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyBackupsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyBackupsBackup : TeaModel {
                [NameInMap("BackupDBNames")]
                [Validation(Required=false)]
                public string BackupDBNames { get; set; }

                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public int? BackupId { get; set; }

                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                [NameInMap("BackupJobID")]
                [Validation(Required=false)]
                public int? BackupJobID { get; set; }

                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
