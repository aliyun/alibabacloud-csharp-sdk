// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeAutoSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// Details of the automatic snapshot policies.
        /// </summary>
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public List<DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies> AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies : TeaModel {
            /// <summary>
            /// The time when the automatic snapshot policy was created. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-mm-ddthh:mm:ssz format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The CRON expression that is used to create the snapshot.
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// The number of cloud desktops that are associated with the automatic snapshot policy.
            /// </summary>
            [NameInMap("DesktopNum")]
            [Validation(Required=false)]
            public int? DesktopNum { get; set; }

            /// <summary>
            /// The ID of the automatic snapshot policy.
            /// </summary>
            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

            /// <summary>
            /// The name of the automatic snapshot policy.
            /// </summary>
            [NameInMap("PolicyName")]
            [Validation(Required=false)]
            public string PolicyName { get; set; }

            /// <summary>
            /// The ID of the region where the automatic snapshot policy resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The retention period of the automatic snapshot. Unit: days. Valid values:
            /// 
            /// *   \-1: The snapshot is permanently retained.
            /// *   1 to 65536: The automatic snapshot is retained for the specified number of days.
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public string RetentionDays { get; set; }

            /// <summary>
            /// The state of the automatic snapshot policy. Valid values:
            /// 
            /// *   Normal: The automatic snapshot policy is normal.
            /// *   Expire: The automatic snapshot policy cannot be used because your account has an overdue payment.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The points in time at which automatic snapshots are created.
            /// 
            /// The time is displayed in UTC+8. Unit: hours. Valid values are 0 to 23, which correspond to the 24 points in time on the hour from 00:00:00 to 23:00:00. 1 indicates 01:00:00. Multiple points in time can be specified.
            /// 
            /// The parameter value is a JSON array that contains up to 24 points in time separated by commas (,). Example: `["0", "1", ... "23"]`.
            /// </summary>
            [NameInMap("TimePoints")]
            [Validation(Required=false)]
            public string TimePoints { get; set; }

        }

        /// <summary>
        /// The token that is used to start the next query. If this parameter is empty, all results haven been returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
