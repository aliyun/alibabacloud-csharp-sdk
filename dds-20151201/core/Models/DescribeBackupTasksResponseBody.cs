// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the backup task.</para>
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// <para>The backup task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Scheduled</b>: The backup task is in planning. Regular backup tasks that have not started are also in this state.</description></item>
            /// <item><description><b>Checking</b>: The instance is being checked before the backup.</description></item>
            /// <item><description><b>Backuping</b>: The backup task is in progress.</description></item>
            /// <item><description><b>Finished</b>: The backup task is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("BackupSetStatus")]
            [Validation(Required=false)]
            public string BackupSetStatus { get; set; }

            /// <summary>
            /// <para>The start time of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-16T11:04:56Z</para>
            /// </summary>
            [NameInMap("BackupStartTime")]
            [Validation(Required=false)]
            public string BackupStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170034</para>
            /// </summary>
            [NameInMap("BackupjobId")]
            [Validation(Required=false)]
            public string BackupjobId { get; set; }

            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Automated</b>: automatic backup</description></item>
            /// <item><description><b>Manual</b>: manual backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            /// <summary>
            /// <para>The progress of the backup task. Unit: %. The progress is returned only for running backup tasks.</para>
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
