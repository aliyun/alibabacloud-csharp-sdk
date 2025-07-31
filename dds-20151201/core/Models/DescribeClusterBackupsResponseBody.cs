// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeClusterBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The cluster backup sets. A cluster backup file contains the backup sets of each node.</para>
        /// </summary>
        [NameInMap("ClusterBackups")]
        [Validation(Required=false)]
        public List<DescribeClusterBackupsResponseBodyClusterBackups> ClusterBackups { get; set; }
        public class DescribeClusterBackupsResponseBodyClusterBackups : TeaModel {
            /// <summary>
            /// <para>The backup status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>init</b>: The backup is being initialized.</description></item>
            /// <item><description><b>No_Need</b>: Log backup is not performed.</description></item>
            /// <item><description><b>Running</b>: Log backup is being performed.</description></item>
            /// <item><description><b>Ready</b>: Log backup is complete.</description></item>
            /// <item><description><b>Failed</b>: Log backup failed.</description></item>
            /// </list>
            /// <remarks>
            /// <para> If the <b>ClusterBackupStatus</b> parameter is set to OK, full backup is successful. If you want to perform point-in-time-restoration on an instance for which log backup is enabled or to implement consistency restoration, make sure that log backup is complete.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Ready</para>
            /// </summary>
            [NameInMap("AttachLogStatus")]
            [Validation(Required=false)]
            public string AttachLogStatus { get; set; }

            [NameInMap("BackupExpireTime")]
            [Validation(Required=false)]
            public string BackupExpireTime { get; set; }

            /// <summary>
            /// <para>The collection of the backup sets of each child node in a cluster backup set.</para>
            /// </summary>
            [NameInMap("Backups")]
            [Validation(Required=false)]
            public List<DescribeClusterBackupsResponseBodyClusterBackupsBackups> Backups { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsBackups : TeaModel {
                /// <summary>
                /// <para>The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, an empty string is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/xxx">http://oss.com/xxx</a></para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-16T19:33:20Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>738025367</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the backup set over an internal network. If the backup set cannot be downloaded, null is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://oss.com/xxx">http://oss.com/xxx</a></para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The backup name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345678.tar.gz</para>
                /// </summary>
                [NameInMap("BackupName")]
                [Validation(Required=false)]
                public string BackupName { get; set; }

                /// <summary>
                /// <para>The size of the backup file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>77544597650</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public string BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-16T19:33:20Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b>: The backup task is successful.</description></item>
                /// <item><description><b>Failed</b>: The backup task failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The information of the node associated with the backup.</para>
                /// </summary>
                [NameInMap("ExtraInfo")]
                [Validation(Required=false)]
                public DescribeClusterBackupsResponseBodyClusterBackupsBackupsExtraInfo ExtraInfo { get; set; }
                public class DescribeClusterBackupsResponseBodyClusterBackupsBackupsExtraInfo : TeaModel {
                    /// <summary>
                    /// <para>The instance type of the node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mdb.shard.4x.large.d</para>
                    /// </summary>
                    [NameInMap("InstanceClass")]
                    [Validation(Required=false)]
                    public string InstanceClass { get; set; }

                    /// <summary>
                    /// <para>The node ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>d-2ze75ab1fa5d****</para>
                    /// </summary>
                    [NameInMap("NodeId")]
                    [Validation(Required=false)]
                    public string NodeId { get; set; }

                    /// <summary>
                    /// <para>The node type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>db</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The storage capacity of the node. Unit: MB.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20480</para>
                    /// </summary>
                    [NameInMap("StorageSize")]
                    [Validation(Required=false)]
                    public string StorageSize { get; set; }

                }

                /// <summary>
                /// <para>The shard name.</para>
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

            }

            /// <summary>
            /// <para>The end of the time range within which the cluster backup is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("ClusterBackupEndTime")]
            [Validation(Required=false)]
            public string ClusterBackupEndTime { get; set; }

            /// <summary>
            /// <para>The backup set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cb-o8c2ugnxo26kx***</para>
            /// </summary>
            [NameInMap("ClusterBackupId")]
            [Validation(Required=false)]
            public string ClusterBackupId { get; set; }

            /// <summary>
            /// <para>The cluster backup mode.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("ClusterBackupMode")]
            [Validation(Required=false)]
            public string ClusterBackupMode { get; set; }

            /// <summary>
            /// <para>The size of the cluster backup set. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>107374182400</para>
            /// </summary>
            [NameInMap("ClusterBackupSize")]
            [Validation(Required=false)]
            public string ClusterBackupSize { get; set; }

            /// <summary>
            /// <para>The beginning of the time range within which the cluster backup is performed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-10-16T19:33:20Z</para>
            /// </summary>
            [NameInMap("ClusterBackupStartTime")]
            [Validation(Required=false)]
            public string ClusterBackupStartTime { get; set; }

            /// <summary>
            /// <para>The status of the cluster backup set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("ClusterBackupStatus")]
            [Validation(Required=false)]
            public string ClusterBackupStatus { get; set; }

            /// <summary>
            /// <para>Version of the backuped instance.</para>
            /// <list type="bullet">
            /// <item><description><b>6.0</b></description></item>
            /// <item><description><b>5.0</b></description></item>
            /// <item><description><b>4.4</b></description></item>
            /// <item><description><b>4.2</b></description></item>
            /// <item><description><b>4.0</b></description></item>
            /// <item><description><b>3.4</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4.2</para>
            /// </summary>
            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The additional information in the JSON format.</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo ExtraInfo { get; set; }
            public class DescribeClusterBackupsResponseBodyClusterBackupsExtraInfo : TeaModel {
                /// <summary>
                /// <para>Indicates whether the cluster backups are migrated from the historical backup sets. If the value of this parameter is <b>1</b>, the cluster backups are migrated from the historical backup sets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RegistryFromHistory")]
                [Validation(Required=false)]
                public string RegistryFromHistory { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the cluster backup sets take effect. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The cluster backup sets take effect.</description></item>
            /// <item><description><b>0</b>: The backup sets of child nodes are incomplete or fail.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsAvail")]
            [Validation(Required=false)]
            public int? IsAvail { get; set; }

            /// <summary>
            /// <para>The progress of the backup task. Unit: %. The progress is returned only for running backup tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The page number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
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
        /// <para>2F42BB4E-461F-5B55-A37C-53B1141C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
