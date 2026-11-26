// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The retention period of data backups in days.</para>
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
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRecoveryPoint")]
        [Validation(Required=false)]
        public bool? EnableRecoveryPoint { get; set; }

        /// <summary>
        /// <para>The backup cycle. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday.</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday.</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday.</description></item>
        /// <item><description><b>Thursday</b>: Thursday.</description></item>
        /// <item><description><b>Friday</b>: Friday.</description></item>
        /// <item><description><b>Saturday</b>: Saturday.</description></item>
        /// <item><description><b>Sunday</b>: Sunday.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Wednesday,Friday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time. Format: HH:mmZ-HH:mmZ (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00Z-13:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The recovery point frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Every hour.</description></item>
        /// <item><description><b>2</b>: Every two hours.</description></item>
        /// <item><description><b>4</b>: Every four hours.</description></item>
        /// <item><description><b>8</b>: Every eight hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9E6B3287-A3E2-5A87-B8D8-E9**********</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
