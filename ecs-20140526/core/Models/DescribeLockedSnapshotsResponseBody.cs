// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLockedSnapshotsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the locked snapshots.</para>
        /// </summary>
        [NameInMap("LockedSnapshotsInfo")]
        [Validation(Required=false)]
        public List<DescribeLockedSnapshotsResponseBodyLockedSnapshotsInfo> LockedSnapshotsInfo { get; set; }
        public class DescribeLockedSnapshotsResponseBodyLockedSnapshotsInfo : TeaModel {
            /// <summary>
            /// <para>The cool-off period for compliance mode, in hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CoolOffPeriod")]
            [Validation(Required=false)]
            public int? CoolOffPeriod { get; set; }

            /// <summary>
            /// <para>The time when the cool-off period ends. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard and is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T13:00:00Z</para>
            /// </summary>
            [NameInMap("CoolOffPeriodExpiredTime")]
            [Validation(Required=false)]
            public string CoolOffPeriodExpiredTime { get; set; }

            /// <summary>
            /// <para>The time when the snapshot was locked. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard and is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockCreationTime")]
            [Validation(Required=false)]
            public string LockCreationTime { get; set; }

            /// <summary>
            /// <para>The lock duration in days. The lock automatically expires when this period ends.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("LockDuration")]
            [Validation(Required=false)]
            public int? LockDuration { get; set; }

            /// <summary>
            /// <para>The time when the lock duration starts. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard and is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format. If a snapshot in the progressing state is locked, its lock duration begins after it enters the accomplished state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockDurationStartTime")]
            [Validation(Required=false)]
            public string LockDurationStartTime { get; set; }

            /// <summary>
            /// <para>The time when the lock expires. The time follows the <a href="https://help.aliyun.com/zh/ecs/developer-reference/iso-8601-time-format?spm=a2c4g.11186623.0.0.277c6c92kl7kXM">ISO 8601</a> standard and is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-10-16T10:00:00Z</para>
            /// </summary>
            [NameInMap("LockExpiredTime")]
            [Validation(Required=false)]
            public string LockExpiredTime { get; set; }

            /// <summary>
            /// <para>The lock mode. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>compliance: The snapshot is locked in compliance mode. A snapshot locked in compliance mode cannot be unlocked and can only be deleted after its lock duration expires. You cannot shorten the lock duration, but users with the required RAM permissions can extend the lock duration at any time. When you lock a snapshot in compliance mode, you can optionally specify a cool-off period.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>compliance</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The lock status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>compliance-cooloff: The snapshot is locked in compliance mode and is in the cool-off period. The snapshot cannot be deleted. However, users with the required RAM permissions can unlock the snapshot and adjust the cool-off period or lock duration.</para>
            /// </description></item>
            /// <item><description><para>compliance: The snapshot is locked in compliance mode, and its cool-off period has ended. The snapshot cannot be unlocked or deleted. However, users with the required RAM permissions can extend the lock duration.</para>
            /// </description></item>
            /// <item><description><para>expired: The lock has expired, and the snapshot can be deleted.</para>
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
            /// <para>s-bp67acfmxazb4p****</para>
            /// </summary>
            [NameInMap("SnapshotId")]
            [Validation(Required=false)]
            public string SnapshotId { get; set; }

        }

        /// <summary>
        /// <para>A token to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
