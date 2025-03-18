// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListBackupDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The backups.</para>
        /// </summary>
        [NameInMap("BackupDataList")]
        [Validation(Required=false)]
        public List<ListBackupDataResponseBodyBackupDataList> BackupDataList { get; set; }
        public class ListBackupDataResponseBodyBackupDataList : TeaModel {
            /// <summary>
            /// <para>The backup type. In general, the following two types are supported: local backup and remote backup. In the local backup type, snapshots reside in the same region as your instance. The following two sub-types are available: full (single backup, single replica) and redundant (zone-redundant storage, multiple replicas). In the remote backup type, snapshots and your instance reside in different regions. Remote backups are the replicas of the backups of the full or redundant type in another region. The values local and remote do not represent specific types, but are used only for data filtering. The value local indicates all local backups, and the value remote indicates all remote backups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>redundant</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The size of cold data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32413521</para>
            /// </summary>
            [NameInMap("ColdDataSize")]
            [Validation(Required=false)]
            public long? ColdDataSize { get; set; }

            /// <summary>
            /// <para>The description of the backup data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("DataDesc")]
            [Validation(Required=false)]
            public string DataDesc { get; set; }

            /// <summary>
            /// <para>The backup granularity.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("DataGran")]
            [Validation(Required=false)]
            public string DataGran { get; set; }

            /// <summary>
            /// <para>The size of the backup data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76085723136</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <para>The snapshot time. The value format of this parameter follows the same standard as that of the StartTime parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T12:23:37.000+00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The end time of the backup task. The value format of this parameter follows the same standard as that of the StartTime parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T12:27:34.000+00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The unique ID of the backup.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780805690994479105</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hgpostcn-cn-pe33jdxxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-hologres-dw</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("InstanceRegion")]
            [Validation(Required=false)]
            public string InstanceRegion { get; set; }

            /// <summary>
            /// <para>The type of the instance.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Warehouse: virtual warehouse instance</description></item>
            /// <item><description>Standard: general-purpose instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Warehouse</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The zone in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("InstanceZoneId")]
            [Validation(Required=false)]
            public string InstanceZoneId { get; set; }

            /// <summary>
            /// <para>The region in which the backup data resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SnapshotRegion")]
            [Validation(Required=false)]
            public string SnapshotRegion { get; set; }

            /// <summary>
            /// <para>The zone in which the backup data resides. In zone-redundant storage mode, backup data is stored in different zones, including the current zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("SnapshotZoneId")]
            [Validation(Required=false)]
            public string SnapshotZoneId { get; set; }

            /// <summary>
            /// <para>The start time of the backup task. The time follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ss.SSSTZ format. The time is displayed in UTC (the same below).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T11:19:56.000+00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the backup task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>processing</description></item>
            /// <item><description>completed</description></item>
            /// <item><description>failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The mode in which the backup task is triggered.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>scheduled: periodic backup</description></item>
            /// <item><description>manual: manual backup</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>scheduled</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4AA0C48F-B5BB-5FF9-A43B-6B91E0715D46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
