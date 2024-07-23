// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeMigrateTasksResponseBody : TeaModel {
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
        /// <para>The details of the migration task.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeMigrateTasksResponseBodyItems Items { get; set; }
        public class DescribeMigrateTasksResponseBodyItems : TeaModel {
            [NameInMap("MigrateTask")]
            [Validation(Required=false)]
            public List<DescribeMigrateTasksResponseBodyItemsMigrateTask> MigrateTask { get; set; }
            public class DescribeMigrateTasksResponseBodyItemsMigrateTask : TeaModel {
                /// <summary>
                /// <para>The migration task type. Valid values:</para>
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
                /// <para>2017-05-30T12:11:04Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The description of the migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Api description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the migration task was completed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-05-30T13:11:04Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the imported data overwrites the existing data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>True</para>
                /// </summary>
                [NameInMap("IsDBReplaced")]
                [Validation(Required=false)]
                public string IsDBReplaced { get; set; }

                /// <summary>
                /// <para>The migration task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>564522545</para>
                /// </summary>
                [NameInMap("MigrateTaskId")]
                [Validation(Required=false)]
                public string MigrateTaskId { get; set; }

                /// <summary>
                /// <para>The status of the migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NoStart</b>: The task is not started.</description></item>
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

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4E356DDF-6B83-45DB-99D5-4B1E8A0D286B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
