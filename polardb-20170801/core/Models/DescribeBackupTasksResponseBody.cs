// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the backup task.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyItems Items { get; set; }
        public class DescribeBackupTasksResponseBodyItems : TeaModel {
            [NameInMap("BackupJob")]
            [Validation(Required=false)]
            public List<DescribeBackupTasksResponseBodyItemsBackupJob> BackupJob { get; set; }
            public class DescribeBackupTasksResponseBodyItemsBackupJob : TeaModel {
                /// <summary>
                /// <para>The ID of the backup task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11111111</para>
                /// </summary>
                [NameInMap("BackupJobId")]
                [Validation(Required=false)]
                public string BackupJobId { get; set; }

                /// <summary>
                /// <para>The state of the backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NoStart</b></description></item>
                /// <item><description><b>Preparing</b></description></item>
                /// <item><description><b>Waiting</b></description></item>
                /// <item><description><b>Uploading</b></description></item>
                /// <item><description><b>Checking</b></description></item>
                /// <item><description><b>Finished</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NoStart</para>
                /// </summary>
                [NameInMap("BackupProgressStatus")]
                [Validation(Required=false)]
                public string BackupProgressStatus { get; set; }

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
                [NameInMap("JobMode")]
                [Validation(Required=false)]
                public string JobMode { get; set; }

                /// <summary>
                /// <para>The progress of the backup task in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Process")]
                [Validation(Required=false)]
                public string Process { get; set; }

                /// <summary>
                /// <para>The time when the backup task started. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-08-08T07:24:01Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The type of the backup task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>TempBackupTask</b>: The backup task is an adhoc backup task.</description></item>
                /// <item><description><b>NormalBackupTask</b>: The backup task is a common backup task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NormalBackupTask</para>
                /// </summary>
                [NameInMap("TaskAction")]
                [Validation(Required=false)]
                public string TaskAction { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA8C1EF1-E3D4-44D7-B809-823187******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
