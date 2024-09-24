// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        /// <summary>
        /// <para>The storage that is occupied by archived backup files on the instance. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ArchiveBackupSize")]
        [Validation(Required=false)]
        public long? ArchiveBackupSize { get; set; }

        /// <summary>
        /// <para>The storage that is occupied by data backup files, excluding archived backup files, on the instance. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94324736</para>
        /// </summary>
        [NameInMap("BackupDataSize")]
        [Validation(Required=false)]
        public long? BackupDataSize { get; set; }

        /// <summary>
        /// <para>The storage that is occupied by log backup files, excluding archived backup files, on the instance. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45145563</para>
        /// </summary>
        [NameInMap("BackupLogSize")]
        [Validation(Required=false)]
        public long? BackupLogSize { get; set; }

        /// <summary>
        /// <para>The size of data backup files that are stored in Object Storage Service (OSS) buckets. Unit: bytes. The value 0 indicates no data backup files are stored in OSS buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8821760</para>
        /// </summary>
        [NameInMap("BackupOssDataSize")]
        [Validation(Required=false)]
        public long? BackupOssDataSize { get; set; }

        /// <summary>
        /// <para>The size of log backup files that are stored in OSS buckets. Unit: bytes. The value 0 indicates no log backup files are stored in OSS buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>44180999</para>
        /// </summary>
        [NameInMap("BackupOssLogSize")]
        [Validation(Required=false)]
        public long? BackupOssLogSize { get; set; }

        /// <summary>
        /// <para>The storage that is used to store backup files. Unit: bytes. The value -1 indicates that no backup files are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>53002759</para>
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public long? BackupSize { get; set; }

        /// <summary>
        /// <para>The storage that is used to store cold backup files. Unit: bytes. The value -1 indicates that no cold backup files are stored.</para>
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
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The storage that is used to store data files. Unit: bytes. The value -1 indicates that no data files are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1292094741</para>
        /// </summary>
        [NameInMap("DataSize")]
        [Validation(Required=false)]
        public long? DataSize { get; set; }

        /// <summary>
        /// <para>The total storage that is occupied by data files and log files on the instance. Unit: bytes. The value -1 indicates that no data files or log files are stored on the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2337275904</para>
        /// </summary>
        [NameInMap("DiskUsed")]
        [Validation(Required=false)]
        public long? DiskUsed { get; set; }

        /// <summary>
        /// <para>The database engine of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The storage that is used to store log files. Unit: bytes. The value -1 indicates that no log files are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1045181163</para>
        /// </summary>
        [NameInMap("LogSize")]
        [Validation(Required=false)]
        public long? LogSize { get; set; }

        /// <summary>
        /// <para>The backup storage for which you must pay. The system provides a free quota on backup storage. You must pay for the backup storage that exceeds the free quota. Unit: bytes.</para>
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
        /// <para>The storage that is occupied to execute SQL statements on the instance. Unit: bytes. The value -1 indicates that no SQL statements are executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>315052751</para>
        /// </summary>
        [NameInMap("SQLSize")]
        [Validation(Required=false)]
        public long? SQLSize { get; set; }

    }

}
