// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>The locked snapshot information.</para>
        /// </summary>
        [NameInMap("LockedSnapshotInfo")]
        [Validation(Required=false)]
        public LockSnapshotResponseBodyLockedSnapshotInfo LockedSnapshotInfo { get; set; }
        public class LockSnapshotResponseBodyLockedSnapshotInfo : TeaModel {
            /// <summary>
            /// <para>The cool-off period in compliance mode. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CoolOffPeriod")]
            [Validation(Required=false)]
            public int? CoolOffPeriod { get; set; }

            /// <summary>
            /// <para>The time when the cool-off period in compliance mode ends. The time follows the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/iso-8601-time-format">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T13:00:00Z</para>
            /// </summary>
            [NameInMap("CoolOffPeriodExpiredTime")]
            [Validation(Required=false)]
            public string CoolOffPeriodExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was locked. The time follows the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/iso-8601-time-format">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockCreationTime")]
            [Validation(Required=false)]
            public string LockCreationTime { get; set; }

            /// <summary>
            /// <para>The lock duration. The snapshot lock automatically expires after the lock duration ends. Unit: days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockDuration")]
            [Validation(Required=false)]
            public int? LockDuration { get; set; }

            /// <summary>
            /// <para>The time when the lock duration starts. The time follows the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/iso-8601-time-format">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC. </para>
            /// <para>If you lock a snapshot that is in the progressing state, the lock duration starts only after the snapshot enters the accomplished state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockDurationStartTime")]
            [Validation(Required=false)]
            public string LockDurationStartTime { get; set; }

            /// <summary>
            /// <para>The time when the lock expires. The time follows the <a href="https://www.alibabacloud.com/help/en/ecs/developer-reference/iso-8601-time-format">ISO 8601</a> standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockExpiredTime")]
            [Validation(Required=false)]
            public string LockExpiredTime { get; set; }

            /// <summary>
            /// <para>The lock mode. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>compliance: The snapshot is locked in compliance mode. A snapshot locked in compliance mode cannot be unlocked by any user and can be deleted only after the lock duration expires. Users cannot shorten the lock duration, but users with the required RAM permissions can extend the lock duration at any time. When locking a snapshot in compliance mode, you can optionally specify a cool-off period.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>compliance</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The lock status. Valid values: </para>
            /// <list type="bullet">
            /// <item><description>compliance-cooloff: The snapshot is locked in compliance mode but is still within the cool-off period. The snapshot cannot be deleted, but users with the required RAM permissions can unlock the snapshot, extend or shorten the cool-off period, and extend or shorten the lock duration. </description></item>
            /// <item><description>compliance: The snapshot is locked in compliance mode and the cool-off period has ended. The snapshot cannot be unlocked or deleted, but users with the required RAM permissions can extend the lock duration. </description></item>
            /// <item><description>expired: The snapshot was previously locked, but the lock duration has ended and the lock has expired. The snapshot is currently unlocked and can be deleted.</description></item>
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
