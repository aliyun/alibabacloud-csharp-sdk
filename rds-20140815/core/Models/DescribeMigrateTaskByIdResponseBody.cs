// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTaskByIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The type of the OSS backup migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>FULL</b>: restores data by using a full log file.</description></item>
        /// <item><description><b>UPDF</b>: restores incremental data by using differential or log log files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FULL</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The time when the OSS backup migration task was created. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
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
        /// <para>The name of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mytestdb</para>
        /// </summary>
        [NameInMap("DBName")]
        [Validation(Required=false)]
        public string DBName { get; set; }

        /// <summary>
        /// <para>The description of the OSS backup migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success to DBCC checkdb asynchronously</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the OSS backup migration task ended. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-05-30T15:15:05Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the import overwrites the existing database. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><b>False</b>: no</description></item>
        /// <item><description><b>True</b>: yes</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6ED3635A-01F9-47BD-B9C8-CB3FD70A336E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the OSS backup migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoStart</b>: The task is not started.</description></item>
        /// <item><description><b>Running</b>: The task is running.</description></item>
        /// <item><description><b>Success</b>: The task is successful.</description></item>
        /// <item><description><b>Failed</b>: The task failed.</description></item>
        /// <item><description><b>Waiting</b>: The task is waiting for the import of incremental backup files.</description></item>
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
