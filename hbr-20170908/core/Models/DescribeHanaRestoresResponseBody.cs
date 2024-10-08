// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaRestoresResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about restore jobs.</para>
        /// </summary>
        [NameInMap("HanaRestore")]
        [Validation(Required=false)]
        public DescribeHanaRestoresResponseBodyHanaRestore HanaRestore { get; set; }
        public class DescribeHanaRestoresResponseBodyHanaRestore : TeaModel {
            [NameInMap("HanaRestores")]
            [Validation(Required=false)]
            public List<DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores> HanaRestores { get; set; }
            public class DescribeHanaRestoresResponseBodyHanaRestoreHanaRestores : TeaModel {
                /// <summary>
                /// <para>The backup ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635315505</para>
                /// </summary>
                [NameInMap("BackupID")]
                [Validation(Required=false)]
                public long? BackupID { get; set; }

                /// <summary>
                /// <para>The backup prefix.</para>
                /// 
                /// <b>Example:</b>
                /// <para>INC_DATA_BACKUP</para>
                /// </summary>
                [NameInMap("BackupPrefix")]
                [Validation(Required=false)]
                public string BackupPrefix { get; set; }

                /// <summary>
                /// <para>Indicates whether the differential backup and log backup are validated. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Cloud Backup checks whether the required differential backup and log backup are available before the restore job starts. If the differential backup or log backup is unavailable, Cloud Backup does not start the restore job.</description></item>
                /// <item><description>false: Cloud Backup does not check whether the required differential backup and log backup are available before the restore job starts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CheckAccess")]
                [Validation(Required=false)]
                public bool? CheckAccess { get; set; }

                /// <summary>
                /// <para>Indicates whether all log entries are deleted from the log area after the log entries are restored. Valid values: true and false. If the return value is false, all log entries are deleted from the log area after the log entries are restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ClearLog")]
                [Validation(Required=false)]
                public bool? ClearLog { get; set; }

                /// <summary>
                /// <para>The ID of the SAP HANA instance that is restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-000923yu******p00j4</para>
                /// </summary>
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                /// <summary>
                /// <para>The current recovery phase. This value is obtained from SAP HANA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CurrentPhase")]
                [Validation(Required=false)]
                public int? CurrentPhase { get; set; }

                /// <summary>
                /// <para>The current progress. This value is obtained from SAP HANA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CurrentProgress")]
                [Validation(Required=false)]
                public long? CurrentProgress { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BWD</para>
                /// </summary>
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                /// <summary>
                /// <para>The ID of the database recovery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1644038961030</para>
                /// </summary>
                [NameInMap("DatabaseRestoreId")]
                [Validation(Required=false)]
                public long? DatabaseRestoreId { get; set; }

                /// <summary>
                /// <para>The time when the restore job ends. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1634356382</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The log position to which the database is restored. This parameter is returned only if the value of the Mode parameter is <b>RECOVERY_TO_LOG_POSITION</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LogPosition")]
                [Validation(Required=false)]
                public long? LogPosition { get; set; }

                /// <summary>
                /// <para>The maximum recovery phase. This value is obtained from SAP HANA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaxPhase")]
                [Validation(Required=false)]
                public int? MaxPhase { get; set; }

                /// <summary>
                /// <para>The maximum progress. This value is obtained from SAP HANA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxProgress")]
                [Validation(Required=false)]
                public long? MaxProgress { get; set; }

                /// <summary>
                /// <para>The details of the recovery phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SQL Error 448 - recovery could not be completed:</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The recovery mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RECOVERY_TO_MOST_RECENT</b>: The database is restored to the recently available state to which the database has been backed up.</description></item>
                /// <item><description><b>RECOVERY_TO_POINT_IN_TIME</b>: The database is restored to a specified point in time.</description></item>
                /// <item><description><b>RECOVERY_TO_SPECIFIC_BACKUP</b>: The database is restored to a specified backup.</description></item>
                /// <item><description><b>RECOVERY_TO_LOG_POSITION</b>: The database is restored to a specified log position.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RECOVERY_TO_SPECIFIC_BACKUP</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The recovery phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>restart</para>
                /// </summary>
                [NameInMap("Phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The point in time at which the database is restored.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1635315505</para>
                /// </summary>
                [NameInMap("ReachedTime")]
                [Validation(Required=false)]
                public long? ReachedTime { get; set; }

                /// <summary>
                /// <para>The point in time to which the database is restored. This parameter is returned only if the value of the Mode parameter is <b>RECOVERY_TO_POINT_IN_TIME</b>. Cloud Backup restores the database to a state closest to the specified point in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649851200</para>
                /// </summary>
                [NameInMap("RecoveryPointInTime")]
                [Validation(Required=false)]
                public long? RecoveryPointInTime { get; set; }

                /// <summary>
                /// <para>The ID of the restore job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-000c1en183ayn9sesgqh</para>
                /// </summary>
                [NameInMap("RestoreId")]
                [Validation(Required=false)]
                public string RestoreId { get; set; }

                /// <summary>
                /// <para>The name of the source system. This parameter indicates the name of the source database that is restored. Format: <c>&lt;Source database name&gt;@SID</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PRD@H4P</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The ID of the source SAP HANA instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cl-0000g3mvy******5cj</para>
                /// </summary>
                [NameInMap("SourceClusterId")]
                [Validation(Required=false)]
                public string SourceClusterId { get; set; }

                /// <summary>
                /// <para>The time when the restore job starts. This value is a UNIX timestamp. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1636970413</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The recovery status. This value is obtained from SAP HANA.</para>
                /// 
                /// <b>Example:</b>
                /// <para>successful</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The status of the restore job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RUNNING</b>: The job is running.</description></item>
                /// <item><description><b>COMPLETE</b>: The job is completed.</description></item>
                /// <item><description><b>PARTIAL_COMPLETE</b>: The job is partially completed.</description></item>
                /// <item><description><b>FAILED</b>: The job failed.</description></item>
                /// <item><description><b>CANCELED</b>: The job is canceled.</description></item>
                /// <item><description><b>EXPIRED</b>: The job timed out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>COMPLETE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the database is restored to a different instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The database is restored to a different instance.</description></item>
                /// <item><description>false: The database is restored within the same instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SystemCopy")]
                [Validation(Required=false)]
                public bool? SystemCopy { get; set; }

                /// <summary>
                /// <para>Indicates whether a catalog backup is used to restore the database. This parameter is returned only if the value of the Mode parameter is <b>RECOVERY_TO_SPECIFIC_BACKUP</b>. If the return value is false, Cloud Backup finds the backup file based on the specified prefix and then restores the backup file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UseCatalog")]
                [Validation(Required=false)]
                public bool? UseCatalog { get; set; }

                /// <summary>
                /// <para>Indicates whether a differential backup or an incremental backup is used to restore the database. Valid values: true and false. If the return value is true, Cloud Backup uses a differential backup or an incremental backup to restore the database. If the return value is false, Cloud Backup uses a log backup to restore the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseDelta")]
                [Validation(Required=false)]
                public bool? UseDelta { get; set; }

                /// <summary>
                /// <para>The ID of the backup vault.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v-000g9acf******gta</para>
                /// </summary>
                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

                /// <summary>
                /// <para>The ID of the volume that is restored. This parameter is returned only if the value of the Mode parameter is <b>RECOVERY_TO_LOG_POSITION</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VolumeId")]
                [Validation(Required=false)]
                public int? VolumeId { get; set; }

            }

        }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7DEFC897-8F05-5C05-912C-C9A9510FBFF1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
