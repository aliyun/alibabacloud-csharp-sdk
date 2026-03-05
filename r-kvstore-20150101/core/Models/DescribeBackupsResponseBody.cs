// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The following parameters are no longer used. Ignore the parameters.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupsResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
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
                public long? BackupId { get; set; }

                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                [NameInMap("BackupJobID")]
                [Validation(Required=false)]
                public long? BackupJobID { get; set; }

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

                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

                [NameInMap("RecoverConfigMode")]
                [Validation(Required=false)]
                public string RecoverConfigMode { get; set; }

            }

        }

        /// <summary>
        /// <para>This parameter does not take effect. Ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("FreeSize")]
        [Validation(Required=false)]
        public long? FreeSize { get; set; }

        /// <summary>
        /// <para>The size of the full backup file of the instance. Unit: bytes. Full backups originate from scheduled backups, manual backups, and backups generated during cache analysis.</para>
        /// <remarks>
        /// <para> The value of this parameter is independent of the number and size of the returned backup sets. Instead, it reflects the total size of all valid full backups of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        /// <summary>
        /// <para>The size of the log backup file of the instance. Unit: bytes. This value is valid only when flashback is enabled.</para>
        /// <remarks>
        /// <para> The value of this parameter is independent of the number and size of the returned backup sets. Instead, it reflects the total size of all valid log backups of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>963C20F0-7CE1-4591-AAF3-6F3CD1CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of backup files that were returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
