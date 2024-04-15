// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeAutoSnapshotPolicyResponseBody : TeaModel {
        /// <summary>
        /// The details of the queried automatic snapshot policies.
        /// </summary>
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public List<DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies> AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPolicyResponseBodyAutoSnapshotPolicies : TeaModel {
            /// <summary>
            /// The time when the automatic snapshot policy was created. The time follows the [ISO 8601](~~25696~~) standard in the `yyyy-mm-ddthh:mm:ssz` format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// The cron expression that specifies when WUYING Workspace creates snapshots on the cloud computers.
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// The number of cloud computers to which the automatic snapshot policy is applied.
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
            /// The ID of the region to which the automatic snapshot policy belongs.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The retention period of the automatic snapshots. Unit: days. Valid values: 1 to 180.
            /// </summary>
            [NameInMap("RetentionDays")]
            [Validation(Required=false)]
            public string RetentionDays { get; set; }

            /// <summary>
            /// The status of the automatic snapshot policy.
            /// 
            /// Valid values:
            /// 
            /// *   Expire: The automatic snapshot policy cannot be used because you have overdue payments in your account.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Normal: The automatic snapshot policy is normal.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The points in time at which the auto snapshots were created.
            /// 
            /// The parameter values are a JSON array. Example: `["0", "1", ... "23"]`. A maximum of 24 points in time are returned. The points in time are separated with commas (,).
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
