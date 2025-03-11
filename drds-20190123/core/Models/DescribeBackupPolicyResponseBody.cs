// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the backup policy.</para>
        /// </summary>
        [NameInMap("BackupPolicyDO")]
        [Validation(Required=false)]
        public DescribeBackupPolicyResponseBodyBackupPolicyDO BackupPolicyDO { get; set; }
        public class DescribeBackupPolicyResponseBodyBackupPolicyDO : TeaModel {
            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupAppName")]
            [Validation(Required=false)]
            public string BackupAppName { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupDbName")]
            [Validation(Required=false)]
            public string BackupDbName { get; set; }

            /// <summary>
            /// <para>The backup level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>db</b>: database backup</description></item>
            /// <item><description><b>instance</b>: instance backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("BackupLevel")]
            [Validation(Required=false)]
            public string BackupLevel { get; set; }

            /// <summary>
            /// <para>Indicates whether the log backup feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: The log backup feature is enabled.</description></item>
            /// <item><description><b>0</b>: The log backup feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public string BackupLog { get; set; }

            /// <summary>
            /// <para>The backup mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>logic</b>: logical backup</description></item>
            /// <item><description><b>phy</b>: fast backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>phy</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>The type of the backup policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DataBackupPolicy</b>: a data backup policy</description></item>
            /// <item><description><b>LogBackupPolicy</b>: a log backup policy</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DataBackupPolicy</para>
            /// </summary>
            [NameInMap("BackupPolicyMode")]
            [Validation(Required=false)]
            public string BackupPolicyMode { get; set; }

            /// <summary>
            /// <para>The retention period of backup files. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("BackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? BackupRetentionPeriod { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The retention period of data backup files. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DataBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? DataBackupRetentionPeriod { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public long? HighSpaceUsageProtection { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LocalLogRetentionHours")]
            [Validation(Required=false)]
            public long? LocalLogRetentionHours { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public long? LocalLogRetentionSpace { get; set; }

            /// <summary>
            /// <para>The retention period of log backup files. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LogBackupRetentionPeriod")]
            [Validation(Required=false)]
            public long? LogBackupRetentionPeriod { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("NextBackupActuallyTime")]
            [Validation(Required=false)]
            public string NextBackupActuallyTime { get; set; }

            /// <summary>
            /// <para>The backup cycle. You can specify multiple backup cycles. Separate multiple backup cycles with commas (,). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: every Monday</description></item>
            /// <item><description><b>1</b>: every Tuesday</description></item>
            /// <item><description><b>2</b>: every Wednesday</description></item>
            /// <item><description><b>3</b>: every Thursday</description></item>
            /// <item><description><b>4</b>: every Friday</description></item>
            /// <item><description><b>5</b>: every Saturday</description></item>
            /// <item><description><b>6</b>: every Sunday</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1,4</para>
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// <para>The time range in which a backup is performed. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22:00:00-23:00:00</para>
            /// </summary>
            [NameInMap("PreferredBackupTime")]
            [Validation(Required=false)]
            public string PreferredBackupTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8FAF3989-79CD-4A67-8FFD-97899B64****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
