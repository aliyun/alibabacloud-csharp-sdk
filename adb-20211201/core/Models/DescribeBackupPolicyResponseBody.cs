// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
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
        /// <para>Indicates whether log backup is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The number of days for which the log backup files are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The cycle based on which backups are performed. If more than one day of the week is specified, the days of the week are separated by commas (,). Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Monday</description></item>
        /// <item><description>Tuesday</description></item>
        /// <item><description>Wednesday</description></item>
        /// <item><description>Thursday</description></item>
        /// <item><description>Friday</description></item>
        /// <item><description>Saturday</description></item>
        /// <item><description>Sunday</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Wednesday,Saturday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The data backup time. The time is in the HH:mmZ-HH:mmZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1AD222E9-E606-4A42-BF6D-8A4442913CEF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
