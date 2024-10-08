// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class UpdateHanaRetentionSettingRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the SAP HANA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cl-00024vyjj******srrq</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SYSTEMDB</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>Specifies whether to permanently retain the backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The backup is permanently retained.</description></item>
        /// <item><description>false: The backup is retained for the specified number of days.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Disabled")]
        [Validation(Required=false)]
        public bool? Disabled { get; set; }

        /// <summary>
        /// <para>The retention period of the backup data. Unit: days. If you set the Disabled parameter to false, the backup is retained for the number of days specified by this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public long? RetentionDays { get; set; }

        /// <summary>
        /// <para>The policy to update the retention period. Format: <c>I|{startTime}|{interval}</c>. The retention period is updated at an interval of {interval} starting from {startTime}.</para>
        /// <list type="bullet">
        /// <item><description>startTime: the time at which the system starts to run a backup job. The time follows the UNIX time format. Unit: seconds.</description></item>
        /// <item><description>interval: the interval at which the system runs a backup job. The interval follows the ISO 8601 standard. For example, PT1H indicates an interval of 1 hour, and P1D indicates an interval of one day.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>I|0|P1D</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public string Schedule { get; set; }

        /// <summary>
        /// <para>The ID of the backup vault.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v-000fb0v2ly******k6</para>
        /// </summary>
        [NameInMap("VaultId")]
        [Validation(Required=false)]
        public string VaultId { get; set; }

    }

}
