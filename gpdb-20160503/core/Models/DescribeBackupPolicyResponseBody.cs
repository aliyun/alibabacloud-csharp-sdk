// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of days for which data backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>Indicates whether automatic point-in-time backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic point-in-time backup is enabled.</description></item>
        /// <item><description><b>false</b>: Automatic point-in-time backup is disabled.</description></item>
        /// </list>
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
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Wednesday,Friday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time. The time is in the HH:mmZ-HH:mmZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00Z-13:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The frequency of the point-in-time backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: per hour</description></item>
        /// <item><description><b>2</b>: per 2 hours</description></item>
        /// <item><description><b>4</b>: per 4 hours</description></item>
        /// <item><description><b>8</b>: per 8 hours</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E6B3287-A3E2-5A87-B8D8-E9**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
