// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDetachedBackupsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the backup sets.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDetachedBackupsResponseBodyItems Items { get; set; }
        public class DescribeDetachedBackupsResponseBodyItems : TeaModel {
            [NameInMap("Backup")]
            [Validation(Required=false)]
            public List<DescribeDetachedBackupsResponseBodyItemsBackup> Backup { get; set; }
            public class DescribeDetachedBackupsResponseBodyItemsBackup : TeaModel {
                /// <summary>
                /// <para>The end time of the backup task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-05-12T03:25:55Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>111111111</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The backup method. Only snapshot backups are supported. The value is set to <b>Snapshot</b>.</para>
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
                /// <para>Manual</para>
                /// </summary>
                [NameInMap("BackupMode")]
                [Validation(Required=false)]
                public string BackupMode { get; set; }

                /// <summary>
                /// <para>The size of the backup set. Unit: bytes.</para>
                /// <remarks>
                /// <para>After you delete the target snapshot backups, the storage space consumed by the backups is released. The released storage space is smaller than the size of the backup file, because the snapshots share certain data blocks.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>7251056</para>
                /// </summary>
                [NameInMap("BackupSetSize")]
                [Validation(Required=false)]
                public string BackupSetSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-05-12T03:25:44Z</para>
                /// </summary>
                [NameInMap("BackupStartTime")]
                [Validation(Required=false)]
                public string BackupStartTime { get; set; }

                /// <summary>
                /// <para>The status of the backup set. Valid values:</para>
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
                /// <para>The type of the backup. Only full backups are supported. The value is set to <b>FullBackup</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FullBackup</para>
                /// </summary>
                [NameInMap("BackupType")]
                [Validation(Required=false)]
                public string BackupType { get; set; }

                /// <summary>
                /// <para>The level of the backup set. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Level-1</b>: level-1 backup set</description></item>
                /// <item><description><b>Level-2</b>: level-2 backup set</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Level-2</para>
                /// </summary>
                [NameInMap("BackupsLevel")]
                [Validation(Required=false)]
                public string BackupsLevel { get; set; }

                /// <summary>
                /// <para>The snapshot checkpoint time. The value is a Unix timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1589253947</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-**************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The data backup set is unavailable.</description></item>
                /// <item><description><b>1</b>: The data backup set is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

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
        /// <para>15</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>717B2382-BB14-4DCB-BBC2-32DBE0******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
