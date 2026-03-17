// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class Rule : TeaModel {
        /// <summary>
        /// <para>The backup type.</para>
        /// <list type="bullet">
        /// <item><description>COMPLETE：Full backup.</description></item>
        /// <item><description>INCREMENTAL：Incremental backup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>COMPLETE</para>
        /// </summary>
        [NameInMap("BackupType")]
        [Validation(Required=false)]
        public string BackupType { get; set; }

        /// <summary>
        /// <para>The replication region id.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// <para>The retention period of remote backups. Minimum value: 1. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("DestinationRetention")]
        [Validation(Required=false)]
        public long? DestinationRetention { get; set; }

        /// <summary>
        /// <para>Whether the plan is disbaled for this data source.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: disabled</description></item>
        /// <item><description><b>false</b>: Not disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>Whether do copy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DoCopy")]
        [Validation(Required=false)]
        public bool? DoCopy { get; set; }

        /// <summary>
        /// <para>This parameter indicates the retention period of the backup data. Minimum value: 1. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule-com-backup-20241023-163113</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>This parameter is returned only if the value of the <b>RuleType</b> parameter is <b>BACKUP</b>. This parameter indicates the backup schedule settings. Format: <c>I|{startTime}|{interval}</c>. The system runs the first backup job at a point in time that is specified in the {startTime} parameter and the subsequent backup jobs at an interval that is specified in the {interval} parameter. The system does not run a backup job before the specified point in time. Each backup job, except the first one, starts only after the previous backup job is completed. For example, <c>I|1631685600|P1D</c> indicates that the system runs the first backup job at 14:00:00 on September 15, 2021 and the subsequent backup jobs once a day.</para>
        /// <list type="bullet">
        /// <item><description>startTime: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
        /// <item><description>interval: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour. P1D indicates an interval of one day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>I|1631685600|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

    }

}
