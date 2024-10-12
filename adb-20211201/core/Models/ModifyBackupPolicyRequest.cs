// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyBackupPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The number of days for which to retain full backup files. Valid values: 7 to 730.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value 7 is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public string BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the AnalyticDB for MySQL Data Lakehouse Edition cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>am-bp1xxxxxxxx47</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value Enable is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public string EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The number of days for which to retain log backup files. Valid values: 7 to 730.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the default value 7 is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("LogBackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? LogBackupRetentionPeriod { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The days of the week on which to perform a full backup. Separate multiple values with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> To ensure data security, we recommend that you specify at least two values.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Wednesday,Friday,Sunday</para>
        /// </summary>
        [NameInMap("PreferredBackupPeriod")]
        [Validation(Required=false)]
        public string PreferredBackupPeriod { get; set; }

        /// <summary>
        /// <para>The start time to perform a full backup. Specify the time in the HH:mmZ-HH:mmZ format. The time must be in UTC.</para>
        /// <remarks>
        /// <para> The time range must be 1 hour.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18:00Z-19:00Z</para>
        /// </summary>
        [NameInMap("PreferredBackupTime")]
        [Validation(Required=false)]
        public string PreferredBackupTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
