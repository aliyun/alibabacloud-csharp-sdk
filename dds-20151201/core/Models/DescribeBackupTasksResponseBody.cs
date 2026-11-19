// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup job details.</para>
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// <para>The backup job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b>: The backup task is scheduled, including routine backup tasks that have not started.</description></item>
            /// <item><description><b>Checking</b>: The instance is being checked before the backup.</description></item>
            /// <item><description><b>Backuping</b>: The backup is in progress.</description></item>
            /// <item><description><b>Finished</b>: The backup is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("BackupSetStatus")]
            [Validation(Required=false)]
            public string BackupSetStatus { get; set; }

            /// <summary>
            /// <para>The backup start time in the yyyy-MM-ddTHH:mm:ssZ format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-16T11:04:56Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The backup job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170034</para>
            /// </summary>
            [NameInMap("BackupjobId")]
            [Validation(Required=false)]
            public string BackupjobId { get; set; }

            /// <summary>
            /// <para>The backup pattern. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: Automatic backup.</description></item>
            /// <item><description><b>Manual</b>: Manual backup.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            /// <summary>
            /// <para>The backup progress in percentage. The progress is displayed only for running backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18%</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D648B367-15B6-1B42-BD4B-47507C9CC****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
