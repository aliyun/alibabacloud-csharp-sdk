// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeBackupLocalResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the backup policy.</para>
        /// </summary>
        [NameInMap("BackupPolicyDO")]
        [Validation(Required=false)]
        public DescribeBackupLocalResponseBodyBackupPolicyDO BackupPolicyDO { get; set; }
        public class DescribeBackupLocalResponseBodyBackupPolicyDO : TeaModel {
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
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupLevel")]
            [Validation(Required=false)]
            public string BackupLevel { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupLog")]
            [Validation(Required=false)]
            public string BackupLog { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupMode")]
            [Validation(Required=false)]
            public string BackupMode { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("BackupPolicyMode")]
            [Validation(Required=false)]
            public string BackupPolicyMode { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
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
            /// <para>No value is returned.</para>
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
            /// <para>Indicates whether the feature is enabled to forcibly delete binary log files if the used storage space of the instance exceeds 90% of the total storage space or the remaining storage space is less than 5 GB. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The feature is enabled.</description></item>
            /// <item><description>0: The feature is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HighSpaceUsageProtection")]
            [Validation(Required=false)]
            public long? HighSpaceUsageProtection { get; set; }

            /// <summary>
            /// <para>The number of hours for which log backup files are retained on the instance. Valid values: 0 to 168. Default value: <b>18</b>. The value <b>0</b> indicates that log backup files are not retained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>18</para>
            /// </summary>
            [NameInMap("LocalLogRetentionHours")]
            [Validation(Required=false)]
            public long? LocalLogRetentionHours { get; set; }

            /// <summary>
            /// <para>The maximum storage usage that is allowed for local log files. Valid values: 0 to 50. Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("LocalLogRetentionSpace")]
            [Validation(Required=false)]
            public long? LocalLogRetentionSpace { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
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
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PreferredBackupPeriod")]
            [Validation(Required=false)]
            public string PreferredBackupPeriod { get; set; }

            /// <summary>
            /// <para>No value is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("PreferredBackupTime")]
            [Validation(Required=false)]
            public string PreferredBackupTime { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDC9CFD5-306D-4A23-9D8C-057274C6****</para>
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
