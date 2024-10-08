// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeHanaBackupsAsyncRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SAP HANA instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-00098******yuqvu</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BPD</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to include differential backups in the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: includes differential backups.</description></item>
        /// <item><description>false: excludes differential backups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeDifferential")]
        [Validation(Required=false)]
        public bool? IncludeDifferential { get; set; }

        /// <summary>
        /// <para>Specifies whether to include incremental backups in the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: includes incremental backups.</description></item>
        /// <item><description>false: excludes incremental backups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeIncremental")]
        [Validation(Required=false)]
        public bool? IncludeIncremental { get; set; }

        /// <summary>
        /// <para>Specifies whether to include log backups in the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: includes log backups.</description></item>
        /// <item><description>false: excludes log backups.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeLog")]
        [Validation(Required=false)]
        public bool? IncludeLog { get; set; }

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
        /// <para>The recovery mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RECOVERY_TO_MOST_RECENT</b>: restores the database to the recently available state to which the database has been backed up.</description></item>
        /// <item><description><b>RECOVERY_TO_POINT_IN_TIME</b>: restores the database to a specified point in time.</description></item>
        /// <item><description><b>RECOVERY_TO_SPECIFIC_BACKUP</b>: restores the database to a specified backup.</description></item>
        /// <item><description><b>RECOVERY_TO_LOG_POSITION</b>: restores the database to a specified log position.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RECOVERY_TO_SPECIFIC_BACKUP</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

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
        /// <para>The point in time to which you want to restore the database. This parameter is valid only if you set the Mode parameter to <b>RECOVERY_TO_POINT_IN_TIME</b>. Cloud Backup restores the database to a state closest to the specified point in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649851200</para>
        /// </summary>
        [NameInMap("RecoveryPointInTime")]
        [Validation(Required=false)]
        public long? RecoveryPointInTime { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmz7mced2ldhy</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the source system. This parameter specifies the name of the source database that you want to restore. You must set the parameter in the <c>&lt;Source database name&gt;@SID</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P01@HP1</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The ID of the source SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-0000g3m******5cj</para>
        /// </summary>
        [NameInMap("SourceClusterId")]
        [Validation(Required=false)]
        public string SourceClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restore the database to a different instance.</para>
        /// <list type="bullet">
        /// <item><description>true: restores the database to a different instance.</description></item>
        /// <item><description>false: restores the database within the same instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SystemCopy")]
        [Validation(Required=false)]
        public bool? SystemCopy { get; set; }

        /// <summary>
        /// <para>Specifies whether Backint is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Backint is used.</description></item>
        /// <item><description>false: Backint is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseBackint")]
        [Validation(Required=false)]
        public bool? UseBackint { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000270c******pi81</para>
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
