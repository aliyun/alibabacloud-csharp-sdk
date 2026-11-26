// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The data backup retention period. Default value: 7. Maximum value: 7. Valid values: 1 to 7.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic recovery point creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true (default): enabled.</description></item>
        /// <item><description>false: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRecoveryPoint")]
        [Validation(Required=false)]
        public bool? EnableRecoveryPoint { get; set; }

        /// <summary>
        /// <para>The data backup cycle. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday: Monday.</description></item>
        /// <item><description>Tuesday: Tuesday.</description></item>
        /// <item><description>Wednesday: Wednesday.</description></item>
        /// <item><description>Thursday: Thursday.</description></item>
        /// <item><description>Friday: Friday.</description></item>
        /// <item><description>Saturday: Saturday.</description></item>
        /// <item><description>Sunday: Sunday.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tuesday,Thursday,Saturday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The data backup time. Default value: 00:00Z-01:00Z. Format: HH:mmZ-HH:mmZ (UTC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15:00Z-16:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        /// <summary>
        /// <para>The recovery point frequency. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b> (default): every hour.</description></item>
        /// <item><description><b>2</b>: every two hours.</description></item>
        /// <item><description><b>4</b>: every four hours.</description></item>
        /// <item><description><b>8</b>: every eight hours.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("RecoveryPointPeriod")]
        [Validation(Required=false)]
        public string RecoveryPointPeriod { get; set; }

    }

}
