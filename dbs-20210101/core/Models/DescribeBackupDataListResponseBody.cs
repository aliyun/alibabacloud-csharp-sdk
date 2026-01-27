// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20210101.Models
{
    public class DescribeBackupDataListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeBackupDataListResponseBodyData Data { get; set; }
        public class DescribeBackupDataListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the task.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<DescribeBackupDataListResponseBodyDataContent> Content { get; set; }
            public class DescribeBackupDataListResponseBodyDataContent : TeaModel {
                /// <summary>
                /// <para>The URL that is used to download the backup set over the Internet.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the value of BackupMethod is <b>Physical</b> or <b>Logical</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/">http://oss.com/</a>****</para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup. The time is in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-17T17:00:32Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>213088****</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the backup set over the internal network.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the value of BackupMethod is <b>Physical</b> or <b>Logical</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/">http://oss.com/</a>****</para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The storage path of backup files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic</para>
                /// </summary>
                [NameInMap("BackupLocation")]
                [Validation(Required=false)]
                public string BackupLocation { get; set; }

                /// <summary>
                /// <para>The backup method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Physical</b></description></item>
                /// <item><description><b>Logical</b></description></item>
                /// <item><description><b>Snapshot</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Snapshot</para>
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
                /// <para>The name of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>logic_backup</para>
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// <para>The backup scale. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DBInstance</b></description></item>
                /// <item><description><b>DBTable</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DBInstance</para>
                /// </summary>
                [NameInMap("BackupScale")]
                [Validation(Required=false)]
                public string BackupScale { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: byte.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25669140480</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup. The time is in the yyyy-MM-ddTHH:mm:ssZ format. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-17T17:00:16Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The backup succeeded.</description></item>
                /// <item><description><b>ERROR</b>: The backup failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The backup type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>FullBackup</b></description></item>
                /// <item><description><b>IncrementBackup</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FullBackup</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>The checksum value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84a4c16431f969712e6895992719****</para>
                /// </summary>
                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                /// <summary>
                /// <para>The snapshot checkpoint time. This value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1713373221</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                /// <summary>
                /// <para>The information about the encryption.</para>
                /// 
                /// <b>Example:</b>
                /// <para>psk2</para>
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                /// <summary>
                /// <para>The type of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polardb_mysql</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The engine version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The time when the backup set expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-19T05:00:49Z</para>
                /// </summary>
                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set expires. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>NEVER: The backup set does not expire.</description></item>
                /// <item><description>EXPIRED: The backup set expired.</description></item>
                /// <item><description>DELAY: The backup set expires after a specific period of time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>DELAY</para>
                /// </summary>
                [NameInMap("ExpectExpireType")]
                [Validation(Required=false)]
                public string ExpectExpireType { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-2ze3nrr64c5******</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: The backup set is available.</description></item>
                /// <item><description><b>0</b>: The backup set is unavailable.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                /// <summary>
                /// <para>The information about the PolarDB level-2 dump.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the level-2 dump feature is enabled for the PolarDB for MySQL cluster and the level-1 backup is dumped.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("PolarSnapshot")]
                [Validation(Required=false)]
                public DescribeBackupDataListResponseBodyDataContentPolarSnapshot PolarSnapshot { get; set; }
                public class DescribeBackupDataListResponseBodyDataContentPolarSnapshot : TeaModel {
                    /// <summary>
                    /// <para>The dump backup ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>abc****</para>
                    /// </summary>
                    [NameInMap("DumpId")]
                    [Validation(Required=false)]
                    public long? DumpId { get; set; }

                    /// <summary>
                    /// <para>The size of the dump backup. Unit: byte.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25669140589</para>
                    /// </summary>
                    [NameInMap("DumpSize")]
                    [Validation(Required=false)]
                    public long? DumpSize { get; set; }

                    /// <summary>
                    /// <para>The time when the backup set expires. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-04-19T05:00:49Z</para>
                    /// </summary>
                    [NameInMap("ExpectExpireTime")]
                    [Validation(Required=false)]
                    public string ExpectExpireTime { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the backup set expires. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>NEVER: The backup set does not expire.</description></item>
                    /// <item><description>EXPIRED: The backup set expired.</description></item>
                    /// <item><description>DELAY: The backup set expires after a specific period of time.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DELAY</para>
                    /// </summary>
                    [NameInMap("expectExpireType")]
                    [Validation(Required=false)]
                    public string ExpectExpireType { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the backup set can be deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The backup set can be deleted.</description></item>
                /// <item><description><b>1</b>: The backup set cannot be deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SupportDeletion")]
                [Validation(Required=false)]
                public int? SupportDeletion { get; set; }

            }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dbtest</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of backup sets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalElements")]
            [Validation(Required=false)]
            public long? TotalElements { get; set; }

            /// <summary>
            /// <para>The total number of pages returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPages")]
            [Validation(Required=false)]
            public long? TotalPages { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request.Forbidden</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95A5FFD0-7F46-5A7D-9DFE-6A376B4E2A28</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
