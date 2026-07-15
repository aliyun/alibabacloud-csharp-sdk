// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeClusterBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the cluster backup sets. A cluster backup contains the backup sets of all nodes.</para>
        /// </summary>
        [NameInMap("ClusterBackups")]
        [Validation(Required=false)]
        public List<DescribeClusterBackupsResponseBodyClusterBackups> ClusterBackups { get; set; }
        public class DescribeClusterBackupsResponseBodyClusterBackups : TeaModel {
            /// <summary>
            /// <para>The status of the attached log backup. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Init</b>: initialization.</para>
            /// </description></item>
            /// <item><description><para><b>No_Need</b>: No attached log backup is available.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: The attached log backup is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>Ready</b>: The attached log backup is complete.</para>
            /// </description></item>
            /// <item><description><para><b>Failed</b>: The attached log backup failed.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>If the value of the <b>ClusterBackupStatus</b> parameter is OK, it only indicates that the full backup was successful. For a cluster instance for which log backup is enabled, the attached log backup must be complete before you can perform a point-in-time restore or ensure data consistency.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("AttachLogStatus")]
            [Validation(Required=false)]
            public string AttachLogStatus { get; set; }

            /// <summary>
            /// <para>The time when the backup expires. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>A value of &quot;9999-01-01T00:00:00Z&quot; indicates that the backup is permanently retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-03-29T03:47:12Z</para>
            /// </summary>
            [NameInMap("BackupExpireTime")]
            [Validation(Required=false)]
            public string BackupExpireTime { get; set; }

            /// <summary>
            /// <para>The backup sets of each child node in the cluster backup.</para>
            /// </summary>
            [NameInMap("Backups")]
            [Validation(Required=false)]
            public List<DescribeClusterBackupsResponseBodyClusterBackupsBackups> Backups { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsBackups : TeaModel {
                /// <summary>
                /// <para>The public URL from which you can download the backup file. If the backup file is unavailable for download, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/xxx">http://oss.com/xxx</a></para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The time when the backup finished. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-16T19:33:20Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>738025367</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The internal URL from which you can download the backup file. If the backup file is unavailable for download, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/xxx">http://oss.com/xxx</a></para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The name of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678.tar.gz</para>
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// <para>The size of the backup file, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>77544597650</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public string BackupSize { get; set; }

                /// <summary>
                /// <para>The time when the backup started. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-16T19:33:20Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The backup status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>Success</b>: The backup is successful.</para>
                /// </description></item>
                /// <item><description><para><b>Failed</b>: The backup failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The information about the instance node that is associated with the backup.</para>
                /// </summary>
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeClusterBackupsResponseBodyClusterBackupsBackupsExtraInfo ExtraInfo { get; set; }
                public class DescribeClusterBackupsResponseBodyClusterBackupsBackupsExtraInfo : TeaModel {
                    /// <summary>
                    /// <para>The specifications of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mdb.shard.4x.large.d</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>The ID of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-2ze75ab1fa5d****</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The type of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The storage space of the node, in MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20480</para>
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public string StorageSize { get; set; }

                }

                /// <summary>
                /// <para>The name of the shard in the MongoDB cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-bp16cb162771****</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: unavailable.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: available.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

            }

            /// <summary>
            /// <para>The time when the cluster backup finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("ClusterBackupEndTime")]
            [Validation(Required=false)]
            public string ClusterBackupEndTime { get; set; }

            /// <summary>
            /// <para>The ID of the cluster backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb-o8c2ugnxo26kx***</para>
            /// </summary>
            [NameInMap("ClusterBackupId")]
            [Validation(Required=false)]
            public string ClusterBackupId { get; set; }

            /// <summary>
            /// <para>The mode of the cluster backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("ClusterBackupMode")]
            [Validation(Required=false)]
            public string ClusterBackupMode { get; set; }

            /// <summary>
            /// <para>The size of the cluster backup set, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("ClusterBackupSize")]
            [Validation(Required=false)]
            public string ClusterBackupSize { get; set; }

            /// <summary>
            /// <para>The time when the cluster backup started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("ClusterBackupStartTime")]
            [Validation(Required=false)]
            public string ClusterBackupStartTime { get; set; }

            /// <summary>
            /// <para>The status of the cluster backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ClusterBackupStatus")]
            [Validation(Required=false)]
            public string ClusterBackupStatus { get; set; }

            /// <summary>
            /// <para>The database engine version of the instance when the backup was created. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>7.0</b></para>
            /// </description></item>
            /// <item><description><para><b>6.0</b></para>
            /// </description></item>
            /// <item><description><para><b>5.0</b></para>
            /// </description></item>
            /// <item><description><para><b>4.4</b></para>
            /// </description></item>
            /// <item><description><para><b>4.2</b></para>
            /// </description></item>
            /// <item><description><para><b>4.0</b></para>
            /// </description></item>
            /// <item><description><para><b>3.4</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4.2</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The supplementary information. The value is a JSON-formatted string.</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo ExtraInfo { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the backup set was migrated from a historical backup. A value of <b>1</b> indicates that the backup was migrated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistryFromHistory")]
                [Validation(Required=false)]
                public string RegistryFromHistory { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the cluster backup set is valid. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: The cluster backup set is valid.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: The backup sets of child nodes are not complete or have failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsAvail")]
            [Validation(Required=false)]
            public int? IsAvail { get; set; }

            /// <summary>
            /// <para>The backup progress in percentage.
            /// This parameter is returned only for backups that are in progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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
        /// <para>The number of entries returned per page.</para>
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
        /// <para>2F42BB4E-461F-5B55-A37C-53B1141C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
