// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// <para>An array consisting of URLs from which you can download backup sets of individual databases.</para>
                /// </summary>
                [NameInMap("BackupDownloadLinkByDB")]
                [Validation(Required=false)]
                public DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB BackupDownloadLinkByDB { get; set; }
                public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB : TeaModel {
                    [NameInMap("BackupDownloadLinkByDB")]
                    [Validation(Required=false)]
                    public List<DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB> BackupDownloadLinkByDB { get; set; }
                    public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB : TeaModel {
                        /// <summary>
                        /// <para>The name of the database.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dbs</para>
                        /// </summary>
                        [NameInMap("DataBase")]
                        [Validation(Required=false)]
                        public string DataBase { get; set; }

                        /// <summary>
                        /// <para>The public URL from which you can download the backup set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://cn-hangzhou.bak.rds.aliyuncs.com/custins53664665/hins18676859_2021072909473127987849.zip?Expires=*****&dbList=tb1">https://cn-hangzhou.bak.rds.aliyuncs.com/custins53664665/hins18676859_2021072909473127987849.zip?Expires=*****&amp;dbList=tb1</a></para>
                        /// </summary>
                        [NameInMap("DownloadLink")]
                        [Validation(Required=false)]
                        public string DownloadLink { get; set; }

                        /// <summary>
                        /// <para>The internal URL from which you can download the backup set.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para><a href="https://cn-hangzhou-internal.bak.rds.aliyuncs.com/custins53664665/hins18676859_2021072909473127987849.zip?Expires=*****&dbList=tb1">https://cn-hangzhou-internal.bak.rds.aliyuncs.com/custins53664665/hins18676859_2021072909473127987849.zip?Expires=*****&amp;dbList=tb1</a></para>
                        /// </summary>
                        [NameInMap("IntranetDownloadLink")]
                        [Validation(Required=false)]
                        public string IntranetDownloadLink { get; set; }

                    }

                }

                /// <summary>
                /// <para>The URL that is used to download the backup set over the Internet. If the backup set cannot be downloaded, null is returned.</para>
                /// <remarks>
                /// <para> For example, if BackupMethod of an ApsaraDB RDS for SQL Server instance is set to <b>Snapshot</b>, a null string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbak-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx">http://rdsbak-hz-v3.oss-cn-hangzhou.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                /// <summary>
                /// <para>The end time of the backup task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-13T12:20:00Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>321020562</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The initiator of the backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>System</b></description></item>
                /// <item><description><b>User</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("BackupInitiator")]
                [Validation(Required=false)]
                public string BackupInitiator { get; set; }

                /// <summary>
                /// <para>The URL that is used to download the backup set over an internal network. If the backup set cannot be downloaded, null is returned.</para>
                /// <remarks>
                /// <para> For example, if BackupMethod of an ApsaraDB RDS for SQL Server instance is set to <b>Snapshot</b>, a null string is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://rdsbak-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxx">http://rdsbak-hz-v3.oss-cn-hangzhou-internal.aliyuncs.com/xxxxx</a></para>
                /// </summary>
                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

                /// <summary>
                /// <para>The method that is used to generate the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Logical</b>: logical backup</description></item>
                /// <item><description><b>Physical</b>: physical backup</description></item>
                /// <item><description><b>Snapshot</b>: snapshot backup</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Physical</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The backup mode of the backup set. Valid values:</para>
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
                /// <para>The size of the data backup file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2167808</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-02-03T12:20:00Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The state of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                /// <summary>
                /// <para>The backup type of the backup set. Valid values:</para>
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
                /// <para>The checksum. The value of this parameter is calculated by using the CRC64 algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1835830439**********</para>
                /// </summary>
                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                /// <summary>
                /// <para>The point in time at which the data in the backup set is consistent. The return value of this parameter is a timestamp.</para>
                /// <remarks>
                /// <para> If the instance runs MySQL 5.6, a timestamp is returned. Otherwise, the value 0 is returned.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1576506856</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                /// <summary>
                /// <para>The backup mode of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: the standard mode. This mode supports full backups and incremental backups.</description></item>
                /// <item><description>1: the copy-only mode. This mode supports only full backups.</description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only when the instance runs SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CopyOnlyBackup")]
                [Validation(Required=false)]
                public string CopyOnlyBackup { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-uf6wjk5xxxxxxx</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The encryption information about the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                /// <summary>
                /// <para>The type of the database engine. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MySQL</description></item>
                /// <item><description>SQLServer</description></item>
                /// <item><description>PostgreSQL</description></item>
                /// <item><description>MariaDB</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MySQL</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The version of the database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The ID of the instance that generates the backup set. This parameter is used to indicate whether the instance that generates the backup set is a primary instance or a secondary instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5882781</para>
                /// </summary>
                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The backup set is unavailable.</description></item>
                /// <item><description><b>1</b>: The backup set is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                /// <summary>
                /// <para>The status of the backup set that is used to restore individual databases or tables. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>OK</b>: The data backup file is normal.</description></item>
                /// <item><description><b>LARGE</b>: The data backup file contains an abnormally large number of tables. It cannot be used to restore individual databases or tables.</description></item>
                /// <item><description><b>EMPTY</b>: The data backup file is generated from a failed backup task.</description></item>
                /// </list>
                /// <remarks>
                /// <para> If an empty string is returned, the data backup file cannot be used to restore individual databases or tables.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("MetaStatus")]
                [Validation(Required=false)]
                public string MetaStatus { get; set; }

                /// <summary>
                /// <para>The storage class of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: regular storage</description></item>
                /// <item><description><b>1</b>: archive storage</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set can be deleted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Enabled</b>: The backup set can be deleted.</description></item>
                /// <item><description><b>Disabled</b>: The backup set cannot be deleted.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Disabled</para>
                /// </summary>
                [NameInMap("StoreStatus")]
                [Validation(Required=false)]
                public string StoreStatus { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of backup sets on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A6D328C-84B8-40DC-BF49-6C73984D7494</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The size of the snapshot chain of the instance. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalEcsSnapshotSize")]
        [Validation(Required=false)]
        public long? TotalEcsSnapshotSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
