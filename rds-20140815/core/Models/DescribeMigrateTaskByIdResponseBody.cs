// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: The migration task migrates full backup files that can be used to restore the full data of the instance.</description></item>
        /// <item><description><b>UPDF</b>: The migration task migrates incremental or log backup files that can be used to restore the incremental data of the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The time when the migration task was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
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
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The description of the migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success to DBCC checkdb asynchronously</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the migration task was completed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-30T15:15:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Indicates whether the imported data overwrites the existing data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>False</b>: The imported data does not overwrite the existing data.</description></item>
        /// <item><description><b>True</b>: The imported data overwrites the existing data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsDBReplaced")]
        [Validation(Required=false)]
        public string IsDBReplaced { get; set; }

        /// <summary>
        /// <para>The ID of the migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>235943</para>
        /// </summary>
        [NameInMap("MigrateTaskId")]
        [Validation(Required=false)]
        public string MigrateTaskId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6ED3635A-01F9-47BD-B9C8-CB3FD70A336E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoStart</b>: The task has not started.</description></item>
        /// <item><description><b>Running</b>:The task is in progress.</description></item>
        /// <item><description><b>Success</b>: The task is successful.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Waiting</b>: The task is waiting for an incremental backup file to be imported.</description></item>
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
