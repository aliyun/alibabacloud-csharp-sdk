// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeBackupsRequest : TeaModel {
        /// <summary>
        /// <para>The backup set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>327329803</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The backup mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Automated</b>: automatic backup</description></item>
        /// <item><description><b>Manual</b>: manual backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automated</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The status of the backup set. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Success</b>: The backup is complete.</description></item>
        /// <item><description><b>Failed</b>: The backup failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("BackupStatus")]
        [Validation(Required=false)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// <para>The backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FullBackup</b>: full backup</description></item>
        /// <item><description><b>IncrementalBackup</b>: incremental backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FullBackup</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call DescribeDBInstances to obtain the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The end time must be later than the start time. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>Narrow down the time range when you use this operation to query backup sets. A large time range may cause a timeout.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-15T16:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. The value must be a positive integer that does not exceed the maximum value of the Integer data type.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// <item><description><b>100</b></description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The start time of the query. Format: <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-06-01T16:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
