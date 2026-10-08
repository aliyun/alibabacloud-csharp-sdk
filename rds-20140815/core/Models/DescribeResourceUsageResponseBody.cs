// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The storage consumed by archived backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ArchiveBackupSize")]
        [Validation(Required=false)]
        public long? ArchiveBackupSize { get; set; }

        /// <summary>
        /// <para>The total storage consumed by data backups, excluding archived backups. Unit: bytes.</para>
        /// <remarks>
        /// <para>For <b>SQL Server</b> instances, this value indicates the total size of physical backups and snapshot backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>94324736</para>
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// <para>The storage consumed by snapshot backups for <b>SQL Server instances</b>. Unit: bytes. A value of 0 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupEcsSnapshotSize")]
        [Validation(Required=false)]
        public string BackupEcsSnapshotSize { get; set; }

        /// <summary>
        /// <para>The total storage consumed by log backups, excluding archived backups. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45145563</para>
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// <para>The size of data files in backup sets stored in OSS. Unit: bytes. A value of 0 indicates no data.</para>
        /// <remarks>
        /// <para>For <b>SQL Server</b> instances, this value indicates the storage consumed by physical backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8821760</para>
        /// </summary>
        [NameInMap("BackupOssDataSize")]
        [Validation(Required=false)]
        public long? BackupOssDataSize { get; set; }

        /// <summary>
        /// <para>The size of log files in backup sets stored in OSS. Unit: bytes. A value of 0 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44180999</para>
        /// </summary>
        [NameInMap("BackupOssLogSize")]
        [Validation(Required=false)]
        public long? BackupOssLogSize { get; set; }

        /// <summary>
        /// <para>The storage consumed by backups (data backups + log backups). Unit: bytes. A value of -1 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53002759</para>
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// <para>The storage consumed by cold backups. Unit: bytes. A value of -1 indicates no data.</para>
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
        /// <para>The storage consumed by data files. Unit: bytes. A value of -1 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1292094741</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The used storage (DataSize + LogSize). Unit: bytes. A value of -1 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2337275904</para>
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The storage consumed by log files. Unit: bytes. A value of -1 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1045181163</para>
        /// </summary>
        [NameInMap("LogSize")]
        [Validation(Required=false)]
        public long? LogSize { get; set; }

        /// <summary>
        /// <para>The billable storage consumed by backups after the free quota is deducted. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PaidBackupSize")]
        [Validation(Required=false)]
        public long? PaidBackupSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F937E173-559C-4498-8D90-38D32342B9E4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The storage consumed by SQL data. Unit: bytes. A value of -1 indicates no data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>315052751</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

    }

}
