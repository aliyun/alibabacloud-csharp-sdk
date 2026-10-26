// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The storage space occupied by archive backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ArchiveBackupSize")]
        [Validation(Required=false)]
        public long? ArchiveBackupSize { get; set; }

        /// <summary>
        /// <para>The total storage space occupied by data backups, excluding archive backups. Unit: bytes.</para>
        /// <remarks>
        /// <para>For <b>SQL Server</b> instances, this parameter indicates the total size of physical backups and snapshot backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>94324736</para>
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// <para>The storage space occupied by snapshot backups of <b>SQL Server</b> instances. Unit: bytes. A value of 0 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupEcsSnapshotSize")]
        [Validation(Required=false)]
        public string BackupEcsSnapshotSize { get; set; }

        /// <summary>
        /// <para>The total storage space occupied by log backups, excluding archive backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45145563</para>
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// <para>The size of data files in backup sets stored in OSS. Unit: bytes. A value of 0 indicates that no data is available.</para>
        /// <remarks>
        /// <para>For <b>SQL Server</b> instances, this parameter indicates the storage space occupied by physical backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8821760</para>
        /// </summary>
        [NameInMap("BackupOssDataSize")]
        [Validation(Required=false)]
        public long? BackupOssDataSize { get; set; }

        /// <summary>
        /// <para>The size of log files in backup sets stored in OSS. Unit: bytes. A value of 0 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44180999</para>
        /// </summary>
        [NameInMap("BackupOssLogSize")]
        [Validation(Required=false)]
        public long? BackupOssLogSize { get; set; }

        /// <summary>
        /// <para>The storage space occupied by backups, including data backups and log backups. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53002759</para>
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// <para>The storage space occupied by cold backups. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2337275904</para>
        /// </summary>
        [NameInMap("ColdBackupSize")]
        [Validation(Required=false)]
        public long? ColdBackupSize { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5******</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage space occupied by data files. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1292094741</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The used storage space, which is the sum of DataSize and LogSize. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2337275904</para>
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// <para>The database engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The storage space occupied by logs. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1045181163</para>
        /// </summary>
        [NameInMap("LogSize")]
        [Validation(Required=false)]
        public long? LogSize { get; set; }

        /// <summary>
        /// <para>The storage space occupied by backups that you are billed for after the free quota is deducted. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PaidBackupSize")]
        [Validation(Required=false)]
        public long? PaidBackupSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F937E173-559C-4498-8D90-38D32342B9E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage space occupied by SQL data. Unit: bytes. A value of -1 indicates that no data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>315052751</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

    }

}
