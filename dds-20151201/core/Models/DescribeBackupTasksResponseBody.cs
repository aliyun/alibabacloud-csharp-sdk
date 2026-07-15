// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the backup jobs.</para>
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// <para>The status of the backup job.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Scheduled</b>: The backup job is scheduled. This includes regular backup jobs that have not started.</para>
            /// </description></item>
            /// <item><description><para><b>Checking</b>: The instance is being checked before the backup.</para>
            /// </description></item>
            /// <item><description><para><b>Backuping</b>: The backup is in progress.</para>
            /// </description></item>
            /// <item><description><para><b>Finished</b>: The backup is complete.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduled</para>
            /// </summary>
            [NameInMap("BackupSetStatus")]
            [Validation(Required=false)]
            public string BackupSetStatus { get; set; }

            /// <summary>
            /// <para>The start time of the backup.</para>
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
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Automated</b>: automatic backup.</para>
            /// </description></item>
            /// <item><description><para><b>Manual</b>: manual backup.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("JobMode")]
            [Validation(Required=false)]
            public string JobMode { get; set; }

            /// <summary>
            /// <para>The backup progress in percentage. The progress is displayed only for running backup jobs.</para>
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
