// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupsResponseBody : TeaModel {
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
                /// <para>The end time of the backup task. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-15T07:30:20Z</para>
                /// </summary>
                [NameInMap("BackupEndTime")]
                [Validation(Required=false)]
                public string BackupEndTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup set.</para>
                /// 
                /// <b>Example:</b>
                /// <para>61*******</para>
                /// </summary>
                [NameInMap("BackupId")]
                [Validation(Required=false)]
                public string BackupId { get; set; }

                /// <summary>
                /// <para>The backup method. Only <b>Snapshot</b> may be returned.</para>
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
                /// <para>The size of the backup set. Unit: bytes.</para>
                /// <remarks>
                /// <para>After you delete the target snapshot backups, the storage space that is consumed by the backups is released. The released storage space is smaller than the size of the backup file, because the snapshots share specific data blocks. For more information, see <a href="https://help.aliyun.com/document_detail/164881.html">FAQ about backup</a>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4639948800</para>
                /// </summary>
                [NameInMap("BackupSetSize")]
                [Validation(Required=false)]
                public string BackupSetSize { get; set; }

                /// <summary>
                /// <para>The start time of the backup task. The time is displayed in UTC. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-15T07:30:05Z</para>
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
                /// <para>The type of the backup. Only <b>FullBackup</b> may be returned.</para>
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
                /// <item><description><b>Level-1</b></description></item>
                /// <item><description><b>Level-2</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Level-1</para>
                /// </summary>
                [NameInMap("BackupsLevel")]
                [Validation(Required=false)]
                public string BackupsLevel { get; set; }

                /// <summary>
                /// <para>The snapshot checkpoint time. The value follows the Unix time format. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1605425407</para>
                /// </summary>
                [NameInMap("ConsistentTime")]
                [Validation(Required=false)]
                public string ConsistentTime { get; set; }

                /// <summary>
                /// <para>The ID of the cluster.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pc-****************</para>
                /// </summary>
                [NameInMap("DBClusterId")]
                [Validation(Required=false)]
                public string DBClusterId { get; set; }

                /// <summary>
                /// <para>The expected expiration time of the backup set (This parameter is supported only for clusters for which sparse backup is enabled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-10-24T08:13:23Z</para>
                /// </summary>
                [NameInMap("ExpectExpireTime")]
                [Validation(Required=false)]
                public string ExpectExpireTime { get; set; }

                /// <summary>
                /// <para>The expected expiration type of the backup set (This parameter is supported only for instances that are enabled with sparse backup).</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>NEVER</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>EXPIRED</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- -->
                /// </description></item>
                /// <item><description><para>DELAY</para>
                /// <!-- -->
                /// 
                /// <!-- -->
                /// 
                /// <!-- --></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>EXPIRED</para>
                /// </summary>
                [NameInMap("ExpectExpireType")]
                [Validation(Required=false)]
                public string ExpectExpireType { get; set; }

                /// <summary>
                /// <para>Indicates whether the backup set is available. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: The backup set is unavailable.</description></item>
                /// <item><description><b>1</b>: The backup set is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IsAvail")]
                [Validation(Required=false)]
                public string IsAvail { get; set; }

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
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public string PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4639948800</para>
        /// </summary>
        [NameInMap("TotalLevel2BackupSize")]
        [Validation(Required=false)]
        public string TotalLevel2BackupSize { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public string TotalRecordCount { get; set; }

    }

}
