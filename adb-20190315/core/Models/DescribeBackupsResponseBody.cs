// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The free size of backup sets. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("FreeBackupSize")]
        [Validation(Required=false)]
        public long? FreeBackupSize { get; set; }

        /// <summary>
        /// <para>The queried backup sets.</para>
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
                /// <para>The end time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-02T16:00Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The expiration time of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-07-02T16:00Z</para>
                /// </summary>
                [NameInMap("BackupExpiredTime")]
                [Validation(Required=false)]
                public string BackupExpiredTime { get; set; }

                /// <summary>
                /// <para>The backup set ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32732****</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The backup method. Only Snapshot is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Snapshot</para>
                /// </summary>
                [NameInMap("BackupMethod")]
                [Validation(Required=false)]
                public string BackupMethod { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2167808</para>
                /// </summary>
                [NameInMap("BackupSize")]
                [Validation(Required=false)]
                public long? BackupSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-06-01T16:00Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

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
                /// <para>The ID of the AnalyticDB for MySQL Data Warehouse Edition cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>am-bp18934i73vb5****</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total size of backup sets. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64953700</para>
        /// </summary>
        [NameInMap("TotalBackupSize")]
        [Validation(Required=false)]
        public long? TotalBackupSize { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
