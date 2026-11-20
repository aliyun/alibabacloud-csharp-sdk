// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListBackupDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of backups.</para>
        /// </summary>
        [NameInMap("BackupDataList")]
        [Validation(Required=false)]
        public List<ListBackupDataResponseBodyBackupDataList> BackupDataList { get; set; }
        public class ListBackupDataResponseBodyBackupDataList : TeaModel {
            /// <summary>
            /// <para>The backup type. Backup types are generally divided into two categories: 1) Local backup, where the snapshot and the instance belong to the same region. 2) Remote backup, where the snapshot and the instance belong to different regions. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>redundant: Local backup with cross-zone multi-copy storage in the same region.</description></item>
            /// <item><description>redundant_remote: Remote backup with cross-zone multi-copy storage in the same region, which is a cross-region copy of the redundant type.</description></item>
            /// <item><description>full: Local backup with single-copy storage.</description></item>
            /// <item><description>full_remote: Remote backup with single-copy storage, which is a cross-region copy of the full type.</description></item>
            /// <item><description>local: Does not represent a specific backup type and is only used to filter local backup data.</description></item>
            /// <item><description>remote: Does not represent a specific backup type and is only used to filter remote backup data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>redundant</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The size of the cold storage data. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32413521</para>
            /// </summary>
            [NameInMap("ColdDataSize")]
            [Validation(Required=false)]
            public long? ColdDataSize { get; set; }

            /// <summary>
            /// <para>The description of the backup data. This field can be updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("DataDesc")]
            [Validation(Required=false)]
            public string DataDesc { get; set; }

            /// <summary>
            /// <para>The backup granularity.</para>
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
            /// <para>The data snapshot time. For the format, refer to StartTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T12:23:37.000+00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The end time of the backup. For the format, refer to StartTime.</para>
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
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-hologres-dw</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The region where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("InstanceRegion")]
            [Validation(Required=false)]
            public string InstanceRegion { get; set; }

            /// <summary>
            /// <para>The instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Warehouse</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The zone where the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("InstanceZoneId")]
            [Validation(Required=false)]
            public string InstanceZoneId { get; set; }

            /// <summary>
            /// <para>The region where the backup data resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SnapshotRegion")]
            [Validation(Required=false)]
            public string SnapshotRegion { get; set; }

            /// <summary>
            /// <para>The zone where the backup data resides. For zone-redundant storage, the data is stored across multiple zones, and this field indicates one of the zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("SnapshotZoneId")]
            [Validation(Required=false)]
            public string SnapshotZoneId { get; set; }

            /// <summary>
            /// <para>The start time of the backup. The time is in the UTC+8 time zone and follows the YYYY-MM-DDTHH:mm:ss.SSSTZ format. The same applies to other time fields.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T11:19:56.000+00:00</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The backup status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>completed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The trigger type.</para>
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
