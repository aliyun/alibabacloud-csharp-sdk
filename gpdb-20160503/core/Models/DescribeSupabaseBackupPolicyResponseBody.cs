// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSupabaseBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The interval between automatic recovery points, in minutes. A value greater than 0 indicates that automatic recovery points are enabled. If the feature is disabled, -1 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("BackupInterval")]
        [Validation(Required=false)]
        public int? BackupInterval { get; set; }

        /// <summary>
        /// <para>The data backup retention period, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic recovery points are enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("EnableRecoveryPoint")]
        [Validation(Required=false)]
        public bool? EnableRecoveryPoint { get; set; }

        /// <summary>
        /// <para>The data backup cycle. Separate multiple values with commas (,). Valid values: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, and Sunday.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Wednesday,Friday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The data backup time window in UTC. The format is HH:mmZ-HH:mmZ.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:00Z-02:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The interval for the automatic creation of recovery points, in hours. Valid values: 1/6 (10 minutes), 1/2 (30 minutes), 1, 2, 4, and 8. This value is valid only when EnableRecoveryPoint is set to true. If automatic recovery points are shutdown, 0 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
