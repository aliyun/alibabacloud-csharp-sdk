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
            /// <para>The backup type.</para>
            /// <list type="bullet">
            /// <item><description><para>redundant: Stores instance snapshots across zones within the same region.</para>
            /// </description></item>
            /// <item><description><para>redundant_remote: Stores instance snapshots across zones in a different region.</para>
            /// </description></item>
            /// <item><description><para>full: Stores an instance snapshot locally.</para>
            /// </description></item>
            /// <item><description><para>full_remote: Stores an instance snapshot remotely.</para>
            /// </description></item>
            /// <item><description><para>local: It is a filter for local snapshots, not a backup type.</para>
            /// </description></item>
            /// <item><description><para>remote: It is a filter for remote snapshots, not a backup type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>redundant</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The size of the cold data, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32413521</para>
            /// </summary>
            [NameInMap("ColdDataSize")]
            [Validation(Required=false)]
            public long? ColdDataSize { get; set; }

            /// <summary>
            /// <para>The description of the snapshot. It can be updated.</para>
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
            /// <para>The size of the snapshot, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>76085723136</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            /// <summary>
            /// <para>The time when the data snapshot was created. For the format, see StartTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T12:23:37.000+00:00</para>
            /// </summary>
            [NameInMap("DataTime")]
            [Validation(Required=false)]
            public string DataTime { get; set; }

            /// <summary>
            /// <para>The time when the backup was completed. For the format, see StartTime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-10-28T12:27:34.000+00:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The unique snapshot ID.</para>
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
            /// <para>The region where the snapshot is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SnapshotRegion")]
            [Validation(Required=false)]
            public string SnapshotRegion { get; set; }

            /// <summary>
            /// <para>The zone where backup snapshot(s). If you use zone-redundant storage, the data is stored across multiple zones. This parameter returns one of those zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("SnapshotZoneId")]
            [Validation(Required=false)]
            public string SnapshotZoneId { get; set; }

            /// <summary>
            /// <para>The timestamp when the backup began. Format: <c>YYYY-MM-DDTHH:mm:ss.SSSTZ</c> (UTC+8). This format is used for all time-related parameters.</para>
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
            /// <para>The backup trigger type.</para>
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
