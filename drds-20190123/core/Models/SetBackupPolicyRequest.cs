// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The databases to be backed up. Separate multiple databases with commas (,).</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the backup level is database level.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test1,test2</para>
        /// </summary>
        [NameInMap("BackupDbNames")]
        [Validation(Required=false)]
        public string BackupDbNames { get; set; }

        /// <summary>
        /// <para>The level of the backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>db: The database type.</description></item>
        /// <item><description>instance: instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>db</para>
        /// </summary>
        [NameInMap("BackupLevel")]
        [Validation(Required=false)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log Backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: enabled.</description></item>
        /// <item><description>0: disabled.</description></item>
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
        /// <item><description>**Logic **: logical backup</description></item>
        /// <item><description><b>phy</b>: physical backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>phy</para>
        /// </summary>
        [NameInMap("BackupMode")]
        [Validation(Required=false)]
        public string BackupMode { get; set; }

        /// <summary>
        /// <para>The retention period of the backup data. Value range: 7 to 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("DataBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string DataBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>drds************</para>
        /// </summary>
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        /// <summary>
        /// <para>The log retention period. Valid values: 7 to 730. This value must be less than or equal to the number of data backup days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public string LogBackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The end time of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:30:30</para>
        /// </summary>
        [NameInMap("PreferredBackupEndTime")]
        [Validation(Required=false)]
        public string PreferredBackupEndTime { get; set; }

        /// <summary>
        /// <para>The backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Monday</description></item>
        /// <item><description>1: Tuesday</description></item>
        /// <item><description>2: Wednesday</description></item>
        /// <item><description>3: Thursday</description></item>
        /// <item><description>4: Friday</description></item>
        /// <item><description>5: Saturday</description></item>
        /// <item><description>6: Sunday</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The start time of the backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11:30:30</para>
        /// </summary>
        [NameInMap("PreferredBackupStartTime")]
        [Validation(Required=false)]
        public string PreferredBackupStartTime { get; set; }

    }

}
