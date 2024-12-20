// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which data backup files are retained. Default value: 7. Maximum value: 7. Valid values: 1 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic point-in-time backup.</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRecoveryPoint")]
        [Validation(Required=false)]
        public bool? EnableRecoveryPoint { get; set; }

        /// <summary>
        /// <para>The cycle based on which backups are performed. If more than one day of the week is specified, the days of the week are separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tuesday, Thursday, Saturday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup window. Specify the backup window in the HH:mmZ-HH:mmZ format. The backup window must be in UTC. Default value: 00:00-01:00.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The frequency of point-in-time backup.</para>
        /// <list type="bullet">
        /// <item><description>1: per hour</description></item>
        /// <item><description>2: per 2 hours</description></item>
        /// <item><description>4: per 4 hours</description></item>
        /// <item><description>8: per 8 hours</description></item>
        /// </list>
        /// <para>Default value: 8.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

    }

}
