// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class CreateHanaRestoreRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1645628400235</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public long? BackupId { get; set; }

        /// <summary>
        /// <para>The backup prefix.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE_DATA_BACKUP_2022_05_02_15_39</para>
        /// </summary>
        [NameInMap("BackupPrefix")]
        [Validation(Required=false)]
        public string BackupPrefix { get; set; }

        /// <summary>
        /// <para>Specifies whether to validate the differential backup and log backup. Valid values: true and false. If you set the value to true, HBR checks whether the required differential backup and log backup are available before the restore job starts. If the differential backup or log backup is unavailable, HBR does not start the restore job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CheckAccess")]
        [Validation(Required=false)]
        public bool? CheckAccess { get; set; }

        /// <summary>
        /// <para>Specifies whether to delete all log entries from the log area after the log entries are restored. Valid values: true and false. If you set the value to false, all log entries are deleted from the log area after the log entries are restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ClearLog")]
        [Validation(Required=false)]
        public bool? ClearLog { get; set; }

        /// <summary>
        /// <para>The ID of the SAP HANA instance that you want to restore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000fbrs5******ka9w</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the database that you want to restore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TS2</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The log position to which you want to restore the database. This parameter is valid only if you set the Mode parameter to <b>RECOVERY_TO_LOG_POSITION</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("LogPosition")]
        [Validation(Required=false)]
        public long? LogPosition { get; set; }

        /// <summary>
        /// <para>The ID of the client where the primary node of the SAP HANA resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c-000ii8tzv**********</para>
        /// </summary>
        [NameInMap("MasterClientId")]
        [Validation(Required=false)]
        public string MasterClientId { get; set; }

        /// <summary>
        /// <para>The recovery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RECOVERY_TO_MOST_RECENT</b>: restores the database to the recently available state to which the database has been backed up.</description></item>
        /// <item><description><b>RECOVERY_TO_POINT_IN_TIME</b>: restores the database to a specified point in time.</description></item>
        /// <item><description><b>RECOVERY_TO_SPECIFIC_BACKUP</b>: restores the database to a specified backup.</description></item>
        /// <item><description><b>RECOVERY_TO_LOG_POSITION</b>: restores the database to a specified log position.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RECOVERY_TO_POINT_IN_TIME</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore the database. This parameter is valid only if you set the Mode parameter to <b>RECOVERY_TO_POINT_IN_TIME</b>. HBR restores the database to a state closest to the specified point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1635315505</para>
        /// </summary>
        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        /// <summary>
        /// <para>The SID admin account that is created by SAP HANA.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB</para>
        /// </summary>
        [NameInMap("SidAdmin")]
        [Validation(Required=false)]
        public string SidAdmin { get; set; }

        /// <summary>
        /// <para>The name of the source system. This parameter specifies the name of the source database that you want to restore. You must set the parameter in the <c>&lt;Source database name&gt;@SID</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HNP@HNP</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the source SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-000ii8tzv******xm0t</para>
        /// </summary>
        [NameInMap("SourceClusterId")]
        [Validation(Required=false)]
        public string SourceClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the database to a different instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a catalog backup to restore the database. This parameter is required only if you set the Mode parameter to <b>RECOVERY_TO_SPECIFIC_BACKUP</b>. If you turn off Use Catalog, you must specify the prefix of a backup file. Then, Cloud Backup finds the backup file based on the specified prefix and restores the backup file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseCatalog")]
        [Validation(Required=false)]
        public bool? UseCatalog { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a differential backup or an incremental backup to restore the database. Valid values: true and false. If you want to use a differential backup or an incremental backup to restore the database, set the value to true. If you set the value to false, HBR uses a log backup to restore the database.</para>
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
        /// <para>v-000************yqr</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

        /// <summary>
        /// <para>The ID of the volume that you want to restore. This parameter is valid only if you set the Mode parameter to <b>RECOVERY_TO_LOG_POSITION</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VolumeId")]
        [Validation(Required=false)]
        public int? VolumeId { get; set; }

    }

}
