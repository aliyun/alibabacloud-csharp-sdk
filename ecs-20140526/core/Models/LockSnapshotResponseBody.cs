// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>Locked snapshot information.</para>
        /// </summary>
        [NameInMap("LockedSnapshotInfo")]
        [Validation(Required=false)]
        public LockSnapshotResponseBodyLockedSnapshotInfo LockedSnapshotInfo { get; set; }
        public class LockSnapshotResponseBodyLockedSnapshotInfo : TeaModel {
            /// <summary>
            /// <para>The cooling-off period of the compliance mode. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CoolOffPeriod")]
            [Validation(Required=false)]
            public int? CoolOffPeriod { get; set; }

            /// <summary>
            /// <para>The end time of the cooling-off period in compliance mode. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format (in UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T13:00:00Z</para>
            /// </summary>
            [NameInMap("CoolOffPeriodExpiredTime")]
            [Validation(Required=false)]
            public string CoolOffPeriodExpiredTime { get; set; }

            /// <summary>
            /// <para>The date and time at which the snapshot is locked. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format (in UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockCreationTime")]
            [Validation(Required=false)]
            public string LockCreationTime { get; set; }

            /// <summary>
            /// <para>The lock duration. After the lock duration ends, the snapshot lock will automatically expire. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockDuration")]
            [Validation(Required=false)]
            public int? LockDuration { get; set; }

            /// <summary>
            /// <para>The start time of the lock duration. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format (in UTC). If you lock a snapshot that is in the Progressing state, the lock time is not calculated until the snapshot enters the Accomplished state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockDurationStartTime")]
            [Validation(Required=false)]
            public string LockDurationStartTime { get; set; }

            /// <summary>
            /// <para>The time when the lock expires. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format (in UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockExpiredTime")]
            [Validation(Required=false)]
            public string LockExpiredTime { get; set; }

            /// <summary>
            /// <para>The lock status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>compliance-cooloff: The snapshot is locked in compliance mode but is still within the cooling-off period. Snapshots cannot be deleted, but users with the corresponding RAM permissions can unlock snapshots, extend or shorten the cooling-off period, and extend or shorten the lock duration.</description></item>
            /// <item><description>compliance: The snapshot is locked in compliance mode and the cooling-off period has ended. Snapshots cannot be unlocked or deleted, but users with the corresponding RAM permissions can extend the lock duration.</description></item>
            /// <item><description>expired: The snapshot was once locked, but the lock duration has ended and the lock has expired. The snapshot is currently not locked and can be deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>compliance-cooloff</para>
            /// </summary>
            [NameInMap("LockStatus")]
            [Validation(Required=false)]
            public string LockStatus { get; set; }

            /// <summary>
            /// <para>The snapshot ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>s-9dp2qojdpdfmgfmf****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
