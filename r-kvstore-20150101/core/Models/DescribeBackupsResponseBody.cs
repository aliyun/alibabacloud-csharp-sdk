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

        /// <summary>
        /// <para>Details of the backup files.</para>
        /// </summary>
        [NameInMap("Backups")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyBackups Backups { get; set; }
        public class DescribeBackupsResponseBodyBackups : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyBackupsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyBackupsBackup : TeaModel {
                /// <summary>
                /// <para>The names of the databases that are backed up. The default value is <b>all</b>, which indicates that all databases are backed up.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("BackupDBNames")]
                [Validation(Required=false)]
                public string BackupDBNames { get; set; }

                /// <summary>
                /// <para>The public download URL of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://rdsbak-hk45-v2.oss-cn-hongkong.aliyuncs.com/">https://rdsbak-hk45-v2.oss-cn-hongkong.aliyuncs.com/</a>********</para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-14T05:31:13Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>165*****50</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public long? BackupId { get; set; }

                /// <summary>
                /// <para>The internal download URL of the backup file.</para>
                /// <remarks>
                /// <para> You can use this URL to download the backup file from an Elastic Compute Service (ECS) instance that is connected to the ApsaraDB for Redis instance. The ECS instance must belong to the same classic network or reside in the same virtual private cloud (VPC) as the ApsaraDB for Redis instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://rdsbak-hk45-v2.oss-cn-hongkong.aliyuncs.com/">https://rdsbak-hk45-v2.oss-cn-hongkong.aliyuncs.com/</a>********</para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The ID of the backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24340</para>
                /// </summary>
                [NameInMap("BackupJobID")]
                [Validation(Required=false)]
                public long? BackupJobID { get; set; }

                /// <summary>
                /// <para>The backup method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Logical</b></description></item>
                /// <item><description><b>Physical</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Physical</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The backup mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Automated</b></description></item>
                /// <item><description><b>Manual</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Automated</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <para>The size of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-14T05:28:50Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The backup type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FullBackup</b></description></item>
                /// <item><description><b>IncrementalBackup</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullBackup</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>The engine version (major version) of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// <remarks>
                /// <para> If the instance uses the standard architecture, this parameter returns the instance ID.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp10noxlhcoim2****-db-1</para>
                /// </summary>
                [NameInMap("NodeInstanceId")]
                [Validation(Required=false)]
                public string NodeInstanceId { get; set; }

                /// <summary>
                /// <para>If the backup includes account information, kernel parameters and whitelist details.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;whitelist&quot;:true,&quot;config&quot;:true,&quot;account&quot;:true}</para>
                /// </summary>
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
