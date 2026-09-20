// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of days for which backups are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The UTC time when the backup ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupEndTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupEndTimeUTC { get; set; }

        /// <summary>
        /// <para>The backup cycle. For example, Friday indicates that the backup is performed every Friday.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Friday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The UTC time when the backup starts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupStartTimeUTC")]
        [Validation(Required=false)]
        public string PreferredBackupStartTimeUTC { get; set; }

        /// <summary>
        /// <para>The backup time range in the current time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:00-02:00</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94AC38B6-7C6D-45B2-BC03-B8750071A482</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
