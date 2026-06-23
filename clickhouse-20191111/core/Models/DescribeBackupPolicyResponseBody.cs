// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeBackupPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The backup retention period. Default value: 7. Valid values: 7 to 730. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The backup size. Unit: MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123124</para>
        /// </summary>
        [NameInMap("BackupSize")]
        [Validation(Required=false)]
        public string BackupSize { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Monday</b></para>
        /// </description></item>
        /// <item><description><para><b>Tuesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Wednesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Thursday</b></para>
        /// </description></item>
        /// <item><description><para><b>Friday</b></para>
        /// </description></item>
        /// <item><description><para><b>Saturday</b></para>
        /// </description></item>
        /// <item><description><para><b>Sunday</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup time in UTC.</para>
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
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the backup feature is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The backup feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The backup feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Switch")]
        [Validation(Required=false)]
        public string Switch { get; set; }

    }

}
