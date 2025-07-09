// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeClusterBackupListResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup sets of the instance. A backup contains the backup sets of all shards in the instance.</para>
        /// </summary>
        [NameInMap("ClusterBackups")]
        [Validation(Required=false)]
        public List<DescribeClusterBackupListResponseBodyClusterBackups> ClusterBackups { get; set; }
        public class DescribeClusterBackupListResponseBodyClusterBackups : TeaModel {
            /// <summary>
            /// <para>The backup sets of all shards in the instance.</para>
            /// </summary>
            [NameInMap("Backups")]
            [Validation(Required=false)]
            public List<DescribeClusterBackupListResponseBodyClusterBackupsBackups> Backups { get; set; }
            public class DescribeClusterBackupListResponseBodyClusterBackupsBackups : TeaModel {
                /// <summary>
                /// <para>The public download URL of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbakbucket-huhehaote-v2.oss-cn-huhehaote.aliyuncs.com/custins424747958/hins100322105_data_20240110012135.rdb">http://rdsbakbucket-huhehaote-v2.oss-cn-huhehaote.aliyuncs.com/custins424747958/hins100322105_data_20240110012135.rdb</a></para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-09T17:21:57</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>514645788</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The internal download URL of the backup file.</para>
                /// <remarks>
                /// <para> You can use this URL to download the backup file from an Elastic Compute Service (ECS) instance that is connected to the Tair (Redis OSS-compatible) instance. The ECS instance must reside in the same virtual private cloud (VPC) as the Tair (Redis OSS-compatible) instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbakbucket-huhehaote-v2.oss-cn-huhehaote-internal.aliyuncs.com/custins424747958/hins100322105_data_20240110012135.rdb">http://rdsbakbucket-huhehaote-v2.oss-cn-huhehaote-internal.aliyuncs.com/custins424747958/hins100322105_data_20240110012135.rdb</a></para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The name of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hins100322105_data_20240110012135.rdb</para>
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// <para>The size of the backup file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public string BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-09T17:21:30Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b></description></item>
                /// <item><description><b>ERROR</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The database engine. The return value is <b>redis</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The additional information.</para>
                /// </summary>
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeClusterBackupListResponseBodyClusterBackupsBackupsExtraInfo ExtraInfo { get; set; }
                public class DescribeClusterBackupListResponseBodyClusterBackupsBackupsExtraInfo : TeaModel {
                    /// <summary>
                    /// <para>The engine version.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5.0</para>
                    /// </summary>
                    [NameInMap("CustinsDbVersion")]
                    [Validation(Required=false)]
                    public string CustinsDbVersion { get; set; }

                }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hins100322105_data_20240108012127.rdb</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: unavailable</description></item>
                /// <item><description><b>1</b>: available</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

                /// <summary>
                /// <para>This parameter does not take effect. Ignore this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RecoverConfigMode")]
                [Validation(Required=false)]
                public string RecoverConfigMode { get; set; }

            }

            /// <summary>
            /// <para>The end time of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-10T17:21:55Z</para>
            /// </summary>
            [NameInMap("ClusterBackupEndTime")]
            [Validation(Required=false)]
            public string ClusterBackupEndTime { get; set; }

            /// <summary>
            /// <para>The ID of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb-zmdqj2m3xyxjtdt0</para>
            /// </summary>
            [NameInMap("ClusterBackupId")]
            [Validation(Required=false)]
            public string ClusterBackupId { get; set; }

            /// <summary>
            /// <para>The backup mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("ClusterBackupMode")]
            [Validation(Required=false)]
            public string ClusterBackupMode { get; set; }

            /// <summary>
            /// <para>The size of the backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2048</para>
            /// </summary>
            [NameInMap("ClusterBackupSize")]
            [Validation(Required=false)]
            public string ClusterBackupSize { get; set; }

            /// <summary>
            /// <para>The start time of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-10T17:21:25Z</para>
            /// </summary>
            [NameInMap("ClusterBackupStartTime")]
            [Validation(Required=false)]
            public string ClusterBackupStartTime { get; set; }

            /// <summary>
            /// <para>The status of the backup set.</para>
            /// <list type="bullet">
            /// <item><description>OK</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ClusterBackupStatus")]
            [Validation(Required=false)]
            public string ClusterBackupStatus { get; set; }

            [NameInMap("ExpectExpireTime")]
            [Validation(Required=false)]
            public string ExpectExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the backup set is valid. A value of 0 indicates that shard-level backups failed or have not been completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsAvail")]
            [Validation(Required=false)]
            public int? IsAvail { get; set; }

            /// <summary>
            /// <para>The backup progress. The system displays only the progress of running backup tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The memory size of a single shard during a full backup. Unit: MB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("ShardClassMemory")]
            [Validation(Required=false)]
            public int? ShardClassMemory { get; set; }

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
        /// <para> The value of this parameter is independent of the number and size of returned backup sets. Instead, it represents the size of all valid full backups of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("FullStorageSize")]
        [Validation(Required=false)]
        public long? FullStorageSize { get; set; }

        /// <summary>
        /// <para>The size of the log backup file of the instance. Unit: bytes. This parameter is valid only when flashback is enabled.</para>
        /// <remarks>
        /// <para> The value of this parameter is independent of the number and size of returned backup sets. Instead, it represents the size of all valid log backups of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5000</para>
        /// </summary>
        [NameInMap("LogStorageSize")]
        [Validation(Required=false)]
        public long? LogStorageSize { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C009DA42-3B19-5B81-963D-1509DE2408DD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
