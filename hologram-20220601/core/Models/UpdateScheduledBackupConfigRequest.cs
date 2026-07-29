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
        /// <para>The number of scheduled backups to retain. For example, if you set this parameter to <c>3</c>, the system retains the three most recent backups and automatically deletes any older ones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("dataKeepQuantity")]
        [Validation(Required=false)]
        public int? DataKeepQuantity { get; set; }

        /// <summary>
        /// <para>The destination region for the backup. This parameter applies only to remote backups and enables cross-region disaster recovery. For example, you can back up an instance from China (Hangzhou) to China (Beijing).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("dstRegion")]
        [Validation(Required=false)]
        public string DstRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable scheduled backups. Set this parameter to <c>true</c> to enable scheduled backups, or <c>false</c> to disable them.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The hour to start the backup. This start time applies to all specified days. For example, if you set <c>week</c> to <c>1,3,5</c> and <c>hour</c> to <c>20</c>, a backup starts at 20:00:00 every Monday, Wednesday, and Friday.</para>
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
        /// <para>The number of manual backups to retain. Manual backups and automatic backups are stored separately and have independent retention policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("manualDataKeepQuantity")]
        [Validation(Required=false)]
        public int? ManualDataKeepQuantity { get; set; }

        /// <summary>
        /// <para>The backup type. This parameter is required only for remote backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remote</para>
        /// </summary>
        [NameInMap("scheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// <para>Specifies the days of the week on which to perform a backup. Separate multiple days with commas. For example, to perform backups on Monday, Wednesday, and Friday, set this parameter to <c>1,3,5</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,3,5</para>
        /// </summary>
        [NameInMap("week")]
        [Validation(Required=false)]
        public string Week { get; set; }

        /// <summary>
        /// <para>The destination availability zone for the backup. This parameter applies only to remote backups.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
