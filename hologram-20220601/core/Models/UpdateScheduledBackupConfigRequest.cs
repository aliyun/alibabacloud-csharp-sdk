// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateScheduledBackupConfigRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of periodic backups to retain. For example, if you set this parameter to 3, the system automatically retains the latest three backups and deletes other expired backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("dataKeepQuantity")]
        [Validation(Required=false)]
        public int? DataKeepQuantity { get; set; }

        /// <summary>
        /// <para>The destination region for backups. This parameter takes effect only for remote backups. You can back up data from the local region to another region to implement cross-region disaster recovery. For example, you can back up an instance in Hangzhou to Beijing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("dstRegion")]
        [Validation(Required=false)]
        public string DstRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable periodic backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Periodic backup is enabled.</description></item>
        /// <item><description>false: Periodic backup is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The start time for backup dates. The backup task starts at this time. The time applies to all valid dates. For example, if week is set to 1,3,5 and hour is set to 20, backups start at 20:00:00 every Monday, Wednesday, and Friday.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("hour")]
        [Validation(Required=false)]
        public int? Hour { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgprecn-cn-zvp25ysxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number of manual backups to retain. Manual backups and automatic backups are stored separately, and each has a completely independent data retention policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("manualDataKeepQuantity")]
        [Validation(Required=false)]
        public int? ManualDataKeepQuantity { get; set; }

        /// <summary>
        /// <para>The backup type. You need to configure this field only for remote backups. You can ignore this field for other backup types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remote</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>The weekly configuration for backup dates. You can specify multiple days separated by commas. For example, to configure Monday, Wednesday, and Friday, set the value to &quot;1,3,5&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,3,5</para>
        /// </summary>
        [NameInMap("week")]
        [Validation(Required=false)]
        public string Week { get; set; }

        /// <summary>
        /// <para>The destination zone for backups. This parameter takes effect only for remote backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
