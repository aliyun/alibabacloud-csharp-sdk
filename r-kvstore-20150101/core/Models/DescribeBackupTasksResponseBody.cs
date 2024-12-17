// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeBackupTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The following parameters are no longer used. Ignore the parameters.</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public DescribeBackupTasksResponseBodyAccessDeniedDetail AccessDeniedDetail { get; set; }
        public class DescribeBackupTasksResponseBodyAccessDeniedDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthAction")]
            [Validation(Required=false)]
            public string AuthAction { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalDisplayName")]
            [Validation(Required=false)]
            public string AuthPrincipalDisplayName { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalOwnerId")]
            [Validation(Required=false)]
            public string AuthPrincipalOwnerId { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("AuthPrincipalType")]
            [Validation(Required=false)]
            public string AuthPrincipalType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("EncodedDiagnosticMessage")]
            [Validation(Required=false)]
            public string EncodedDiagnosticMessage { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("NoPermissionType")]
            [Validation(Required=false)]
            public string NoPermissionType { get; set; }

            /// <summary>
            /// <para>This parameter is no longer used. Ignore this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>_</para>
            /// </summary>
            [NameInMap("PolicyType")]
            [Validation(Required=false)]
            public string PolicyType { get; set; }

        }

        /// <summary>
        /// <para>The details of the backup tasks.</para>
        /// </summary>
        [NameInMap("BackupJobs")]
        [Validation(Required=false)]
        public List<DescribeBackupTasksResponseBodyBackupJobs> BackupJobs { get; set; }
        public class DescribeBackupTasksResponseBodyBackupJobs : TeaModel {
            /// <summary>
            /// <para>The ID of the backup task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8491111</para>
            /// </summary>
            [NameInMap("BackupJobID")]
            [Validation(Required=false)]
            public long? BackupJobID { get; set; }

            /// <summary>
            /// <para>The state of the backup task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NoStart</b>: The backup task is not started.</description></item>
            /// <item><description><b>Preparing</b>: The backup task is being prepared.</description></item>
            /// <item><description><b>Waiting</b>: The backup task is pending.</description></item>
            /// <item><description><b>Uploading</b>: The system is uploading the backup file.</description></item>
            /// <item><description><b>Checking</b>: The system is checking the uploaded backup file.</description></item>
            /// <item><description><b>Finished</b>: The backup task is completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Automated</para>
            /// </summary>
            [NameInMap("BackupProgressStatus")]
            [Validation(Required=false)]
            public string BackupProgressStatus { get; set; }

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
            /// <para>The ID of the data node.</para>
            /// 
            /// <b>Example:</b>
            /// <hr>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

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
            /// <para>The start time of the backup task. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-05T19:24:00Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The type of the backup task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TempBackupTask</b>: The backup task was manually performed.</description></item>
            /// <item><description><b>NormalBackupTask</b>: The backup task was automatically performed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NormalBackupTask</para>
            /// </summary>
            [NameInMap("TaskAction")]
            [Validation(Required=false)]
            public string TaskAction { get; set; }

        }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The status of the backup task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoStart</b>: The backup task is not started.</description></item>
        /// <item><description><b>Preparing</b>: The backup task is being prepared.</description></item>
        /// <item><description><b>Waiting</b>: The backup task is pending.</description></item>
        /// <item><description><b>Uploading:</b> The system is uploading the backup file.</description></item>
        /// <item><description><b>Checking:</b> The system is checking the uploaded backup file.</description></item>
        /// <item><description><b>Finished</b>: The backup task is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BB73740C-23E2-4392-9DA4-2660C74C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
