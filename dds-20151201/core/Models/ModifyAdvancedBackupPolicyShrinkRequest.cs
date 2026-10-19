// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyAdvancedBackupPolicyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of backup policies.</para>
        /// </summary>
        [NameInMap("AdvancedBackupDataPolicies")]
        [Validation(Required=false)]
        public string AdvancedBackupDataPoliciesShrink { get; set; }

        /// <summary>
        /// <para>The list of log backup policies.</para>
        /// </summary>
        [NameInMap("AdvancedBackupLogPolicies")]
        [Validation(Required=false)]
        public string AdvancedBackupLogPoliciesShrink { get; set; }

        /// <summary>
        /// <para>The backup retention policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: All backup sets of the instance are deleted immediately when the instance is released.</description></item>
        /// <item><description>1: The last backup set is retained for long-term retention (LTR) when the instance is released.</description></item>
        /// <item><description>2: All backup sets are retained for long-term retention (LTR) when the instance is released.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("BackupRetentionPolicyOnClusterDeletion")]
        [Validation(Required=false)]
        public int? BackupRetentionPolicyOnClusterDeletion { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-2zeb2d64cb46xxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The time period during which the backup is performed. The format is <i>HH:mm</i>Z-<i>HH:mm</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The time range is limited to 1 hour.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>09:00Z-10:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The snapshot backup type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Flash</b>: backup within seconds.</description></item>
        /// <item><description><b>Standard</b>: standard backup. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("SnapshotBackupType")]
        [Validation(Required=false)]
        public string SnapshotBackupType { get; set; }

    }

}
