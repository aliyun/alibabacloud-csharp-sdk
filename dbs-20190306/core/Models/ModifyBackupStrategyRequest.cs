// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ModifyBackupStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The incremental backup interval in seconds.</para>
        /// <remarks>
        /// <para>Only physical backups are supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The full backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Monday: Monday</description></item>
        /// <item><description>Tuesday: Tuesday</description></item>
        /// <item><description>Wednesday: Wednesday</description></item>
        /// <item><description>Thursday: Thursday</description></item>
        /// <item><description>Friday: Friday</description></item>
        /// <item><description>Saturday: Saturday</description></item>
        /// <item><description>Sunday: Sunday</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least two days of the week for BackupPeriod and separate the days with commas (,).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Monday,Tuesday,Wednesday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi01XXXX</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The start time of the full backup. Format: HH:mm.</para>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>14:22</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        /// <summary>
        /// <para>The full backup epoch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>simple</b>: periodic backup. This value is used together with BackupPeriod and BackupStartTime.</description></item>
        /// <item><description><b>manual</b>: manual backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>simple</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("BackupStrategyType")]
        [Validation(Required=false)]
        public string BackupStrategyType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

    }

}
