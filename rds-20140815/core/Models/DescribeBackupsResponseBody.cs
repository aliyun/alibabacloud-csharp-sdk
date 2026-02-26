// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupsResponseBodyItems Items { get; set; }
        public class DescribeBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeBackupsResponseBodyItemsBackup : TeaModel {
                [NameInMap("BackupDownloadLinkByDB")]
                [Validation(Required=false)]
                public DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB BackupDownloadLinkByDB { get; set; }
                public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDB : TeaModel {
                    [NameInMap("BackupDownloadLinkByDB")]
                    [Validation(Required=false)]
                    public List<DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB> BackupDownloadLinkByDB { get; set; }
                    public class DescribeBackupsResponseBodyItemsBackupBackupDownloadLinkByDBBackupDownloadLinkByDB : TeaModel {
                        [NameInMap("DataBase")]
                        [Validation(Required=false)]
                        public string DataBase { get; set; }

                        [NameInMap("DownloadLink")]
                        [Validation(Required=false)]
                        public string DownloadLink { get; set; }

                        [NameInMap("IntranetDownloadLink")]
                        [Validation(Required=false)]
                        public string IntranetDownloadLink { get; set; }

                    }

                }

                [NameInMap("BackupDownloadURL")]
                [Validation(Required=false)]
                public string BackupDownloadURL { get; set; }

                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                [NameInMap("BackupInitiator")]
                [Validation(Required=false)]
                public string BackupInitiator { get; set; }

                [NameInMap("BackupIntranetDownloadURL")]
                [Validation(Required=false)]
                public string BackupIntranetDownloadURL { get; set; }

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

                [NameInMap("Checksum")]
                [Validation(Required=false)]
                public string Checksum { get; set; }

                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public long? ConsistentTime { get; set; }

                [NameInMap("CopyOnlyBackup")]
                [Validation(Required=false)]
                public string CopyOnlyBackup { get; set; }

                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public string Encryption { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                [NameInMap("HostInstanceID")]
                [Validation(Required=false)]
                public string HostInstanceID { get; set; }

                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public int? IsAvail { get; set; }

                [NameInMap("MetaStatus")]
                [Validation(Required=false)]
                public string MetaStatus { get; set; }

                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

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
