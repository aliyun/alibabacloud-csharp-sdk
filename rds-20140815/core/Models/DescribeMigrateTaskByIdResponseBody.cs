// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the backup migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: The restore operation is performed by using a full backup file.</description></item>
        /// <item><description><b>UPDF</b>: The incremental data is restored by using an incremental backup file or log file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The time when the backup migration task was created. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-05-30T12:11:04Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The description of the backup migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success to DBCC checkdb asynchronously</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the backup migration task ended. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-30T15:15:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the import is an overwrite import. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>False</b>: No.</description></item>
        /// <item><description><b>True</b>: Yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsDBReplaced")]
        [Validation(Required=false)]
        public string IsDBReplaced { get; set; }

        /// <summary>
        /// <para>The ID of the OSS backup migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>235943</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6ED3635A-01F9-47BD-B9C8-CB3FD70A336E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the backup migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoStart</b>: Not started.</description></item>
        /// <item><description><b>Running</b>: Running.</description></item>
        /// <item><description><b>Success</b>: Succeeded.</description></item>
        /// <item><description><b>Failed</b>: Failed.</description></item>
        /// <item><description><b>Waiting</b>: Waiting for incremental backup file import.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
