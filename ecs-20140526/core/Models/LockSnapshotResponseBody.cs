// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class LockSnapshotResponseBody : TeaModel {
        /// <summary>
        /// <para>Information about the locked snapshot.</para>
        /// </summary>
        [NameInMap("LockedSnapshotInfo")]
        [Validation(Required=false)]
        public LockSnapshotResponseBodyLockedSnapshotInfo LockedSnapshotInfo { get; set; }
        public class LockSnapshotResponseBodyLockedSnapshotInfo : TeaModel {
            /// <summary>
            /// <para>The cool-off period for compliance mode. Unit: hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CoolOffPeriod")]
            [Validation(Required=false)]
            public int? CoolOffPeriod { get; set; }

            /// <summary>
            /// <para>The time the cool-off period for compliance mode ends. The time is in UTC and follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T13:00:00Z</para>
            /// </summary>
            [NameInMap("CoolOffPeriodExpiredTime")]
            [Validation(Required=false)]
            public string CoolOffPeriodExpiredTime { get; set; }

            /// <summary>
            /// <para>The time the lock was created. The time is in UTC and follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockCreationTime")]
            [Validation(Required=false)]
            public string LockCreationTime { get; set; }

            /// <summary>
            /// <para>The lock duration, in days. The snapshot lock automatically expires at the end of this period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockDuration")]
            [Validation(Required=false)]
            public int? LockDuration { get; set; }

            /// <summary>
            /// <para>The time the lock duration starts. The time is in UTC and follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// <para>If you lock a snapshot that is in the <c>progressing</c> state, the lock duration starts only after the snapshot enters the <c>accomplished</c> state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockDurationStartTime")]
            [Validation(Required=false)]
            public string LockDurationStartTime { get; set; }

            /// <summary>
            /// <para>The time the lock expires. The time is in UTC and follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard in <c>yyyy-MM-ddTHH:mm:ssZ</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockExpiredTime")]
            [Validation(Required=false)]
            public string LockExpiredTime { get; set; }

            /// <summary>
            /// <para>The lock mode. Possible value:</para>
            /// <list type="bullet">
            /// <item><description><c>compliance</c>: The snapshot is locked in compliance mode. A snapshot in compliance mode cannot be unlocked and can be deleted only after its lock duration expires. You cannot shorten the lock duration, but users with the required Resource Access Management (RAM) permissions can extend it at any time. When you lock a snapshot in compliance mode, you can optionally specify a cool-off period.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>compliance</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The lock status. Possible values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>compliance-cooloff</c>: The snapshot is locked in compliance mode but is still in its cool-off period. The snapshot cannot be deleted. However, users with the required Resource Access Management (RAM) permissions can unlock it, change the cool-off period, and adjust the lock duration.</para>
            /// </description></item>
            /// <item><description><para><c>compliance</c>: The snapshot is locked in compliance mode, and the cool-off period has ended. The snapshot cannot be unlocked or deleted, but users with the required Resource Access Management (RAM) permissions can extend the lock duration.</para>
            /// </description></item>
            /// <item><description><para><c>expired</c>: The snapshot was previously locked, but the lock duration has ended, and the lock has expired. The snapshot is not currently locked and can be deleted.</para>
            /// </description></item>
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
